using NUnit.Framework;
using System;

[TestFixture]
public class FizzBuzzTest {

  [Test]
  public void FizzBuzzTest() {
    
    for(int i = 1; i <= 100; i++) {
      if(i%15 == 0) 
        Assert.AreEqual("FizzBuzz", FizzBuzz.FizzBuzz(i));
      else if (i%5 == 0) 
        Assert.AreEqual("Buzz", FizzBuzz.FizzBuzz(i));
      else if(i%3 == 0) 
        Assert.AreEqual("Fizz", FizzBuzz.FizzBuzz(i));
      else 
        Assert.AreEqual(i.ToString(), FizzBuzz.FizzBuzz(i));
    }
  }
}