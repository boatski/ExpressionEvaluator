using System;
using System.Text;
using System.Collections.Generic;

public class Parser
{
    /// <summary>
    /// Takes an equation in infix format and parses it into postfix format. Each operator or number
    /// is stored in a Command. The parsed, postfix format equation is then stored in a list of commands.
    /// </summary>
    /// <param name="infix">
    /// The user's equation in infix format
    /// </param>
    /// <param name="factory">
    /// The factory used to create commands
    /// </param>
    /// <returns>
    /// Returns a list of commands for the user's equation in postfix format
    /// </returns>
    public List<Command> infixToPostfix(string infix, CommandFactory factory)
    {
        Command command;
        List<Command> postfix = new List<Command>(); // Equation in postfix format
        Stack<Command> tempStack = new Stack<Command>(); // Temporary stack of operators
        int length = infix.Length;

        for (int i = 0; i < length; i++)
        {
            char c = infix[i];

            // Infix to Postfix algorithm
            if (Char.IsNumber(c))
            {
                createNumber(c, factory, ref postfix, ref i, length, infix, false);
            }
            else if (c == '(')
            {
                command = factory.createLeftParenthesesCommand();
                tempStack.Push(command);
            }
            else if (c == '^')
            {
                command = factory.createExponentCommand();

                if ((tempStack.Count > 0) && (operatorCheck(Convert.ToChar(tempStack.Peek().getValue()), c, tempStack.Count)))
                {
                    postfix.Add(tempStack.Pop());
                }// end if

                tempStack.Push(command);
            }
            else if (c == '*')
            {
                command = factory.createMultiplyCommand();

                if ((tempStack.Count > 0) && (operatorCheck(Convert.ToChar(tempStack.Peek().getValue()), c, tempStack.Count)))
                {
                    postfix.Add(tempStack.Pop());
                }// end if

                tempStack.Push(command);
            }
            else if (c == '/')
            {
                command = factory.createDivideCommand();

                if ((tempStack.Count > 0) && (operatorCheck(Convert.ToChar(tempStack.Peek().getValue()), c, tempStack.Count)))
                {
                    postfix.Add(tempStack.Pop());
                }// end if

                tempStack.Push(command);
            }
            else if (c == '%')
            {
                command = factory.createModulusCommand();

                if ((tempStack.Count > 0) && (operatorCheck(Convert.ToChar(tempStack.Peek().getValue()), c, tempStack.Count)))
                {
                    postfix.Add(tempStack.Pop());
                }// end if

                tempStack.Push(command);
            }
            else if (c == '+')
            {
                command = factory.createAddCommand();

                if ((tempStack.Count > 0) && (operatorCheck(Convert.ToChar(tempStack.Peek().getValue()), c, tempStack.Count)))
                {
                    postfix.Add(tempStack.Pop());
                }// end if

                tempStack.Push(command);
            }
            else if (c == '-')
            {
                string operators = "+-*/%";

                if ((i != 0) && (operators.IndexOf(infix[i-1]) != -1) && (Char.IsNumber(infix[i + 1])))
                {// if the index is not 0, index - 1 is an operator, and index + 1 is a number, then create a negative number
                    i++;
                    createNumber(infix[i], factory, ref postfix, ref i, length, infix, true);
                }
                else
                {

                    // If infix[0] is '-', then append a 0 before appending the operator
                    if (i == 0)
                    {
                        command = factory.createNumberCommand(0);
                        postfix.Add(command);
                    }// end if

                    // If c == '-' and infix[i+1] == '-', then that is # - - #, which is # + #.
                    // Otherwise, it is a normal subtract command.
                    if (infix[i + 1] == '-')
                    {// # - - # = # + #
                        command = factory.createAddCommand();
                        i++;
                    }
                    else
                    {
                        command = factory.createSubtractCommand();
                    }// end if

                    if ((tempStack.Count > 0) && (operatorCheck(Convert.ToChar(tempStack.Peek().getValue()), c, tempStack.Count)))
                    {
                        postfix.Add(tempStack.Pop());
                    }// end if

                    tempStack.Push(command);
                }
            }
            else if (c == ')')
            {
                command = factory.createRightParenthesesCommand();

                while ((tempStack.Count > 0) && (Convert.ToChar(tempStack.Peek().getValue()) != '('))
                {
                    postfix.Add(tempStack.Pop());
                }// end while

                // Pops off the left parentheses
                if (tempStack.Count > 0)
                {
                    tempStack.Pop();
                }// end if
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Invalid Character: " + c);
            }// end if
        }// end foreach

        // Adds the last operation to the postfix list.
        while (tempStack.Count > 0)
        {
            postfix.Add(tempStack.Pop());
        }// end while

        return postfix;
    }// end infixToPostfix


