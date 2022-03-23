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
    public partial class HumanSourceControl : Form
    {
        public HumanSourceControl()
        {
            InitializeComponent();
        }

        void AcademicianList()
        {
            List<EntityAcademician> acalist = BLLHumanSource.Listele();
            dataGridView1.DataSource = acalist;
            this.Text = "DEPARTMAN";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void HumanSourceControl_Load(object sender, EventArgs e)
        {
            AcademicianList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EntityAcademician ent = new EntityAcademician();
            ent.NAME = txtName.Text; ;
            ent.DEPARTMAN = txtDepartman.Text;
            ent.POSITION = txtPosition.Text;
            ent.PHONE = txtPhone.Text;
            ent.EMAIL = txtEmail.Text;
            ent.OFFICE = txtOffice.Text;
            ent.TIMETABLE = txtTimeTable.Text;
            BLLHumanSource.Add(ent);
            
            MessageBox.Show("Academician save successfully");
            AcademicianList();
        }

        private void txtDepartman_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPosition_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOffice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTimeTable_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}
