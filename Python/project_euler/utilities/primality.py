"""Utility functions for operations relating to prime numbers."""

from math import ceil, sqrt


def is_prime(integer: int) -> bool:
    """Checks whether the integer is a prime by trial division.

    Arguments:
        integer {int} -- The integer to check for primality.

    Returns:
        bool -- True if the integer is prime otherwise False.
    """
    if integer <= 1:
        return False

    if integer == 2 or integer == 3:
        return True

    if integer % 2 == 0:
        return False

    for divisor in range(3, ceil(sqrt(integer)) + 2, 2):
        if integer % divisor == 0:
            return False
    return True
