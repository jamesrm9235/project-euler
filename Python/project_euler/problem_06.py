"""https://projecteuler.net/problem=6"""


def solve(count: int = 100) -> int:
    """Solves problem 6.

    Calculates the sum of the squares and square of the sum
    of a number of integers equal to the count, and then
    returns the difference between the square of sum and
    sum of squares.

    Keyword Arguments:
        count {int} -- The number of integers, from 1, to count. (default: {100})

    Returns:
        int -- The difference between the sum of the squares and the square of the sum.
    """
    return square_of_sum(count) - sum_of_squares(count)


def square_of_sum(count: int) -> int:
    """Calculates and squares the sum of the numbers from 1 and the count (inclusive).

    Arguments:
        count {int} -- The number of integers to be summed beginning at 1.

    Returns:
        int -- The square of the sum.
    """
    return sum([i for i in range(count + 1)]) ** 2


def sum_of_squares(count: int) -> int:
    """Calculates the sum of the square of each integer between 1 and the count (inclusive).

    Arguments:
        count {int} -- The number of integers, from 1, that will be squared and then summed.

    Returns:
        int -- The sum of the squares.
    """
    return sum([i ** 2 for i in range(count + 1)])
