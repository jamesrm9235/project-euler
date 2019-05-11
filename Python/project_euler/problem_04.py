"""https://projecteuler.net/problem=4"""


def is_palindrome(integer: int) -> bool:
    """Checks if the integer is a palindrome.

    Arguments:
        integer {int} -- The integer to check.

    Returns:
        bool -- True if the integer is a palindrome otherwise False.
    """
    return str(integer) == reverse_integer(integer)


def reverse_integer(integer: int) -> str:
    """Reverses the order of the digits in an integer.

    Arguments:
        integer {int} -- The integer to be reversed.

    Returns:
        str -- A string of the reversed integer.
    """
    return str(integer)[::-1]


def solve() -> int:
    """Solves problem 4.

    Uses a nested for-loop to iterate from 999 to 100 and checks whether the product
    is a palindrome. The inner loop will not iterate to 99; it will iterate to the
    current value of the parent loop.

    Returns:
        int -- The largest product that is a palindrome.
    """
    largest_palindrome = 0
    for i in range(999, 99, -1):
        for j in range(999, i, -1):
            product = i * j
            if product <= largest_palindrome:
                break
            if is_palindrome(product):
                largest_palindrome = product
    return largest_palindrome
