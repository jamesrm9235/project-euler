"""https://projecteuler.net/problem=10"""

from project_euler.utilities.primality import is_prime


def solve(limit: int) -> int:
    """Solves problem 10.

    Computes the sum of all prime numbers less than the limit.
    Each number is tested for primality and added to a running
    sum if the number is prime.

    Arguments:
        limit {int} -- Integers less than this number will be tested for primality.

    Returns:
        int -- The sum of all primes less than the limit.
    """
    # TODO: Runs at ~13 sec when limit is 2 mil. Needs optimization.
    counter = 0
    result = 0
    while counter < limit:
        if is_prime(counter):
            result += counter
        counter += 1
    return result
