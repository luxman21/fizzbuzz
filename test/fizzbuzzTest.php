<?php

require_once 'app/fizzbuzz.php';

class FizzBuzzTest extends PHPUnit_Framework_TestCase
{
  
  function testIsFizzBuzz() { 
    for ($i=1; $i<=100; $i = $i + 1) {
      if($i%15 == 0)
        $this->assertEquals("FizzBuzz", fizzbuzz($i));
      elseif($i%5 == 0)
        $this->assertEquals("Buzz", fizzbuzz($i));
      elseif($i%3 == 0)
        $this->assertEquals("Fizz", fizzbuzz($i));
      else 
        $this->assertEquals($i, fizzbuzz($i));
    }
  }

}
