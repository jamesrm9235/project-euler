"""https://projecteuler.net/problem=06"""

import unittest
from project_euler.problem_06 import solve, square_of_sum, sum_of_squares


class Problem06Test(unittest.TestCase):
    """Test fixture for problem 06."""

    def test_square_of_sum_with_example(self):
        """Tests square of sum function using the example in the problem description."""
        count = 10
        expected = 3025

        actual = square_of_sum(count)

        self.assertEqual(expected, actual)

    def test_sum_of_squares_with_example(self):
        """Tests sum of squares function using the example in the problem description."""
        count = 10
        expected = 385

        actual = sum_of_squares(count)

        self.assertEqual(expected, actual)

    def test_solve_with_example_problem(self):
        """Tests the example in the problem description."""
        count = 10
        expected = 2640

        actual = solve(count)

        self.assertEqual(expected, actual)

    def test_solve(self):
        """Test that confirms the answer to the problem."""
        expected = 25164150

        actual = solve()

        self.assertEqual(expected, actual)
