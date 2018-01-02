namespace MissionPlanner
{
    partial class Validation
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.BUT_login = new MissionPlanner.Controls.MyButton();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(91, 195);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtUsername.Size = new System.Drawing.Size(135, 20);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "Username";
            this.txtUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(91, 231);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(135, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Password";
            // 
            // BUT_login
            // 
            this.BUT_login.Location = new System.Drawing.Point(104, 264);
            this.BUT_login.Name = "BUT_login";
            this.BUT_login.Size = new System.Drawing.Size(75, 23);
            this.BUT_login.TabIndex = 2;
            this.BUT_login.Text = "Log in";
            this.BUT_login.UseVisualStyleBackColor = true;
            this.BUT_login.Click += new System.EventHandler(this.BUT_login_Click);
            // 
            // Validation
            // 
            this.BackgroundImage = global::MissionPlanner.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(292, 402);
            this.Controls.Add(this.BUT_login);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Name = "Validation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.MyButton btnLogin;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private Controls.MyButton BUT_login;
    }
}