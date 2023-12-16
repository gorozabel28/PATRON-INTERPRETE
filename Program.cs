class Program
{
    static void Main()
    {
        var context = new Context();

        var terminal1 = new TerminalExpression("1");
        var terminal2 = new TerminalExpression("2");
        var terminal3 = new TerminalExpression("3");
        var terminal4 = new TerminalExpression("4");

        var addExpr = new AddExpression(terminal1, terminal2);
        var subExpr = new SubtractExpression(addExpr, terminal3);
        var multExpr = new MultiplyExpression(terminal4, new TerminalExpression("2"));
        var divExpr = new DivideExpression(multExpr, new TerminalExpression("2"));

     
        var result = divExpr.Interpret(context);
        Console.WriteLine($"Resultado: {result}"); 
    }
}