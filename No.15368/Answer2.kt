import java.util.*
public lateinit var employeeBosslist : MutableList<Int>
public lateinit var answerValues : MutableList<Long>

fun main(args: Array<String>) = with(Scanner(System.`in`)) {
   var n = nextLine().toInt();
   employeeBosslist = ("0 "+  nextLine()).split(" ").map { it.toInt() }.toMutableList()
   answerValues = MutableList<Long>(n, {0})
   var value = 2

   for(i in 0 until n){
      answerValues[i]++;
      var idx = i;
      while(idx != 0){
         idx = employeeBosslist[idx] - 1;
         answerValues[idx] += value++.toLong();
         if(idx != 0){
            idx = employeeBosslist[idx] - 1;
            answerValues[idx] += value++.toLong();
         }
      }
      value = 2;
   }

   for(i in 0 until n){
      print(answerValues[i].toString() + " ")
   }
}
