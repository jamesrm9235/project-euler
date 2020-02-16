"""
https://projecteuler.net/problem=14
"""

import unittest
from Python.project_euler.problem_14 import solve

class Problem14Test(unittest.TestCase):

    def test_problem_14_solution(self):
        expected = 837799
        start = 1000000

        actual = solve(start)

        self.assertEqual(expected, actual)