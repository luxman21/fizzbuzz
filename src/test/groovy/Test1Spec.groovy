import spock.lang.Specification
import spock.lang.Unroll

class Test1Spec extends Specification {

  @Unroll
  def "fizzBuzz(#n) == resultdata[#n]"() {
    setup:
    def fizzbuzz = new FizzBuzz()
    
    String[] resultdata = new String[101]
    for (i in 1..100) {
      if(i % 15 == 0) resultdata[i] =  "FizzBuzz"
      else if(i % 5 == 0) resultdata[i] = "Buzz"
      else if(i % 3 == 0) resultdata[i] = "Fizz"
      else resultdata[i] = i
    }

    expect:
    for (n in 1..100) {
      fizzbuzz.fizzBuzz(n) == resultdata[n]
    }
  }
}