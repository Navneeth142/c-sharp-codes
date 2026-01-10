using CsharpEvaluation.Shared;

namespace CsharpEvaluation.Problem3_WorkerActivityTracker;

/// <summary>
/// Comprehensive test suite for Worker Activity Tracker problem
/// </summary>
public class Tests
{
    private readonly Solution _solution = new();
    private readonly TestRunner _testRunner = new();

    /// <summary>
    /// Compares two integer arrays for equality
    /// </summary>
    private bool CompareArrays(int[] arr1, int[] arr2)
    {
        if (arr1.Length != arr2.Length) return false;
        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i]) return false;
        }
        return true;
    }

    /// <summary>
    /// Test 1: Basic example - two workers with same WAM
    /// </summary>
    public void Test1_BasicExample()
    {
        int[][] logs = [[0, 5], [1, 2], [0, 2], [0, 5], [1, 3]];
        int k = 5;
        int[] expected = [0, 2, 0, 0, 0];
        
        _testRunner.RunTest(
            "Test 1: Two Workers with Same WAM",
            () => _solution.FindWorkerActivityMinutes(logs, k),
            expected,
            CompareArrays
        );
    }

    /// <summary>
    /// Test 2: Single worker, single activity
    /// </summary>
    public void Test2_SingleWorkerSingleActivity()
    {
        int[][] logs = [[1, 1]];
        int k = 4;
        int[] expected = [1, 0, 0, 0];
        
        _testRunner.RunTest(
            "Test 2: Single Worker, Single Activity",
            () => _solution.FindWorkerActivityMinutes(logs, k),
            expected,
            CompareArrays
        );
    }

    /// <summary>
    /// Test 3: Workers with different activity levels
    /// </summary>
    public void Test3_DifferentActivityLevels()
    {
        int[][] logs = [[1, 1], [2, 2], [2, 3]];
        int k = 4;
        int[] expected = [1, 1, 0, 0];
        
        _testRunner.RunTest(
            "Test 3: Workers with Different WAM Levels",
            () => _solution.FindWorkerActivityMinutes(logs, k),
            expected,
            CompareArrays
        );
    }

    /// <summary>
    /// Test 4: Workers with duplicate timestamps
    /// </summary>
    public void Test4_DuplicateTimestamps()
    {
        int[][] logs = [[0, 1], [0, 1], [0, 1], [1, 2], [1, 2]];
        int k = 3;
        int[] expected = [2, 0, 0];
        
        _testRunner.RunTest(
            "Test 4: Duplicate Timestamps (Same Minute)",
            () => _solution.FindWorkerActivityMinutes(logs, k),
            expected,
            CompareArrays
        );
    }

    /// <summary>
    /// Test 5: All workers have WAM of 1
    /// </summary>
    public void Test5_AllWorkersWAM1()
    {
        int[][] logs = [[0, 1], [1, 2], [2, 3], [3, 4], [4, 5]];
        int k = 5;
        int[] expected = [5, 0, 0, 0, 0];
        
        _testRunner.RunTest(
            "Test 5: All Workers Have WAM=1",
            () => _solution.FindWorkerActivityMinutes(logs, k),
            expected,
            CompareArrays
        );
    }

    /// <summary>
    /// Test 6: All workers have maximum WAM
    /// </summary>
    public void Test6_AllWorkersMaxWAM()
    {
        int[][] logs = [[0, 1], [0, 2], [0, 3], [1, 4], [1, 5], [1, 6]];
        int k = 5;
        int[] expected = [0, 0, 2, 0, 0];
        
        _testRunner.RunTest(
            "Test 6: All Workers Have WAM=3",
            () => _solution.FindWorkerActivityMinutes(logs, k),
            expected,
            CompareArrays
        );
    }

    /// <summary>
    /// Test 7: Large number of workers (100+)
    /// </summary>
    public void Test7_LargeNumberOfWorkers()
    {
        List<int[]> logsList = new();
        // Create 100 workers, each with 2 unique minutes
        for (int i = 0; i < 100; i++)
        {
            logsList.Add([i, i * 2]);
            logsList.Add([i, i * 2 + 1]);
        }
        int[][] logs = logsList.ToArray();
        int k = 5;
        int[] expected = [0, 100, 0, 0, 0];
        
        _testRunner.RunTest(
            "Test 7: Large Number of Workers (100)",
            () => _solution.FindWorkerActivityMinutes(logs, k),
            expected,
            CompareArrays
        );
    }

    /// <summary>
    /// Test 8: Large k value with sparse data
    /// </summary>
    public void Test8_LargeKSparseData()
    {
        int[][] logs = [[0, 1], [1, 2], [1, 3]];
        int k = 100;
        int[] expected = new int[100];
        expected[0] = 1; // One worker with WAM=1
        expected[1] = 1; // One worker with WAM=2
        
        _testRunner.RunTest(
            "Test 8: Large k with Sparse Data",
            () => _solution.FindWorkerActivityMinutes(logs, k),
            expected,
            CompareArrays
        );
    }

    /// <summary>
    /// Test 9: Maximum constraint (large dataset)
    /// </summary>
    public void Test9_MaximumConstraint()
    {
        List<int[]> logsList = new();
        // Create 1000 workers with varying activity
        for (int i = 0; i < 1000; i++)
        {
            int activities = (i % 5) + 1; // WAM from 1 to 5
            for (int j = 0; j < activities; j++)
            {
                logsList.Add([i, j]);
            }
        }
        int[][] logs = logsList.ToArray();
        int k = 10;
        int[] expected = [200, 200, 200, 200, 200, 0, 0, 0, 0, 0];
        
        _testRunner.RunTest(
            "Test 9: Maximum Constraint (1000 workers)",
            () => _solution.FindWorkerActivityMinutes(logs, k),
            expected,
            CompareArrays
        );
    }

    /// <summary>
    /// Test 10: Workers with varying activity levels
    /// </summary>
    public void Test10_VaryingActivityLevels()
    {
        int[][] logs = [
            [0, 1], [0, 2], [0, 3], [0, 4], [0, 5], // Worker 0: WAM=5
            [1, 1], [1, 2], [1, 3], // Worker 1: WAM=3
            [2, 1], // Worker 2: WAM=1
            [3, 5], [3, 6] // Worker 3: WAM=2
        ];
        int k = 6;
        int[] expected = [1, 1, 1, 0, 1, 0];
        
        _testRunner.RunTest(
            "Test 10: Workers with Varying Activity Levels",
            () => _solution.FindWorkerActivityMinutes(logs, k),
            expected,
            CompareArrays
        );
    }

    /// <summary>
    /// Test 11: Edge case - k=1
    /// </summary>
    public void Test11_EdgeCaseK1()
    {
        int[][] logs = [[0, 1], [0, 2], [1, 3]];
        int k = 1;
        int[] expected = [1]; // Worker 1 has WAM=1, worker 0 has WAM=2 (exceeds k, not counted)
        
        _testRunner.RunTest(
            "Test 11: Edge Case k=1",
            () => _solution.FindWorkerActivityMinutes(logs, k),
            expected,
            CompareArrays
        );
    }

    /// <summary>
    /// Test 12: Complex mixed scenario
    /// </summary>
    public void Test12_ComplexMixedScenario()
    {
        int[][] logs = [
            [0, 1], [0, 1], [0, 2], // Worker 0: WAM=2
            [1, 5], [1, 5], [1, 5], // Worker 1: WAM=1
            [2, 10], [2, 11], [2, 12], [2, 13], // Worker 2: WAM=4
            [3, 20], [3, 21], [3, 22], // Worker 3: WAM=3
            [4, 30] // Worker 4: WAM=1
        ];
        int k = 5;
        int[] expected = [2, 1, 1, 1, 0];
        
        _testRunner.RunTest(
            "Test 12: Complex Mixed Scenario",
            () => _solution.FindWorkerActivityMinutes(logs, k),
            expected,
            CompareArrays
        );
    }

    /// <summary>
    /// Runs all tests
    /// </summary>
    public void RunAllTests()
    {
        Console.WriteLine("\n🏭 WORKER ACTIVITY TRACKER - TEST SUITE");
        Console.WriteLine("Running all 12 test cases...\n");

        Test1_BasicExample();
        Test2_SingleWorkerSingleActivity();
        Test3_DifferentActivityLevels();
        Test4_DuplicateTimestamps();
        Test5_AllWorkersWAM1();
        Test6_AllWorkersMaxWAM();
        Test7_LargeNumberOfWorkers();
        Test8_LargeKSparseData();
        Test9_MaximumConstraint();
        Test10_VaryingActivityLevels();
        Test11_EdgeCaseK1();
        Test12_ComplexMixedScenario();

        _testRunner.PrintSummary();
    }

    /// <summary>
    /// Runs a specific test by number
    /// </summary>
    public void RunSpecificTest(int testNumber)
    {
        Console.WriteLine($"\n🏭 WORKER ACTIVITY TRACKER - Running Test {testNumber}\n");

        switch (testNumber)
        {
            case 1: Test1_BasicExample(); break;
            case 2: Test2_SingleWorkerSingleActivity(); break;
            case 3: Test3_DifferentActivityLevels(); break;
            case 4: Test4_DuplicateTimestamps(); break;
            case 5: Test5_AllWorkersWAM1(); break;
            case 6: Test6_AllWorkersMaxWAM(); break;
            case 7: Test7_LargeNumberOfWorkers(); break;
            case 8: Test8_LargeKSparseData(); break;
            case 9: Test9_MaximumConstraint(); break;
            case 10: Test10_VaryingActivityLevels(); break;
            case 11: Test11_EdgeCaseK1(); break;
            case 12: Test12_ComplexMixedScenario(); break;
            default:
                Console.WriteLine("Invalid test number. Please choose 1-12.");
                return;
        }

        _testRunner.PrintSummary();
    }
}
