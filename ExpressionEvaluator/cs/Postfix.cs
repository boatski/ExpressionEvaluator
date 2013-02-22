using System;
using System.Collections.Generic;

public class Postfix : Evaluator
{
    /// <summary>
    /// Evaluates the postfix equation by iterating through a list of commands.
    /// </summary>
    /// <param name="postfix">
    /// A list of commands in postfix format
    /// </param>
    /// <returns>
    /// Returns an integer result of the processed, postfix format user equation
    /// </returns>
    public override int evaluatePostfix(List<Command> postfix)
    {
        Stack<int> resultStack = new Stack<int>();

        try
        {
            foreach (Command command in postfix)
            {
                string value = command.getValue().ToString(); // Get the command's value and convert it to a string
                int numberValue; // numberValue is used to store the value if it is an integer
                bool isNumber = int.TryParse(value, out numberValue); // If value is an integer, store it in numberValue

                if (isNumber)
                {// If the command is a number, push it's value to the result stack
                    resultStack.Push(numberValue);
                }
                else
                {
                    char op = Convert.ToChar(command.getValue());
                    string operations = "+-*/%^";

                    if (operations.IndexOf(op) != -1)
                    {// If the command is an operation, then execute that operation
                        command.execute(ref resultStack);
                    }// end if
                }// end if
            }// end foreach

            return resultStack.Pop();
        }
        catch (DivideByZeroException z)
        {// Catch divide by zero and alert the user.
            System.Web.HttpContext.Current.Response.Write(@"<script language='javascript'>alert('Error: Divide by Zero:\nCheck your expression. You cannot divide by zero.');</script>");
        }
        catch (Exception ex)
        {// Catch any other missed errors and alert the user.
            System.Web.HttpContext.Current.Response.Write(@"<script language='javascript'>alert('Error: Invalid Expression:\nCheck your expression.');</script>");
        }
        return 0;
    }// end evaluatePostfix
} /* end class Postfix */
