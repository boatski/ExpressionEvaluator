
public class BasicFactory : CommandFactory
{
    /// <summary>
    /// Creates a new Number command and sets its value.
    /// </summary>
    /// <param name="number">
    /// The value of the number command.
    /// </param>
    /// <returns>
    /// Returns an allocated Number command.
    /// </returns>
    public override Number createNumberCommand(int number)
    {
        return new Number(number);
    }// end createNumberCommand

    /// <summary>
    /// Creates an Add command.
    /// </summary>
    /// <returns>
    /// Returns an allocated Add command.
    /// </returns>
    public override Add createAddCommand()
    {
        return new Add();
    }// end createAddCommand

    /// <summary>
    /// Creates an Subtract command.
    /// </summary>
    /// <returns>
    /// Returns an allocated Subtract command.
    /// </returns>
    public override Subtract createSubtractCommand()
    {
        return new Subtract();
    }// end createSubtractCommand

    /// <summary>
    /// Creates an Divide command.
    /// </summary>
    /// <returns>
    /// Returns an allocated Divide command.
    /// </returns>
    public override Divide createDivideCommand()
    {
        return new Divide();
    }// end createDivideCommand

    /// <summary>
    /// Creates an Multiply command.
    /// </summary>
    /// <returns>
    /// Returns an allocated Multiply command.
    /// </returns>
    public override Multiply createMultiplyCommand()
    {
        return new Multiply();
    }// end createMultiplyCommand

    /// <summary>
    /// Creates an add command.
    /// </summary>
    /// <returns>
    /// Returns an allocated Modulus command.
    /// </returns>
    public override Modulus createModulusCommand()
    {
        return new Modulus();
    }// end createModulusCommand

    /// <summary>
    /// Creates an Exponent command.
    /// </summary>
    /// <returns>
    /// Returns an allocated Exponent command.
    /// </returns>
    public override Exponent createExponentCommand()
    {
        return new Exponent();
    }// end createExponentCommand

    /// <summary>
    /// Creates an RightParentheses command.
    /// </summary>
    /// <returns>
    /// Returns an allocated RightParentheses command.
    /// </returns>
    public override RightParentheses createRightParenthesesCommand()
    {
        return new RightParentheses();
    }// end createRightParenthesesCommand

    /// <summary>
    /// Creates an LeftParentheses command.
    /// </summary>
    /// <returns>
    /// Returns an allocated LeftParentheses command.
    /// </returns>
    public override LeftParentheses createLeftParenthesesCommand()
    {
        return new LeftParentheses();
    }// end createLeftParenthesesCommand
} /* end class BasicFactory */
