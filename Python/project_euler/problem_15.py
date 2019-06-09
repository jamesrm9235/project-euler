"""https://projecteuler.net/problem=15"""

from math import factorial

def solve(width: int, height: int):
    total_moves = width + height
    return binomial_coefficient(total_moves, width)


def binomial_coefficient(possibilities: int, pick: int) -> int:
    return factorial(possibilities) / (factorial(pick) * factorial((possibilities - pick)))


class Lattice:

    @classmethod
    def create_problem15_lattice(cls):
        """Factory function for creating a 20x20 lattice.

        Returns:
            [Lattice] -- A lattice with 20x20 dimensions.
        """
        return cls(20, 20)

    def __init__(self, width: int, height: int):
        self.width = width
        self.height = height

        self._lattice = []
        for row in range(height + 1):  # Offset by 1
            self._lattice.append([])
            for column in range(width + 1):  # Offset by 1
                self._lattice[row].append(".")

    def print_lattice(self):
        for row in range(self.height + 1):
            output = ""
            for column in range(self.width + 1):
                output += self._lattice[row][column] + " "
            print(output)

    def reset_lattice(self):
        pass

    def mark(self, point) -> bool:
        try:
            self._lattice[point[0]][point[1]] = "*"
            return True
        except IndexError:
            return False

    def find_paths(self, start):
        paths = []
        for row in range(self.height + 1):
            for column in range(self.width + 1):
                self.mark((row, column))

        self.print_lattice()
        paths.append(self._lattice)
        return paths

    def trace_perimeter(self):
        row = 0
        for column in range(self.width + 1):
            self.mark((row, column))

        column = self.width
        for row in range(self.height + 1):
            self.mark((row, column))
        self.print_lattice()

    def trace_middle(self):
        row = 0
        column = 0
        self.mark((row, column))
        for x in range(self.height + 1):
            column += 1
            self.mark((row, column))

            row += 1
            self.mark((row, column))
        self.print_lattice()


if __name__ == "__main__":
    print("Problem 15: Lattice paths")
    print(solve(20, 20))
