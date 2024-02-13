using LibrarySample;
using System.Collections.Immutable;

namespace ConsoleSample;
class Program
{
    static void Main(string[] args)
    {
        
        var list = new List<object?>();
        list.Add(null);
        
        
        Console.WriteLine(list.Contains(null));

        return;
        (string expression, decimal result)[] expressions = {
            ("1+1", 2m),
            ("2*2", 4m),
            ("3/1", 3m),
            ("4-4", 0m)
        };
        foreach (var testCase in expressions)
        {
            var result = Evaluator.EvaluateSimpleExpression(testCase.expression);
            Console.WriteLine($"{testCase.expression}=={testCase.result} => {result == testCase.result}");
        }

        Console.WriteLine("\nPress enter to exit.");
        Console.ReadLine();
    }
}

