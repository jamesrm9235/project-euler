using System;
using System.Diagnostics;
using Miller.ProjectEuler.Solutions;

namespace Miller.ProjectEuler.Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter problem number:");

            var input = Console.ReadLine();
            var problem = 0;
            Int32.TryParse(input, out problem);

            switch (problem)
            {
                case 1:
                    {
                        // Solve with linq
                        var watch = Stopwatch.StartNew();
                        var solution1 = Problem01.SolveWithLinq(1000);
                        watch.Stop();
                        var linqElapsed = watch.Elapsed;

                        // Solve with loop
                        watch = Stopwatch.StartNew();
                        var solution2 = Problem01.SolveWithLoop(1000);
                        watch.Stop();
                        var loopElapsed = watch.Elapsed;

                        Console.WriteLine($"Problem 1 solution (with linq): {solution1}");
                        Console.WriteLine($"Elapsed: {linqElapsed}");
                        Console.WriteLine($"Problem 1 solution (with loop): {solution2}");
                        Console.WriteLine($"Elapsed: {loopElapsed}");
                        break;
                    }
                case 4:
                    {
                        var solution = Problem04.Solve();
                        Console.WriteLine($"Problem 4 solution: {solution}");
                        break;
                    }
                case 16:
                    {
                        var solution = Problem16.Solve(2, 1000);
                        Console.WriteLine($"Problem 16 solution: {solution}");
                        break;
                    }
                case 17:
                    {
                        var solution = Problem17.Solve();
                        Console.WriteLine($"Problem 17 solution: {solution}");
                        break;
                    }
                case 20:
                    {
                        var solution = Problem20.Solve(100);
                        Console.WriteLine($"Problem 20 solution: {solution}");
                        break;
                    }
                case 25:
                    {

                        var watch = new Stopwatch();
                        watch.Start();
                        var solution = Problem25.Solve(1000);
                        watch.Stop();

                        Console.WriteLine($"Problem 25 solution: {solution}");
                        Console.WriteLine($"Elapsed time: {watch.Elapsed}");
                        break;
                    }
                default:
                    {
                        Console.WriteLine($"Problem {problem} has not been solved.");
                        break;
                    }
            }
        }
    }
}
