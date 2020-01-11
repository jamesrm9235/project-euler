"""https://projecteuler.net/problem=13"""

import unittest
from project_euler.problem_13 import chop_into_list, solve, INPUT


class Problem13Test(unittest.TestCase):
    """Test fixture for problem 13."""

    def test_chop_into_list_with_problem_input(self):
        """Tests the function using the problem's input."""
        expected = 100  # The string should be sliced into 100 substrings.
        size = 50

        actual = chop_into_list(INPUT, size)

        self.assertEqual(expected, len(actual))

    def test_solve_with_simple_input(self):
        """Tests the solve function using a simple input string."""
        expected = "1368"  # The sum of 123 + 456 + 789
        simple_input = "123456789"
        size = 3

        actual = solve(simple_input, size)

        self.assertEqual(expected, actual)

    def test_solve_with_actual_input(self):
        """Test that confirms the answer to the problem."""
        expected = "5537376230"
        size = 50

        actual = solve(INPUT, size)

        self.assertEqual(expected, actual)