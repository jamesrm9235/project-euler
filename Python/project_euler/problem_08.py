"""https://projecteuler.net/problem=8"""

from typing import List

NUMBER_STRING = ("73167176531330624919225119674426574742355349194934"
                 "96983520312774506326239578318016984801869478851843"
                 "85861560789112949495459501737958331952853208805511"
                 "12540698747158523863050715693290963295227443043557"
                 "66896648950445244523161731856403098711121722383113"
                 "62229893423380308135336276614282806444486645238749"
                 "30358907296290491560440772390713810515859307960866"
                 "70172427121883998797908792274921901699720888093776"
                 "65727333001053367881220235421809751254540594752243"
                 "52584907711670556013604839586446706324415722155397"
                 "53697817977846174064955149290862569321978468622482"
                 "83972241375657056057490261407972968652414535100474"
                 "82166370484403199890008895243450658541227588666881"
                 "16427171479924442928230863465674813919123162824586"
                 "17866458359124566529476545682848912883142607690042"
                 "24219022671055626321111109370544217506941658960408"
                 "07198403850962455444362981230987879927244284909188"
                 "84580156166097919133875499200524063689912560717606"
                 "05886116467109405077541002256983155200055935729725"
                 "71636269561882670428252483600823257530420752963450")


def group_digits(size: int) -> List[str]:
    """Slices a string into a groups of adjacent digits.

    Slices a string internal to this module into groups
    of adjacent digits. The size of each group is determind
    by the size parameter.

    Arguments:
        size {int} -- The number of characters sliced into each group.

    Returns:
        List[str] -- The sliced groups returned as a list of strings.
    """
    return [NUMBER_STRING[i: i + size]
            for i in range(0, len(NUMBER_STRING))
            if len(NUMBER_STRING[i: i + size]) == size]


def solve(size: int = 13) -> int:
    """Solves problem 8.

    Iterates through a list of groups sliced from a long number string
    and computes the product of the digits in each group.

    Arguments:
        size {int} -- The size of the digit groups. Default is 13.

    Returns:
        int -- The largest product computed from a group.
    """
    groups = group_digits(size)
    greatest_product = 0
    for group in groups:
        product = 1
        for i in group:
            product *= int(i)
        if product > greatest_product:
            greatest_product = product
    return greatest_product
