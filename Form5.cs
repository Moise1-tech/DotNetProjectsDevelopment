using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab2DotNetAss
{
    public partial class MushroomForm : Form
    {
        private TextBox txtAnswer;
        private Label lblQuestion;
        private string state;
        private bool hasRing;

        public MushroomForm()
        {
            //InitializeComponent();

            txtAnswer = Controls.OfType<TextBox>().First();

            // label that shows the question text
            lblQuestion = new Label();
            lblQuestion.AutoSize = false;
            lblQuestion.Left = txtAnswer.Left;
            lblQuestion.Width = txtAnswer.Width;
            lblQuestion.Height = 50;
            lblQuestion.Top = txtAnswer.Top - 60;
            Controls.Add(lblQuestion);

            txtAnswer.KeyDown += TxtAnswer_KeyDown;

            // connect the LogOut button
            foreach (Button b in Controls.OfType<Button>())
            {
                if (b.Text == "LogOut")
                    b.Click += LogOut;
            }

            Ask("ring");
        }

        private void Ask(string question)
        {
            state = question;
            txtAnswer.Clear();
            txtAnswer.Focus();

            switch (question)
            {
                case "ring":
                    lblQuestion.Text = "Does your mushroom have a ring? (yes/no)";
                    break;
                case "forest":
                    lblQuestion.Text = "Does your mushroom grow in a forest? (yes/no)";
                    break;
                case "gills":
                    lblQuestion.Text = "Does your mushroom have gills? (yes/no)";
                    break;
                case "convex":
                    lblQuestion.Text = "Does your mushroom have a convex cup? (yes/no)";
                    break;
            }
        }

        private void Result(string name)
        {
            state = "done";
            txtAnswer.Clear();
            lblQuestion.Text = "Your mushroom is: " + name + "\r\nPress Enter to start again.";
        }

        private void TxtAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            e.SuppressKeyPress = true;   // stops the beep sound

            // after the result, Enter starts again
            if (state == "done")
            {
                Ask("ring");
                return;
            }

            string text = txtAnswer.Text.Trim().ToLower();
            bool yes;

            if (text == "yes" || text == "y")
                yes = true;
            else if (text == "no" || text == "n")
                yes = false;
            else
            {
                MessageBox.Show("Please answer with yes or no.");
                txtAnswer.Clear();
                return;
            }

            Answer(yes);
        }

        // never more than 3 questions
        private void Answer(bool yes)
        {
            switch (state)
            {
                case "ring":
                    hasRing = yes;
                    if (yes) Ask("forest");
                    else Ask("gills");
                    break;

                case "forest":       // has a ring
                    if (yes) Result("Amanite tue-mouche");
                    else Ask("convex");
                    break;

                case "gills":        // has no ring
                    if (!yes) Result("Cepe de Bordeaux");
                    else Ask("convex");
                    break;

                case "convex":
                    if (hasRing)
                        Result(yes ? "Agaric jaunissant" : "Coprin chevelu");
                    else
                        Result(yes ? "Pied bleu" : "Girolle");
                    break;
            }
        }

        private void LogOut(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
        }
    }
}