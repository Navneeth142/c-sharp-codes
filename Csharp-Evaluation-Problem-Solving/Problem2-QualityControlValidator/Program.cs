namespace CsharpEvaluation.Problem2_QualityControlValidator;

class TestProgram
{
    static void Main()
    {
        Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║   PROBLEM 2: QUALITY CONTROL BRACKET VALIDATOR             ║");
        Console.WriteLine("║   C# Evaluation - Problem Solving Assessment               ║");
        Console.WriteLine("╚════════════════════════════════════════════════════════════╝");
        Console.WriteLine();

        Tests tests = new Tests();
        tests.RunAllTests();
        
        Console.WriteLine("\n\nPress any key to exit...");
        Console.ReadKey();
    }
}
