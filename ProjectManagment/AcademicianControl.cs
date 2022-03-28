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
            ent.ID = Convert.ToInt32(txtID.Text);
            ent.NAME = txtName.Text;
            ent.DEPARTMAN = txtDepartman.Text;
            ent.POSITION = txtPosition.Text;
            ent.PHONE = txtPhone.Text;
            ent.EMAIL = txtEmail.Text;
            ent.OFFICE = txtOffice.Text;
            ent.TIMETABLE = txtTimeTable.Text;
            BLLAcademician.Update(ent);
            //AcademicianList();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtDepartman.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtPosition.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtOffice.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtTimeTable.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calender calender = new Calender();
            calender.Show();
            this.Hide();
        }

    private void button4_Click(object sender, EventArgs e)
    {
      this.Hide();
    }
  }
}
