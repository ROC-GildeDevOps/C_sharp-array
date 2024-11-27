using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_sharp_array
{
    public partial class Form1 : Form
    {
        private int index;
        private int[] getallen = { 25, 35, 22, 44, 53 };

        public Form1()
        {
            InitializeComponent();
            Array.Sort(getallen);
        }

        private void btn_while_Click(object sender, EventArgs e)
        {
            while (index < getallen.Length)
            {
                lbl_output.Text += " " + getallen[index].ToString();
                index++;
            }
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            lbl_output.Text = "";
            index = 0;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_for_Click(object sender, EventArgs e)
        {
            for (index = 0; index < getallen.Length; index++)
            {
                lbl_output.Text += " " + getallen[index].ToString();
            }
        }

        private void btn_each_Click(object sender, EventArgs e)
        {
            foreach (int getal in getallen)
            {
                lbl_output.Text += " " + getal.ToString();
            }
        }
    }
}
