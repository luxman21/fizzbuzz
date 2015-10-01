#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <string.h>
#include <iostream>
using namespace std;

//BEGIN_CHALLENGE
struct data {
  int number;
  string fizzbuzz;
};
//END_CHALLENGE

void isFizzbuzz(int n) {
  //ここに素数判定プログラムを実装してください。
  //BEGIN_CHALLENGE

  data s[n+1];
  if (n % 15 == 0)      { s[n].fizzbuzz = "FizzBuzz"; printf("%s\n", s[n].fizzbuzz.c_str() );}
  else if (n % 5 == 0)  { s[n].fizzbuzz = "Buzz"; printf("%s\n", s[n].fizzbuzz.c_str() );}
  else if (n % 3 == 0)  { s[n].fizzbuzz = "Fizz"; printf("%s\n", s[n].fizzbuzz.c_str() );}
  else                  { s[n].number = n; printf("%d\n", s[n].number );}

  //END_CHALLENGE
}

int main(int argc, char *argv[])
{
  int arg1 = atoi(argv[1]);
  if (argc != 2) {
    printf("usage: ./a.out <number>\n");
    return 1;
  }
  isFizzbuzz(arg1);
  return 0;
}
