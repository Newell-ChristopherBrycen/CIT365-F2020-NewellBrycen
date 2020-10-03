using System;
using System.Windows.Forms;

namespace MegaDesk_Newell
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

      
        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void AddQuoteButton_Click(object sender, EventArgs e)
        {
            AddQuote viewAddQuote = new AddQuote();
            viewAddQuote.Tag = this;
            viewAddQuote.Show(this);
            Hide();
        }

        private void ViewQuotesButton_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewViewQuote = new ViewAllQuotes();
            viewViewQuote.Tag = this;
            viewViewQuote.Show(this);
            Hide();
        }

        private void SearchQuotesButton_Click(object sender, EventArgs e)
        {
            SearchQuotes viewSearchQuote = new SearchQuotes();
            viewSearchQuote.Tag = this;
            viewSearchQuote.Show(this);
            Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Close the Main Menu Form.
            Close();
        }
    }
}
