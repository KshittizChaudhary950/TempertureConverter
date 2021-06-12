using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Fbtn_Click(object sender, EventArgs e)
        {
            double num;
        
            double f;
         
            if(input.Text!="")
            {
                num = Convert.ToDouble( input.Text);

                f = (1.8 * num) + 32;

                Output.Text =Convert.ToString(System.Math.Round(f,2));

                //  MessageBox.Show(f.ToString());


            }
            else
            {
                MessageBox.Show("Please enter number which to want to convert");
            }
        }

        private void Celsiusbtn_Click(object sender, EventArgs e)
        {
            double num2;
            double c;

            if(input.Text!="")
            {
                num2 =Convert.ToDouble( input.Text);

                c = (num2 - 32) * 5 / 9;
                Output.Text =Convert.ToString( System.Math.Round(c,2));

                Console.ReadLine();

            


            }
            else
            {
                MessageBox.Show("Please enter the number");
            }

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            if (input.Text!="" && Output.Text!="")
            {
                input.Text = "";
                Output.Text = "";
                input.Focus();


            }
            else
            {
                MessageBox.Show("There is onthing to clear");
            }
        }
    }
}
