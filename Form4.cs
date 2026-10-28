using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab2DotNetAss
{
    public partial class BicycleForm : Form
    {
        private TextBox txtStart;
        private TextBox txtEnd;
        private TextBox txtFee;

        public BicycleForm()
        {
            //InitializeComponent();

            // find the 3 textboxes from top to bottom: start, end, fee
            var boxes = Controls.OfType<TextBox>().OrderBy(t => t.Top).ToList();
            txtStart = boxes[0];
            txtEnd = boxes[1];
            txtFee = boxes[2];
            txtFee.ReadOnly = true;

            // calculate automatically when start or end changes
            txtStart.TextChanged += Calculate;
            txtEnd.TextChanged += Calculate;

            // connect the LogOut button
            foreach (Button b in Controls.OfType<Button>())
            {
                if (b.Text == "LogOut")
                    b.Click += LogOut;
            }
        }

        private void Calculate(object sender, EventArgs e)
        {
            if (txtStart.Text.Trim() == "" || txtEnd.Text.Trim() == "")
            {
                txtFee.Text = "";
                return;
            }

            // int.TryParse rejects decimals and letters
            if (!int.TryParse(txtStart.Text.Trim(), out int start) ||
                !int.TryParse(txtEnd.Text.Trim(), out int end))
            {
                txtFee.Text = "Whole numbers only";
                return;
            }

            if (start < 0 || start > 23)
            {
                txtFee.Text = "Start: 0 to 23";
                return;
            }

            if (end < 1 || end > 24)
            {
                txtFee.Text = "End: 1 to 24";
                return;
            }

            if (start >= end)
            {
                txtFee.Text = "Start < End";
                return;
            }

            int total = 0;

            // add the rate of every rented hour
            for (int hour = start; hour < end; hour++)
            {
                if (hour < 7)
                    total += 500;       // 0 - 7
                else if (hour < 14)
                    total += 1000;      // 7 - 14
                else if (hour < 19)
                    total += 1500;      // 14 - 19
                else if (hour < 21)
                    total += 1000;      // 19 - 21
                else
                    total += 500;       // 21 - 24
            }

            txtFee.Text = total + " RWF";
        }

        private void LogOut(object sender, EventArgs e)
        {
            // tells the menu and login that the user logged out
            this.DialogResult = DialogResult.Retry;
        }
    }
}