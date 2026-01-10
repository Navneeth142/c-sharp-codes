namespace CsharpEvaluation.Problem3_WorkerActivityTracker;

/// <summary>
/// Solution class for Worker Activity Tracker problem
/// </summary>
public class Solution
{
    /// <summary>
    /// Finds the distribution of worker activity minutes
    /// </summary>
    /// <param name="logs">Activity logs where each entry is [workerID, minute]</param>
    /// <param name="k">Maximum activity level to track</param>
    /// <returns>Array where result[i] is count of workers with WAM of (i+1)</returns>
    /// <remarks>
    /// Worker Active Minutes (WAM) = number of unique minutes a worker was active
    /// 
    /// Algorithm approach (Dictionary + HashSet):
    /// 1. Use Dictionary to map workerID to HashSet of unique minutes
    /// 2. Process each log entry, adding minute to worker's HashSet
    /// 3. Count how many workers have each WAM level
    /// 4. Return 1-indexed result array
    /// 
    /// Time Complexity: O(n) where n is number of logs
    /// Space Complexity: O(w + m) where w is workers and m is unique minutes
    /// 
    /// Note: Contestants can use ANY approach - this is just one solution!
    /// </remarks>
    public int[] FindWorkerActivityMinutes(int[][] logs, int k)
    {
        // TODO: Implement your solution here
        
        throw new NotImplementedException();
    }
}
