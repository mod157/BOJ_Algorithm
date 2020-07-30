import java.io.*
import java.util.*
import java.util.StringTokenizer
fun main(args: Array<String>) = with(BufferedReader(InputStreamReader(System.`in`))) {
   val str = readLine()
   val regex = Regex("((c|s|z|dz)=)|((c|d)-)|((l|n)j)")
   print(str.replace(regex, " ").length)
}