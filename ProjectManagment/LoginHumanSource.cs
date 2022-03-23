using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FacadeLayer;
using EntityLayer;
using BusinessLogicLayer;

namespace ProjectManagment
{
    public partial class LoginHumanSource : Form
    {
        public LoginHumanSource()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserSelect userSelect = new UserSelect();
            userSelect.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            EntityHumanSourceInfo ent = new EntityHumanSourceInfo();
            ent.USERNAME = "Humansource";
            ent.PASSWORD = "123456";

            if ("Humansource" == txtUserName.Text && "123456" == txtPassword.Text)
            {
                HumanSourceControl humanSourceControl = new HumanSourceControl();
                humanSourceControl.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password!");
            }
        }
    }
}
