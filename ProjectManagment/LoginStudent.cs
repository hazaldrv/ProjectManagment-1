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
    public partial class LoginStudent : Form
    {
        public LoginStudent()
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
            EntityStudentInfo ent = new EntityStudentInfo();
            ent.USERNAME = "Student";
            ent.PASSWORD = "123456";
            if("Student" == txtUserName.Text && "123456" == txtPassword.Text)
            {
                StudentControl studentControl = new StudentControl();
                studentControl.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password!");
            }

            
            
        }
    }
}
