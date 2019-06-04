"""https://projecteuler.net/problem=15"""


class Lattice:

    def __init__(self, width, height):
        self.width = width
        self.height = height

        self.lattice = []
        for row in range(height):
            self.lattice.append([])
            for column in range(width):
                self.lattice[row].append(".")

    def print_lattice(self):
        for row in range(self.height):
            output = ""
            for column in range(self.width):
                output += self.lattice[row][column]
            print(output)


if __name__ == "__main__":
    print("Problem 15: Lattice paths")
    l = Lattice(3, 3)
    l.print_lattice()
