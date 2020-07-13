import java.util.Scanner;
fun main(args: Array<String>) = with(Scanner(System.`in`)) {
   val n = nextInt()
   var sum = 0;
   for(i in 1 .. n){
      sum += i;
   }
   print(sum);
}