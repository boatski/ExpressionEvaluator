
public  abstract class CommandFactory {

    /// <summary>
    /// Creates a new Number command and sets its value.
    /// </summary>
    /// <param name="number">
    /// The value of the number command.
    /// </param>
    /// <returns>
    /// Returns an allocated Number command.
    /// </returns>
    public abstract Number createNumberCommand(int number);

    /// <summary>
    /// Creates an Add command.
    /// </summary>
    /// <returns>
    /// Returns an allocated Add command.
    /// </returns>
    public abstract Add createAddCommand();

    /// <summary>
    /// Creates an Subtract command.
    /// </summary>
    /// <returns>
    /// Returns an allocated Subtract command.
    /// </returns>
    public abstract Subtract createSubtractCommand();

    /// <summary>
    /// Creates an Divide command.
    /// </summary>
    /// <returns>
    /// Returns an allocated Divide command.
    /// </returns>
    public abstract Divide createDivideCommand();

    /// <summary>
    /// Creates an Multiply command.
    /// </summary>
    /// <returns>
    /// Returns an allocated Multiply command.
    /// </returns>
    public abstract Multiply createMultiplyCommand();

    /// <summary>
    /// Creates an add command.
    /// </summary>
    /// <returns>
    /// Returns an allocated Modulus command.
    /// </returns>
    public abstract Modulus createModulusCommand();

    /// <summary>
    /// Creates an Exponent command.
    /// </summary>
    /// <returns>
    /// Returns an allocated Exponent command.
    /// </returns>
    public abstract Exponent createExponentCommand();

    /// <summary>
    /// Creates an RightParentheses command.
    /// </summary>
    /// <returns>
    /// Returns an allocated RightParentheses command.
    /// </returns>
    public abstract RightParentheses createRightParenthesesCommand();

    /// <summary>
    /// Creates an LeftParentheses command.
    /// </summary>
    /// <returns>
    /// Returns an allocated LeftParentheses command.
    /// </returns>
    public abstract LeftParentheses createLeftParenthesesCommand();
} /* end class CommandFactory */
