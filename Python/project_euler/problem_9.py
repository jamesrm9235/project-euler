"""
A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
a**2 + b**2 = c**2

For example, 3**2 + 4**2 = 9 + 16 = 25 = 5**2.

There exists exactly one Pythagorean triplet for which a + b + c = 1000.
Find the product abc.
"""

from math import gcd
from typing import List

def generate_primitive_triple(arg_m: int, arg_n: int) -> tuple:
    """
    Generates a Pythagorean triple from the integers using Euclid's formula.
    """
    if gcd(arg_m, arg_n) != 1:  # Both integers must be coprime
        return None
    if arg_m < arg_n or arg_n < 0:  # Euclid's formula requires that m>n>0
        return None

    arg_a = arg_m**2 - arg_n**2
    arg_b = 2 * arg_m * arg_n
    arg_c = arg_m**2 + arg_n**2

    if arg_m % 2 != 0 and arg_n % 2 != 0:  # Divide by 2 to make the triple a primitive
        arg_a /= 2
        arg_b /= 2
        arg_c /= 2
    return int(arg_a), int(arg_b), int(arg_c) if arg_a**2 + arg_b**2 == arg_c**2 else None

def find_pythagorean_triples(greatest_c: int) -> List[tuple]:
    """
    """
    triples = []
    for arg_m in range(1, greatest_c + 1):
        if arg_m % 3 != 0 and arg_m % 4 != 0 and arg_m % 5 != 0:
            continue
        else:
            for arg_n in range(1, arg_m):
                if arg_m % 3 != 0 and arg_m % 4 != 0 and arg_m % 5 != 0:
                    continue
                else:
                    triple = generate_primitive_triple(arg_m, arg_n)
                    if triple is not None:
                        print(triple)
                        break


    # for arg_c in range(1, greatest_c + 1):
    #     for arg_m in range(arg_c):
    #         for arg_n in range(arg_m):
    #             triple = generate_primitive_triple(arg_m, arg_n)
    #             if triple is not None and triple[2] == arg_c:
    #                 triple_found = True
    #                 triples.append(triple)
    #                 break
    #         if triple_found:
    #             triple_found = False
    #             break
    return triples

if __name__ == "__main__":
    print("Project Euler - Problem 9")
    # print(generate_primitive_triple(3, 2))
    TRIPLES = find_pythagorean_triples(17)
    print(TRIPLES)
