"""https://projecteuler.net/problem=7"""

from project_euler.utilities.primality import is_prime


def solve(count: int = 10001) -> int:
    """Solves problem 7.

    Counts prime numbers up to the count and stops
    counting once the function has counted primes
    equaling the passed in count.

    Arguments:
        count {int} -- The number of prime numbers to count.
        Default is 10001.

    Returns:
        int -- The last prime number that was counted.
    """
    if count <= 0:
        return 0
    if count == 1:
        return 2
    if count == 2:
        return 3

    n_odd = 5
    primes_counted = 3
    while primes_counted < count:
        n_odd += 2
        if is_prime(n_odd):
            primes_counted += 1
    return n_odd
