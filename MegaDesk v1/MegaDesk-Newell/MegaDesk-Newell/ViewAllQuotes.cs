using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Newell
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {

        }

        private void returnToMainMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu openMenu = new MainMenu();
            openMenu.Tag = this;
            openMenu.Show(this);
            Hide();
        }
    }
}
