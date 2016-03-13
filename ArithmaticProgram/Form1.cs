using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArithmaticProgram
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        int num1;
        int num2;

        private void frmMain_Load(object sender, EventArgs e)
        {
            Random randnum = new Random();
            num1 = randnum.Next(10);
            num2 = randnum.Next(10);
            txtNumOne.Text = num1.ToString();
            txtNumTwo.Text = num2.ToString();
            lblAnswer.Text = "";
            txtResult.Text = "";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            
            int answer = Convert.ToInt16(txtResult.Text);
            int correct = Convert.ToInt16(txtCorrect.Text);
            int missed = Convert.ToInt16(txtWrong.Text);
            int total = Convert.ToInt16(txtTotal.Text);

                if ((num1 + num2) == answer)
                {
                    correct += 1;
                    total += 1;

                    lblAnswer.ForeColor = System.Drawing.Color.Green;
                    lblAnswer.Text = "Correct";
                    txtCorrect.Text = correct.ToString();
                    txtTotal.Text = total.ToString();

                    txtResult.Text = "";

                    Random randnum = new Random();
                    num1 = randnum.Next(10);
                    num2 = randnum.Next(10);
                    txtNumOne.Text = num1.ToString();
                    txtNumTwo.Text = num2.ToString();

                }
                else
                {
                    missed += 1;
                    total += 1;

                    lblAnswer.ForeColor = System.Drawing.Color.Red;
                    lblAnswer.Text = "Try Again!";
                    txtWrong.Text = missed.ToString();
                    txtTotal.Text = total.ToString();
                    txtResult.Text = "";
                }

        }
    }
}
