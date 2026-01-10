using CsharpEvaluation.Shared;

namespace CsharpEvaluation.Problem2_QualityControlValidator;

/// <summary>
/// Comprehensive test suite for Quality Control Bracket Validator problem
/// </summary>
public class Tests
{
    private readonly Solution _solution = new();
    private readonly TestRunner _testRunner = new();

    /// <summary>
    /// Test 1: Simple valid pair
    /// Basic sub-assembly operation
    /// </summary>
    public void Test1_SimpleValidPair()
    {
        string input = "()";
        bool expected = true;
        
        _testRunner.RunTest(
            "Test 1: Simple Valid Pair ()",
            () => _solution.ValidateAssemblyInstructions(input),
            expected
        );
    }

    /// <summary>
    /// Test 2: Multiple valid pairs
    /// Different operation types in sequence
    /// </summary>
    public void Test2_MultipleValidPairs()
    {
        string input = "()[]{}";
        bool expected = true;
        
        _testRunner.RunTest(
            "Test 2: Multiple Valid Pairs ()[]{}",
            () => _solution.ValidateAssemblyInstructions(input),
            expected
        );
    }

    /// <summary>
    /// Test 3: Valid nested brackets
    /// Component grouping inside sub-assembly
    /// </summary>
    public void Test3_ValidNested()
    {
        string input = "([])";
        bool expected = true;
        
        _testRunner.RunTest(
            "Test 3: Valid Nested Brackets ([])",
            () => _solution.ValidateAssemblyInstructions(input),
            expected
        );
    }

    /// <summary>
    /// Test 4: Complex valid nesting
    /// Multiple levels of nested operations
    /// </summary>
    public void Test4_ComplexValidNesting()
    {
        string input = "{[()]}";
        bool expected = true;
        
        _testRunner.RunTest(
            "Test 4: Complex Valid Nesting {[()]}",
            () => _solution.ValidateAssemblyInstructions(input),
            expected
        );
    }

    /// <summary>
    /// Test 5: Mismatched brackets
    /// Sub-assembly closed with wrong bracket type
    /// </summary>
    public void Test5_MismatchedBrackets()
    {
        string input = "(]";
        bool expected = false;
        
        _testRunner.RunTest(
            "Test 5: Mismatched Brackets (]",
            () => _solution.ValidateAssemblyInstructions(input),
            expected
        );
    }

    /// <summary>
    /// Test 6: Wrong order (interleaved)
    /// Brackets opened and closed in wrong sequence
    /// </summary>
    public void Test6_WrongOrder()
    {
        string input = "([)]";
        bool expected = false;
        
        _testRunner.RunTest(
            "Test 6: Wrong Order ([)]",
            () => _solution.ValidateAssemblyInstructions(input),
            expected
        );
    }

    /// <summary>
    /// Test 7: Only opening brackets
    /// Incomplete assembly instructions
    /// </summary>
    public void Test7_OnlyOpeningBrackets()
    {
        string input = "(((";
        bool expected = false;
        
        _testRunner.RunTest(
            "Test 7: Only Opening Brackets (((",
            () => _solution.ValidateAssemblyInstructions(input),
            expected
        );
    }

    /// <summary>
    /// Test 8: Only closing brackets
    /// Invalid instruction start
    /// </summary>
    public void Test8_OnlyClosingBrackets()
    {
        string input = ")))";
        bool expected = false;
        
        _testRunner.RunTest(
            "Test 8: Only Closing Brackets )))",
            () => _solution.ValidateAssemblyInstructions(input),
            expected
        );
    }

    /// <summary>
    /// Test 9: Long valid sequence
    /// Performance test with 100+ characters
    /// </summary>
    public void Test9_LongValidSequence()
    {
        string input = "()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}()[]{}";
        bool expected = true;
        
        _testRunner.RunTest(
            "Test 9: Long Valid Sequence (100+ chars)",
            () => _solution.ValidateAssemblyInstructions(input),
            expected
        );
    }

