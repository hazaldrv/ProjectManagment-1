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
    public partial class LoginAcademician : Form
    {
        public LoginAcademician()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserSelect userSelect = new UserSelect();
            userSelect.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            EntityAcademicianInfo ent = new EntityAcademicianInfo();
            ent.USERNAME = "Academician";
            ent.PASSWORD = "123456";
            if ("Academician" == txtUserName.Text && "123456" == txtPassword.Text)
            {
                AcademicianControl academicianControl = new AcademicianControl();
                academicianControl.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password!");
            }

        }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
      if (checkBox1.CheckState == CheckState.Checked)
      {
        txtPassword.UseSystemPasswordChar = true;
        checkBox1.Text = "Hide";
      }
      else if (checkBox1.CheckState == CheckState.Unchecked)
      {
        txtPassword.UseSystemPasswordChar = false;
        checkBox1.Text = "Show";
      }
    }

    private void button4_Click(object sender, EventArgs e)
    {
      this.Hide();
    }
  }
}
