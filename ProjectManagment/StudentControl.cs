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
    public partial class StudentControl : Form
    {
        public StudentControl()
        {
            InitializeComponent();
        }

        void AcademicianList()
        {
            List<EntityAcademician> acalist = BLLHumanSource.Listele();
            dataGridView1.DataSource = acalist;

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            AcademicianList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calender calender = new Calender();
            calender.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserSelect userSelect = new UserSelect();
            userSelect.Show();
            this.Hide();
        }
    }
}
