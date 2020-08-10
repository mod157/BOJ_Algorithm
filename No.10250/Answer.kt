import java.io.*
import java.util.*
import java.util.StringTokenizer
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   val n1 = readLine().toInt()
   var sb = StringBuilder()
   for(i in 0 until n1){
      val st = StringTokenizer(readLine())
      val h = st.nextToken().toInt()
      val w = st.nextToken().toInt()
      val n = st.nextToken().toInt()

      var f = n % h
      var num = n / h
      if(f == 0){
         f = h
      }else{
         num++;
      }
      if(num >= 10){
         sb.appendln(f.toString()+num)
      }else{
         sb.appendln(f.toString()+"0"+num)
      }
   }

   print(sb.toString())
}