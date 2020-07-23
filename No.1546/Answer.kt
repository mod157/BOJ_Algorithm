import java.io.*
import java.util.StringTokenizer
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   val n = readLine().toInt()
   var st = StringTokenizer(readLine())
   var value:Float = 0f
   var max:Int = 0
   for(i in 0 until n){
      val a = st.nextToken().toInt()
      value += a
      if(a > max){
         max = a
      }
   }
   print(value / (max * n) * 100)
}