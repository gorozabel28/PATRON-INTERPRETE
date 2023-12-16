public class DivideExpression : AbstractExpression
{
    private readonly AbstractExpression _left;
    private readonly AbstractExpression _right;

    public DivideExpression(AbstractExpression left, AbstractExpression right)
    {
        _left = left;
        _right = right;
    }

    public override int Interpret(Context context)
    {
        int divisor = _right.Interpret(context);
        if (divisor == 0)
        {
            throw new DivideByZeroException("Error: División por cero");
        }

        return _left.Interpret(context) / divisor;
    }
}