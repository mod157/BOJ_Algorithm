import java.io.*
import java.util.StringTokenizer
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   val st = StringTokenizer(readLine())
   val n = mutableListOf(st.nextToken().toLong(), st.nextToken().toLong(), st.nextToken().toLong())
   val idx = st.nextToken().toInt()
   var values = mutableListOf(1L)
   var value : Long
   var temp = n[0]
   val INF = 1000000000000000000L

   while(temp <= INF && temp > 0){
      values.add(temp)
      temp = n[0]*temp
   }

   var len = values.size
   for(i in 0 until len){
      temp = n[1];
      while(temp <= INF && temp > 0){
         value = values.get(i)*temp;
         if(value > 0 && value <= INF)
               values.add(value);
         temp = temp * n[1];
      }
   }

   len = values.size
   for(i in 0 until len){
      temp = n[2];
      while(temp <= INF && temp > 0){
         value = values.get(i)*temp;
         if(value > 0 && value <= INF)
            values.add(value);
         temp = temp * n[2];
      }
   }
   
   values.sort()
   print(values[idx])
}