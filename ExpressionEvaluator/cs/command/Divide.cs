
public class Divide : Binary
{
    /// <summary>
    /// Evaluates the divisiojn of two numbers and returns the result. Rounds down if the result is a decimal.
    /// </summary>
    /// <param name="n1">
    /// The first number to be divide.
    /// </param>
    /// <param name="n2">
    /// The second number to be divide.
    /// </param>
    /// <returns>
    /// Returns the division of n1/n2.
    /// </returns>
    public override int evaluate(int n1, int n2)
    {
        return (n1 / n2);
    }// end evaluate

    /// <summary>
    /// Each command has an associated operator that is represented by a character.
    /// </summary>
    /// <returns>
    /// Returns the character operator this Command represents.
    /// </returns>
    public override char getOperator()
    {
        return '/';
    }// end getOperator
} /* end class Divide */
