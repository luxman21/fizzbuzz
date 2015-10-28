package fizzbuzz

import "testing"
import "strconv"

func TestFizzBuzz(t *testing.T) {

  var expected [101]string
  var actual [101]string

  for i:=1;i<=100;i++ {
    
    actual[i] = fizzBuzz(i)
    if(i % 15 == 0) {
      expected[i] = "FizzBuzz"
    } else if(i % 5 == 0) {
      expected[i] = "Buzz"
    } else if(i % 3 == 0) {
      expected[i] = "Fizz"
    } else { expected[i] = strconv.Itoa(i) }
  }

  if actual != expected {
    t.Errorf("got %v\nwant %v", actual, expected)
  }

}
