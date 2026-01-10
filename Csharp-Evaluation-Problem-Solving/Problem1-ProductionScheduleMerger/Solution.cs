namespace CsharpEvaluation.Problem1_ProductionScheduleMerger;

/// <summary>
/// Solution class for Production Schedule Merger problem
/// </summary>
public class Solution
{
    /// <summary>
    /// Merges all overlapping production time slots into consolidated schedule
    /// </summary>
    /// <param name="schedules">Array of production time slots, where each slot is [startTime, endTime]</param>
    /// <returns>Array of merged non-overlapping time slots</returns>
    /// <remarks>
    /// Time slots are considered overlapping if they touch or overlap.
    /// For example, [1,4] and [4,5] should be merged into [1,5].
    /// 
    /// Algorithm approach:
    /// 1. Sort the schedules by start time
    /// 2. Iterate through sorted schedules
    /// 3. Merge overlapping or adjacent schedules
    /// 4. Return the merged result
    /// 
    /// Time Complexity: O(n log n) due to sorting
    /// Space Complexity: O(n) for the result list
    /// </remarks>
    public int[][] MergeProductionSchedules(int[][] schedules)
    {
        if (schedules.Length == 0)
            return schedules;

        Array.Sort(schedules,(a, b)=>a[0].CompareTo(b[0]));
        int n = schedules.Length;
        int j = 0;
        int k = 0;
        int[][] res = new int[n][];
        while (j < n)
        {
            int i = j;
            int mini = schedules[j][0];
            int maxi = schedules[j][1];

            while (i < n - 1 && schedules[i][1] >= schedules[i + 1][0])
            {
                maxi = Math.Max(maxi,schedules[i + 1][1]);
                i++;
            }
            res[k] = new int[2];
            res[k][0] = mini;
            res[k][1] = maxi;
            k++;
            j = i+1;
        }
        int[][] ans = new int[k][];
        for (int x = 0; x < k; x++)
            ans[x] = res[x];
        return ans;
    }
}

