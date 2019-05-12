"""https://projecteuler.net/problem=4"""

import unittest
from project_euler.problem_04 import is_palindrome, reverse_integer, solve


class Problem04Test(unittest.TestCase):
    """Test fixture for problem 04."""

    def test_is_palindrome_returns_true(self):
        """Tests that palindromes return True."""
        integer = 12321

        actual = is_palindrome(integer)

        self.assertTrue(actual)

    def test_is_palindrome_returns_false(self):
        """Tests that non-palindromes return False."""
        integer = 12345

        actual = is_palindrome(integer)

        self.assertFalse(actual)

    def test_reverse_integer(self):
        """Tests that the order of digits in the integer are reversed and returned as a string."""
        expected = "54321"
        integer = 12345

        actual = reverse_integer(integer)

        self.assertIsInstance(actual, str)
        self.assertEqual(expected, actual)

    def test_solve(self):
        """Test that confirms the answer to the problem."""
        expected = 906609

        actual = solve()

        self.assertEqual(expected, actual)
