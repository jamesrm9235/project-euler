"""https://projecteuler.net/problem=3"""
import math


def find_largest_prime_factor(number):
    """
    Finds the factors of the number
    and then tests each one for primality
    and returns the largest prime factor.
    """
    factors = trial_division(number)
    for factor in factors[::-1]:
        if is_prime(factor):
            return factor


def trial_division(number):
    """
    Uses brute-force to find factors
    that are divisors of the number.
    """
    factors = []
    trial_divisor = 1
    while trial_divisor <= math.sqrt(number):
        if number % trial_divisor == 0:
            factors.append(trial_divisor)
        trial_divisor += 1
    return factors


def is_prime(number: int) -> bool:
    """Checks whether the number is prime.

    Evaluates whether the number is prime
    by computing its factors by trial division
    and checking that one is the only factor.

    Arguments:
        number {int} -- The number to check for primality.

    Returns:
        bool -- True if the number is prime otherwise False.
    """
    if number == 1:
        return False

    factors = trial_division(number)
    return len(factors) == 1 and factors[0] == 1