import java.io.*
import java.util.StringTokenizer
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   val n = StringTokenizer(readLine())
   val a = n.nextToken().toInt();
   val b = n.nextToken().toInt();
   val c = n.nextToken().toInt();
   if( a >= b){
      if(b >= c){
         print(b);
      }else if(a >= c){
         print(c);
      }else{
         print(a);
      }
   }else{
      if(c >= b){
         print(b);
      }else if(a >= c){
         print(a);
      }else{
         print(c);
      }
   }
}