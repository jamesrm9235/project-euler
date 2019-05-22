"""https://projecteuler.net/problem=11"""

import unittest
from project_euler.problem_11 import Grid, product


class Problem11Test(unittest.TestCase):
    """Test fixture for problem 11."""

    def test_diagonal_ld(self):
        """Test that the grid is traversed left-down diagonally from the position."""
        depth = 4
        expected = [26, 20, 99, 0]
        grid = Grid()
        position = (8, 6)

        actual = grid.diagonal_ld(position, depth)

        self.assertListEqual(expected, actual)

    def test_diagonal_ld_with_exceeding_depth(self):
        """Test that diagonal left-down does not raise an IndexError when the depth exceeds the grid."""
        depth = 4
        expected = []
        grid = Grid()
        parameterized_data = [(0, 19), (1, 18), (2, 17)]
        for position in parameterized_data:
            with self.subTest(i=position):
                actual = grid.diagonal_ld(position, depth)

                self.assertListEqual(expected, actual)

    def test_diagonal_lu(self):
        """Test that the grid is traversed left-up diagonally from the position."""
        depth = 4
        expected = [26, 2, 63, 60]
        grid = Grid()
        position = (8, 6)

        actual = grid.diagonal_lu(position, depth)

        self.assertListEqual(expected, actual)

    def test_diagonal_lu_with_exceeding_depth(self):
        """Test that diagonal left-up does not raise an IndexError when the depth exceeds the grid."""
        depth = 4
        expected = []
        grid = Grid()
        parameterized_data = [(0, 0), (1, 1), (2, 2)]
        for position in parameterized_data:
            with self.subTest(i=position):
                actual = grid.diagonal_lu(position, depth)

                self.assertListEqual(expected, actual)

    def test_diagonal_rd(self):
        """Test that the grid is traversed right-down diagonally from the position."""
        depth = 4
        expected = [26, 63, 78, 14]
        grid = Grid()
        position = (8, 6)

        actual = grid.diagonal_rd(position, depth)

        self.assertListEqual(expected, actual)

    def test_diagonal_rd_with_exceeding_depth(self):
        """Test that diagonal right-down does not raise an IndexError when the depth exceeds the grid."""
        depth = 4
        expected = []
        grid = Grid()
        parameterized_data = [(19, 19), (18, 18), (17, 17)]
        for position in parameterized_data:
            with self.subTest(i=position):
                actual = grid.diagonal_rd(position, depth)

                self.assertListEqual(expected, actual)

    def test_diagonal_ru(self):
        """Test that the grid is traversed right-up diagonally from the position."""
        depth = 4
        expected = [26, 75, 36, 56]
        grid = Grid()
        position = (8, 6)

        actual = grid.diagonal_ru(position, depth)

        self.assertListEqual(expected, actual)

    def test_diagonal_ru_with_exceeding_depth(self):
        """Test that diagonal right-up does not raise an IndexError when the depth exceeds the grid."""
        depth = 4
        expected = []
        grid = Grid()
        parameterized_data = [(19, 0), (18, 1), (17, 2)]
        for position in parameterized_data:
            with self.subTest(i=position):
                actual = grid.diagonal_ru(position, depth)

                self.assertListEqual(expected, actual)

    def test_down(self):
        """Test that the grid is traversed downwards from the position."""
        depth = 4
        expected = [26, 95, 97, 20]
        grid = Grid()
        position = (8, 6)

        actual = grid.down(position, depth)

        self.assertListEqual(expected, actual)

    def test_down_with_exceeding_depth(self):
        """Test that down does not raise an IndexError when the depth exceeds the grid."""
        depth = 4
        expected = []
        grid = Grid()
        parameterized_data = [(0, 19), (0, 18), (0, 17)]
        for position in parameterized_data:
            with self.subTest(i=position):
                actual = grid.down(position, depth)

                self.assertListEqual(expected, actual)

    def test_left(self):
        """Test that the grid is traversed to the left from the position."""
        depth = 4
        expected = [26, 10, 67, 23]
        grid = Grid()
        position = (8, 6)

        actual = grid.left(position, depth)

        self.assertListEqual(expected, actual)

    def test_left_with_exceeding_depth(self):
        """Test that left does not raise an IndexError when the depth exceeds the grid."""
        depth = 4
        expected = []
        grid = Grid()
        parameterized_data = [(0, 0), (1, 0), (2, 0)]
        for position in parameterized_data:
            with self.subTest(i=position):
                actual = grid.left(position, depth)

                self.assertListEqual(expected, actual)

    def test_right(self):
        """Test that the grid is traversed to the right from the position."""
        depth = 4
        expected = [26, 38, 40, 67]
        grid = Grid()
        position = (8, 6)

        actual = grid.right(position, depth)

        self.assertListEqual(expected, actual)

    def test_right_with_exceeding_depth(self):
        """Test that right does not raise an IndexError when the depth exceeds the grid."""
        depth = 4
        expected = []
        grid = Grid()
        parameterized_data = [(19, 0), (18, 0), (17, 0)]
        for position in parameterized_data:
            with self.subTest(i=position):
                actual = grid.right(position, depth)

                self.assertListEqual(expected, actual)

    def test_up(self):
        """Test that the grid is traversed upwards from the position."""
        depth = 4
        expected = [26, 44, 41, 69]
        grid = Grid()
        position = (8, 6)

        actual = grid.up(position, depth)

        self.assertListEqual(expected, actual)

    def test_up_with_exceeding_depth(self):
        """Test that up does not raise an IndexError when the depth exceeds the grid."""
        depth = 4
        expected = []
        grid = Grid()
        parameterized_data = [(0, 0), (0, 1), (0, 2)]
        for position in parameterized_data:
            with self.subTest(i=position):
                actual = grid.up(position, depth)

                self.assertListEqual(expected, actual)

    def test_product(self):
        """Tests that the product is calculated from a List of ints."""
        expected = 1788696
        numbers = [26, 63, 78, 14]

        actual = product(numbers)

        self.assertEqual(expected, actual)
