"""https://projecteuler.net/problem=2"""

import unittest
from project_euler.problem_02 import solve


class Problem02(unittest.TestCase):
    """Test fixture for problem 02."""

    def test_solve(self):
        """Test that confirms the answer to the problem."""
        expected = 4613732

        actual = solve()

        self.assertEqual(expected, actual)
