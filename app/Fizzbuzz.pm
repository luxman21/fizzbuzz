package app::Fizzbuzz;

use strict;
use warnings;

sub fizzbuzz {
  #ここに素数判定プログラムを実装してください。
  #BEGIN_CHALLENGE
	
  my $ithresult = shift;
  my @result;
  my $i = 1;

  while ($i <= 100) {
    if ($i % 3 == 0 && $i % 5 == 0) {
	  $result[$i] = "FizzBuzz";
	} elsif ($i % 3 == 0) {
	  $result[$i] = "Fizz";
	} elsif ($i % 5 == 0) {
	  $result[$i] = "Buzz";
	} else {
	  $result[$i] = $i;
	}
	$i++
  }
  
  return $result[$ithresult];

  #END_CHALLENGE
}

1;