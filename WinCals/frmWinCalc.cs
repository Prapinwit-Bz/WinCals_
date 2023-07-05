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
        private bool dotStatus = false;
        private char symbol = '0';

        private void AddToDisplay(string numberSymbol)
        {
            if (numberSymbol == ".")
                this.dotStatus = true;
            // BUG
            //if (this.txtDisplay.Text.Length >= 15)
            // this.txtDisplay.Text = this.txtDisplay.Text;

            if (this.txtDisplay.Text == "0" && numberSymbol == ".") // 0.
            {
                this.txtDisplay.Text += numberSymbol;
            }
            else if (this.txtDisplay.Text == "0") // 0 = 0
            {
                this.txtDisplay.Text = numberSymbol;
            }
            else if (this.txtDisplay.Text != "0") // 1234
            {
                this.txtDisplay.Text += numberSymbol;
            }
        }
        private string calculating(string num1, string num2, char _symbol)
        {
            double numFirst = double.Parse(num1);
            double numSecond = double.Parse(num2);
            double numAnswer = 0.0f;
            switch (_symbol)
            {
                case '+': numAnswer = numFirst + numSecond; break;
                case '-': numAnswer = numFirst - numSecond; break;
                case '*': numAnswer = numFirst * numSecond; break;
                case '/': numAnswer = numFirst / numSecond; break;
            }
            return numAnswer.ToString();
        }
        private void setNumber1(char _symbol)
    {
        this.symbol = _symbol;
        this.number1 = this.txtDisplay.Text;
        this.txtDisplay.Text = "0";
        this.dotStatus = false;
    }
    public frmWinCalc()
        {
            InitializeComponent();
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!this.dotStatus)
                this.AddToDisplay(".");
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            this.number2 = this.txtDisplay.Text;
            this.txtDisplay.Text =
            this.calculating(this.number1, number2, this.symbol);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.setNumber1('+');
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            this.setNumber1('-');
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            this.setNumber1('*');
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            this.setNumber1('/');
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.number1 = this.number2 = this.answer = "0";
            this.txtDisplay.Text = "0";
            this.symbol = '0';
            this.dotStatus = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (this.txtDisplay.Text.Length > 0)
                this.txtDisplay.Text =
                this.txtDisplay.Text.Remove
                (this.txtDisplay.Text.Length - 1);

            if ((this.txtDisplay.Text.Length == 0) ||
            (this.txtDisplay.Text == ""))
                this.txtDisplay.Text += "0";
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

        private void mnuClearItem_Click(object sender, EventArgs e)
        {
            this.btnClear_Click(sender, e);
        }

        private void mnuExitItem_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void mnuAboutItem_Click(object sender, EventArgs e)
        {
            frmAbout objAbout = new frmAbout();

            objAbout.ShowDialog();
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
