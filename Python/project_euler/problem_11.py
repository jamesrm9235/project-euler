"""https://projecteuler.net/problem=11"""


from functools import reduce
from typing import List


def solve() -> int:
    """Solves problem 11.

    Iterates over each point in the grid and computes the product of
    4-adjacent digits from the point in eight directions:

    up, right-up diagonal, right, right-down diagonal,
    down, left-down diagonal, left, left-up diagonal

    Each product is stored in a list. When all points have been computed,
    the greatest point from the list is returned.

    Returns:
        int -- The greatest product formed by 4 adjacent numbers in any direction.
    """
    grid = Grid()
    depth = 4
    products = []
    for i in range(0, 20):
        for j in range(0, 20):
            products.append(product(grid.up((i, j), depth)))
            products.append(product(grid.right_up((i, j), depth)))
            products.append(product(grid.right((i, j), depth)))
            products.append(product(grid.right_down((i, j), depth)))
            products.append(product(grid.down((i, j), depth)))
            products.append(product(grid.left_down((i, j), depth)))
            products.append(product(grid.left((i, j), depth)))
            products.append(product(grid.left_up((i, j), depth)))

    return max(products)


def product(numbers: List[int]) -> int:
    """Calculates the product of the integers in the list.

    Arguments:
        numbers {List[int]} -- A list of integers.

    Returns:
        int -- The calculated product.
    """
    if not numbers:
        return 0
    return reduce(lambda x, y: x * y, numbers)


