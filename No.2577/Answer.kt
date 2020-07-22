import java.io.*
import java.util.StringTokenizer
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   val n1 = readLine().toInt()
   val n2 = readLine().toInt()
   val n3 = readLine().toInt()
   var num = (n1 * n2 * n3).toString();
   var answer = mutableListOf(0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
   for(i in 0 until num.length){
      answer[num.get(i) - '0']++
   }

   for(i in 0 until answer.size){
      println(answer[i])
   }
}