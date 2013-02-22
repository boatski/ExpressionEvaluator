using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.EnterpriseServices;
using System.Web.Services;

namespace ExpressionEvaluator
{
    public partial class calculator : System.Web.UI.Page
    {
        private const string valid = "abcdefghij1234567890"; // Valid string characters
        private const string invalid = "klmnopqrstuvwxyz"; // Invalid string characters
        private const string operators = "+-*/^()%"; // Valid operators

        /// <summary>
        /// When the page loads, a key press listener is attached to the evaluation textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            lblEqual.Visible = false;
            evaluationBox.Focus();
            //evaluationBox.Attributes.Add("onkeypress", "return handleEnter('" + submitButton.ClientID + "', event)");
        }// end Page_Load

        /// <summary>
        /// Clears the evaluation textbox and all variable textboxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void clearButton_Click(object sender, EventArgs e)
        {
            lblEqual.Visible = false;
            lblResult.Text = "";

            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtD.Text = "";
            txtE.Text = "";
            txtF.Text = "";
            txtG.Text = "";
            txtH.Text = "";
            txtI.Text = "";
            txtJ.Text = "";
            evaluationBox.Text = "";
        }// end submitButton_Click

        /// <summary>
        /// Converts the input string to all lowercase letters and removes all spaces. Then checks if
        /// the variables being used have values in their textboxes and that they are correct values. 
        /// If not, the user is alerted. The variables in the string are replaced with their values.
        /// Then, the input string is them converted to postfix format and evaluated.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void submitButton_Click(object sender, EventArgs e)
        {
            string infix = evaluationBox.Text; // Get the string from the evaluation textbox

            System.Diagnostics.Debug.WriteLine(infix);

            infix = infix.ToLower(); // Converts all upper case characters in the string to lower case
            infix = infix.Replace(" ", string.Empty); // Remove all spaces from the string

            System.Diagnostics.Debug.WriteLine(infix);

            if (variableCheck(ref infix))
            {
                System.Diagnostics.Debug.WriteLine(infix);

                // Replace all variables with their associated values
                infix = replaceVariablesWithValues(infix);

                System.Diagnostics.Debug.WriteLine(infix);

                //CommandFactory factory = new BasicFactory();
                CommandFactory factory = new OptimizedFactory();

                // Parse the user's equation from infix into postfix format
                Parser parser = new Parser();
                List<Command> postfix = parser.infixToPostfix(infix, factory);

                System.Diagnostics.Debug.WriteLine(infix);

                // Evaluate the postfix format equation
                Evaluator evaluator = new Postfix();
                int result = evaluator.evaluatePostfix(postfix);

                lblEqual.Visible = true;
                lblResult.Text = result.ToString();
                
            }// end if
        }// end submitButton_Click

