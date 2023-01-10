using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework3
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int? input = null;
        string inputString;
        double? avg = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // making sure the user does not input a 0 or a non number
            while (input == null || input == 0)
            {
                try
                {
                    inputString = Interaction.InputBox("How many numbers to generate?", "Random Number Generator");
                    // if the user clicks cancel on the inputbox, it will return "", so we break the loop and close the program
                    if(inputString == "")
                    {
                        break;
                    }
                    else
                    {
                        input = int.Parse(inputString);
                        if(input == 0)
                        {
                            MessageBox.Show("I Can't Generate 0 Number...");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (inputString == "")
                this.Close();
            for(int i = 1; i <= input; i++)
            {
                listBox1.Items.Add(r.Next(0, 999));
            }

         }

        private void btnFindNo_Click(object sender, EventArgs e)
        {
            try
            {
                int inputF = int.Parse(Interaction.InputBox("What number are you looking for?", "Find a Number"));
                if (listBox1.Items.Contains(inputF))
                {
                    int index = listBox1.Items.IndexOf(inputF);
                    MessageBox.Show(String.Format("The number {0} is found at the index {1}.", inputF, index));
                    listBox1.SetSelected(index, true);
                }
                else
                {
                    MessageBox.Show(String.Format("The number {0} does not exist in this list.", inputF));
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            lblOutput.Text = string.Empty;
            avg = null;
            listBox1.Items.Clear();
            for (int i = 1; i <= input; i++)
            {
                listBox1.Items.Add(r.Next(0, 999));
            }
           
        }

        private void btnGetAVG_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int n = listBox1.Items.Count;
            for(int i = 0; i < n; i++)
            {
                sum += int.Parse(listBox1.Items[i].ToString());
            }
            avg = sum / n;
            lblOutput.Text += String.Format("\nThe Average of The Generated Numbers is {0}", avg);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblOutput.Text = String.Empty;
            avg = null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMoreAvg_Click(object sender, EventArgs e)
        {
            if(avg != null)
            {
                int counter = 0;
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    int number = int.Parse(listBox1.Items[i].ToString());
                    if (avg < number)
                        counter++;
                }
                lblOutput.Text += string.Format("\nThere are {0} numbers in the list that are bigger than the average.", counter);
            }
            else
            {
                MessageBox.Show("The average has not been calculated yet!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLessAvg_Click(object sender, EventArgs e)
        {
            if (avg != null)
            {
                int counter = 0;
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    int number = int.Parse(listBox1.Items[i].ToString());
                    if (avg > number)
                        counter++;
                }
                lblOutput.Text += string.Format("\nThere are {0} numbers in the list that are smaller than the average.", counter);
            }
            else
            {
                MessageBox.Show("The average has not been calculated yet!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            int max = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int number = int.Parse(listBox1.Items[i].ToString());
                if (max < number)
                    max = number;
            }
            lblOutput.Text += string.Format("\nThe maximum number value in this list is {0}.", max);
        }

        private void btnGetMin_Click(object sender, EventArgs e)
        {
            int min = 1000;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int number = int.Parse(listBox1.Items[i].ToString());
                if (min > number)
                    min = number;
            }
            lblOutput.Text += string.Format("\nThe minimum number value in this list is {0}.", min);
        }
    }
}
