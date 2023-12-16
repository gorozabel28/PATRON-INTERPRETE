public class TerminalExpression : AbstractExpression
{
    private readonly string _value;

    public TerminalExpression(string value)
    {
        _value = value;
    }

    public override int Interpret(Context context)
    {
        return int.Parse(_value);
    }
}