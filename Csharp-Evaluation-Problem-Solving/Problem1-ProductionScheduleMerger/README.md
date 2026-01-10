# Problem 1: Production Schedule Merger

## Manufacturing Context

You are a production scheduler at a large manufacturing facility. The factory runs multiple production lines, and each line has scheduled time slots for different jobs. Due to overlapping schedules and last-minute changes, some production time slots overlap with each other.

Your task is to **merge all overlapping production time slots** to create a consolidated schedule that shows the actual continuous production periods. This will help optimize machine utilization and avoid scheduling conflicts.

## Problem Statement

Given an array of production time slots where each slot is represented as `[startTime, endTime]`, merge all overlapping time slots and return an array of non-overlapping time slots that cover all the production periods.

**Important:** Two time slots are considered overlapping if they touch or overlap. For example, `[1,4]` and `[4,5]` should be merged into `[1,5]`.

## Input Format

- An array of production time slots: `int[][] schedules`
- Each time slot is represented as `[startTime, endTime]`
- Time is represented in hours (0-10000)

## Output Format

- An array of merged production time slots
- Each time slot is `[startTime, endTime]`
- Time slots should be sorted by start time
- No overlapping time slots in the output

## Examples

### Example 1: Basic Overlapping Schedules

**Input:**
```
schedules = [[1,3],[2,6],[8,10],[15,18]]
```

**Output:**
```
[[1,6],[8,10],[15,18]]
```

**Explanation:** The first two time slots `[1,3]` and `[2,6]` overlap, so they are merged into `[1,6]`. The remaining slots don't overlap with any others.

### Example 2: Adjacent Schedules (Touching Boundaries)

**Input:**
```
schedules = [[1,4],[4,5]]
```

**Output:**
```
[[1,5]]
```

**Explanation:** Time slots `[1,4]` and `[4,5]` touch at time 4, so they are considered overlapping and merged into `[1,5]`.

### Example 3: Unsorted Input

**Input:**
```
schedules = [[4,7],[1,4]]
```

**Output:**
```
[[1,7]]
```

**Explanation:** Even though the input is not sorted, the slots `[1,4]` and `[4,7]` touch and should be merged into `[1,7]`.

## Constraints

- `1 <= schedules.length <= 10,000`
- `schedules[i].length == 2`
- `0 <= startTime <= endTime <= 10,000`

## Method Signature

You need to implement the following method in the `Solution.cs` file:

```csharp
public int[][] MergeProductionSchedules(int[][] schedules)
{
    // Your implementation here
}
```

## How to Run Your Solution

### Option 1: Run with All Tests

1. Navigate to the Problem 1 folder:
   ```powershell
   cd d:\Devteam\AMIT\Csharp-Evaluation-Problem-Solving\Csharp-Evaluation-Problem-Solving\Problem1-ProductionScheduleMerger
   ```

2. Run the program:
   ```powershell
   dotnet run
   ```

3. Select option `1` to run all tests

### Option 2: Run Individual Test

1. Navigate to the Problem 1 folder (same as above)

2. Run the program:
   ```powershell
   dotnet run
   ```

3. Select option `2` to run a specific test, then enter the test number (1-12)

### Option 3: Test Your Own Input

1. Navigate to the Problem 1 folder (same as above)

2. Run the program:
   ```powershell
   dotnet run
   ```

3. Select option `3` to enter your own test data

## Performance Measurement

The test framework automatically measures:
- **Execution Time**: How long your solution takes to run
- **Memory Usage**: How much memory your solution uses

After each test, you'll see performance metrics displayed. The summary at the end shows average performance across all tests.

Good luck! 🚀
