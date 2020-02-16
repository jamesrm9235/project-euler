using Miller.ProjectEuler.Solutions;
using System;
using System.Diagnostics;

namespace Miller.ProjectEuler.SolutionRunner
{
    public sealed class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("--- Project Euler Solution Runner ---");
            Console.Write("Enter problem number: ");
            if (uint.TryParse(Console.ReadLine(), out uint number))
            {
                IProblem problem = ProblemFactory.GetProblem(number);

                Stopwatch timer = new Stopwatch();
                timer.Start();
                string solution = problem.Solve();
                timer.Stop();

                Console.WriteLine($"Problem: {problem.Name}");
                Console.WriteLine($"Solution: {solution}");
                Console.WriteLine($"Elapsed time: {timer.Elapsed}");
            }
            else
            {
                Console.WriteLine("Input must be a positive integer.");
            }
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }

        private static class ProblemFactory
        {
            public static IProblem GetProblem(uint number)
            {
                switch (number)
                {
                    case 1:
                        {
                            return new Problem01(count: 1000);
                        }
                    default:
                        {
                            return new NullProblem();
                        }
                }
            }
        }

        private sealed class NullProblem : IProblem
        {
            public string Name => "Null";

            public string Solve()
            {
                return "This problem has not been solved.";
            }
        }
    }
}
