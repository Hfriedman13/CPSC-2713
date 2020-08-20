using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            int num1, num2, result;                    //declaring variables
            num1 = Convert.ToInt32(tbNum1.Text);
            num2 = Convert.ToInt32(tbNum2.Text);
            String option = Convert.ToString(tbOption.Text);

            if (option.Equals("+")) //additon
            {
                result = num1 + num2;
                resultsLabel.Text = result.ToString();
            }
            else if (option.Equals("-")) //sub
            {
                result = num1 - num2;
                resultsLabel.Text = result.ToString();
            }
            else if (option.Equals("*"))//multi 
            {
                result = num1 * num2;
                resultsLabel.Text = result.ToString();
            }
            else
                resultsLabel.Text = "Invalid choice"; //chose invaild choice

        }   
    }
}
