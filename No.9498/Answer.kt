import java.util.Scanner;
fun main(args: Array<String>) = with(Scanner(System.`in`)) {
   val a = nextInt()
   when(a/10){
      10, 9 -> print("A")
      8 -> print("B")
      7 -> print("C")
      6 -> print("D")
      else -> print("F")
   }
}