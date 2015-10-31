import java.util.ArrayList;
import java.util.Scanner;

public class FizzBuzz {
    public static Scanner scanner = new Scanner(System.in);
    public static String inp;
    public static String fizz = "Fizz";
    public static String buzz = "Buzz";

    public static void main (String args []){
        System.out.println("Enter Number");
    loopAlg();
    }

    public static void loopAlg () {

        int inp = scanner.nextInt();

        if(inp % 3 == 0 && inp % 5 != 0){
            System.out.println(fizz);
        } else if (inp % 5 == 0 && inp % 3 != 0){
            System.out.println(buzz);
        }
        else if(inp % 3 == 0 && inp % 5 == 0) {
            System.out.println(fizz+buzz);
        } else {
            System.out.println(inp);
        }
        loopAlg();
    }
}
