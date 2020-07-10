import java.util.*

fun main(args: Array<String>) = with(Scanner(System.`in`)) {
   var n = nextLine().toInt();
   var par = ("0 0 "+  nextLine()).split(" ").map { it.toInt() }.toMutableList()
   var answerValues = MutableList<Long>(n + 1, {0})
   var employeeChildValue = MutableList<Int>(n + 1, {0})

   for (i in n downTo 1) {
      answerValues[par[i]] += ++answerValues[i] + ++employeeChildValue[i];
      employeeChildValue[par[i]] += employeeChildValue[i];
  }

   for(i in 1..n){
      print(answerValues[i].toString() + " ")
   }
}
