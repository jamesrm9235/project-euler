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
