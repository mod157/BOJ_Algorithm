import java.io.*
import java.util.*
import java.util.StringTokenizer
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   
   var sb = StringBuilder()
   var hw = Array(15) { Array(15) { 0 } }
   for(i in 0..14){
       hw[0][i] = i + 1;
   }

   for(i in 1..14){
       for(j in 0..14){
           if(j == 0){
               hw[i][j] = 1;
               continue;
           }
           if(j == 1){
               hw[i][j] = i + 2;
               continue;
           }
           hw[i][j] = hw[i][j - 1] + hw[i - 1][j]; 
       }
   }

   val n = readLine().toInt()
   for(i in 0 until n){
      var a = readLine().toInt()
      var b = readLine().toInt()
      sb.appendln(hw[a][b - 1].toString());
   }
   print(sb.toString())
}