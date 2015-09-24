<?php

function fizzbuzz($n) {
  //ここに素数を一文字づつ数列化した際のn番目の数値を出力するプログラムを実装してください。
  //BEGIN_CHALLENGE

  // Declared in ascending order, or sort ascending before using
  $step[0] = 3;
  $step[1] = 5;
  $step[2] = 15;
  
  // Build the 1 to 100 array
  for ($i = 1; $i<=100; $i++) {
    $theList[$i] = $i;
  }
  
  // Mark the "Fizz"es
  for ($i = $step[0]; $i <= 100; $i = $i + $step[0]) {
    $theList[$i] = "Fizz";
  }
  // Mark the "Buzz"es
  for ($i = $step[1]; $i <= 100; $i = $i + $step[1]) {
    $theList[$i] = "Buzz";
  }
  // Mark the "FizzBuzz"es
  for ($i = $step[2]; $i <= 100; $i = $i + $step[2]) {
    $theList[$i] = "FizzBuzz";
  }
  
  return $theList[$n];
  //END_CHALLENGE
}