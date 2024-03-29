﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagment
{
    public partial class UserSelect : Form
    {
        public UserSelect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.Info;
            LoginHumanSource loginHumanSource = new LoginHumanSource();
            loginHumanSource.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = SystemColors.Info;
            LoginAcademician loginAcademician = new LoginAcademician();
            loginAcademician.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = SystemColors.Info;
            LoginStudent loginStudent = new LoginStudent();
            loginStudent.Show();
            this.Hide();
        }

    private void button4_Click(object sender, EventArgs e)
    {
      this.Hide();
    }
  }
}
