"""
Project Euler - Problem 7

By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

What is the 10 001st prime number?
"""

import math
import timeit

def is_prime_by_trial_division(number: int) -> bool:
    """
    Tests for primality by finding the factors of the number,
    and then checks if the only factor found is 1.

    Only numbers that are less than the square root of the number
    being checked are tested.

    This is a brute-force strategy.
    """
    trial_divisor = 1
    while trial_divisor <= math.sqrt(number):
        if number % trial_divisor == 0 and trial_divisor != 1:
            return False
        trial_divisor += 1

    return True

def print_last_prime(number_of_primes_to_count: int) -> None:
    """
    Counts the number of primes equal to the passed in integer
    and prints the last prime.
    """
    i = 1
    primes_counted = 0
    while primes_counted < number_of_primes_to_count:
        i += 1
        if is_prime_by_trial_division(i):
            primes_counted += 1
    print("Last prime: " + str(i))

if __name__ == "__main__":
    print("Project Euler - Problem 7")
    START_TIME = timeit.default_timer()
    print_last_prime(10001)
    END_TIME = timeit.default_timer()
    print("Time: " + str(END_TIME - START_TIME))
