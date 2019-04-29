/*
If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Find the sum of all the multiples of 3 or 5 below 1000.
*/
#include <iostream>

using namespace std;

bool isMultipleOfThree(int naturalNumber)
{
  return naturalNumber % 3 == 0;
}

bool isMultipleOfFive(int naturalNumber)
{
  return naturalNumber % 5 == 0;
}

int main()
{
  int sum = 0;
  int max = 1000;
  for (int i = 0; i < max; i++)
  {
    if (isMultipleOfThree(i) || isMultipleOfFive(i))
    {
      sum += i;
    }
  }
  cout << "Answer: " << sum << endl;
}
