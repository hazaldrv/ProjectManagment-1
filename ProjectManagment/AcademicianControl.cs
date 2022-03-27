using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using FacadeLayer;
using BusinessLogicLayer;

namespace ProjectManagment
{
    public partial class AcademicianControl : Form
    {
        public AcademicianControl()
        {
            InitializeComponent();
        }
        void AcademicianList()
        {
            List<EntityAcademician> acalist = BLLHumanSource.Listele();
            dataGridView1.DataSource = acalist;
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EntityAcademician ent = new EntityAcademician();
            ent.NAME = txtName.Text;
            ent.DEPARTMAN = txtDepartman.Text;
            ent.POSITION = txtPosition.Text;
            ent.PHONE = txtPhone.Text;
            ent.EMAIL = txtEmail.Text;
            ent.OFFICE = txtOffice.Text;
            BLLAcademician.Update(ent);
            AcademicianList();
            MessageBox.Show("Academician information was update");
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            AcademicianList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserSelect userSelect = new UserSelect();
            userSelect.Show();
            this.Hide();
        }
    }
}
