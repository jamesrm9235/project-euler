"""https://projecteuler.net/problem=1"""


def solve(count: int) -> int:
    """Computes the sum of all multiples of 3 or 5 less than the count.

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
        if is_multiple(i, 3) or is_multiple(i, 5):
            result += i
    return result


def is_multiple(integer: int, divisor: int) -> bool:
    """Evaluates whether an integer is a multiple of another.

    Arguments:
        integer {int} -- The integer to test. Must be a natural number.
        divisor {int} -- The divsor to divide the integer by. Must be a natural number.

    Raises:
        ValueError: Raised if either the integer or divisor are equal to zero.

    Returns:
        bool -- True if the integer is a multiple otherwise False.
    """
    if integer == 0:
        raise ValueError("The integer cannot be zero.")
    elif divisor == 0:
        raise ValueError("The divisor cannot be zero.")

    return integer % divisor == 0
