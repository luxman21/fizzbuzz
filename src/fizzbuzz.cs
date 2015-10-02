using System;

public class FizzBuzz {

  public static object fizzbuzz(int n) {
    //ここに素数判定プログラムを実装してください。
    //BEGIN_CHALLENGE

    object data;

    if(n%15 == 0) data = "FizzBuzz";
    else if(n%5 == 0) data = "Buzz";
    else if(n%3 == 0) data = "Fizz";
    else data = n;

    return data;
    //END_CHALLENGE
  }

}
