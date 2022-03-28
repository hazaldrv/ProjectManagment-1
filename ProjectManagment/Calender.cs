using System;
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
    public partial class Calender : Form
    {
        public Calender()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.BackColor == SystemColors.ButtonHighlight)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to make a appointment?", "Are you sure", MessageBoxButtons.YesNo);

                if (DialogResult.Yes == dialogResult)
                {
                    MessageBox.Show("Please select the time your appointment is being made");
                    this.button8.BackColor = Color.Red;
                }
                else
                {
                    MessageBox.Show("Your appointment has not been made");
                }
            }
            else
            {
                MessageBox.Show("You already have an appointment for today");
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (button40.BackColor == SystemColors.ButtonHighlight)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to buy this time??", "Are you sure", MessageBoxButtons.YesNo);

                if (DialogResult.Yes == dialogResult)
                {
                    MessageBox.Show("Please select the time your appointment is being made");
                    this.button40.BackColor = Color.Red;
                }
                else
                {
                    MessageBox.Show("Your time has not been made");
                }
            }
            else
            {
                MessageBox.Show("You already have an appointment for today");
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.BackColor == SystemColors.ButtonHighlight)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to buy this time??", "Are you sure", MessageBoxButtons.YesNo);

                if (DialogResult.Yes == dialogResult)
                {
                    MessageBox.Show("Please select the time your appointment is being made");
                    this.button9.BackColor = Color.Red;
                }
                else
                {
                    MessageBox.Show("Your time has not been made");
                }
            }
            else
            {
                MessageBox.Show("You already have an appointment for today");
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.BackColor == SystemColors.ButtonHighlight)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to buy this time??", "Are you sure", MessageBoxButtons.YesNo);

                if (DialogResult.Yes == dialogResult)
                {
                    MessageBox.Show("Please select the time your appointment is being made");
                    this.button10.BackColor = Color.Red;
                }
                else
                {
                    MessageBox.Show("Your time has not been made");
                }
            }
            else
            {
                MessageBox.Show("You already have an appointment for today");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.BackColor == SystemColors.ButtonHighlight)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to buy this time??", "Are you sure", MessageBoxButtons.YesNo);

                if (DialogResult.Yes == dialogResult)
                {
                    MessageBox.Show("Please select the time your appointment is being made");
                    this.button11.BackColor = Color.Red;
                }
                else
                {
                    MessageBox.Show("Your time has not been made");
                }
            }
            else
            {
                MessageBox.Show("You already have an appointment for today");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.BackColor == SystemColors.ButtonHighlight)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to buy this time??", "Are you sure", MessageBoxButtons.YesNo);

                if (DialogResult.Yes == dialogResult)
                {
                    MessageBox.Show("Please select the time your appointment is being made");
                    this.button12.BackColor = Color.Red;
                }
                else
                {
                    MessageBox.Show("Your time has not been made");
                }
            }
            else
            {
                MessageBox.Show("You already have an appointment for today");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (button21.BackColor == SystemColors.ButtonHighlight)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to buy this time??", "Are you sure", MessageBoxButtons.YesNo);

                if (DialogResult.Yes == dialogResult)
                {
                    MessageBox.Show("Please select the time your appointment is being made");
                    this.button21.BackColor = Color.Red;
                }
                else
                {
                    MessageBox.Show("Your time has not been made");
                }
            }
            else
            {
                MessageBox.Show("You already have an appointment for today");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (button20.BackColor == SystemColors.ButtonHighlight)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to buy this time??", "Are you sure", MessageBoxButtons.YesNo);

                if (DialogResult.Yes == dialogResult)
                {
                    MessageBox.Show("Please select the time your appointment is being made");
                    this.button20.BackColor = Color.Red;
                }
                else
                {
                    MessageBox.Show("Your time has not been made");
                }
            }
            else
            {
                MessageBox.Show("You already have an appointment for today");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (button9.BackColor == SystemColors.ButtonHighlight)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to buy this time??", "Are you sure", MessageBoxButtons.YesNo);

                if (DialogResult.Yes == dialogResult)
                {
                    MessageBox.Show("Please select the time your appointment is being made");
                    this.button9.BackColor = Color.Red;
                }
                else
                {
                    MessageBox.Show("Your time has not been made");
                }
            }
            else
            {
                MessageBox.Show("You already have an appointment for today");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (button18.BackColor == SystemColors.ButtonHighlight)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to buy this time??", "Are you sure", MessageBoxButtons.YesNo);

                if (DialogResult.Yes == dialogResult)
                {
                    MessageBox.Show("Please select the time your appointment is being made");
                    this.button18.BackColor = Color.Red;
                }
                else
                {
                    MessageBox.Show("Your time has not been made");
                }
            }
            else
            {
                MessageBox.Show("You already have an appointment for today");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (button17.BackColor == SystemColors.ButtonHighlight)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to buy this time??", "Are you sure", MessageBoxButtons.YesNo);

                if (DialogResult.Yes == dialogResult)
                {
                    MessageBox.Show("Please select the time your appointment is being made");
                    this.button17.BackColor = Color.Red;
                }
                else
                {
                    MessageBox.Show("Your time has not been made");
                }
            }
            else
            {
                MessageBox.Show("You already have an appointment for today");
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (button28.BackColor == SystemColors.ButtonHighlight)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to buy this time??", "Are you sure", MessageBoxButtons.YesNo);

                if (DialogResult.Yes == dialogResult)
                {
                    MessageBox.Show("Please select the time your appointment is being made");
                    this.button28.BackColor = Color.Red;
                }
                else
                {
                    MessageBox.Show("Your time has not been made");
                }
            }
            else
            {
                MessageBox.Show("You already have an appointment for today");
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (button27.BackColor == SystemColors.ButtonHighlight)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to buy this time??", "Are you sure", MessageBoxButtons.YesNo);

                if (DialogResult.Yes == dialogResult)
                {
                    MessageBox.Show("Please select the time your appointment is being made");
                    this.button27.BackColor = Color.Red;
                }
                else
                {
                    MessageBox.Show("Your time has not been made");
                }
            }
            else
            {
                MessageBox.Show("You already have an appointment for today");
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (button26.BackColor == SystemColors.ButtonHighlight)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to buy this time??", "Are you sure", MessageBoxButtons.YesNo);

                if (DialogResult.Yes == dialogResult)
                {
                    MessageBox.Show("Please select the time your appointment is being made");
                    this.button26.BackColor = Color.Red;
                }
                else
                {
                    MessageBox.Show("Your time has not been made");
                }
            }
            else
            {
                MessageBox.Show("You already have an appointment for today");
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (button25.BackColor == SystemColors.ButtonHighlight)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to buy this time??", "Are you sure", MessageBoxButtons.YesNo);

                if (DialogResult.Yes == dialogResult)
                {
                    MessageBox.Show("Please select the time your appointment is being made");
                    this.button25.BackColor = Color.Red;
                }
                else
                {
                    MessageBox.Show("Your time has not been made");
                }
            }
            else
            {
                MessageBox.Show("You already have an appointment for today");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (button24.BackColor == SystemColors.ButtonHighlight)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to buy this time??", "Are you sure", MessageBoxButtons.YesNo);

                if (DialogResult.Yes == dialogResult)
                {
                    MessageBox.Show("Please select the time your appointment is being made");
                    this.button24.BackColor = Color.Red;
                }
                else
                {
                    MessageBox.Show("Your time has not been made");
                }
            }
            else
            {
                MessageBox.Show("You already have an appointment for today");
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (button22.BackColor == SystemColors.ButtonHighlight)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to buy this time??", "Are you sure", MessageBoxButtons.YesNo);

                if (DialogResult.Yes == dialogResult)
                {
                    MessageBox.Show("Please select the time your appointment is being made");
                    this.button22.BackColor = Color.Red;
                }
                else
                {
                    MessageBox.Show("Your time has not been made");
                }
            }
            else
            {
                MessageBox.Show("You already have an appointment for today");
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (button24.BackColor == SystemColors.ButtonHighlight)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to buy this time??", "Are you sure", MessageBoxButtons.YesNo);

                if (DialogResult.Yes == dialogResult)
                {
                    MessageBox.Show("Please select the time your appointment is being made");
                    this.button24.BackColor = Color.Red;
                }
                else
                {
                    MessageBox.Show("Your time has not been made");
                }
            }
            else
            {
                MessageBox.Show("You already have an appointment for today");
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (button33.BackColor == SystemColors.ButtonHighlight)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to buy this time??", "Are you sure", MessageBoxButtons.YesNo);

                if (DialogResult.Yes == dialogResult)
                {
                    MessageBox.Show("Please select the time your appointment is being made");
                    this.button33.BackColor = Color.Red;
                }
                else
                {
                    MessageBox.Show("Your time has not been made");
                }
            }
            else
            {
                MessageBox.Show("You already have an appointment for today");
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (button32.BackColor == SystemColors.ButtonHighlight)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to buy this time??", "Are you sure", MessageBoxButtons.YesNo);

                if (DialogResult.Yes == dialogResult)
                {
                    MessageBox.Show("Please select the time your appointment is being made");
                    this.button32.BackColor = Color.Red;
                }
                else
                {
                    MessageBox.Show("Your time has not been made");
                }
            }
            else
            {
                MessageBox.Show("You already have an appointment for today");
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (button31.BackColor == SystemColors.ButtonHighlight)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to buy this time??", "Are you sure", MessageBoxButtons.YesNo);

                if (DialogResult.Yes == dialogResult)
                {
                    MessageBox.Show("Please select the time your appointment is being made");
                    this.button31.BackColor = Color.Red;
                }
                else
                {
                    MessageBox.Show("Your time has not been made");
                }
            }
            else
            {
                MessageBox.Show("You already have an appointment for today");
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (button37.BackColor == SystemColors.ButtonHighlight)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to buy this time??", "Are you sure", MessageBoxButtons.YesNo);

                if (DialogResult.Yes == dialogResult)
                {
                    MessageBox.Show("Please select the time your appointment is being made");
                    this.button37.BackColor = Color.Red;
                }
                else
                {
                    MessageBox.Show("Your time has not been made");
                }
            }
            else
            {
                MessageBox.Show("You already have an appointment for today");
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (button36.BackColor == SystemColors.ButtonHighlight)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to buy this time??", "Are you sure", MessageBoxButtons.YesNo);

                if (DialogResult.Yes == dialogResult)
                {
                    MessageBox.Show("Please select the time your appointment is being made");
                    this.button36.BackColor = Color.Red;
                }
                else
                {
                    MessageBox.Show("Your time has not been made");
                }
            }
            else
            {
                MessageBox.Show("You already have an appointment for today");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can't make an appointment at the weekend!", "PROBLEM",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can't make an appointment at the weekend!", "PROBLEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can't make an appointment at the weekend!", "PROBLEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can't make an appointment at the weekend!", "PROBLEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can't make an appointment at the weekend!", "PROBLEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can't make an appointment at the weekend!", "PROBLEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can't make an appointment at the weekend!", "PROBLEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You can't make an appointment at the weekend!", "PROBLEM", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your appointment was created with success", "Info", MessageBoxButtons.OK);
        }
    }
    


}
