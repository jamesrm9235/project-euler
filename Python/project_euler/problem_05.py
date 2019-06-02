"""https://projecteuler.net/problem=5"""

from functools import reduce
from project_euler.utilities.prime_utils import prime_factorization


def solve(count: int = 20) -> int:
    """Solves problem 5.

    The least common multiple of all numbers between 2 and the count
    is found by finding the minimum number of prime factors necessary
    to form each number between 2 and the count.

    Keyword Arguments:
        count {int} -- The number of integers to count. (default: {20})

    Returns:
        int -- The least common multiple of all numbers between 1 and the count.
    """
    common_prime_factors = []
    for i in range(2, count + 1):
        primes = prime_factorization(i)
        for j in primes:
            if j in common_prime_factors:
                if primes.count(j) > common_prime_factors.count(j):
                    while common_prime_factors.count(j) != primes.count(j):
                        common_prime_factors.append(j)
                break
            else:
                common_prime_factors.append(j)
    return reduce(lambda x, y: x * y, common_prime_factors)
