import java.io.*
import java.util.*
import java.util.StringTokenizer
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   val n = readLine().toInt()
   var sb = StringBuilder()
   var strList = MutableList(n, {""})
   
   for(i in 0 until n){
      strList[i] = readLine()
      var length = strList[i].length
      var answer = 0;
      var value = 0;
      for(j in 0 until length){
         if(strList[i][j].equals('O')){
            value += 1;
            answer += value;
            continue;
        }else{                
            value = 0;
            continue;
        }
      }
      sb.appendln(answer);
   }
   print(sb.toString())
}