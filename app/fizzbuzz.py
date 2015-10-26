#!/usr/bin/env python
# -*- coding: utf-8 -*-

def fizzbuzz(n):
#ここに素数判定プログラムを実装してください。
#BEGIN_CHALLENGE

  result = ""
  if(n % 15 == 0):
      result = "FizzBuzz"
  elif(n % 5 == 0):
      result = "Buzz"
  elif(n % 3 == 0):
      result = "Fizz" 
  else: 
      result = str(n)
    
  return result

#END_CHALLENGE
