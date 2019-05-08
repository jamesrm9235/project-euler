"""https://projecteuler.net/problem=2"""

import unittest
from project_euler.problem_02 import solve


class Problem02(unittest.TestCase):
    """Test fixture for problem 02."""

    def test_solve_with_maximum_of_4_million(self):
        """Test that solves the problem."""
        expected = 4613732
        maximum = 4000000

        actual = solve(maximum)

        self.assertEqual(expected, actual)