        /// <summary>
        /// Iterates through the input string looking for variables a through i. If the variable exists in the string, then the
        /// variable textbox associated with that variable is checked. The user is alerted if the textbox is empty or doesn't
        /// contain an integer value.
        /// 
        /// Also checks for multiplication examples such as 3a, aa, or a3. If these are found, then they are changed to 3*a,
        /// a*a, or a*3 for example.
        /// </summary>
        /// <param name="infix">
        /// The current equation with variables that need to be changed with their values. The string is passed in by reference.
        /// </param>
        /// <returns>
        /// Returns true if the textboxes for each variable being used contain a value
        /// </returns>
        private bool variableCheck(ref string infix)
        {
            for (int i = 0; i < infix.Length; i++)
            {
                char c = infix[i];
                if (c == 'a')
                {
                    // Alert the user if a variable is in the string and the textbox is empty.
                    if (variableTextboxCheck(txtA, c))
                    {
                        return false;
                    }// end if

                    // Check for occurences of multiplications such as 3a or ab or a3. Change to 3*a if it exists
                    if ((i != (infix.Length)) && (i != 0))
                    {
                        multiplyCheck(ref infix, ref i);
                    }// end if
                }
                else if (c == 'b')
                {
                    // Alert the user if a variable is in the string and the textbox is empty.
                    if (variableTextboxCheck(txtB, c))
                    {
                        return false;
                    }// end if

                    // Check for occurences of multiplications such as 3a or ab or a3. Change to 3*a if it exists
                    if ((i != (infix.Length)) && (i != 0))
                    {
                        multiplyCheck(ref infix, ref i);
                    }// end if
                }
                else if (c == 'c')
                {
                    // Alert the user if a variable is in the string and the textbox is empty.
                    if (variableTextboxCheck(txtC, c))
                    {
                        return false;
                    }// end if

                    // Check for occurences of multiplications such as 3a or ab or a3. Change to 3*a if it exists
                    if ((i != (infix.Length)) && (i != 0))
                    {
                        multiplyCheck(ref infix, ref i);
                    }// end if
                }
                else if (c == 'd')
                {
                    // Alert the user if a variable is in the string and the textbox is empty.
                    if (variableTextboxCheck(txtD, c))
                    {
                        return false;
                    }// end if

                    // Check for occurences of multiplications such as 3a or ab or a3. Change to 3*a if it exists
                    if ((i != (infix.Length)) && (i != 0))
                    {
                        multiplyCheck(ref infix, ref i);
                    }// end if
                }
                else if (c == 'e')
                {
                    // Alert the user if a variable is in the string and the textbox is empty.
                    if (variableTextboxCheck(txtE, c))
                    {
                        return false;
                    }// end if

                    // Check for occurences of multiplications such as 3a or ab or a3. Change to 3*a if it exists
                    if ((i != (infix.Length)) && (i != 0))
                    {
                        multiplyCheck(ref infix, ref i);
                    }// end if
                }
                else if (c == 'f')
                {
                    // Alert the user if a variable is in the string and the textbox is empty.
                    if (variableTextboxCheck(txtF, c))
                    {
                        return false;
                    }// end if

                    // Check for occurences of multiplications such as 3a or ab or a3. Change to 3*a if it exists
                    if ((i != (infix.Length)) && (i != 0))
                    {
                        multiplyCheck(ref infix, ref i);
                    }// end if
                }
                else if (c == 'g')
                {
                    // Alert the user if a variable is in the string and the textbox is empty.
                    if (variableTextboxCheck(txtG, c))
                    {
                        return false;
                    }// end if

                    // Check for occurences of multiplications such as 3a or ab or a3. Change to 3*a if it exists
                    if ((i != (infix.Length)) && (i != 0))
                    {
                        multiplyCheck(ref infix, ref i);
                    }// end if
                }
                else if (c == 'h')
                {
                    // Alert the user if a variable is in the string and the textbox is empty.
                    if (variableTextboxCheck(txtH, c))
                    {
                        return false;
                    }// end if

                    // Check for occurences of multiplications such as 3a or ab or a3. Change to 3*a if it exists
                    if ((i != (infix.Length)) && (i != 0))
                    {
                        multiplyCheck(ref infix, ref i);
                    }// end if
                }
                else if (c == 'i')
                {
                    // Alert the user if a variable is in the string and the textbox is empty.
                    if (variableTextboxCheck(txtI, c))
                    {
                        return false;
                    }// end if

                    // Check for occurences of multiplications such as 3a or ab or a3. Change to 3*a if it exists
                    if ((i != (infix.Length)) && (i != 0))
                    {
                        multiplyCheck(ref infix, ref i);
                    }// end if
                }
                else if (c == 'j')
                {
                    // Alert the user if a variable is in the string and the textbox is empty.
                    if (variableTextboxCheck(txtJ, c))
                    {
                        return false;
                    }// end if

                    // Check for occurences of multiplications such as 3a or ab or a3. Change to 3*a if it exists
                    if ((i != (infix.Length)) && (i != 0))
                    {
                        multiplyCheck(ref infix, ref i);
                    }// end if
                }
                else if ((c == '(') || (c == ')'))
                {
                    // Check for occurences of multiplications such as a( or )a. Change to a*( if it exists
                    if ((i != (infix.Length)) && (i != 0))
                    {
                        multiplyCheck(ref infix, ref i);
                    }// end if
                }
                else if (invalid.IndexOf(c) != -1)
                {
                    System.Web.HttpContext.Current.Response.Write(@"<script language='javascript'>alert('Error: Invalid Input.\nThe variable " + Char.ToUpper(c) + " is not an allowed variable. Only variables A through J are allowed.');</script>");
                    //RegisterDOMReadyScript("alert message", "alert('The variable " + Char.ToUpper(c) + " is not an allowed variable. Only variables A through J are allowed.');");
                    return false;
                }
                else if ((valid.IndexOf(c) == -1) && (operators.IndexOf(c) == -1))
                {
                    System.Web.HttpContext.Current.Response.Write(@"<script language='javascript'>alert('Error: Invalid Input.\nThe character entered, " + c.ToString() + ", is not allowed.');</script>");
                    return false;
                }// end if
            }// end for

            return true;
        }// end variableCheck

