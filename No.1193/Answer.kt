import java.io.*
import java.util.*
import java.util.StringTokenizer
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   val n = readLine().toInt()
   var cnt = 1
   var div = 0
   while(true){
       div += cnt
       if(div >= n){
           break;
       }
       cnt++
   }
   
   var value = n - (div - cnt + 1)
   var a = 1 + value
   var b = cnt - value
   if(cnt % 2 == 0){
      print(a.toString() + "/" + b.toString())
   }else{
      print(b.toString() + "/" + a.toString())
   }
}