    private void createNumber(char c, CommandFactory factory, ref List<Command> postfix, ref int i, int length, string infix, bool isNegative)
    {
        Command command;
        int numberLength = 0;
        int currentIndex = i; // Copy current index
        string strNumber = c.ToString(); // Convert the current character to a string

        // Get index i+1 and check if it's an integer
        while (currentIndex != (length - 1))
        {
            char c1 = infix[currentIndex + 1]; // Get the next character at index i+1
            int intC1 = (int)char.GetNumericValue(c1); // Convert it to an integer

            // Check if the next character is an integer.
            if ((Char.IsNumber(c1)) && (intC1 >= 0) && (intC1 <= 9))
            {
                // Track number of digits in the number
                numberLength++;

                // Combines each character into strNumber if it's a number
                strNumber += c1;

                // Tracks the index number
                currentIndex++;
            }
            else
            { // break out of the while loop if the character is not a number and update the index
                break;
            }// end if
        }// end while

        i += numberLength;

        int number = 0;

        // Catches an overflow exception if the number entered cannot fit in a 32bit integer.
        try
        {
            number = checked(int.Parse(strNumber)); // Convert the string to an integer
        }
        catch (System.OverflowException e)
        {
            System.Web.HttpContext.Current.Response.Write(@"<script language='javascript'>alert('Error: Number Size\nThe number " + strNumber + "is too large or too small.');</script>");
            System.Diagnostics.Debug.WriteLine(e.StackTrace);
        }// end try

        // Negates the number.
        if (isNegative)
        {
            number *= -1;
        }// end if

        command = factory.createNumberCommand(number);
        postfix.Add(command);

    }// end canCreateNumber

    /// <summary>
    /// Calls operatorComparison to check the order of operations on two operators.
    /// </summary>
    /// <param name="stackTop">
    /// Command value at the top of the temporary Command stack
    /// </param>
    /// <param name="op">
    /// Current Command value being processed
    /// </param>
    /// <param name="count">
    /// Current size of the temporary Command stack
    /// </param>
    /// <returns>
    /// Returns true if the method OperatorComparison returns true;
    /// </returns>
    private bool operatorCheck(char stackTop, char op, int count)
    {
        if ((count > 0) && (stackTop != '('))
        {
            if (operatorComparison(stackTop, op))
            {
                return true;
            }// end if
        }// end if

        return false;
    }// end OperatorCheck

    /// <summary>
    /// Checks for order of operations on the current operator against the operator on
    /// the top of the temporary operator stack.
    /// </summary>
    /// <param name="stackTop">
    /// Command value at the top of the temporary Command stack
    /// </param>
    /// <param name="op">
    /// Current Command value being processed
    /// </param>
    /// <returns>
    /// Returns false if the Command value at the top of the stack has a lower order of 
    /// operations than the current Command value being processed.
    /// </returns>
    private bool operatorComparison(char stackTop, char op)
    {
        if ((stackTop == '+') && ((op == '*') || (op == '/') || (op == '%') || (op == '^')))
        {
            // + has lower precedence than *, /, %, or ^
            return false;
        }
        else if ((stackTop == '-') && ((op == '*') || (op == '/') || (op == '%') || (op == '^')))
        {
            // - has lower precedence than *, /, %, or ^
            return false;
        }
        else if ((stackTop == '*') && (op == '^'))
        {
            // * has lower precedence than ^
            return false;
        }
        else if ((stackTop == '/') && (op == '^'))
        {
            // / has lower precedence than ^
            return false;
        }// end if

        return true;
    }// end OperatorComparison

} /* end class Parser */
