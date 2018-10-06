using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_MatthewSchaupp
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void WidthTextBox_Validating(object sender, CancelEventArgs e)
        {
            string ErrorMessage;
            if (!ValidInput(widthTextBox.Text, out ErrorMessage))
            {
                e.Cancel = true;
                widthTextBox.Select(0, widthTextBox.Text.Length);

                widthErrorProvider.SetError(widthTextBox, ErrorMessage);
            }
        }

        private void WidthTextBox_Validated(object sender, EventArgs e)
        {
            widthErrorProvider.SetError(widthTextBox, "");
        }

        public bool ValidInput(string input, out string errorMessage)
        {
            if (input.Length == 0)
            {
                errorMessage = "***Width is required***";
                return false;
            }
            
            decimal num = 0;
            if (decimal.TryParse(input, out num))
            {
                if (num >= Constants.MinWidth && num <= Constants.MaxWidth)
                {
                    errorMessage = "";
                    return true;
                }
            }

            errorMessage = "Width must be between " + Constants.MinWidth + "\"" + " and " + Constants.MaxWidth + "\"";
            return false;
        }

        private void DepthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

                string errorMessage = "Please only enter numbers";
                depthErrorProvider.SetError(depthTextBox, errorMessage);
            }
            else
            {
                e.Handled = false;
            }
        }

        private void DepthTextBox_TextChanged(object sender, EventArgs e)
        {
            string input = depthTextBox.Text;
            decimal numInput = decimal.Parse(input);

            if (numInput >= Constants.MinDepth && numInput <= Constants.MaxDepth)
            {
                depthErrorProvider.SetError(depthTextBox, "");
            }
            else
            {
                depthErrorProvider.SetError(depthTextBox, "Depth must be between " + Constants.MinDepth + "\"" + " and " + Constants.MaxDepth + "\"");
            }
        }
    }
}
