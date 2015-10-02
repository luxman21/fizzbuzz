#include <stdlib.h>
#include <math.h>
#include <string>
#include <iostream>
#include <sstream>
using namespace std;

string fizzbuzz(int n) {
  //ここに素数判定プログラムを実装してください。
  //BEGIN_CHALLENGE

  string data;
  ostringstream oss;
  if (n % 15 == 0)      { data = "FizzBuzz"; }
  else if (n % 5 == 0)  { data = "Buzz"; }
  else if (n % 3 == 0)  { data = "Fizz"; }
  else                  { oss<< n; data = oss.str() ; }

  return data;
  //END_CHALLENGE
}

int main(int argc, char *argv[])
{

  int arg1 = atoi(argv[1]);
  if (argc != 2) {
    cout << "usage: ./a.out <number>\n";
    return 1;
  }
  cout << fizzbuzz(arg1);
  return 0;
}
