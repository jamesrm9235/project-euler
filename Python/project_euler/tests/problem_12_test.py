"""https://projecteuler.net/problem=12"""

import unittest
from collections import namedtuple
from project_euler.problem_12 import solve, triangular_number


class Problem12Test(unittest.TestCase):
    """Test fixture for problem 12."""

    def test_triangular_number(self):
        """Test that the first seven triangular numbers are generated."""
        Case = namedtuple("Case", "parameter expected")
        parameterized_cases = [
            Case(1, 1),
            Case(2, 3),
            Case(3, 6),
            Case(4, 10),
            Case(5, 15),
            Case(6, 21),
            Case(7, 28)
        ]
        for case in parameterized_cases:
            with self.subTest(i=case.parameter):
                actual = triangular_number(case.parameter)

                self.assertEqual(case.expected, actual)

    # def test_solve_with_example_problem(self):
    #     """Tests the example in the problem description."""
    #     expected = 28
    #     minimum_factors = 5

    #     actual = solve(minimum_factors)

    #     self.assertEqual(expected, actual)
