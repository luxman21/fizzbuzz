import org.junit.Test;
import static org.junit.Assert.assertEquals;

public class TestFizzBuzz {

  @Test
  public void testFizzBuzz() {

    String[] data = new String[100];
    for (int i=0; i<100; i++) {
      if (i % 15 == 0) {
        data[i] = "FizzBuzz";
      }
      else if (i % 5 == 0) {
        data[i] = "Buzz";
      } 
      else if (i % 3 == 0) {
        data[i] = "Fizz";
      }
      else data[i] = Integer.toString(i);
    }

    for (int i=0; i<100; i++) {
      assertEquals(FizzBuzz.fizzBuzz(i), data[i]);
    }
  }
}