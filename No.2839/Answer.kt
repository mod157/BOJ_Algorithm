import java.io.*
import java.util.*
import java.util.StringTokenizer
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   val n = readLine().toInt()
   var k5 = n / 5;
   var k3 = 0;
   var a = n % 5;
   while(k5 >= 0){
      if(a == 0){
         break;
      }
      if(a % 3 == 0){
         k3 = a / 3;
         a %= 3;
         break;
      }
      k5--;
      a += 5;
   }
   
   if(a == 0){
      print(k5 + k3);
   }else{
      print(-1);
   }
}