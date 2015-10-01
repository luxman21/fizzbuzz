using System;

public class FizzBuzz {

  public static object isFizzBuzz(int n) {
    //ここに素数判定プログラムを実装してください。
    //BEGIN_CHALLENGE

    object[] array = new object[101];

    for(int i = 1; i <= 100; i++) {

      if(i%15 == 0) array[i] = "FizzBuzz";
      else if(i%5 == 0) array[i] = "Buzz";
      else if(i%3 == 0) array[i] = "Fizz";
      else array[i] = i;
      //Console.WriteLine (array[i]);
    }

    return array[n];
    //END_CHALLENGE
  }

}
