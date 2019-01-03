using System;
using System.Collections.Generic;

namespace WilliamsChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Please add your problem number as an argument.");
                return;
            }
            var problemNumber = args[0];
            Runnable problem;
            TestCase tests;
            try
            {
                problem = (Runnable)Activator.CreateInstance(Type.GetType($"WilliamsChallenges.Problems.Problem{problemNumber}"));
                tests = (TestCase)Activator.CreateInstance(Type.GetType($"WilliamsChallenges.TestCases.Problem{problemNumber}"));
            }
            catch
            {
                Console.WriteLine($"Could not find Problem {problemNumber}.");
                return;
            }

            var inputs = tests.GetInputs();
            var solutions = tests.GetOutputs();
            for (var i = 0; i < inputs.Length; i++)
            {
                var success = problem.Run(inputs[i]) == solutions[i];
                Console.WriteLine($"Test case {i} {(success ? "passed": "failed")}.");
            }
        }
    }
}
