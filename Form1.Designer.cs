namespace Lab2DotNetAss
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lbusername = new Label();
            lbpassword = new Label();
            textuser = new TextBox();
            textpass = new TextBox();
            Login = new Button();
            exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(304, 21);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 0;
            label1.Text = "LOGIN FORM";
            // 
            // lbusername
            // 
            lbusername.AutoSize = true;
            lbusername.Location = new Point(46, 137);
            lbusername.Name = "lbusername";
            lbusername.Size = new Size(104, 25);
            lbusername.TabIndex = 1;
            lbusername.Text = "USERNAME";
            // 
            // lbpassword
            // 
            lbpassword.AutoSize = true;
            lbpassword.Location = new Point(46, 183);
            lbpassword.Name = "lbpassword";
            lbpassword.Size = new Size(108, 25);
            lbpassword.TabIndex = 2;
            lbpassword.Text = "PASSWORD";
            // 
            // textuser
            // 
            textuser.Location = new Point(196, 137);
            textuser.Name = "textuser";
            textuser.Size = new Size(277, 31);
            textuser.TabIndex = 3;
            // 
            // textpass
            // 
            textpass.Location = new Point(196, 192);
            textpass.Name = "textpass";
            textpass.Size = new Size(277, 31);
            textpass.TabIndex = 4;
            // 
            // Login
            // 
            Login.Location = new Point(196, 271);
            Login.Name = "Login";
            Login.Size = new Size(112, 34);
            Login.TabIndex = 5;
            Login.Text = "login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // exit
            // 
            exit.Location = new Point(361, 271);
            exit.Name = "exit";
            exit.Size = new Size(112, 34);
            exit.TabIndex = 6;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(exit);
            Controls.Add(Login);
            Controls.Add(textpass);
            Controls.Add(textuser);
            Controls.Add(lbpassword);
            Controls.Add(lbusername);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "Login Form";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbusername;
        private Label lbpassword;
        private TextBox textuser;
        private TextBox textpass;
        private Button Login;
        private Button exit;
    }
}
