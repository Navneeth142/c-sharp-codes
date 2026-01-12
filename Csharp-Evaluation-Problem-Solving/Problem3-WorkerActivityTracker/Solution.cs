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
    public class Solution
    {
        public int[] FindWorkerActivityMinutes(int[][] logs, int k)
        {
            int[] result = new int[k];

            Dictionary<int, HashSet<int>> map = new Dictionary<int, HashSet<int>>();
            for (int i = 0; i < logs.Length; i++)
            {
                int workerId = logs[i][0];
                int minute = logs[i][1];

                if (!map.ContainsKey(workerId))
                {
                    map[workerId] = new HashSet<int>();
                }

                map[workerId].Add(minute);
            }
            foreach (var entry in map)
            {
                int wam = entry.Value.Count;
                if (wam >= 1 && wam <= k)
                {
                    result[wam - 1]++;
                }
            }
            return result;
        }
    }
}

