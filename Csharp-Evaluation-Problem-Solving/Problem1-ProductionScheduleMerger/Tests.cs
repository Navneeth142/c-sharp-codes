using CsharpEvaluation.Shared;

namespace CsharpEvaluation.Problem1_ProductionScheduleMerger;

/// <summary>
/// Comprehensive test suite for Production Schedule Merger problem
/// </summary>
public class Tests
{
    private readonly Solution _solution = new();
    private readonly TestRunner _testRunner = new();

    /// <summary>
    /// Compares two jagged arrays for equality
    /// </summary>
    private bool CompareJaggedArrays(int[][] arr1, int[][] arr2)
    {
        if (arr1.Length != arr2.Length) return false;
        
        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i].Length != arr2[i].Length) return false;
            for (int j = 0; j < arr1[i].Length; j++)
            {
                if (arr1[i][j] != arr2[i][j]) return false;
            }
        }
        return true;
    }

    /// <summary>
    /// Test 1: Basic overlapping schedules (2 slots)
    /// Simple case with two overlapping production slots
    /// </summary>
    public void Test1_BasicOverlapping()
    {
        int[][] input = [[1, 3], [2, 6]];
        int[][] expected = [[1, 6]];
        
        _testRunner.RunTest(
            "Test 1: Basic Overlapping Schedules",
            () => _solution.MergeProductionSchedules(input),
            expected,
            CompareJaggedArrays
        );
    }

    /// <summary>
    /// Test 2: Multiple overlapping schedules (4+ slots)
    /// Production line with multiple overlapping time slots
    /// </summary>
    public void Test2_MultipleOverlapping()
    {
        int[][] input = [[1, 3], [2, 6], [8, 10], [15, 18]];
        int[][] expected = [[1, 6], [8, 10], [15, 18]];
        
        _testRunner.RunTest(
            "Test 2: Multiple Overlapping Schedules",
            () => _solution.MergeProductionSchedules(input),
            expected,
            CompareJaggedArrays
        );
    }

    /// <summary>
    /// Test 3: Adjacent schedules (touching boundaries)
    /// Back-to-back production shifts that should be merged
    /// </summary>
    public void Test3_AdjacentSchedules()
    {
        int[][] input = [[1, 4], [4, 5]];
        int[][] expected = [[1, 5]];
        
        _testRunner.RunTest(
            "Test 3: Adjacent Schedules (Touching Boundaries)",
            () => _solution.MergeProductionSchedules(input),
            expected,
            CompareJaggedArrays
        );
    }

    /// <summary>
    /// Test 4: Non-overlapping schedules
    /// Completely separate production periods
    /// </summary>
    public void Test4_NonOverlapping()
    {
        int[][] input = [[1, 2], [3, 5], [6, 7], [8, 10], [12, 16]];
        int[][] expected = [[1, 2], [3, 5], [6, 7], [8, 10], [12, 16]];
        
        _testRunner.RunTest(
            "Test 4: Non-Overlapping Schedules",
            () => _solution.MergeProductionSchedules(input),
            expected,
            CompareJaggedArrays
        );
    }

    /// <summary>
    /// Test 5: Single schedule
    /// Only one production slot scheduled
    /// </summary>
    public void Test5_SingleSchedule()
    {
        int[][] input = [[1, 5]];
        int[][] expected = [[1, 5]];
        
        _testRunner.RunTest(
            "Test 5: Single Schedule",
            () => _solution.MergeProductionSchedules(input),
            expected,
            CompareJaggedArrays
        );
    }

    /// <summary>
    /// Test 6: All schedules overlap into one
    /// Continuous production period from multiple overlapping slots
    /// </summary>
    public void Test6_AllOverlapIntoOne()
    {
        int[][] input = [[1, 4], [2, 5], [3, 6], [5, 8], [7, 10]];
        int[][] expected = [[1, 10]];
        
        _testRunner.RunTest(
            "Test 6: All Schedules Merge Into One",
            () => _solution.MergeProductionSchedules(input),
            expected,
            CompareJaggedArrays
        );
    }

    /// <summary>
    /// Test 7: Unsorted input schedules
    /// Schedules provided in random order (real-world scenario)
    /// </summary>
    public void Test7_UnsortedInput()
    {
        int[][] input = [[4, 7], [1, 4], [9, 12], [15, 18], [11, 13]];
        int[][] expected = [[1, 7], [9, 13], [15, 18]];
        
        _testRunner.RunTest(
            "Test 7: Unsorted Input Schedules",
            () => _solution.MergeProductionSchedules(input),
            expected,
            CompareJaggedArrays
        );
    }

    /// <summary>
    /// Test 8: Large number of schedules (100+ slots)
    /// Stress test with many production slots
    /// </summary>
    public void Test8_LargeNumberOfSchedules()
    {
        // Create 100 schedules with some overlapping patterns
        List<int[]> inputList = new();
        for (int i = 0; i < 100; i++)
        {
            inputList.Add([i * 10, i * 10 + 15]); // Each overlaps with next
        }
        int[][] input = inputList.ToArray();
        
        // All should merge into one big schedule
        int[][] expected = [[0, 1005]];
        
        _testRunner.RunTest(
            "Test 8: Large Number of Schedules (100 slots)",
            () => _solution.MergeProductionSchedules(input),
            expected,
            CompareJaggedArrays
        );
    }

    /// <summary>
    /// Test 9: Schedules with same start times
    /// Multiple production lines starting at the same time
    /// </summary>
    public void Test9_SameStartTimes()
    {
        int[][] input = [[1, 4], [1, 5], [1, 3], [6, 8], [6, 10]];
        int[][] expected = [[1, 5], [6, 10]];
        
        _testRunner.RunTest(
            "Test 9: Schedules with Same Start Times",
            () => _solution.MergeProductionSchedules(input),
            expected,
            CompareJaggedArrays
        );
    }

    /// <summary>
    /// Test 10: Complex mixed scenario
    /// Realistic factory schedule with various patterns
    /// </summary>
    public void Test10_ComplexMixedScenario()
    {
        int[][] input = [
            [1, 3], [2, 4], [5, 7], [6, 8], [9, 10],
            [11, 15], [14, 18], [20, 25], [22, 30], [26, 28]
        ];
        int[][] expected = [[1, 4], [5, 8], [9, 10], [11, 18], [20, 30]];
        
        _testRunner.RunTest(
            "Test 10: Complex Mixed Scenario",
            () => _solution.MergeProductionSchedules(input),
            expected,
            CompareJaggedArrays
        );
    }

    /// <summary>
    /// Test 11: Maximum constraint test (1000 schedules)
    /// Performance test with large dataset
    /// </summary>
    public void Test11_MaximumConstraint()
    {
        // Create 1000 schedules with overlapping patterns
        // Each schedule overlaps with the next one
        List<int[]> inputList = new();
        for (int i = 0; i < 1000; i++)
        {
            inputList.Add([i * 2, i * 2 + 3]); // Each overlaps with next (gap of 2, overlap of 1)
        }
        int[][] input = inputList.ToArray();
        
        // Should merge into one continuous schedule from 0 to 2001
        int[][] expected = [[0, 2001]];
        
        _testRunner.RunTest(
            "Test 11: Maximum Constraint (1000 schedules)",
            () => _solution.MergeProductionSchedules(input),
            expected,
            CompareJaggedArrays
        );
    }

    /// <summary>
    /// Test 12: Schedules with identical time ranges
    /// Multiple production lines with exact same schedule
    /// </summary>
    public void Test12_IdenticalTimeRanges()
    {
        int[][] input = [[1, 5], [1, 5], [1, 5], [7, 10], [7, 10]];
        int[][] expected = [[1, 5], [7, 10]];
        
        _testRunner.RunTest(
            "Test 12: Identical Time Ranges",
            () => _solution.MergeProductionSchedules(input),
            expected,
            CompareJaggedArrays
        );
    }

    /// <summary>
    /// Runs all tests
    /// </summary>
    public void RunAllTests()
    {
        Console.WriteLine("\n🏭 PRODUCTION SCHEDULE MERGER - TEST SUITE");
        Console.WriteLine("Running all 12 test cases...\n");

        Test1_BasicOverlapping();
        Test2_MultipleOverlapping();
        Test3_AdjacentSchedules();
        Test4_NonOverlapping();
        Test5_SingleSchedule();
        Test6_AllOverlapIntoOne();
        Test7_UnsortedInput();
        Test8_LargeNumberOfSchedules();
        Test9_SameStartTimes();
        Test10_ComplexMixedScenario();
        Test11_MaximumConstraint();
        Test12_IdenticalTimeRanges();

        _testRunner.PrintSummary();
    }

    /// <summary>
    /// Runs a specific test by number
    /// </summary>
    public void RunSpecificTest(int testNumber)
    {
        Console.WriteLine($"\n🏭 PRODUCTION SCHEDULE MERGER - Running Test {testNumber}\n");

        switch (testNumber)
        {
            case 1: Test1_BasicOverlapping(); break;
            case 2: Test2_MultipleOverlapping(); break;
            case 3: Test3_AdjacentSchedules(); break;
            case 4: Test4_NonOverlapping(); break;
            case 5: Test5_SingleSchedule(); break;
            case 6: Test6_AllOverlapIntoOne(); break;
            case 7: Test7_UnsortedInput(); break;
            case 8: Test8_LargeNumberOfSchedules(); break;
            case 9: Test9_SameStartTimes(); break;
            case 10: Test10_ComplexMixedScenario(); break;
            case 11: Test11_MaximumConstraint(); break;
            case 12: Test12_IdenticalTimeRanges(); break;
            default:
                Console.WriteLine("Invalid test number. Please choose 1-12.");
                return;
        }

        _testRunner.PrintSummary();
    }
}
