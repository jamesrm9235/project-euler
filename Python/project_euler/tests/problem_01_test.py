"""https://projecteuler.net/problem=1"""
from random import randint
import unittest
from project_euler.problem_01 import solve


class Problem01Test(unittest.TestCase):
    """Test fixture for problem 01."""

    def test_solve_raises_value_error(self):
        """Test that raises ValueError when the count is less than or equal to zero."""
        count = randint(-10, 0)

        self.assertRaises(ValueError, solve, count)

    def test_solve_with_example_problem(self):
        """Tests the example in the problem description."""
        count = 10
        expected = 23

        actual = solve(count)

        self.assertEqual(expected, actual)

    def test_solve(self):
        """Test that solves the problem."""
        count = 1000
        expected = 233168

        actual = solve(count)

        self.assertEqual(expected, actual)
