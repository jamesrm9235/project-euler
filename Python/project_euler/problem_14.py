"""
https://projecteuler.net/problem=14
"""

from timeit import default_timer
from typing import List

def solve(number: int) -> int:
    """Solves problem 14.

    Iterates up to the number passed into this function and returns
    the number that has the longest Collatz sequence. To improve performance,
    integers that have had their Collatz sequence counted are stored in a
    dictionary to avoid counting that sequence again when that integer appears
    in another integer's Collatz sequence.

    Arguments:
        number {int} -- The integer to iterate up to.

    Returns:
        int -- The integer that has the longest Collatz sequence
    """
    answer = 0  # starting number that has the longest Collatz sequence
    max_length = 0
    counts = {}
    for i in range(1, number):
        length = 1  # initialized at 1 because i is included in the sequence
        current = i
        while current != 1:
            if current < i:  # avoids counting sequences that have already been counted
                length += counts[current]
                break
            elif current % 2 == 0:
                current //= 2
            else:
                current = (3 * current) + 1
            length += 1
        counts[i] = length
        if length > max_length:
            answer = i
            max_length = length
    return answer

if __name__ == "__main__":
    print("Problem 14 - Longest Collatz sequence")
    START = default_timer()
    ANSWER = solve(1000000)
    END = default_timer()
    print("Answer: {0}".format(ANSWER))
    print("Elapsed time: {0} seconds".format(END - START))
