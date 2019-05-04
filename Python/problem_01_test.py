"""https://projecteuler.net/problem=1"""
from random import randint
import unittest
from problem_01 import is_multiple, solve


class Problem01Test(unittest.TestCase):
    """The test fixture for problem 01."""

    def test_is_multiple_raises_value_error_when_integer_is_zero(self):
        """A ValueError is raised when integer is zero."""
        integer = 0
        divisor = randint(1, 10)

        self.assertRaises(ValueError, is_multiple, integer, divisor)

    def test_is_multiple_raises_value_error_when_divisor_is_zero(self):
        """A ValueError is raised when divisor is zero."""
        integer = randint(1, 10)
        divisor = 0

        self.assertRaises(ValueError, is_multiple, integer, divisor)

    def test_is_multiple_returns_true_when_integer_is_multiple_of_3(self):
        """Tests that an integer under 10 is a multiple of 3."""
        multiples = [3, 6, 9]
        for i in multiples:
            with self.subTest(i=i):
                integer = i
                divisor = 3

                actual = is_multiple(integer, divisor)

                self.assertTrue(actual)

    def test_is_multiple_returns_true_when_integer_is_multiple_of_5(self):
        """Tests that an integer under 10 is a multiple of 5."""
        multiples = [5]
        for i in multiples:
            with self.subTest(i=i):
                integer = i
                divisor = 5

                actual = is_multiple(integer, divisor)

                self.assertTrue(actual)

    def test_solve_raises_value_error_when_count_is_less_than_or_equal_to_zero(self):
        """Raises ValueError when the count is less than or equal to zero."""
        count = randint(-10, 0)

        self.assertRaises(ValueError, solve, count)

    def test_solve_returns_23_when_count_is_10(self):
        """Tests the example in the problem description."""
        count = 10
        expected = 23

        actual = solve(count)

        self.assertEqual(expected, actual)

    def test_solve_returns_233168_when_count_is_1000(self):
        """Test that returns the answer to the problem."""
        count = 1000
        expected = 233168

        actual = solve(count)

        self.assertEqual(expected, actual)
