namespace Lab2DotNetAss
{
    partial class Menu
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
            Bicycle = new Button();
            Mushroom = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Bicycle
            // 
            Bicycle.Location = new Point(56, 209);
            Bicycle.Name = "Bicycle";
            Bicycle.Size = new Size(112, 34);
            Bicycle.TabIndex = 0;
            Bicycle.Text = "Bicycle";
            Bicycle.UseVisualStyleBackColor = true;
            // 
            // Mushroom
            // 
            Mushroom.Location = new Point(453, 209);
            Mushroom.Name = "Mushroom";
            Mushroom.Size = new Size(112, 34);
            Mushroom.TabIndex = 1;
            Mushroom.Text = "Mushroom";
            Mushroom.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("MS Reference Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(211, 49);
            label1.Name = "label1";
            label1.Size = new Size(331, 60);
            label1.TabIndex = 2;
            label1.Text = "MENU FORM";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Mushroom);
            Controls.Add(Bicycle);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Bicycle;
        private Button Mushroom;
        private Label label1;
    }
}