namespace Lab2DotNetAss
{
    partial class Mushroom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            m = new Button();
            label1 = new Label();
            textmushroom = new TextBox();
            SuspendLayout();
            // 
            // m
            // 
            m.Location = new Point(240, 226);
            m.Name = "m";
            m.Size = new Size(112, 34);
            m.TabIndex = 0;
            m.Text = "LogOut";
            m.UseVisualStyleBackColor = true;
            m.Click += m_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 132);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 1;
            label1.Text = "Mushroom";
            // 
            // textmushroom
            // 
            textmushroom.Location = new Point(180, 132);
            textmushroom.Name = "textmushroom";
            textmushroom.Size = new Size(449, 31);
            textmushroom.TabIndex = 2;
            textmushroom.TextChanged += textBox1_TextChanged;
            // 
            // Mushroom
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textmushroom);
            Controls.Add(label1);
            Controls.Add(m);
            Name = "Mushroom";
            Text = "Mushroom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button m;
        private Label label1;
        private TextBox textmushroom;
    }
}