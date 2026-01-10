# Problem 3: Worker Activity Tracker

## Manufacturing Context

You are a production manager at a large manufacturing facility with multiple shifts and hundreds of workers. The factory uses an automated time-tracking system that logs every time a worker performs a task.

Your goal is to analyze worker productivity by tracking **unique active minutes** - the number of distinct minutes during which each worker performed at least one task. This helps identify productivity patterns and optimize workforce allocation.

## Problem Statement

Given activity logs for workers and an integer `k`, calculate how many workers have each possible level of activity.

**Worker Active Minutes (WAM)** for a worker is defined as the **number of unique minutes** in which the worker performed a task. A minute can only be counted once, even if the worker performed multiple tasks in that minute.

You need to return a **1-indexed array** of size `k` where `result[j]` represents the number of workers whose WAM equals `j`.

## Input Format

- `logs`: A 2D integer array where each `logs[i] = [workerID, minute]` indicates that the worker with `workerID` performed a task at the given `minute`
- `k`: An integer representing the maximum activity level to track

## Output Format

- An integer array of size `k` where:
  - `result[0]` = count of workers with WAM of 1
  - `result[1]` = count of workers with WAM of 2
  - ... and so on
  - `result[j-1]` = count of workers with WAM of j

## Examples

### Example 1: Two Workers with Same Activity Level

**Input:**
```
logs = [[0,5],[1,2],[0,2],[0,5],[1,3]]
k = 5
```

**Output:**
```
[0,2,0,0,0]
```

**Explanation:**
- Worker ID=0 performed tasks at minutes: 5, 2, 5 (duplicate)
  - Unique minutes: {2, 5} → WAM = 2
- Worker ID=1 performed tasks at minutes: 2, 3
  - Unique minutes: {2, 3} → WAM = 2
- Both workers have WAM of 2, so `result[1]` = 2 (index 1 represents WAM=2)
- All other indices are 0

### Example 2: Workers with Different Activity Levels

**Input:**
```
logs = [[1,1],[2,2],[2,3]]
k = 4
```

**Output:**
```
[1,1,0,0]
```

**Explanation:**
- Worker ID=1 performed task at minute: 1
  - Unique minutes: {1} → WAM = 1
- Worker ID=2 performed tasks at minutes: 2, 3
  - Unique minutes: {2, 3} → WAM = 2
- One worker with WAM=1: `result[0]` = 1
- One worker with WAM=2: `result[1]` = 1
- Rest are 0

## Constraints

- `1 <= logs.length <= 100,000`
- `0 <= workerID <= 100,000`
- `1 <= minute <= 100,000`
- `1 <= k <= 100,000`

## Method Signature

You need to implement the following method in the `Solution.cs` file:

```csharp
public int[] FindWorkerActivityMinutes(int[][] logs, int k)
{
    // Your implementation here
}
```

## How to Run Your Solution

### Run All Tests

1. Navigate to the Problem 3 folder:
   ```powershell
   cd d:\Devteam\AMIT\Csharp-Evaluation-Problem-Solving\Csharp-Evaluation-Problem-Solving\Problem3-WorkerActivityTracker
   ```

2. Run the program:
   ```powershell
   dotnet run
   ```

All 12 test cases will execute automatically and display results with performance metrics.

## Performance Measurement

The test framework automatically measures:
- **Execution Time**: How long your solution takes to run
- **Memory Usage**: How much memory your solution uses

Good luck! 🚀
