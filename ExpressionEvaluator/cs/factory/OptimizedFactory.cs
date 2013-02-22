
public class OptimizedFactory : CommandFactory
{
    private Add add = null;
    private Subtract subtract = null;
    private Multiply multiply = null;
    private Divide divide = null;
    private Modulus modulus = null;
    private Exponent exponent = null;
    private LeftParentheses leftParentheses = null;
    private RightParentheses rightParentheses = null;

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
    /// Creates an Add command if one has not been allocated.
    /// </summary>
    /// <returns>
    /// Returns an allocated Add command.
    /// </returns>
    public override Add createAddCommand()
    {
        if (add == null)
        {
            add = new Add();
        }// end if
        return add;
    }// end createAddCommand

    /// <summary>
    /// Creates an Subtract command if one has not been allocated.
    /// </summary>
    /// <returns>
    /// Returns an allocated Subtract command.
    /// </returns>
    public override Subtract createSubtractCommand()
    {
        if (subtract == null)
        {
            subtract = new Subtract();
        }// end if
        return subtract;
    }// end createSubtractCommand

    /// <summary>
    /// Creates an Divide command if one has not been allocated.
    /// </summary>
    /// <returns>
    /// Returns an allocated Divide command.
    /// </returns>
    public override Divide createDivideCommand()
    {
        if (divide == null)
        {
            divide = new Divide();
        }// end if
        return divide;
    }// end createDivideCommand

    /// <summary>
    /// Creates an Multiply command if one has not been allocated.
    /// </summary>
    /// <returns>
    /// Returns an allocated Multiply command.
    /// </returns>
    public override Multiply createMultiplyCommand()
    {
        if (multiply == null)
        {
            multiply = new Multiply();
        }// end if
        return new Multiply();
    }// end createMultiplyCommand

    /// <summary>
    /// Creates an add command if one has not been allocated.
    /// </summary>
    /// <returns>
    /// Returns an allocated Modulus command.
    /// </returns>
    public override Modulus createModulusCommand()
    {
        if (modulus == null)
        {
            modulus = new Modulus();
        }// end if
        return new Modulus();
    }// end createModulusCommand

    /// <summary>
    /// Creates an Exponent command if one has not been allocated.
    /// </summary>
    /// <returns>
    /// Returns an allocated Exponent command.
    /// </returns>
    public override Exponent createExponentCommand()
    {
        if (exponent == null)
        {
            exponent = new Exponent();
        }// end if
        return new Exponent();
    }// end createExponentCommand

    /// <summary>
    /// Creates an RightParentheses command if one has not been allocated.
    /// </summary>
    /// <returns>
    /// Returns an allocated RightParentheses command.
    /// </returns>
    public override RightParentheses createRightParenthesesCommand()
    {
        if (rightParentheses == null)
        {
            rightParentheses = new RightParentheses();
        }// end if
        return new RightParentheses();
    }// end createRightParenthesesCommand

    /// <summary>
    /// Creates an LeftParentheses command if one has not been allocated.
    /// </summary>
    /// <returns>
    /// Returns an allocated LeftParentheses command.
    /// </returns>
    public override LeftParentheses createLeftParenthesesCommand()
    {
        if (leftParentheses == null)
        {
            leftParentheses = new LeftParentheses();
        }// end if
        return new LeftParentheses();
    }// end createLeftParenthesesCommand
} /* end class OptimizedFactory */
