"""https://projecteuler.net/problem=11"""

import unittest
from project_euler.problem_11 import diagonal_rd, product


class Problem11Test(unittest.TestCase):
    """Test fixture for problem 11."""

    def test_diagonal_rd(self):
        """Test that traverses grid right-down diagonally from."""
        depth = 4
        expected = [26, 63, 78, 14]
        position = (8, 6)

        actual = diagonal_rd(position, depth)

        self.assertListEqual(expected, actual)

    def test_product(self):
        """Tests that the product is calculated from a List of ints."""
        expected = 1788696
        numbers = [26, 63, 78, 14]

        actual = product(numbers)

        self.assertEqual(expected, actual)
