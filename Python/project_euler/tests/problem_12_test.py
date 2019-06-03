"""https://projecteuler.net/problem=12"""

import unittest
from collections import namedtuple
from project_euler.problem_12 import factor_count, solve, triangular_number


class Problem12Test(unittest.TestCase):
    """Test fixture for problem 12."""

    def test_factor_count(self):
        """Test that the expected number of factors is returned for each number."""
        Data = namedtuple("Data", "number expected")
        parameterized_data = [
            Data(number=1, expected=1),
            Data(number=3, expected=2),
            Data(number=6, expected=4),
            Data(number=10, expected=4),
            Data(number=15, expected=4),
            Data(number=21, expected=4),
            Data(number=28, expected=6)
        ]
        for data in parameterized_data:
            with self.subTest(i=data.number):
                actual = factor_count(data.number)

                self.assertEqual(data.expected, actual)

    def test_solve_with_example_problem(self):
        """Tests the example in the problem description."""
        expected = 28
        minimum_factors = 5

        actual = solve(minimum_factors)

        self.assertEqual(expected, actual)

    def test_solve(self):
        """Test that confirms the answer to the problem."""
        expected = 76576500

        actual = solve()

        self.assertEqual(expected, actual)

    def test_triangular_number(self):
        """Tests that the first seven triangle numbers are generated."""
        Data = namedtuple("Data", "n expected")
        parameterized_data = [
            Data(n=1, expected=1),
            Data(n=2, expected=3),
            Data(n=3, expected=6),
            Data(n=4, expected=10),
            Data(n=5, expected=15),
            Data(n=6, expected=21),
            Data(n=7, expected=28),
        ]
        for data in parameterized_data:
            with self.subTest(i=data.n):
                actual = triangular_number(data.n)

                self.assertEqual(data.expected, actual)
