namespace CsharpEvaluation.Problem3_WorkerActivityTracker;

class TestProgram
{
    static void Main()
    {
        Console.WriteLine("╔════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║   PROBLEM 3: WORKER ACTIVITY TRACKER                       ║");
        Console.WriteLine("║   C# Evaluation - Problem Solving Assessment               ║");
        Console.WriteLine("╚════════════════════════════════════════════════════════════╝");
        Console.WriteLine();

        Tests tests = new Tests();
        tests.RunAllTests();
        
        Console.WriteLine("\n\nPress any key to exit...");
        Console.ReadKey();
    }
}
