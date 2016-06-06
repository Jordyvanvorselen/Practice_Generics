using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generics_Practice
{
    public partial class GenericsGUI : Form
    {
        public GenericsGUI()
        {
            InitializeComponent();
        }

        private void btnTestEquality_Click(object sender, EventArgs e)
        {
            Compare<string> compareString = new Compare<string>();
            bool result = compareString.CompareUserInput(txtString1.Text, txtString2.Text);
            showResultToUser(result);
        }

        private void btnTestInts_Click(object sender, EventArgs e)
        {
            Compare<decimal> compareInt = new Compare<decimal>();
            bool result = compareInt.CompareUserInput(nudDecimal1.Value, nudDecimal2.Value);
            showResultToUser(result);
        }

        /// <summary>
        /// Shows the result to the user.
        /// </summary>
        /// <param name="result">Boolean that determines if the given anwer was Correct(=True) or Wrong(=False)</param>
        private void showResultToUser(bool result)
        {
            this.changeResultTextColor(result);
            txtResult.Text = Convert.ToString(result);
        }

        /// <summary>
        /// Function that changes the ForeColor property of the txtResult textbox according to a Correct or Wrong answer.
        /// Correct = Green
        /// Wrong = Red
        /// </summary>
        /// <param name="result">Boolean that determines if the given anwer was Correct(=True) or Wrong(=False)</param>
        private void changeResultTextColor(bool result)
        {
            if (result)
            {
                txtResult.ForeColor = Color.Green;
            }
            else
            {
                txtResult.ForeColor = Color.Red;
            }
        }
    }
}
