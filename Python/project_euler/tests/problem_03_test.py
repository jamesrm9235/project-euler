"""https://projecteuler.net/problem=3"""
import unittest
from project_euler.problem_03 import solve


class Problem03Test(unittest.TestCase):
    """Test fixture for problem 03."""

    def test_solve_with_example_problem(self):
        """Tests the example in the problem description."""
        expected = 29
        number = 13195

        actual = solve(number)

        self.assertEqual(expected, actual)

    def test_solve(self):
        """Test that confirms the answer to the problem."""
        expected = 6857
        number = 600851475143

        actual = solve(number)

        self.assertEqual(expected, actual)
