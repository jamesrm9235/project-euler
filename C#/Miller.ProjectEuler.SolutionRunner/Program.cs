using Miller.ProjectEuler.Solutions;
using System;
using System.Diagnostics;
using System.IO;

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
                IProblem problem = ProblemFactory.Create(number);

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
            public static IProblem Create(uint number)
            {
                switch (number)
                {
                    case 1:
                        {
                            return new Problem01();
                        }
                    case 2:
                        {
                            return new Problem02();
                        }
                    case 3:
                        {
                            return new Problem03();
                        }
                    case 4:
                        {
                            return new Problem04();
                        }
                    case 5:
                        {
                            return new Problem05();
                        }
                    case 22:
                        {
                            Stream res = GetEmbeddedResource("Resources.p022_names.txt");
                            using (var reader = new StreamReader(res))
                            {
                                string text = reader.ReadToEnd();
                                return new Problem22(text);
                            }
                        }
                    case 42:
                        {
                            Stream res = GetEmbeddedResource("Resources.p042_words.txt");
                            using (var reader = new StreamReader(res))
                            {
                                string text = reader.ReadToEnd();
                                return new Problem42(text);
                            }
                        }
                    default:
                        {
                            return new NullProblem();
                        }
                }
            }
        }

        private static Stream GetEmbeddedResource(string fileName)
        {
            return System.Reflection.Assembly.GetEntryAssembly().GetManifestResourceStream($"{typeof(Program).Namespace}.{fileName}");
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
