using System.Collections.Generic;

public abstract class Parentheses : Command
{
    /// <summary>
    /// Each command has an associated operator that is represented by a character.
    /// </summary>
    /// <returns>
    /// Returns the character operator this Command represents.
    /// </returns>
    public override object getValue()
    {
        return getOperator();
    }// end getValue

    /// <summary>
    /// Does nothing. Implementation required by command.
    /// </summary>
    /// <param name="stack"></param>
    public override void execute(ref Stack<int> stack)
    {
        // Nothing to execute
    }// end execute

    /// <summary>
    /// Each command has an associated operator that is represented by a character.
    /// </summary>
    /// <returns>
    /// Returns the character operator this Command represents.
    /// </returns>
    public abstract char getOperator();

} /* end class Parentheses */
