using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Microsoft.Win32;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenEMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            RegistryKey newKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\OpenEMS");
            newKey.SetValue("db_name", txtDBName.Text);
            newKey.SetValue("db_host", txtFQDN.Text);
            newKey.SetValue("db_user", txtUsername.Text);

            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\OpenEMS"))
            {
                if (key != null)
                {
                    txtDBName.Text = key.GetValue("db_name").ToString();
                    txtFQDN.Text = (string)key.GetValue("db_host");
                    txtUsername.Text = (string)key.GetValue("db_user");
                    txtPassword.Focus();
                }
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(null, null);
            }
        }
    }
}
