import org.scalatest._
import FizzBuzz._

class TestFizzBuzzSpec extends FlatSpec with Matchers {

  "fizzBuzz" should " return corresponding 'FizzBuzz'values for number passed" in {

    val data = new Array[String](101)
    for (i <- 1 to 100) {
      i match {
        case i if i % 15 == 0 => data(i) = "FizzBuzz"
        case i if i % 5  == 0 => data(i) = "Buzz"
        case i if i % 3  == 0 => data(i) = "Fizz"
        case _                => data(i) = i.toString
      }
      assert(fizzBuzz(i) == data(i))     
    }
  } 
}
