"""Tests for the prime_utils utility module."""

import unittest
from project_euler.utilities.prime_utils import (is_prime,
                                                 prime_factorization,
                                                 sieve_of_eratosthenes)


class PrimeUtilsTest(unittest.TestCase):
    """Test fixture for the prime_utils utility module."""

    def test_sieve_of_eratosthenes(self):
        """Tests the Sieve of Eratosthenes implementation with a limit of 50."""
        expected = [2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47]
        limit = 50

        actual = sieve_of_eratosthenes(limit)

        self.assertListEqual(expected, actual)

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

    def test_prime_factorization(self):
        """Tests that 232792560 is decomposed to its prime factors."""
        expected = [2, 2, 2, 2, 3, 3, 5, 7, 11, 13, 17, 19]
        integer = 232792560

        actual = prime_factorization(integer)

        self.assertEqual(expected, actual)
