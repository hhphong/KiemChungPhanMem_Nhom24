using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void disable()
        {
            textBox1.Enabled = true;
            btnOFF.Hide();
            btnOn.Show();
            btnBack.Enabled = false;
            btnClear.Enabled = false;
            btnPlus.Enabled = false;
            btnMinus.Enabled = false;
            btnTimes.Enabled = false;
            btnDivide.Enabled = false;
            btnEqual.Enabled = false;
            btnDoc.Enabled = false;
            btnZero.Enabled = false;
            btnOne.Enabled = false;
            btnTwo.Enabled = false;
            btnThree.Enabled = false;
            btnFour.Enabled = false;
            btnFive.Enabled = false;
            btnSix.Enabled = false;
            btnSeven.Enabled = false;
            btnEight.Enabled = false;
            btnNine.Enabled = false;
        }

        public void enable()
        {
            textBox1.Enabled = true;
            btnOFF.Show();
            btnOn.Hide();
            btnBack.Enabled = true;
            btnClear.Enabled = true;
            btnPlus.Enabled = true;
            btnMinus.Enabled = true;
            btnTimes.Enabled = true;
            btnDivide.Enabled = true;
            btnEqual.Enabled = true;
            btnDoc.Enabled = true;
            btnZero.Enabled = true;
            btnOne.Enabled = true;
            btnTwo.Enabled = true;
            btnThree.Enabled = true;
            btnFour.Enabled = true;
            btnFive.Enabled = true;
            btnSix.Enabled = true;
            btnSeven.Enabled = true;
            btnEight.Enabled = true;
            btnNine.Enabled = true;
        }
        private void btnOFF_Click(object sender, EventArgs e)
        {
            disable();
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            enable();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
           
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "=";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }
    }
}
