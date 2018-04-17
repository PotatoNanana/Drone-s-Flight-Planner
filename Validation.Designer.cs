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
            this.txtUsername.Font = new System.Drawing.Font("PJ Standard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsername.Location = new System.Drawing.Point(103, 208);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtUsername.Size = new System.Drawing.Size(135, 31);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "ชื่อผู้ใช้งาน";
            this.txtUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            this.txtUsername.Enter += new System.EventHandler(this.userid_enter);
            this.txtUsername.Leave += new System.EventHandler(this.userid_leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("PJ Standard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.Location = new System.Drawing.Point(103, 249);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(135, 31);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "รหัสผ่าน";
            this.txtPassword.Enter += new System.EventHandler(this.pwd_enter);
            this.txtPassword.Leave += new System.EventHandler(this.pwd_leave);
            // 
            // BUT_login
            // 
            this.BUT_login.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(232)))), ((int)(((byte)(108)))));
            this.BUT_login.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(232)))), ((int)(((byte)(108)))));
            this.BUT_login.ColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(148)))), ((int)(((byte)(41)))));
            this.BUT_login.Font = new System.Drawing.Font("PJ Standard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUT_login.Location = new System.Drawing.Point(113, 295);
            this.BUT_login.Name = "BUT_login";
            this.BUT_login.Size = new System.Drawing.Size(100, 30);
            this.BUT_login.TabIndex = 2;
            this.BUT_login.Text = "เข้าสู่ระบบ";
            this.BUT_login.UseVisualStyleBackColor = true;
            this.BUT_login.Click += new System.EventHandler(this.BUT_login_Click);
            // 
            // Validation
            // 
            this.BackgroundImage = global::MissionPlanner.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(327, 444);
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