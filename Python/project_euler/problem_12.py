"""https://projecteuler.net/problem=12"""

from math import ceil, sqrt
from typing import List


def solve(minimum_factors: int = 500):
    n = 1
    while True:
        factors = factorize(triangular_number(n))
        if len(factors) >= minimum_factors:
            break
        else:
            n += 1
    return triangular_number(n)


def triangular_number(n: int) -> int:
    """Uses an explicit formula to compute the nth triangular number.

    Arguments:
        n {int} -- The nth triangular number to compute.

    Returns:
        int -- The triangular number.
    """
    return int((n * (n + 1)) / 2)


def factorize(n: int) -> List[int]:
    factors = []
    for i in range(1, n):
        if n % i == 0:
            factors.append(i)
    factors.append(n)
    return factors

if __name__ == "__main__":
    print("Problem 12: Highly divisible triangular number")
    print(solve())
