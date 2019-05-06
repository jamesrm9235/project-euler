"""https://projecteuler.net/problem=3"""
import unittest
from project_euler.problem_03 import is_prime, solve


class Problem03Test(unittest.TestCase):
    """The test fixture for problem 03."""

    def test_is_prime_with_1(self):
        """Returns False when the number is 1."""
        number = 1

        actual = is_prime(number)

        self.assertFalse(actual)

    def test_is_prime_with_primes(self):
        """Test that is_prime returns True for prime numbers less than 10."""
        known_primes = [2, 3, 5, 7]
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

    def test_solve_with_example_problem(self):
        """Tests the example in the problem description."""
        expected = 29
        number = 13195

        actual = solve(number)

        self.assertEqual(expected, actual)

    def test_solve_with_600851475143(self):
        """Test that returns the answer to the problem."""
        expected = 6857
        number = 600851475143

        actual = solve(number)

        self.assertEqual(expected, actual)
