import java.io.*
import java.util.*
import java.util.StringTokenizer
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   val n = readLine().toInt()
   val st = StringTokenizer(readLine())
   var list = Eratos(1000)
   for(s in st.nextToken()){
      if(list.indexOf()){

      }
   }
   print(sb.toString())
}

fun Eratos(max : Int) : MutableList<Int>{
   var c = BooleanArray(max + 1)
   var list = MutableList(0) { 0 };
   for(i in 2..max){
       if(c[i] == false){
           // 추가
           list.add(i);
           // i의 배수 지우기
           for(j in i+i..max){
               c[j]=true;
           }
       }
   }

   return list;
}