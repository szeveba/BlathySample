namespace LibrarySample;

/// <summary>
/// Különböző matematikai kifejezések kiértékeléséhez.
/// </summary>
public static class Evaluator
{
    private static char[] operators = { '+', '-', '*', '/' };

    /// <summary>
    /// Egyszerű matematikai kifejezések kiértékeléséhez.
    /// </summary>
    /// <param name="expression">Matematikai kifejezés</param>
    /// <returns>Matematikai kifejezés eredménye</returns>
    /// <exception cref="ArgumentException"></exception>
    /// <exception cref="NotImplementedException"></exception>
    public static decimal EvaluateSimpleExpression(string expression)
    {
        var symbols = expression.Where(x => operators.Contains(x));
        if (1 != symbols.Count()) throw new ArgumentException("Ez a metódus csak egy műveleti jeles kifejezéseket tud kiértékelni.");
        var symbol = symbols.First();
        var splits = expression.Split(symbol);
        var firstOperand = decimal.Parse(splits[0]);
        var secondOperand = decimal.Parse(splits[1]);
        switch (symbol)
        {
            case '+': return firstOperand + secondOperand;
            case '-': return firstOperand - secondOperand;
            case '*': return firstOperand * secondOperand;
            case '/': return firstOperand / secondOperand;
            default: throw new NotImplementedException(symbol + " jellel nincs definiálva művelet!");
        }
    }
}

