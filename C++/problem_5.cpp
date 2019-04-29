/*
2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
*/
#include <iostream>

int main() {
  int result = 0;
  int constant = 10;
  for (int i = 9; i > 0; i--) {
    result += constant * i;
  }
  std::cout << "Result: " << result << std::endl;
}