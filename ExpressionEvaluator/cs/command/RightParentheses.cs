
public class RightParentheses : Parentheses
{
    /// <summary>
    /// Each command has an associated operator that is represented by a character.
    /// </summary>
    /// <returns>
    /// Returns the character operator this Command represents.
    /// </returns>
    public override char getOperator()
    {
        return ')';
    }// end getOperator
} /* end class RightParentheses */
