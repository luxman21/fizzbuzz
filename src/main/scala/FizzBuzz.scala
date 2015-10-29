object FizzBuzz {

  def fizzBuzz(n: Int): String = {
    //ここに素数判定プログラムを実装してください。
    //BEGIN_CHALLENGE
    n match {
      case n if n % 15 == 0 => "FizzBuzz"
      case n if n % 5 == 0  => "Buzz"
      case n if n % 3 == 0  => "Fizz"
      case _           => n.toString
    }
    //END_CHALLENGE
  }
}
