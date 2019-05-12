"""https://projecteuler.net/problem=3"""

from math import ceil, sqrt
from project_euler.utilities.primality import is_prime


def solve(integer: int = 600851475143) -> int:
    """Solves problem 3.

    Finds the largest prime of the argument
    through trial division by checking
    if the factor is a prime. The factors are
    checked in reverse order and starts with
    the square root of the integer.

    Arguments:
        integer {int} -- The integer to be factored.
        Default is 600851475143

    Returns:
        int -- The largest prime factor of the integer if found.
    """
    prime = None
    upper_factor = ceil(sqrt(integer))
    for i in range(upper_factor, 0, -1):
        if integer % i == 0 and is_prime(i):
            prime = i
            break
    return prime
