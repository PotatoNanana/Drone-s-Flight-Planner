using System;
namespace MissionPlanner
{
    partial class MainV3_admin
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
            //Console.WriteLine("MainV3_Dispose");
            if (PluginThreadrunner != null)
                PluginThreadrunner.Dispose();
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
        /// 
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainV3_admin));
            this.CTX_mainmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.autoHideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readonlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.but_maintenance = new System.Windows.Forms.Button();
            this.but_setup = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.but_flightPlan = new System.Windows.Forms.Button();
            this.but_mainMenu = new System.Windows.Forms.Button();
            this.but_farmProfile = new System.Windows.Forms.Button();
            this.menu = new MissionPlanner.Controls.MyButton();
            this.CTX_mainmenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CTX_mainmenu
            // 
            this.CTX_mainmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoHideToolStripMenuItem,
            this.fullScreenToolStripMenuItem,
            this.readonlyToolStripMenuItem,
            this.connectionOptionsToolStripMenuItem});
            this.CTX_mainmenu.Name = "CTX_mainmenu";
            resources.ApplyResources(this.CTX_mainmenu, "CTX_mainmenu");
            // 
            // autoHideToolStripMenuItem
            // 
            this.autoHideToolStripMenuItem.CheckOnClick = true;
            this.autoHideToolStripMenuItem.Name = "autoHideToolStripMenuItem";
            resources.ApplyResources(this.autoHideToolStripMenuItem, "autoHideToolStripMenuItem");
            this.autoHideToolStripMenuItem.Click += new System.EventHandler(this.autoHideToolStripMenuItem_Click);
            // 
            // fullScreenToolStripMenuItem
            // 
            this.fullScreenToolStripMenuItem.CheckOnClick = true;
            this.fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
            resources.ApplyResources(this.fullScreenToolStripMenuItem, "fullScreenToolStripMenuItem");
            this.fullScreenToolStripMenuItem.Click += new System.EventHandler(this.fullScreenToolStripMenuItem_Click);
            // 
            // readonlyToolStripMenuItem
            // 
            this.readonlyToolStripMenuItem.CheckOnClick = true;
            this.readonlyToolStripMenuItem.Name = "readonlyToolStripMenuItem";
            resources.ApplyResources(this.readonlyToolStripMenuItem, "readonlyToolStripMenuItem");
            this.readonlyToolStripMenuItem.Click += new System.EventHandler(this.readonlyToolStripMenuItem_Click);
            // 
            // connectionOptionsToolStripMenuItem
            // 
            this.connectionOptionsToolStripMenuItem.Name = "connectionOptionsToolStripMenuItem";
            resources.ApplyResources(this.connectionOptionsToolStripMenuItem, "connectionOptionsToolStripMenuItem");
            this.connectionOptionsToolStripMenuItem.Click += new System.EventHandler(this.connectionOptionsToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.but_maintenance);
            this.panel1.Controls.Add(this.but_setup);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.but_flightPlan);
            this.panel1.Controls.Add(this.but_mainMenu);
            this.panel1.Controls.Add(this.but_farmProfile);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // but_maintenance
            // 
            resources.ApplyResources(this.but_maintenance, "but_maintenance");
            this.but_maintenance.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.but_maintenance.FlatAppearance.BorderSize = 0;
            this.but_maintenance.ForeColor = System.Drawing.Color.White;
            this.but_maintenance.Name = "but_maintenance";
            this.but_maintenance.UseCompatibleTextRendering = true;
            this.but_maintenance.UseVisualStyleBackColor = true;
            this.but_maintenance.Click += new System.EventHandler(this.but_maintenance_Click);
            // 
            // but_setup
            // 
            resources.ApplyResources(this.but_setup, "but_setup");
            this.but_setup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.but_setup.FlatAppearance.BorderSize = 0;
            this.but_setup.ForeColor = System.Drawing.Color.White;
            this.but_setup.Name = "but_setup";
            this.but_setup.UseCompatibleTextRendering = true;
            this.but_setup.UseVisualStyleBackColor = true;
            this.but_setup.Click += new System.EventHandler(this.but_setup_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(100)))));
            resources.ApplyResources(this.SidePanel, "SidePanel");
            this.SidePanel.Name = "SidePanel";
            // 
            // but_flightPlan
            // 
            resources.ApplyResources(this.but_flightPlan, "but_flightPlan");
            this.but_flightPlan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.but_flightPlan.FlatAppearance.BorderSize = 0;
            this.but_flightPlan.ForeColor = System.Drawing.Color.White;
            this.but_flightPlan.Name = "but_flightPlan";
            this.but_flightPlan.UseCompatibleTextRendering = true;
            this.but_flightPlan.UseVisualStyleBackColor = true;
            this.but_flightPlan.Click += new System.EventHandler(this.but_flightPlan_Click);
            // 
            // but_mainMenu
            // 
            resources.ApplyResources(this.but_mainMenu, "but_mainMenu");
            this.but_mainMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.but_mainMenu.FlatAppearance.BorderSize = 0;
            this.but_mainMenu.ForeColor = System.Drawing.Color.White;
            this.but_mainMenu.Name = "but_mainMenu";
            this.but_mainMenu.UseCompatibleTextRendering = true;
            this.but_mainMenu.UseVisualStyleBackColor = true;
            this.but_mainMenu.Click += new System.EventHandler(this.but_mainMenu_Click);
            // 
            // but_farmProfile
            // 
            resources.ApplyResources(this.but_farmProfile, "but_farmProfile");
            this.but_farmProfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.but_farmProfile.FlatAppearance.BorderSize = 0;
            this.but_farmProfile.ForeColor = System.Drawing.Color.White;
            this.but_farmProfile.Name = "but_farmProfile";
            this.but_farmProfile.UseCompatibleTextRendering = true;
            this.but_farmProfile.UseVisualStyleBackColor = true;
            this.but_farmProfile.Click += new System.EventHandler(this.but_farmProfile_Click);
            // 
            // menu
            // 
            resources.ApplyResources(this.menu, "menu");
            this.menu.Name = "menu";
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            this.menu.MouseEnter += new System.EventHandler(this.menu_MouseEnter);
            // 
            // MainV3
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu);
            this.KeyPreview = true;
            this.Name = "MainV3_admin";
            this.Load += new System.EventHandler(this.MainV3_admin_Load);
            this.CTX_mainmenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.MyButton menu;
        private System.Windows.Forms.ContextMenuStrip CTX_mainmenu;
        private System.Windows.Forms.ToolStripMenuItem autoHideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readonlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionOptionsToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button but_mainMenu;
        private System.Windows.Forms.Button but_farmProfile;
        private System.Windows.Forms.Button but_setup;
        private System.Windows.Forms.Button but_flightPlan;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button but_maintenance;
    }
}