        /// <summary>
        /// If a variable is used in the input string, then the associated textbox for that variable is checked.
        /// If it is empty or does not contain an integer value, then the user is alerted and asked to enter somethign else.
        /// </summary>
        /// <param name="txt">
        /// The textbox associated with the passed in character.
        /// </param>
        /// <param name="c">
        /// The character's textbox that's being checked.
        /// </param>
        /// <returns>
        /// Returns false if the textbox being checked is empty or contains an invalid value.
        /// </returns>
        private bool variableTextboxCheck(TextBox txt, char c)
        {
            int temp;
            string strValue = txt.Text.Trim();

            if (strValue.Equals(string.Empty))
            {// Checks for an empty textbox
                System.Web.HttpContext.Current.Response.Write(@"<script language='javascript'>alert('Error: Missing Value\nA value is missing for variable " + Char.ToUpper(c) + ".');</script>");
                return true;
            }
            else if (!int.TryParse(strValue, out temp))
            {// Checks if the value in the textbox is a number
                System.Web.HttpContext.Current.Response.Write(@"<script language='javascript'>alert('Error: Invalid Value Input\nThe value, " + strValue + ", entered for variable " + Char.ToUpper(c) + " is invalid.');</script>");
                return true;
            }// end if

            return false;
        }// end variableTextboxCheck

        /// <summary>
        /// Checks for multiplication examples such as 3a, aa, or a3. If these are found, then they are changed to 3*a,
        /// a*a, or a*3 for example.
        /// </summary>
        /// <param name="infix">
        /// A reference to the input string that it can be manipulated.
        /// </param>
        /// <param name="index">
        /// A reference to the current index being looked at in the input string.
        /// Referenced so that the index can be manipulated if "*" is inserted into the string.
        /// </param>
        private void multiplyCheck(ref string infix, ref int index)
        {
            char currentChar = infix[index];
            char previousChar = infix[index - 1];
            
            // If the previous character is a number or variable, insert *
            if (isNumberOrVariable(previousChar) && (currentChar != ')'))
            {
                infix = infix.Insert(index, "*");
                index++;
            }// end if

            // If the next character is a number or variable, insert *
            if (index != (infix.Length - 1) && (currentChar != '('))
            {
                char nextChar = infix[index + 1];

                if (isNumberOrVariable(nextChar))
                {
                    infix = infix.Insert((index + 1), "*");
                    index++;
                }
                else if((currentChar == ')') && (nextChar == '('))
                {
                    infix = infix.Insert(index + 1, "*");
                    index++;
                }// end if
            }// end if
        }// end multiplyCheck

        /// <summary>
        /// Checks whether a character is a number or variable by looking for it in the valid string.
        /// </summary>
        /// <param name="c">
        /// One character from the infix string
        /// </param>
        /// <returns>
        /// Returns true if the character c is part of the valid string.
        /// </returns>
        private bool isNumberOrVariable(char c)
        {
            if (valid.IndexOf(c) == -1)
            {
                return false;
            }// end if

            return true;
        }// end isNumberOrVariable

        /// <summary>
        /// Replaces all occurences of variables with their associated values.
        /// </summary>
        /// <param name="infix">
        /// Input string with variables.
        /// </param>
        /// <returns>
        /// Returns input string with variables replaced with their values.
        /// </returns>
        private string replaceVariablesWithValues(string infix)
        {
            // Iterate through each character in the string infix. If any of the characters exist below,
            // replace each occurence of the character with the value in it's associated textbox.
            foreach (char c in infix)
            {
                switch (c)
                {
                    case 'a':
                        infix = infix.Replace(c.ToString(), txtA.Text);
                        break;
                    case 'b':
                        infix = infix.Replace(c.ToString(), txtB.Text);
                        break;
                    case 'c':
                        infix = infix.Replace(c.ToString(), txtC.Text);
                        break;
                    case 'd':
                        infix = infix.Replace(c.ToString(), txtD.Text);
                        break;
                    case 'e':
                        infix = infix.Replace(c.ToString(), txtE.Text);
                        break;
                    case 'f':
                        infix = infix.Replace(c.ToString(), txtF.Text);
                        break;
                    case 'g':
                        infix = infix.Replace(c.ToString(), txtG.Text);
                        break;
                    case 'h':
                        infix = infix.Replace(c.ToString(), txtH.Text);
                        break;
                    case 'i':
                        infix = infix.Replace(c.ToString(), txtI.Text);
                        break;
                    case 'j':
                        infix = infix.Replace(c.ToString(), txtJ.Text);
                        break;
                }// end switch
            }// end foreach

            return infix;
        }// end replaceVariablesWithValues
    }// end class calculator
}// end class