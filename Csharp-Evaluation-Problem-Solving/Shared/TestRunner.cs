namespace CsharpEvaluation.Shared;

/// <summary>
/// Base test runner framework for executing and tracking test results
/// </summary>
public class TestRunner
{
    private List<TestResult> _testResults = new();
    private int _totalTests = 0;
    private int _passedTests = 0;
    private int _failedTests = 0;

    /// <summary>
    /// Runs a single test case
    /// </summary>
    public void RunTest<T>(string testName, Func<T> testFunction, T expectedResult, Func<T, T, bool>? comparer = null)
    {
        _totalTests++;
        Console.WriteLine($"\n{'=',-60}");
        Console.WriteLine($"🧪 Running Test: {testName}");
        Console.WriteLine($"{'=',-60}");

        try
        {
            var perfResult = PerformanceMeasurement.MeasurePerformance(testFunction, testName);
            T actualResult = perfResult.Result;

            bool passed;
            if (comparer != null)
            {
                passed = comparer(actualResult, expectedResult);
            }
            else
            {
                passed = EqualityComparer<T>.Default.Equals(actualResult, expectedResult);
            }

            if (passed)
            {
                _passedTests++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("✅ PASSED");
                Console.ResetColor();
            }
            else
            {
                _failedTests++;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("❌ FAILED");
                Console.WriteLine($"   Expected: {FormatResult(expectedResult)}");
                Console.WriteLine($"   Actual:   {FormatResult(actualResult)}");
                Console.ResetColor();
            }

            perfResult.PrintMetrics();

            _testResults.Add(new TestResult
            {
                TestName = testName,
                Passed = passed,
                ExecutionTimeMs = perfResult.ExecutionTimeMs,
                MemoryUsedBytes = perfResult.MemoryUsedBytes
            });
        }
        catch (Exception ex)
        {
            _failedTests++;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"❌ FAILED with exception: {ex.Message}");
            Console.ResetColor();

            _testResults.Add(new TestResult
            {
                TestName = testName,
                Passed = false,
                ErrorMessage = ex.Message
            });
        }
    }

    /// <summary>
    /// Prints a summary of all test results
    /// </summary>
    public void PrintSummary()
    {
        Console.WriteLine($"\n\n{'=',-60}");
        Console.WriteLine("📋 TEST SUMMARY");
        Console.WriteLine($"{'=',-60}");
        Console.WriteLine($"Total Tests:  {_totalTests}");
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Passed:       {_passedTests}");
        Console.ResetColor();
        
        if (_failedTests > 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Failed:       {_failedTests}");
            Console.ResetColor();
        }

        if (_passedTests > 0)
        {
            double avgTime = _testResults.Where(r => r.Passed).Average(r => r.ExecutionTimeMs);
            long avgMemory = (long)_testResults.Where(r => r.Passed).Average(r => r.MemoryUsedBytes);
            
            Console.WriteLine($"\n📊 Average Performance (Passed Tests):");
            Console.WriteLine($"   {PerformanceMeasurement.FormatPerformanceMetrics(avgTime, avgMemory)}");
        }

        Console.WriteLine($"{'=',-60}\n");
    }

    /// <summary>
    /// Formats a result for display
    /// </summary>
    private string FormatResult<T>(T result)
    {
        if (result is Array array)
        {
            if (array.Rank == 1)
            {
                return "[" + string.Join(", ", array.Cast<object>()) + "]";
            }
            else if (array.Rank == 2 && array is int[][] jaggedArray)
            {
                return "[" + string.Join(", ", jaggedArray.Select(arr => "[" + string.Join(",", arr) + "]")) + "]";
            }
        }
        return result?.ToString() ?? "null";
    }

    /// <summary>
    /// Resets the test runner for a new test session
    /// </summary>
    public void Reset()
    {
        _testResults.Clear();
        _totalTests = 0;
        _passedTests = 0;
        _failedTests = 0;
    }
}

/// <summary>
/// Represents the result of a single test
/// </summary>
public class TestResult
{
    public string TestName { get; set; } = string.Empty;
    public bool Passed { get; set; }
    public double ExecutionTimeMs { get; set; }
    public long MemoryUsedBytes { get; set; }
    public string? ErrorMessage { get; set; }
}
