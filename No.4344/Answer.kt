import java.io.*
import java.util.StringTokenizer
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   val n = readLine().toInt()
   var sb = StringBuilder()
   for(i in 0 until n){
      var st = StringTokenizer(readLine())
      var values = mutableListOf(Integer.parseInt(st.nextToken()))
      var avg = 0;
      var answer:Double = 0.0;
      for(j in 1..values[0]){
         var value = Integer.parseInt(st.nextToken())
         avg += value
         values.add(value)
      }
      avg = avg / values[0]
      for(j in 1..values[0]){
         if(values[j] > avg){
            answer += 100;
         }
      }
      sb.appendln(String.format("%.3f%%", answer / values[0]));
   }
   print(sb.toString())
}