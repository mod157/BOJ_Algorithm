import java.io.*
import java.util.*
import java.util.StringTokenizer
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   val n = readLine().toInt()
   if(n != 1){
      var answer = n / 6;
      var div = 0;
      var cnt = 1;
      while(true){
          div += cnt++;
          if(div >= answer){
              if(n > div * 6 + 1 ){
                  cnt++;
                  break;
              }else{
                  break;
              }
          }
      }
      print(cnt);
  }else{
      print(n);
  }
}