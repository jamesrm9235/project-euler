"""
2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
"""
import math

def solve(number):
    primes = get_prime_numbers(number)
    answer = 1
    results = []
    for prime in primes:
        print prime
        lastProduct = prime
        power = 2
        while lastProduct <= number:
            product = math.pow(prime, power)
            if product > number:
                power = 2
                results.append(lastProduct)
                answer *= lastProduct
                break
            else:
                lastProduct = product
                power += 1
    print answer
    return results


def get_prime_numbers(number):
    i = 2
    primes = []
    while i <= number:
        if is_prime(i) == True:
            primes.append(i)
        i += 1
    return primes

def get_prime_factors(number):
    n = number
    factors = []
    factor = 2
    while n > 1:
        if n % factor == 0:
            factors.append(factor)
            n /= factor
            while n % factor == 0:
                factors.append(factor)
                n /= factor
        factor += 1
    return factors

def is_prime(number):
    """
    Tests a number for primality.
    """
    trial_divisor = 2
    while trial_divisor <= math.sqrt(number):
        if number % trial_divisor == 0:
            return False
        trial_divisor += 1
    return True

if __name__ == "__main__":
    print get_prime_numbers(10)
    print get_prime_numbers(20)
    print solve(20)
