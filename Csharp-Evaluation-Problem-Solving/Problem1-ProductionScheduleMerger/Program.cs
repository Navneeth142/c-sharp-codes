namespace CsharpEvaluation.Problem1_ProductionScheduleMerger;

class TestProgram
{
    static void Main()
    {
        Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║   PROBLEM 1: PRODUCTION SCHEDULE MERGER - TEST RUNNER     ║");
        Console.WriteLine("║   C# Evaluation - Problem Solving Assessment               ║");
        Console.WriteLine("╚════════════════════════════════════════════════════════════╝");
        Console.WriteLine();

        Tests tests = new Tests();
        tests.RunAllTests();
        
        Console.WriteLine("\n\nPress any key to exit...");
        Console.ReadKey();
    }
}
