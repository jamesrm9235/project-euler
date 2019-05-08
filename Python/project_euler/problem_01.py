"""https://projecteuler.net/problem=1"""


def solve(count: int) -> int:
    """Solves problem 1.

    Computes the sum of all multiples of 3 or 5 less than the count.

    Arguments:
        count {int} -- The number of integers to count.

    Raises:
        ValueError: Raised if the count is less than or equal to zero.

    Returns:
        int -- The computed sum.
    """
    if count <= 0:
        raise ValueError("The count must be a natural number greater than 0.")
    result = 0
    for i in range(1, count):
        if i % 3 == 0 or i % 5 == 0:
            result += i
    return result
