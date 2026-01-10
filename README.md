# C# Evaluation - Problem Solving Assessment

Welcome to the C# Problem Solving Evaluation project! This repository contains programming challenges designed to assess problem-solving skills in a manufacturing industry context.

## 📋 Project Overview

This evaluation consists of multiple problems, each in its own folder with:
- Detailed problem description with manufacturing context
- Solution template for implementation
- Comprehensive test suite (10+ test cases)
- Performance measurement tools
- Individual execution capability

## 🏗️ Project Structure

```
Csharp-Evaluation-Problem-Solving/
├── Shared/
│   ├── PerformanceMeasurement.cs    # Performance tracking utilities
│   └── TestRunner.cs                # Test execution framework
│
├── Problem1-ProductionScheduleMerger/
│   ├── README.md                    # Problem description
│   ├── Solution.cs                  # Your implementation goes here
│   ├── Tests.cs                     # 12 comprehensive test cases
│   ├── Program.cs                   # Entry point for this problem
│   └── Problem1-ProductionScheduleMerger.csproj
│
├── Problem2-QualityControlValidator/
│   ├── README.md                    # Problem description
│   ├── Solution.cs                  # Your implementation goes here
│   ├── Tests.cs                     # 14 comprehensive test cases
│   ├── Program.cs                   # Entry point for this problem
│   └── Problem2-QualityControlValidator.csproj
│
└── Problem3-WorkerActivityTracker/
    ├── README.md                    # Problem description
    ├── Solution.cs                  # Your implementation goes here
    ├── Tests.cs                     # 12 comprehensive test cases
    ├── Program.cs                   # Entry point for this problem
    └── Problem3-WorkerActivityTracker.csproj
```

## 🚀 Getting Started

### Prerequisites

- .NET 10.0 SDK or later
- Any C# IDE (Visual Studio, VS Code, Rider) or command line

### Running a Problem

Each problem can be run independently:

1. **Navigate to the problem folder:**
   ```powershell
   cd Csharp-Evaluation-Problem-Solving\Problem1-ProductionScheduleMerger
   ```

2. **Run the program:**
   ```powershell
   dotnet run
   ```

3. **Choose from the menu:**
   - Run all tests
   - Run specific test
   - Test custom input
   - View problem description

## 📝 How to Solve a Problem

1. **Read the Problem**: Open the `README.md` in the problem folder
2. **Implement Solution**: Edit the `Solution.cs` file and implement the required method
3. **Run Tests**: Execute the program and select "Run All Tests"
4. **Check Performance**: Review execution time and memory usage metrics
5. **Iterate**: Optimize your solution based on test results

## 🧪 Test Cases

Each problem includes 10+ comprehensive test cases covering:
- Basic scenarios
- Edge cases
- Large datasets (performance testing)
- Complex mixed scenarios
- Boundary conditions

All test cases are designed to pass with correct implementations (no negative test cases).

## 📊 Performance Measurement

The framework automatically measures:
- **Execution Time**: Milliseconds/seconds taken to execute
- **Memory Usage**: Bytes/KB/MB of memory consumed

Performance metrics are displayed after each test and averaged in the summary.

## 🎯 Current Problems

### Problem 1: Production Schedule Merger
**Difficulty**: Medium  
**Topic**: Array Manipulation, Sorting, Merging Intervals  
**Context**: Merge overlapping production time slots in a manufacturing facility  
**Test Cases**: 12

[See Problem 1 README](./Csharp-Evaluation-Problem-Solving/Problem1-ProductionScheduleMerger/README.md)

### Problem 2: Quality Control Bracket Validator
**Difficulty**: Easy  
**Topic**: Stack, String Manipulation, Bracket Matching  
**Context**: Validate assembly instruction bracket sequences for quality control  
**Test Cases**: 14

[See Problem 2 README](./Csharp-Evaluation-Problem-Solving/Problem2-QualityControlValidator/README.md)

### Problem 3: Worker Activity Tracker
**Difficulty**: Medium  
**Topic**: Hash Tables, Sets, Data Aggregation  
**Context**: Track and analyze worker productivity across manufacturing shifts  
**Test Cases**: 12

[See Problem 3 README](./Csharp-Evaluation-Problem-Solving/Problem3-WorkerActivityTracker/README.md)

## 📦 Adding New Problems

To add a new problem:

1. Create a new folder: `ProblemX-ProblemName/`
2. Add the following files:
   - `README.md` - Problem description
   - `Solution.cs` - Solution template
   - `Tests.cs` - Test cases
   - `Program.cs` - Entry point
3. Follow the same structure as Problem 1


---

**Good luck with your evaluation! 🚀**
