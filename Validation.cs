using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using Community.CsharpSqlite.SQLiteClient;

namespace MissionPlanner
{
    public partial class Validation : Form
    {
        public static bool WindowsStoreApp { get { return Application.ExecutablePath.Contains("WindowsApps"); } }

        SqlConnection con = Tutorial.SqlConn.DBUtils.GetDBConnection();
        public static event EventHandler Goto_main_Clicked;

        public static int roleid;
        
        public Validation()
        {
            Application.DoEvents();

            Form splash = Program.Splash;
            splash.Refresh();

            InitializeComponent();

            string strVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            
        }

        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            Exception ex = e.Exception;

            handleException(ex);
        }

        static void handleException(Exception ex)
        {
            if (ex.Message == "Safe handle has been closed")
            {
                return;
            }

            if (MainV3.instance != null && MainV3.instance.IsDisposed)
                return;

            MissionPlanner.Utilities.Tracking.AddException(ex);

            // hyperlinks error
            if (ex.Message == "Requested registry access is not allowed." ||
                ex.ToString().Contains("System.Windows.Forms.LinkUtilities.GetIELinkBehavior"))
            {
                return;
            }
            if (ex.Message == "The port is closed.")
            {
                CustomMessageBox.Show("Serial connection has been lost");
                return;
            }
            if (ex.Message == "A device attached to the system is not functioning.")
            {
                CustomMessageBox.Show("Serial connection has been lost");
                return;
            }
            if (ex.GetType() == typeof(OpenTK.Graphics.GraphicsContextException))
            {
                CustomMessageBox.Show("Please update your graphics card drivers. Failed to create opengl surface\n" + ex.Message);
                return;
            }
            if (ex.GetType() == typeof(MissingMethodException) || ex.GetType() == typeof(TypeLoadException))
            {
                CustomMessageBox.Show("Please Update - Some older library dlls are causing problems\n" + ex.Message);
                return;
            }

            DialogResult dr =
                CustomMessageBox.Show("An error has occurred\n" + ex.ToString() + "\n\nReport this Error???",
                    "Send Error", MessageBoxButtons.YesNo);

        }

        protected virtual void OnGotoMainClicked(EventArgs e)
        {
            Goto_main_Clicked?.Invoke(this, e);
        }
        
        private static int role_id;
        private void Goto_main_Click(object sender, EventArgs e)
        {
            String query = "select count(*) from UserLogin where username=@usr and password=@pwd";
            SqlCommand scmd = new SqlCommand(query, con);
            scmd.Parameters.Clear();
            scmd.Parameters.AddWithValue("@usr", txtUsername.Text);
            scmd.Parameters.AddWithValue("@pwd", txtPassword.Text);

            SqlCommand cmd = new SqlCommand("Select role from UserLogin Where username='" + txtUsername.Text + "' and password='" + txtPassword.Text + "'", con);
            string role;
            con.Open();
            if(scmd.ExecuteScalar().ToString() == "1")
            {
                SqlDataReader dtr = cmd.ExecuteReader();
                //SqlDataAdapter sda = new SqlDataAdapter("Select role from UserLogin Where username='" + txtUsername.Text + "' and password='" + txtPassword.Text + "'   ", con);
                //DataTable dt = new DataTable();
                //sda.Fill(dt);

                while (dtr.Read())
                {
                    role = dtr["role"].ToString();
                    switch (role)
                    {
                        case "developer":
                            {
                                roleid = 1;
                                this.Hide();
                                var frm = new MainV2();
                                frm.ShowDialog();
                                break;
                            }

                        case "admin":
                            {
                                roleid = 2;
                                this.Hide();
                                var frm = new MainV3_admin();
                                frm.ShowDialog();
                                break;
                            }

                        case "pilot":
                            {
                                roleid = 3;
                                this.Hide();
                                var frm = new MainV3_pilot();
                                frm.ShowDialog();
                                break;
                            }

                        default:
                            {
                                this.Hide();
                                var frm = new MainV3();
                                frm.ShowDialog();
                                break;
                            }
                    }
                }
            }
            else
            {
                MessageBox.Show("ชื่อผู้ใช้งานหรือรหัสผ่านของคุณไม่ถูกต้อง \nกรุณากรอกใหม่อีกครั้ง");
            }
            con.Close();
        }
        
        private void userid_enter(object sender, EventArgs e)
        {
            if(txtUsername.Text == "ชื่อผู้ใช้งาน")
            {
                txtUsername.Text = "";
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void userid_leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "ชื่อผู้ใช้งาน";
                txtUsername.ForeColor = Color.DimGray;
            }
        }

        private void pwd_enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "รหัสผ่าน")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void pwd_leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "รหัสผ่าน";
                txtPassword.ForeColor = Color.DimGray;
            }
        }
        
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Enter)
            {
                Goto_main.PerformClick();
            }
            return base.ProcessDialogKey(keyData);
        }

        private void Goto_main_KeyDown(object sender, KeyEventArgs e)
        {
            ProcessDialogKey(e.KeyData);
        }
    }
}