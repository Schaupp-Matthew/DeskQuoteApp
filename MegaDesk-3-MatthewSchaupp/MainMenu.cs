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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void addQuoteButton_Click(object sender, EventArgs e)
        {
            AddQuote newAddQuoteForm = new AddQuote();
            newAddQuoteForm.Tag = this;
            newAddQuoteForm.Show(this);
            Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewQuoteButton_Click(object sender, EventArgs e)
        {
            ViewAllQuotes newViewAllQuotesForm = new ViewAllQuotes();
            newViewAllQuotesForm.Tag = this;
            newViewAllQuotesForm.Show(this);
            Hide();
        }

        private void searchQuotesButton_Click(object sender, EventArgs e)
        {
            SearchQuotes newSearchQuotesForm = new SearchQuotes();
            newSearchQuotesForm.Tag = this;
            newSearchQuotesForm.Show(this);
            Hide();
        }
    }
}
