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
            this.Goto_main = new MissionPlanner.Controls.MyButton();
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
            this.txtUsername.Enter += new System.EventHandler(this.userid_enter);
            this.txtUsername.Leave += new System.EventHandler(this.userid_leave);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("PJ Standard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.Location = new System.Drawing.Point(103, 249);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(135, 31);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "รหัสผ่าน";
            this.txtPassword.Enter += new System.EventHandler(this.pwd_enter);
            this.txtPassword.Leave += new System.EventHandler(this.pwd_leave);
            // 
            // Goto_main
            // 
            this.Goto_main.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(232)))), ((int)(((byte)(108)))));
            this.Goto_main.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(232)))), ((int)(((byte)(108)))));
            this.Goto_main.ColorMouseOver = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(148)))), ((int)(((byte)(41)))));
            this.Goto_main.Font = new System.Drawing.Font("PJ Standard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Goto_main.Location = new System.Drawing.Point(113, 295);
            this.Goto_main.Name = "Goto_main";
            this.Goto_main.Size = new System.Drawing.Size(100, 30);
            this.Goto_main.TabIndex = 2;
            this.Goto_main.Text = "เข้าสู่ระบบ";
            this.Goto_main.UseVisualStyleBackColor = true;
            this.Goto_main.Click += new System.EventHandler(this.Goto_main_Click);
            this.Goto_main.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Goto_main_KeyDown);
            // 
            // Validation
            // 
            this.BackgroundImage = global::MissionPlanner.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(327, 444);
            this.Controls.Add(this.Goto_main);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Validation";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.MyButton btnLogin;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private Controls.MyButton Goto_main;
    }
}