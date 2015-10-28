package fizzbuzz

import "strconv"

func fizzBuzz(n int) string {
  //ここに素数を一文字づつ数列化した際のn番目の数値を出力するプログラムを実装してください。
  //BEGIN_CHALLENGE

  var result string
  if(n % 15 == 0) {
    result = "FizzBuzz"
  } else if(n % 5 == 0) {
    result = "Buzz"
  } else if(n % 3 == 0) {
    result = "Fizz"
  } else {
    result = strconv.Itoa(n)
  }
  return result
  //END_CHALLENGE
}
