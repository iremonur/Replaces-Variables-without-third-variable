using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReplaceVariables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            int first_variable = 0;
            int second_variable = 0;
            first_variable = int.Parse(txtFirstVariable.Text);
            second_variable = int.Parse(txtSecondVariable.Text);


            first_variable = first_variable + second_variable;
            second_variable = first_variable - second_variable;
            first_variable = first_variable - second_variable;

            txtFirstValue.Text = first_variable.ToString();
            txtSecondValue.Text = second_variable.ToString();

        }
    }
}
