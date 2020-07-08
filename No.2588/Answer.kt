import java.util.*
fun main(args: Array<String>) = with(Scanner(System.`in`)) {
   val a = nextInt()
   val b = nextInt()
   println((a*(b%10)).toString() + "\n" + a*(b%100/10) + "\n" + a*(b/100) + "\n" + a*b)
}