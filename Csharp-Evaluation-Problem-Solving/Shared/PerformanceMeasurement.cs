using System.Diagnostics;

namespace CsharpEvaluation.Shared;

/// <summary>
/// Utility class for measuring code performance
/// </summary>
public static class PerformanceMeasurement
{
    /// <summary>
    /// Measures the execution time and memory usage of a function
    /// </summary>
    /// <typeparam name="T">Return type of the function</typeparam>
    /// <param name="function">The function to measure</param>
    /// <param name="functionName">Name of the function for display purposes</param>
    /// <returns>Performance result containing execution time, memory usage, and function result</returns>
    public static PerformanceResult<T> MeasurePerformance<T>(Func<T> function, string functionName = "Function")
    {
        // Force garbage collection before measurement for more accurate memory tracking
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();

        long memoryBefore = GC.GetTotalMemory(false);
        
        Stopwatch stopwatch = Stopwatch.StartNew();
        T result = function();
        stopwatch.Stop();

        long memoryAfter = GC.GetTotalMemory(false);
        long memoryUsed = Math.Max(0, memoryAfter - memoryBefore);

        return new PerformanceResult<T>
        {
            Result = result,
            ExecutionTimeMs = stopwatch.Elapsed.TotalMilliseconds,
            MemoryUsedBytes = memoryUsed,
            FunctionName = functionName
        };
    }

    /// <summary>
    /// Formats performance metrics for display
    /// </summary>
    public static string FormatPerformanceMetrics(double executionTimeMs, long memoryUsedBytes)
    {
        string timeStr = executionTimeMs < 1 
            ? $"{executionTimeMs:F4} ms" 
            : executionTimeMs < 1000 
                ? $"{executionTimeMs:F2} ms" 
                : $"{executionTimeMs / 1000:F2} seconds";

        string memoryStr = memoryUsedBytes < 1024 
            ? $"{memoryUsedBytes} bytes"
            : memoryUsedBytes < 1024 * 1024
                ? $"{memoryUsedBytes / 1024.0:F2} KB"
                : $"{memoryUsedBytes / (1024.0 * 1024.0):F2} MB";

        return $"⏱️  Execution Time: {timeStr} | 💾 Memory Used: {memoryStr}";
    }
}

/// <summary>
/// Result of a performance measurement
/// </summary>
public class PerformanceResult<T>
{
    public T Result { get; set; } = default!;
    public double ExecutionTimeMs { get; set; }
    public long MemoryUsedBytes { get; set; }
    public string FunctionName { get; set; } = string.Empty;

    public void PrintMetrics()
    {
        Console.WriteLine($"📊 Performance Metrics for '{FunctionName}':");
        Console.WriteLine($"   {PerformanceMeasurement.FormatPerformanceMetrics(ExecutionTimeMs, MemoryUsedBytes)}");
    }
}
