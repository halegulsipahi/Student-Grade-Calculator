using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = btnCalculate;
        }




        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int grade1 = Convert.ToInt32(txtGradeOne.Text);
            int grade2 = Convert.ToInt32(txtGradeTwo.Text);

            if (grade1 < 0 || grade1 > 100 || grade2 < 0 || grade2 > 100)
            {
                ClearResults();
                MessageBox.Show("Incorrect grade entry!");
                return;
            }
            double average = (grade1 + grade2) / 2.0;

            lblAverage.Text = "Average: " + average.ToString();

            if (average > 50)
            {
                lblAverage.BackColor = Color.Green;
                lblStatus.Text = "Passed!";
            }
            else if (average == 50)
            {
                lblAverage.BackColor = Color.Yellow;
                lblAverage.ForeColor = Color.Black;
                lblStatus.Text = "Conditional Pass!";
            }
            else
            {
                lblAverage.BackColor = Color.Red;
                lblStatus.Text = "Failed!";
            }
        }
        private void ClearResults()
        {
            lblAverage.Text = "";
            lblAverage.BackColor = Color.Transparent;
            lblStatus.Text = "";

        }

        private void txtGradeOne_TextChanged(object sender, EventArgs e)
        {
            ClearResults();
        }

        private void txtGradeTwo_TextChanged(object sender, EventArgs e)
        {
            ClearResults();
        }

        private void txtGradeOne_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtGradeTwo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       
    }
}
