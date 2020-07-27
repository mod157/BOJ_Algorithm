import java.io.*
import java.util.StringTokenizer

var sb = StringBuilder()
fun main(args: Array<String>){
   selfNumber(10000)
   print(sb.toString())
}

fun selfNumber(n : Int){
   var hs = hashSetOf(2)
   for(i in 1 until n){
       var let : Int
       var temp = (i.toString()).toCharArray()
       
       when(temp.size){
         1 ->
            let = (temp[0] - '0').toInt()
         2 ->
            let = (temp[0] - '0').toInt().plus((temp[1] - '0').toInt())
         3 ->
            let = (temp[0] - '0').toInt().plus((temp[1] - '0').toInt().plus((temp[2] - '0').toInt()))
         else ->
            let = (temp[0] - '0').toInt().plus((temp[1] - '0').toInt().plus((temp[2] - '0').toInt().plus((temp[3] - '0').toInt())))
       }
       hs.add(i + let.toInt());
   }

   for(i in 1..n){
       if(!hs.contains(i)){
           sb.appendln(i);
       }
   }
}