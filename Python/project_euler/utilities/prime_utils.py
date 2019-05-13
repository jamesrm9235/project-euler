"""Utility functions for operations relating to prime numbers."""

from math import ceil, sqrt
from typing import List


def sieve_of_eratosthenes(limit: int) -> List[int]:
    """Finds all primes up to the limit using the Sieve of Eratosthenes.

    Arguments:
        limit {int} -- The primes beneath this integer will be returned.

    Returns:
        List[int] -- A list of primes less than the limit.
    """
    sieve = [i for i in range(2, limit + 1)]
    primes = []
    prime = 2

    while prime ** 2 < limit:  # Multiples below prime squared will be removed.
        for i in range(prime, limit + 1):
            multiple = prime * i
            if multiple > limit:
                break
            if multiple in sieve:
                sieve.remove(multiple)

        # TODO Append to primes outside of while loop.
        primes.append(sieve[0])
        sieve.pop(0)
        prime = sieve[0]
    primes.extend(sieve)
    return primes


def is_prime(integer: int) -> bool:
    """Checks whether the integer is a prime by trial division.

    The function will test divisors that are either one more
    or one less than a multiple of six (i.e. 6n+1 and 6n-1)
    in order to skip numbers that are multiples of 2 or 3.

    Arguments:
        integer {int} -- The integer to check for primality.

    Returns:
        bool -- True if the integer is prime otherwise False.
    """
    if integer <= 1:
        return False
    if integer in (2, 3):
        return True
    if integer % 2 == 0 or integer % 3 == 0:
        return False

    divisor = 5
    limit = ceil(sqrt(integer))
    while divisor <= limit:
        if integer % divisor == 0:
            return False
        divisor += 2  # Set to a number one more than a multiple of six.
        if integer % divisor == 0:
            return False
        divisor += 4  # Set to a number one less than a multiple of six.
    return True
