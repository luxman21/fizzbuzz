def fizzbuzz(n)
  #ここに素数を一文字づつ数列化した際のn番目の数値を出力するプログラムを実装してください。
  #BEGIN_CHALLENGE

  result = ""
  if (n% 15 == 0)
    result = "FizzBuzz"
  elsif (n % 5 == 0)
    result = "Buzz"
  elsif (n % 3 == 0)
    result = "Fizz"
  else result = n 
  end 

  return result

  #END_CHALLENGE
end