    /// <summary>
    /// Test 10: Alternating valid patterns
    /// Complex but valid assembly sequence
    /// </summary>
    public void Test10_AlternatingValidPatterns()
    {
        string input = "({[()]})[({})]";
        bool expected = true;
        
        _testRunner.RunTest(
            "Test 10: Alternating Valid Patterns",
            () => _solution.ValidateAssemblyInstructions(input),
            expected
        );
    }

    /// <summary>
    /// Test 11: Deep nesting (20+ levels)
    /// Stress test with deeply nested operations
    /// </summary>
    public void Test11_DeepNesting()
    {
        string input = "(((((((((((((((((((())))))))))))))))))))";
        bool expected = true;
        
        _testRunner.RunTest(
            "Test 11: Deep Nesting (20 levels)",
            () => _solution.ValidateAssemblyInstructions(input),
            expected
        );
    }

    /// <summary>
    /// Test 12: Maximum constraint (large input)
    /// Performance test with very long valid sequence
    /// </summary>
    public void Test12_MaximumConstraint()
    {
        // Create a string with 5000 pairs (10,000 characters)
        string opening = new string('(', 5000);
        string closing = new string(')', 5000);
        string input = opening + closing;
        bool expected = true;
        
        _testRunner.RunTest(
            "Test 12: Maximum Constraint (10,000 chars)",
            () => _solution.ValidateAssemblyInstructions(input),
            expected
        );
    }

    /// <summary>
    /// Test 13: Extra closing bracket
    /// More closing than opening brackets
    /// </summary>
    public void Test13_ExtraClosingBracket()
    {
        string input = "())";
        bool expected = false;
        
        _testRunner.RunTest(
            "Test 13: Extra Closing Bracket ())",
            () => _solution.ValidateAssemblyInstructions(input),
            expected
        );
    }

    /// <summary>
    /// Test 14: Mixed invalid patterns
    /// Complex invalid sequence
    /// </summary>
    public void Test14_MixedInvalidPatterns()
    {
        string input = "({[}])";
        bool expected = false;
        
        _testRunner.RunTest(
            "Test 14: Mixed Invalid Patterns ({[}])",
            () => _solution.ValidateAssemblyInstructions(input),
            expected
        );
    }

    /// <summary>
    /// Runs all tests
    /// </summary>
    public void RunAllTests()
    {
        Console.WriteLine("\n🏭 QUALITY CONTROL BRACKET VALIDATOR - TEST SUITE");
        Console.WriteLine("Running all 14 test cases...\n");

        Test1_SimpleValidPair();
        Test2_MultipleValidPairs();
        Test3_ValidNested();
        Test4_ComplexValidNesting();
        Test5_MismatchedBrackets();
        Test6_WrongOrder();
        Test7_OnlyOpeningBrackets();
        Test8_OnlyClosingBrackets();
        Test9_LongValidSequence();
        Test10_AlternatingValidPatterns();
        Test11_DeepNesting();
        Test12_MaximumConstraint();
        Test13_ExtraClosingBracket();
        Test14_MixedInvalidPatterns();

        _testRunner.PrintSummary();
    }

    /// <summary>
    /// Runs a specific test by number
    /// </summary>
    public void RunSpecificTest(int testNumber)
    {
        Console.WriteLine($"\n🏭 QUALITY CONTROL BRACKET VALIDATOR - Running Test {testNumber}\n");

        switch (testNumber)
        {
            case 1: Test1_SimpleValidPair(); break;
            case 2: Test2_MultipleValidPairs(); break;
            case 3: Test3_ValidNested(); break;
            case 4: Test4_ComplexValidNesting(); break;
            case 5: Test5_MismatchedBrackets(); break;
            case 6: Test6_WrongOrder(); break;
            case 7: Test7_OnlyOpeningBrackets(); break;
            case 8: Test8_OnlyClosingBrackets(); break;
            case 9: Test9_LongValidSequence(); break;
            case 10: Test10_AlternatingValidPatterns(); break;
            case 11: Test11_DeepNesting(); break;
            case 12: Test12_MaximumConstraint(); break;
            case 13: Test13_ExtraClosingBracket(); break;
            case 14: Test14_MixedInvalidPatterns(); break;
            default:
                Console.WriteLine("Invalid test number. Please choose 1-14.");
                return;
        }

        _testRunner.PrintSummary();
    }
}
