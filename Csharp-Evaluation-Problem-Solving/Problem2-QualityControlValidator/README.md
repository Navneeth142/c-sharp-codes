# Problem 2: Quality Control Bracket Validator

## Manufacturing Context

You are a quality control engineer at a manufacturing facility. The factory uses an automated assembly instruction system where different types of brackets represent different levels of assembly operations:

- **Round brackets `()`**: Sub-assembly operations
- **Square brackets `[]`**: Component grouping operations  
- **Curly brackets `{}`**: Quality checkpoint operations

Assembly instructions must be properly structured with matching and correctly ordered brackets to ensure the production line operates safely and efficiently.

## Problem Statement

Given a string containing assembly instruction brackets `(`, `)`, `{`, `}`, `[`, `]`, determine if the instruction sequence is valid.

An instruction sequence is **valid** if:
1. Every opening bracket is closed by the same type of closing bracket
2. Opening brackets are closed in the correct order
3. Every closing bracket has a corresponding opening bracket of the same type

## Input Format

- A string `instructions` containing only the characters: `(`, `)`, `{`, `}`, `[`, `]`

## Output Format

- `true` if the instruction sequence is valid
- `false` if the instruction sequence is invalid

## Examples

### Example 1: Simple Valid Instruction

**Input:**
```
instructions = "()"
```

**Output:**
```
true
```

**Explanation:** A simple sub-assembly operation that opens and closes correctly.

### Example 2: Multiple Valid Operations

**Input:**
```
instructions = "()[]{}"
```

**Output:**
```
true
```

**Explanation:** Three different operation types, all properly opened and closed in sequence.

### Example 3: Invalid - Mismatched Brackets

**Input:**
```
instructions = "(]"
```

**Output:**
```
false
```

**Explanation:** A sub-assembly operation `(` is incorrectly closed with a component grouping bracket `]`.

### Example 4: Valid Nested Operations

**Input:**
```
instructions = "([])"
```

**Output:**
```
true
```

**Explanation:** A component grouping operation `[]` is properly nested inside a sub-assembly operation `()`.

### Example 5: Invalid - Wrong Order

**Input:**
```
instructions = "([)]"
```

**Output:**
```
false
```

**Explanation:** The brackets are interleaved incorrectly. The `[` is opened inside `(` but `]` tries to close after `)`.

## Constraints

- `1 <= instructions.length <= 10,000`
- `instructions` consists only of brackets: `()[]{}` 

## Method Signature

You need to implement the following method in the `Solution.cs` file:

```csharp
public bool ValidateAssemblyInstructions(string instructions)
{
    // Your implementation here
}
```

## How to Run Your Solution

### Run All Tests

1. Navigate to the Problem 2 folder:
   ```powershell
   cd d:\Devteam\AMIT\Csharp-Evaluation-Problem-Solving\Csharp-Evaluation-Problem-Solving\Problem2-QualityControlValidator
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
