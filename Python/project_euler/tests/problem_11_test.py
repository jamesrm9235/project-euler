"""https://projecteuler.net/problem=11"""

import unittest
from project_euler.problem_11 import (diagonal_ld, diagonal_lu, diagonal_rd, diagonal_ru,
                                      down, left, product, right, up)


class Problem11Test(unittest.TestCase):
    """Test fixture for problem 11."""

    def test_diagonal_ld(self):
        """Test that the grid is traversed left-down diagonally from the position."""
        depth = 4
        expected = [26, 20, 99, 0]
        position = (8, 6)

        actual = diagonal_ld(position, depth)

        self.assertListEqual(expected, actual)

    def test_diagonal_lu(self):
        """Test that the grid is traversed left-up diagonally from the position."""
        depth = 4
        expected = [26, 2, 63, 60]
        position = (8, 6)

        actual = diagonal_lu(position, depth)

        self.assertListEqual(expected, actual)

    def test_diagonal_rd(self):
        """Test that the grid is traversed right-down diagonally from the position."""
        depth = 4
        expected = [26, 63, 78, 14]
        position = (8, 6)

        actual = diagonal_rd(position, depth)

        self.assertListEqual(expected, actual)

    def test_diagonal_ru(self):
        """Test that the grid is traversed right-up diagonally from the position."""
        depth = 4
        expected = [26, 75, 36, 56]
        position = (8, 6)

        actual = diagonal_ru(position, depth)

        self.assertListEqual(expected, actual)

    def test_down(self):
        """Test that the grid is traversed downwards from the position."""
        depth = 4
        expected = [26, 95, 97, 20]
        position = (8, 6)

        actual = down(position, depth)

        self.assertListEqual(expected, actual)

    def test_left(self):
        """Test that the grid is traversed to the left from the position."""
        depth = 4
        expected = [26, 10, 67, 23]
        position = (8, 6)

        actual = left(position, depth)

        self.assertListEqual(expected, actual)

    def test_right(self):
        """Test that the grid is traversed to the right from the position."""
        depth = 4
        expected = [26, 38, 40, 67]
        position = (8, 6)

        actual = right(position, depth)

        self.assertListEqual(expected, actual)

    def test_up(self):
        """Test that the grid is traversed upwards from the position."""
        depth = 4
        expected = [26, 44, 41, 69]
        position = (8, 6)

        actual = up(position, depth)

        self.assertListEqual(expected, actual)

    def test_product(self):
        """Tests that the product is calculated from a List of ints."""
        expected = 1788696
        numbers = [26, 63, 78, 14]

        actual = product(numbers)

        self.assertEqual(expected, actual)
