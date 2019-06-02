"""https://projecteuler.net/problem=05"""

import unittest
from project_euler.problem_05 import solve


class Problem05Test(unittest.TestCase):
    """Test fixture for problem 05."""

    def test_solve_with_example_problem(self):
        """Tests the example in the problem description."""
        expected = 2520
        count = 10

        actual = solve(count)

        self.assertEqual(expected, actual)

    def test_solve(self):
        """Test that confirms the answer to the problem."""
        expected = 232792560

        actual = solve()

        self.assertEqual(expected, actual)
