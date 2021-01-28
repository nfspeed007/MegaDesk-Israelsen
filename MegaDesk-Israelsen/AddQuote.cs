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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();

            // Makes the list for the desktop material combo box
            List < DesktopMaterial > materials = Enum.GetValues(typeof(DesktopMaterial))
                .Cast<DesktopMaterial>().ToList();

            desktopMaterial.DataSource = materials;

            // Makes the list for the rush order combo box
            List<RushOrder> rush = Enum.GetValues(typeof(RushOrder)).Cast<RushOrder>().ToList();

            rushOrder.DataSource = rush;
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainMenu = (MainMenu)this.Tag;
            mainMenu.Show();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
