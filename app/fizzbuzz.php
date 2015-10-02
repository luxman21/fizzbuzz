<?php

function fizzbuzz($n) {
  //ここに素数を一文字づつ数列化した際のn番目の数値を出力するプログラムを実装してください。
  //BEGIN_CHALLENGE

  if($n % 15 == 0)
    $data = "FizzBuzz";
  else if($n % 5 == 0)
    $data = "Buzz";
  else if($n % 3 == 0)
    $data = "Fizz";
  else 
    $data = $n;

  return $data;

  //END_CHALLENGE
}