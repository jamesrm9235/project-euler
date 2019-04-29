"""
The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ?
"""
import math
import timeit

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

def is_prime(number):
    """
    Finds the factors of the number
    and tests that the only factor is 1.
    """
    factors = trial_division(number)
    return len(factors) == 1 and factors[0] == 1

if __name__ == "__main__":
    start = timeit.default_timer()
    print find_largest_prime_factor(600851475143)
    end = timeit.default_timer()
    print end - start