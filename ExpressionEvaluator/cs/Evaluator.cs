using System.Collections.Generic;

public abstract class Evaluator
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
    public abstract int evaluatePostfix(List<Command> postfix);
} /* end class Evaluator */
