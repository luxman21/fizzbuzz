package app::Fizzbuzz;

use strict;
use warnings;

sub fizzbuzz {
  #ここに素数判定プログラムを実装してください。
  #BEGIN_CHALLENGE
	
  my $ithfizzbuzz = shift;
  my @result;

  if ($ithfizzbuzz % 15 == 0) {
	  $result[$ithfizzbuzz] = "FizzBuzz";
  } elsif ($ithfizzbuzz % 5 == 0) {
    $result[$ithfizzbuzz] = "Buzz";
  } elsif ($ithfizzbuzz % 3 == 0) {
	  $result[$ithfizzbuzz] = "Fizz";
  } else {
	  $result[$ithfizzbuzz] = $ithfizzbuzz;
  }
 
  return $result[$ithfizzbuzz];

  #END_CHALLENGE
}

1;