class Grid():
    """Represents the 20x20 grid in problem 11.

    This class exposes methods for traversing problem 11's grid.
    The grid is represented as a 2-dimensional list where each nested
    list is a column. An xy-position in the grid can be specified using a
    2-item tuple.

    Returns:
        [type] -- An object that exposes methods for traversing the grid.
    """

    def __init__(self):

        # Each nested List is a column.
        self.grid = [
            [8, 49, 81, 52, 22, 24, 32, 67, 24, 21, 78, 16, 86, 19, 4, 88, 4, 20, 20, 1],
            [2, 49, 49, 70, 31, 47, 98, 26, 55, 36, 17, 39, 56, 80, 52, 36, 42, 69, 73, 70],
            [22, 99, 31, 95, 16, 32, 81, 20, 58, 23, 53, 5, 0, 81, 8, 68, 16, 36, 35, 54],
            [97, 40, 73, 23, 71, 60, 28, 68, 5, 9, 28, 42, 48, 68, 83, 87, 73, 41, 29, 71],
            [38, 17, 55, 4, 51, 99, 64, 2, 66, 75, 22, 96, 35, 5, 97, 57, 38, 72, 78, 83],
            [15, 81, 79, 60, 67, 3, 23, 62, 73, 0, 75, 35, 71, 94, 35, 62, 25, 30, 31, 51],
            [0, 18, 14, 11, 63, 45, 67, 12, 99, 76, 31, 31, 89, 47, 99, 20, 39, 23, 90, 54],
            [40, 57, 29, 42, 89, 2, 10, 20, 26, 44, 67, 47, 7, 69, 16, 72, 11, 88, 1, 69],
            [0, 60, 93, 69, 41, 44, 26, 95, 97, 20, 15, 55, 5, 28, 7, 3, 24, 34, 74, 16],
            [75, 87, 71, 24, 92, 75, 38, 63, 17, 45, 94, 58, 44, 73, 97, 46, 94, 62, 31, 92],
            [4, 17, 40, 68, 36, 33, 40, 94, 78, 35, 3, 88, 44, 92, 57, 33, 72, 99, 49, 33],
            [5, 40, 67, 56, 54, 53, 67, 39, 78, 14, 80, 24, 37, 13, 32, 67, 18, 69, 71, 48],
            [7, 98, 53, 1, 22, 78, 59, 63, 96, 0, 4, 0, 44, 86, 16, 46, 8, 82, 48, 61],
            [78, 43, 88, 32, 40, 36, 54, 8, 83, 61, 62, 17, 60, 52, 26, 55, 46, 67, 86, 43],
            [52, 69, 30, 56, 40, 84, 70, 40, 14, 33, 16, 54, 21, 17, 26, 12, 29, 59, 81, 52],
            [12, 48, 3, 71, 28, 20, 66, 91, 88, 97, 14, 24, 58, 77, 79, 32, 32, 85, 16, 1],
            [50, 4, 49, 37, 66, 35, 18, 66, 34, 34, 9, 36, 51, 4, 33, 63, 40, 74, 23, 89],
            [77, 56, 13, 2, 33, 17, 38, 49, 89, 31, 53, 29, 54, 89, 27, 93, 62, 4, 57, 19],
            [91, 62, 36, 36, 13, 12, 64, 94, 63, 33, 56, 85, 17, 55, 98, 53, 76, 36, 5, 67],
            [8, 0, 65, 91, 80, 50, 70, 21, 72, 95, 92, 57, 58, 40, 66, 69, 36, 16, 54, 48]
        ]

    def up(self, position: tuple, depth: int) -> List[int]:
        """Finds the adjacent numbers upward from the position in the grid.

        Arguments:
            position {tuple} -- The xy coordinates of the number to begin searching from.
            depth {int} -- How far to search away from the position.

        Returns:
            List[int] -- A list of the upward adjacent numbers.
        """
        x_coord, y_coord = position
        if (y_coord - depth) - 1 < 0:
            return []
        return [self.grid[x_coord][y_coord - i] for i in range(0, depth)]

    def right_up(self, position: tuple, depth: int) -> List[int]:
        """Finds the right-up diagonally adjacent numbers from the position in the grid.

        Arguments:
            position {tuple} -- The xy coordinates of the number to begin searching from.
            depth {int} -- How far to search away from the position.

        Returns:
            List[int] -- A list of the right-up diagonally adjacent numbers.
        """
        x_coord, y_coord = position
        if (x_coord + depth) - 1 > 19 or (y_coord - depth) - 1 < 0:
            return []
        return [self.grid[x_coord + i][y_coord - i] for i in range(0, depth)]

    def right(self, position: tuple, depth: int) -> List[int]:
        """Finds the adjacent numbers to the right of the position in the grid.

        Arguments:
            position {tuple} -- The xy coordinates of the number to begin searching from.
            depth {int} -- How far to search away from the position.

        Returns:
            List[int] -- A list of the right adjacent numbers.
        """
        x_coord, y_coord = position
        if (x_coord + depth) - 1 > 19:
            return []
        return [self.grid[x_coord + i][y_coord] for i in range(0, depth)]

    def right_down(self, position: tuple, depth: int) -> List[int]:
        """Finds the right-down diagonally adjacent numbers from the position in the grid.

        Arguments:
            position {tuple} -- The xy coordinates of the number to begin searching from.
            depth {int} -- How far to search away from the position.

        Returns:
            List[int] -- A list of the right-down diagonally adjacent numbers.
        """
        x_coord, y_coord = position
        if (x_coord + depth) - 1 > 19 or (y_coord + depth) - 1 > 19:
            return []
        return [self.grid[x_coord + i][y_coord + i] for i in range(0, depth)]

    def down(self, position: tuple, depth: int) -> List[int]:
        """Finds the adjacent numbers downwards from the position in the grid.

        Arguments:
            position {tuple} -- The xy coordinates of the number to begin searching from.
            depth {int} -- How far to search away from the position.

        Returns:
            List[int] -- A list of the downward adjacent numbers.
        """
        x_coord, y_coord = position
        if (y_coord + depth) - 1 > 19:
            return []
        return [self.grid[x_coord][y_coord + i] for i in range(0, depth)]

    def left_down(self, position: tuple, depth: int) -> List[int]:
        """Finds the left-down diagonally adjacent numbers from the position in the grid.

        Arguments:
            position {tuple} -- The xy coordinates of the number to begin searching from.
            depth {int} -- How far to search away from the position.

        Returns:
            List[int] -- A list of the left-down diagonally adjacent numbers.
        """
        x_coord, y_coord = position
        if (x_coord - depth) - 1 < 0 or (y_coord + depth) - 1 > 19:
            return []
        return [self.grid[x_coord - i][y_coord + i] for i in range(0, depth)]

    def left(self, position: tuple, depth: int) -> List[int]:
        """Finds the adjacent numbers to the left of the position in the grid.

        Arguments:
            position {tuple} -- The xy coordinates of the number to begin searching from.
            depth {int} -- How far to search away from the position.

        Returns:
            List[int] -- A list of the left adjacent numbers.
        """
        x_coord, y_coord = position
        if (x_coord - depth) - 1 < 0:
            return []
        return [self.grid[x_coord - i][y_coord] for i in range(0, depth)]

    def left_up(self, position: tuple, depth: int) -> List[int]:
        """Finds the left-up diagonally adjacent numbers from the position in the grid.

        Arguments:
            position {tuple} -- The xy coordinates of the number to begin searching from.
            depth {int} -- How far to search away from the position.

        Returns:
            List[int] -- A list of the left-up diagonally adjacent numbers.
        """
        x_coord, y_coord = position
        if (x_coord - depth) - 1 < 0 or (y_coord - depth) - 1 < 0:
            return []
        return [self.grid[x_coord - i][y_coord - i] for i in range(0, depth)]
