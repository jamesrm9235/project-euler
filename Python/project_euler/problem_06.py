"""https://projecteuler.net/problem=6"""


def sum_of_squares(count: int) -> int:
    result = 0
    for i in range(1, count + 1):
        result += i ** 2
    return result


def square_of_sum(count: int) -> int:
    result = 0
    for i in range(1, count + 1):
        result += i
    return result ** 2


def solve(count: int = 100) -> int:
    return square_of_sum(count) - sum_of_squares(count)
