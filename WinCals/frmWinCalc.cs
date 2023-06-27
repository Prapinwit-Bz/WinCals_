using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCals
{
    public partial class frmWinCalc : Form
    {
        private string number1 = "", number2 = "", answer = "";

        private void AddToDisplay(string numberSymbol)
        {
            if (this.txtDisplay.Text == "0")
            {
                if(numberSymbol == ".")
                {
                    this.txtDisplay.Text += numberSymbol;   
                }
                this.txtDisplay.Text = numberSymbol;
            }
            else
            {
                this.txtDisplay.Text += numberSymbol;
            }
        }

        public frmWinCalc()
        {
            InitializeComponent();
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            this.AddToDisplay(".");
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.number1 = this.number2 = this.answer = "0";
            this.txtDisplay.Text = "0";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.AddToDisplay("9");
        }
    }
}
