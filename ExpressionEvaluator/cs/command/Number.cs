using System.Collections.Generic;

public class Number : Command
{
    private int value = 0;

    /// <summary>
    /// Constructor sets the value of this number command.
    /// </summary>
    /// <param name="number">
    /// The number command's value.
    /// </param>
    public Number(int number)
    {
        this.value = number;
    }// end Number
    
    /// <summary>
    /// Does nothing. Implementation required by Command.
    /// </summary>
    /// <param name="stack"></param>
    public override void execute(ref Stack<int> stack)
    {
        // Does nothing
    }// end execute

    /// <summary>
    /// Number commands store integer values.
    /// </summary>
    /// <returns>
    /// Returns the number this command holds
    /// </returns>
    public override object getValue()
    {
        return this.value;
    }// end getValue

} /* end class Number */
