namespace Miller.ProjectEuler.Solutions
{
    public interface IProblem
    {
        /// <summary>
        /// Problem name
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Executes the solution
        /// </summary>
        /// <returns>Answer</returns>
        string Solve();
    }
}