
public class Add : Binary
{
    /// <summary>
    /// Evaluates the sum of two numbers and returns the result.
    /// </summary>
    /// <param name="n1">
    /// The first number to be added.
    /// </param>
    /// <param name="n2">
    /// The second number to be added.
    /// </param>
    /// <returns>
    /// Returns the sume of n1 + n2.
    /// </returns>
    public override int evaluate(int n1, int n2)
    {
        return (n1 + n2);
    }// end evaluate

    /// <summary>
    /// Each command has an associated operator that is represented by a character.
    /// </summary>
    /// <returns>
    /// Returns the character operator this Command represents.
    /// </returns>
    public override char getOperator()
    {
        return '+';
    }// end getOperator
} /* end class Add */
