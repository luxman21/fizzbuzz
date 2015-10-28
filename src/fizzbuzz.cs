using System;

public class FizzBuzz {

  public static string FizzBuzz(int n) {
    //ここに素数判定プログラムを実装してください。
    //BEGIN_CHALLENGE
    
    string data;    
    if (n % 15 == 0) data = "FizzBuzz";
    else if(n % 5 == 0) data = "Buzz";
    else if(n % 3 == 0) data = "Fizz";
    else data = n.ToString();

    return data;
    //END_CHALLENGE
  }

}
