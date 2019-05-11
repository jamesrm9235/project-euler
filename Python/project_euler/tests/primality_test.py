"""Tests for the primality utility module."""

import unittest
from project_euler.utilities.primality import is_prime


class PrimalityTest(unittest.TestCase):
    """Test fixture for the primality utility module."""

    def test_is_prime_with_lte_1(self):
        """Test that False is returned when the number is a number less than or equal to 1."""
        not_primes = [-1, 0, 1]
        for not_prime in not_primes:
            with self.subTest(i=not_prime):
                number = not_prime

                actual = is_prime(number)

                self.assertFalse(actual)

    def test_is_prime_with_primes(self):
        """Test that is_prime returns True for the first primes less than 20."""
        known_primes = [2, 3, 5, 7, 11, 13, 17, 19]
        for prime in known_primes:
            with self.subTest(i=prime):
                number = prime

                actual = is_prime(number)

                self.assertTrue(actual)

    def test_is_prime_with_not_primes(self):
        """Test that is_prime returns False for non-prime numbers less than 10."""
        not_primes = [4, 6, 8, 9]
        for not_prime in not_primes:
            with self.subTest(i=not_prime):
                number = not_prime

                actual = is_prime(number)

                self.assertFalse(actual)
