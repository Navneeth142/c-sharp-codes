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
        /*int[][] input = [[1, 3], [2, 6]];
        Solution solution = new Solution();
        int[][] result = solution.MergeProductionSchedules(input);
        for(int i=0; i<result.Length; i++)
        {
            Console.WriteLine(result[i][0] + " " + result[i][1]);
        }
        */
        Console.WriteLine("\n\nPress any key to exit...");
        Console.ReadKey();
    }
}
