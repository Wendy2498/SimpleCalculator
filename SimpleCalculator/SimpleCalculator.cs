/*Wendy Faulk
 * 5/20/2021
 * CIS 123
 * Week 4 Murach Coding Assignmnet (Teamwork--Done Individually)
 * Extra 6-1 Create a simple calculator */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class FrmSimpleCalculator : Form
    {
        public FrmSimpleCalculator()
        {
            InitializeComponent();
        }

        //Step 3. Create method "Calculate" to calculate the Result value,
        //using Operand1, Operator and Operand2 as parameters.
        private decimal Calculate(decimal operand1, string operator1, decimal operand2)
        {
            //Set Result value to 0, will take various calculation values.
            decimal result = 0m;

            //Use if else to calculate result based upon Operator entered.
            if (operator1 == "+")
                result = operand1 + operand2;
            else if (operator1 == "-")
                result = operand1 - operand2;
            else if (operator1 == "*")
                result = operand1 * operand2;
            else if (operator1 == "/")
                result = operand1 / operand2;
            return result;               //Return the calculated result of this called method.
        }
       

        //Step 4. Create Calculate Click event handler.
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Get the Operand 1 text value and convert it to a decimal.
            decimal operand1 = Convert.ToDecimal(txtOperand1.Text);

            //Convert the Operator text value to a string.
             string operator1 = Convert.ToString(txtOperator1.Text);

            //Get the Operand 2 text value and convert it to a decimal.
            decimal operand2 = Convert.ToDecimal(txtOperand2.Text);

            //Call Calculate method, pass 3 arguments.
            decimal result = Calculate(operand1, operator1, operand2);

            //Display result in form, rounded to 4 places.
            txtResult.Text = Math.Round(result, 4).ToString();

            //Move focus to Operand 1 text box
            txtOperand1.Focus();
        }

        //Create event handler for Exit button that closes the form.
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Create event handler that clears Result text box when user changes text in another box.
        private void ClearResult(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }
    }
}

