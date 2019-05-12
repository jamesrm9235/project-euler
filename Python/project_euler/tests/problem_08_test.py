"""https://projecteuler.net/problem=08"""

import unittest
from project_euler.problem_08 import solve


class Problem08Test(unittest.TestCase):
    """Test fixture for problem 08."""

    def test_solve_with_example_problem(self):
        """Tests the example in the problem description."""
        expected = 5832
        size = 4

        actual = solve(size)

        self.assertEqual(expected, actual)

    def test_solve(self):
        """Test that confirms the answer to the problem."""
        expected = 23514624000

        actual = solve()

        self.assertEqual(expected, actual)
