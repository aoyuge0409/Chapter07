using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int MAXITERATIONS = 200000; // Limit loop passes

        private void BtnStart_Click(object sender, EventArgs e)
        {
            bool flag;
            int counter; // Pass counter
            int max; // Max value for random number
            int last;
            int current;
            Random randomNumber = new Random();
            //========= Program Input Step ================
            flag = int.TryParse(txtMax.Text, out max);
            if (flag == false)
            {
                MessageBox.Show("Digit characters only.", "Input Error",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtMax.Focus();
                return;
            }
            
            counter = 0;
            last = (int)randomNumber.Next(max);
            do
            {
                current = randomNumber.Next(max);
                if (last == current)

                    
            
{
            
                 }
                last = current;
                counter++;
            } while (counter < MAXITERATIONS);
            //========= Program Output Step ==============
            if (counter < MAXITERATIONS)
            {
                lblAnswer.Text = "It took " + counter.ToString() + " passes to match";
            }
            else
            {
                lblAnswer.Text = "No back-to-back match";
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
