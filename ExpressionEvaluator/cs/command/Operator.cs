using System.Collections.Generic;

public abstract class Operator : Command
{
    /// <summary>
    /// Calls the evaluate method to evaluate two numbers
    /// </summary>
    /// <param name="stack">
    /// A reference to a stack of integers that need to be evaluated.
    /// </param>
    public override void execute(ref Stack<int> stack)
    {
        int n2 = stack.Pop();
        int n1 = stack.Pop();

        int result = evaluate(n1, n2);
        stack.Push(result);
    }// end execute

    /// <summary>
    /// The returned type is an object because it may be an integer or character.
    /// </summary>
    /// <returns>
    /// Returns the value a command is associated with.
    /// </returns>
    public override object getValue()
    {
        return getOperator();
    }// end getValue

    /// <summary>
    /// Evaluates two numbers and returns the result.
    /// </summary>
    /// <param name="n1">
    /// The first number.
    /// </param>
    /// <param name="n2">
    /// The second number
    /// </param>
    /// <returns>
    /// Returns the result of two evaluated numbers.
    /// </returns>
    public abstract int evaluate(int n1, int n2);

    /// <summary>
    /// Each command has an associated operator that is represented by a character.
    /// </summary>
    /// <returns>
    /// Returns the character operator this Command represents.
    /// </returns>
    public abstract char getOperator();

    //public abstract char getOperator();
} /* end class Operator */
