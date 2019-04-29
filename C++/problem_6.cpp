/*
The sum of the squares of the first ten natural numbers is,
1^2 + 2^2 + ... + 10^2 = 385

The square of the sum of the first ten natural numbers is,
(1 + 2 + ... + 10)^2 = 55^2 = 3025

Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
*/
#include <cmath>
#include <iostream>

using namespace std;

int partialSum(int n);

int main() {
  int limit = 10;
  int sumOfSquares = 0;
  int sum = partialSum(limit);
  for (int i = 1; i <= limit; i++) {
    sumOfSquares += pow(i, 2);
  }

  cout << "Sum: " << sum << endl;
  cout << "Sum of squares: " << sumOfSquares << endl;
  // int squareOfSum = pow(sum, 2);
  // int difference = squareOfSum - sumOfSquares;
  // cout << "Difference --> " << difference << endl;
  // cout << "Sum: " << 10 * (10 + 1) / 2 << endl;
}

int partialSum(int n) {
  return n * (n + 1) / 2;
}
