public class SubtractExpression : AbstractExpression
{
    private readonly AbstractExpression _left;
    private readonly AbstractExpression _right;

    public SubtractExpression(AbstractExpression left, AbstractExpression right)
    {
        _left = left;
        _right = right;
    }

    public override int Interpret(Context context)
    {
        return _left.Interpret(context) - _right.Interpret(context);
    }
}