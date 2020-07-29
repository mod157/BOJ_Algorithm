import java.io.*
import java.util.*
import java.util.StringTokenizer
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   val s = readLine().toUpperCase()
   var alpha : Array<Int> = Array(26, {0});
   var isSame = false;
   
   for(c in s){
       alpha[c - 'A']++;
   }

   var max = 0;
   for(i in 1 until alpha.count()){
       if(alpha[i] == 0){
           continue;
       }

       if(alpha[i] > alpha[max]){
           max = i;
           isSame = false;
           continue;
       }

       if(alpha[max] == alpha[i]){
           isSame = true;
       }
   }
   if(isSame){
      print("?")
   }else{
      print('A' + max)
   }
}