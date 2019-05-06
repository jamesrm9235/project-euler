"""https://projecteuler.net/problem=3"""
from math import ceil, sqrt


def is_prime(integer: int) -> bool:
    """Checks whether the integer is prime.

    Evaluates whether the argument is a prime
    number by checking if each integer between
    2 and the square root of the argument is a
    factor.

    Arguments:
        integer {int} -- The integer to check for primality.

    Returns:
        bool -- True if the integer is prime otherwise False.
    """
    if integer == 1:
        return False
    divisor = 2
    while divisor <= sqrt(integer):
        if integer % divisor == 0:
            return False
        divisor += 1
    return True


def solve(integer: int) -> int:
    """Solves problem 3.

    Finds the largest prime of the argument
    through trial division by checking
    if the factor is a prime. The factors are
    checked in reverse order and starts with
    the square root of the integer.

    Arguments:
        integer {int} -- The integer to be factored.

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
