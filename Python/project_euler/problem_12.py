"""https://projecteuler.net/problem=12"""

from project_euler.utilities.prime_utils import prime_factorization


def factor_count(integer: int) -> int:
    """Computes the number of factors in the integer.

    The function uses prime factorization to find the count of factors in the integer. It will find
    the integer's prime factors, and then increase the exponent of each prime by one, and multiply
    the raised numbers.

    Arguments:
        integer {int} -- The integer whose count of factors to find.

    Returns:
        int -- The number of factors of the integer.
    """
    prime_factors = prime_factorization(integer)
    number_of_factors = 1
    for i in set(prime_factors):
        number_of_factors *= prime_factors.count(i) + 1
    return number_of_factors


def solve(minimum_factors: int = 500):
    """Solves problem 12.

    Keyword Arguments:
        minimum_factors {int} -- The function will return once a trianglur number who has a number
        of factors greater than or equal to this number is found. (default: {500})

    Returns:
        [type] -- The triangular number with a number of factors greater than or equal to the
        minimum number passed into this function.
    """
    n = 1
    while True:
        triangle_number = triangular_number(n)
        factors = factor_count(triangle_number)
        if factors >= minimum_factors:
            return triangle_number
        else:
            n += 1


def triangular_number(n: int) -> int:
    """Uses an explicit formula to compute the nth triangular number.

    Arguments:
        n {int} -- The nth triangular number to compute.

    Returns:
        int -- The triangular number.
    """
    return int((n * (n + 1)) / 2)


if __name__ == "__main__":
    print("Problem 12: Highly divisible triangular number")
    print(solve())
