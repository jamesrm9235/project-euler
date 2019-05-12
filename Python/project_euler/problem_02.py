"""https://projecteuler.net/problem=2"""


def solve(maximum: int = 4000000) -> int:
    """Solves problem 2.

    Generates terms in the Fibonacci series without exceeding
    the maximum, and if a term is even, it is added to a running
    sum of even terms.

    Arguments:
        maximum {int} -- If the next term in the series
        would exceed this value, the series will terminate.
        Default is 4000000.

    Returns:
        int -- The sum of all even terms in the series up to the maximum.
    """
    result = 0
    prev = 1
    lead = 2
    intermediate = None
    while lead <= maximum:
        if lead % 2 == 0:
            result += lead
        intermediate = lead
        lead += prev
        prev = intermediate
    return result
