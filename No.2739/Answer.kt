import java.util.Scanner;
fun main(args: Array<String>) = with(Scanner(System.`in`)) {
   val n = nextInt()
   for(i in 1 .. 9){
      println(n.toString() + " * " + i + " = " + n*i)
   }
}