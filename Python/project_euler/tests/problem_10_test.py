"""https://projecteuler.net/problem=10"""

import unittest
from project_euler.problem_10 import solve


class Problem10Test(unittest.TestCase):
    """Test fixture for problem 10."""

    def test_solve_with_example_problem(self):
        """Tests the example in the problem description."""
        expected = 17
        limit = 10

        actual = solve(limit)

        self.assertEqual(expected, actual)

    def test_solve(self):
        """Test that confirms the answer to the problem."""
        expected = 142913828922

        actual = solve()

        self.assertEqual(expected, actual)
