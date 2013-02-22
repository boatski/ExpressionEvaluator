using System.Collections.Generic;

public abstract class Command
{
    /// <summary>
    /// Calls the evaluate method to evaluate two numbers
    /// </summary>
    /// <param name="stack">
    /// A reference to a stack of integers that need to be evaluated.
    /// </param>
    public abstract void execute(ref Stack<int> stack);

    /// <summary>
    /// The returned type is an object because it may be an integer or character.
    /// </summary>
    /// <returns>
    /// Returns the value a command is associated with.
    /// </returns>
    public abstract object getValue();
} /* end class Command */
