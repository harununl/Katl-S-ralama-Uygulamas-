﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Katlı_Sıralama_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int firstNumber, lastNumber, divisibleNumber;
        string divisibleText="";

        private void cmbDivisibleTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            divisibleNumber = Convert.ToInt32(cmbDivisibleTerm.SelectedItem);


        }

        private void txtDivisibleNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            if ((e.KeyChar == '.' && ((sender as TextBox).Text.IndexOf('.') > -1)))
                e.Handled = true;

        }

        private void txtFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            if ((e.KeyChar == '.' && ((sender as TextBox).Text.IndexOf('.') > -1)))
                e.Handled=true;

        }

        private void cmbDivisibleTerm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
            if ((e.KeyChar == '.' && ((sender as TextBox).Text.IndexOf('.') > -1)))
                e.Handled = true;
        }

        private void rbBlack_CheckedChanged(object sender, EventArgs e)
        {
            if(rbBlack.Checked)
            {
                rbBlue.Checked = false;
                rbGreen.Checked = false;
                rbRed.Checked = false;
                txtDivisibleNumber.ForeColor = Color.Black;
            }
        }

        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {
            if(rbRed.Checked)
            {
                rbBlack.Checked = false;
                rbBlue.Checked = false;
                rbGreen.Checked=false;
                txtDivisibleNumber.ForeColor = Color.Red;

            }
        }

        private void rbBlue_CheckedChanged(object sender, EventArgs e)
        {
            if(rbBlue.Checked)
            {
                rbRed.Checked = false;
                rbGreen.Checked = false ;
                rbBlack.Checked = false;
                txtDivisibleNumber.ForeColor = Color.Blue;
            }
        }

        private void rbGreen_CheckedChanged(object sender, EventArgs e)
        {
            if(rbGreen.Checked)
            {
                rbBlack.Checked= false;
                rbBlue.Checked= false;  
                rbRed.Checked= false;
                txtDivisibleNumber.ForeColor = Color.Green;


            }
        }

        private void chBold_CheckedChanged(object sender, EventArgs e)
        {
            if(chBold.Checked)
            
                txtDivisibleNumber.Font = new Font(txtDivisibleNumber.Font.FontFamily,txtDivisibleNumber.Font.Size, FontStyle.Bold);

            else
                txtDivisibleNumber.Font = new Font(txtDivisibleNumber.Font.FontFamily, txtDivisibleNumber.Font.Size, FontStyle.Regular);

        }

        private void chItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (chItalic.Checked)

                txtDivisibleNumber.Font = new Font(txtDivisibleNumber.Font.FontFamily, txtDivisibleNumber.Font.Size, FontStyle.Italic);

            else
                txtDivisibleNumber.Font = new Font(txtDivisibleNumber.Font.FontFamily, txtDivisibleNumber.Font.Size, FontStyle.Regular);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDivisibleTerm.Items.Add("2");
            cmbDivisibleTerm.Items.Add("3");
            cmbDivisibleTerm.Items.Add("4");
            cmbDivisibleTerm.Items.Add("5");
            cmbDivisibleTerm.Items.Add("6");
            cmbDivisibleTerm.Items.Add("7");
            cmbDivisibleTerm.Items.Add("8");
            cmbDivisibleTerm.Items.Add("9");
            cmbDivisibleTerm.Items.Add("10");

        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int controlNumber = 0;
            if (txtFrom.Text.Trim() == "" || txtTo.Text.Trim() == "")
            {
                if (txtFrom.Text.Trim() == "")
                    errorProvider1.SetError(txtFrom, "Please Fill Textbox");
                MessageBox.Show("Please Fill Necessary Fields");
                if (txtTo.Text.Trim() == "")
                    errorProvider1.SetError(txtTo, "Please Fill Textbox");
                

            }
                
            else if(cmbDivisibleTerm.SelectedIndex==-1)
            {
                MessageBox.Show("Please Fill Divisible Term");
            }
            else
            {

                for (int i = firstNumber; i <= lastNumber; i++)
                {
                    if (i % divisibleNumber == 0)
                    {
                        divisibleText += " " + i.ToString() + " ";
                        controlNumber++;
                        if (controlNumber % 10 == 0)
                        {
                            divisibleText += Environment.NewLine;
                        }
                    }

                }
                txtDivisibleNumber.Text = divisibleText;
                firstNumber = Convert.ToInt32(txtFrom.Text);
                lastNumber = Convert.ToInt32(txtTo.Text);
                //MessageBox.Show(firstNumber + " " + lastNumber + "" + divisibleNumber);
            }
        }
    }
}
