using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnAddNewQuote_Click(object sender, EventArgs e)
        {
            var addQuoteForm = new AddQuote();
            addQuoteForm.Tag = this;
            addQuoteForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnViewQuotes_Click(object sender, EventArgs e)
        {
            var viewQuotesForm = new ViewAllQuotes(this);
            viewQuotesForm.Show();
            this.Hide();

        }

        private void btnSearchQuotes_Click(object sender, EventArgs e)
        {
            var searchQuotesForm = new SearchQuotes(this);
            searchQuotesForm.Show();
            this.Hide();
        }
    }
}
