using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Israelsen
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void addNewQuote_Click(object sender, EventArgs e)
        {
            // create AddQuote form
            var frmAddQuote = new AddQuote();

            // reference to MainMenu
            frmAddQuote.Tag = this;
            
            // show new AddQuote form
            frmAddQuote.Show();

            // hide MainMenu
            this.Hide();
        }

        private void viewQuotes_Click(object sender, EventArgs e)
        {
            // create ViewQuote form
            var frmViewQuotes = new ViewAllQuotes();

            // reference to MainMenu
            frmViewQuotes.Tag = this;

            // show new ViewQuote form
            frmViewQuotes.Show();

            // hide MainMenu
            this.Hide();
        }

        private void searchQuotes_Click(object sender, EventArgs e)
        {
            // create ViewQuote form
            var frmSearchQuotes = new SearchQuotes();

            // reference to MainMenu
            frmSearchQuotes.Tag = this;

            // show new ViewQuote form
            frmSearchQuotes.Show();

            // hide MainMenu
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            // closes MainMenu
            this.Close();
        }
    }
}
