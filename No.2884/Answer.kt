import java.util.Scanner;
fun main(args: Array<String>) = with(Scanner(System.`in`)) {
   var a = nextInt()
   var b = nextInt()
   if(b < 45){
      if(a == 0){
         a = 23
      }else{
         a--
      }
      b += 15
  }else{
      b -= 45
  }
   print(a.toString() + " " + b)
}