"""https://projecteuler.net/problem=07"""

import unittest
from collections import namedtuple
from project_euler.problem_07 import solve


class Problem07Test(unittest.TestCase):
    """Test fixture for problem 07."""

    def test_solve_with_special_cases(self):
        """Tests solve with a count of 0, 1, 2, and 3."""
        Data = namedtuple("ArrangeData", "count expected")
        parameterized_data = [
            Data(count=0, expected=0),
            Data(count=1, expected=2),
            Data(count=2, expected=3),
            Data(count=3, expected=5)]
        for data in parameterized_data:
            with self.subTest(i=data.count):
                actual = solve(data.count)

                self.assertEqual(data.expected, actual)

    def test_solve_with_example_problem(self):
        """Tests the example in the problem description."""
        expected = 13
        count = 6

        actual = solve(count)

        self.assertEqual(expected, actual)

    def test_solve(self):
        """Test that solves the problem."""
        expected = 104743
        count = 10001

        actual = solve(count)

        self.assertEqual(expected, actual)
