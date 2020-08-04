import java.io.*
import java.util.*
import java.util.StringTokenizer
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   val st = StringTokenizer(readLine())
   var a = st.nextToken().toInt()
   var b = st.nextToken().toInt()
   var v = st.nextToken().toInt()
   print((v - b - 1) / (a - b) + 1)
}