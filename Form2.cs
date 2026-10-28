using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab2DotNetAss
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            foreach (Button b in Controls.OfType<Button>())
            {
                if (b.Text == "Bicycle")
                    b.Click += OpenBicycle;
                else if (b.Text == "Mushroom")
                    b.Click += OpenMushroom;
            }
        }

        private void OpenBicycle(object sender, EventArgs e)
        {
            BicycleForm bicycle = new BicycleForm();
            this.Hide();
            OpenChild(bicycle);
        }

        private void OpenMushroom(object sender, EventArgs e)
        {
            MushroomForm mushroom = new MushroomForm();
            this.Hide();
            OpenChild(mushroom);
        }

        private void OpenChild(Form child)
        {
            DialogResult result = child.ShowDialog();

            if (result == DialogResult.Retry)
            {
                // LogOut was clicked: close the menu and tell the login form
                this.DialogResult = DialogResult.Retry;
                this.Close();
            }
            else
            {
                this.Show();   // the child was closed with X: back to the menu
            }
        }
    }
}