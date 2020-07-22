import java.io.*
import java.util.StringTokenizer
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   val st = StringTokenizer(readLine())
   var n1 = st.nextToken().toLong()
   var n2 = st.nextToken().toLong()
   var n3 = st.nextToken().toLong()
   var n4 = st.nextToken().toInt()
   var values = mutableListOf(1L)
   var p1:Int = 0
   var p2:Int = 0
   var p3:Int = 0
   for(i in 1..n4.toInt()){
      while(values[i-1] >= values[p1] * n1) p1++;
      while(values[i-1] >= values[p2] * n2) p2++;
      while(values[i-1] >= values[p3] * n3) p3++;
      values.add(min(values[p1] * n1,values[p2] * n2));
      values[i] = min(values[i], values[p3] * n3);
      
   }
   print(values[n[3].toInt()].toString())
}

fun min(value1 : Long, value2 :Long) : Long{
   if(value1 > value2){
      return value2
   }else{
      return value1
   }
}