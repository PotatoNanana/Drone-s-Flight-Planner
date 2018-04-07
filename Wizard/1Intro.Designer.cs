using System.Windows.Forms;
namespace MissionPlanner.Wizard
{
    partial class _1Intro
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_1Intro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxwizard = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxheli = new MissionPlanner.Controls.PictureBoxMouseOver();
            this.pictureBoxquad = new MissionPlanner.Controls.PictureBoxMouseOver();
            this.pictureBoxrover = new MissionPlanner.Controls.PictureBoxMouseOver();
            this.pictureBoxplane = new MissionPlanner.Controls.PictureBoxMouseOver();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxwizard)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxheli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxquad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxrover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxplane)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBoxwizard);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.label1.Name = "label1";
            // 
            // pictureBoxwizard
            // 
            resources.ApplyResources(this.pictureBoxwizard, "pictureBoxwizard");
            this.pictureBoxwizard.Image = global::MissionPlanner.Properties.Resources.wizardicon1;
            this.pictureBoxwizard.Name = "pictureBoxwizard";
            this.pictureBoxwizard.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBoxheli);
            this.panel2.Controls.Add(this.pictureBoxquad);
            this.panel2.Controls.Add(this.pictureBoxrover);
            this.panel2.Controls.Add(this.pictureBoxplane);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            // 
            // pictureBoxheli
            // 
            resources.ApplyResources(this.pictureBoxheli, "pictureBoxheli");
            this.pictureBoxheli.Image = global::MissionPlanner.Properties.Resources.light_06;
            this.pictureBoxheli.ImageNormal = global::MissionPlanner.Properties.Resources.light_06;
            this.pictureBoxheli.ImageOver = global::MissionPlanner.Properties.Resources._01_06;
            this.pictureBoxheli.Name = "pictureBoxheli";
            this.pictureBoxheli.selected = false;
            this.pictureBoxheli.TabStop = false;
            this.pictureBoxheli.Tag = "heli";
            this.pictureBoxheli.Click += new System.EventHandler(this.pictureBoxheli_Click);
            // 
            // pictureBoxquad
            // 
            resources.ApplyResources(this.pictureBoxquad, "pictureBoxquad");
            this.pictureBoxquad.Image = global::MissionPlanner.Properties.Resources.light_05;
            this.pictureBoxquad.ImageNormal = global::MissionPlanner.Properties.Resources.light_05;
            this.pictureBoxquad.ImageOver = global::MissionPlanner.Properties.Resources._01_05;
            this.pictureBoxquad.Name = "pictureBoxquad";
            this.pictureBoxquad.selected = false;
            this.pictureBoxquad.TabStop = false;
            this.pictureBoxquad.Tag = "copter";
            this.pictureBoxquad.Click += new System.EventHandler(this.pictureBoxquad_Click);
            // 
            // pictureBoxrover
            // 
            resources.ApplyResources(this.pictureBoxrover, "pictureBoxrover");
            this.pictureBoxrover.Image = global::MissionPlanner.Properties.Resources.light_03;
            this.pictureBoxrover.ImageNormal = global::MissionPlanner.Properties.Resources.light_03;
            this.pictureBoxrover.ImageOver = global::MissionPlanner.Properties.Resources._01_03;
            this.pictureBoxrover.Name = "pictureBoxrover";
            this.pictureBoxrover.selected = false;
            this.pictureBoxrover.TabStop = false;
            this.pictureBoxrover.Tag = "rover";
            this.pictureBoxrover.Click += new System.EventHandler(this.pictureBoxrover_Click);
            // 
            // pictureBoxplane
            // 
            resources.ApplyResources(this.pictureBoxplane, "pictureBoxplane");
            this.pictureBoxplane.Image = global::MissionPlanner.Properties.Resources.light_01;
            this.pictureBoxplane.ImageNormal = global::MissionPlanner.Properties.Resources.light_01;
            this.pictureBoxplane.ImageOver = global::MissionPlanner.Properties.Resources._01_01;
            this.pictureBoxplane.Name = "pictureBoxplane";
            this.pictureBoxplane.selected = false;
            this.pictureBoxplane.TabStop = false;
            this.pictureBoxplane.Tag = "plane";
            this.pictureBoxplane.Click += new System.EventHandler(this.pictureBoxplane_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(96)))));
            this.panel3.Controls.Add(this.label7);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Name = "label9";
            // 
            // _1Intro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "_1Intro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxwizard)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxheli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxquad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxrover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxplane)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxwizard;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Controls.PictureBoxMouseOver pictureBoxplane;
        private Controls.PictureBoxMouseOver pictureBoxquad;
        private Controls.PictureBoxMouseOver pictureBoxrover;
        private Controls.PictureBoxMouseOver pictureBoxheli;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel3;
        private Label label8;
        private Label label7;
        private Label label9;
    }
}
