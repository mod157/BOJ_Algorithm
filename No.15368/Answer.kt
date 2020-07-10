import java.util.*
public lateinit var employeeBosslist : MutableList<MutableList<Int>>
public lateinit var employeeValues : MutableList<Int>
public lateinit var answerValues : MutableList<Long>
public lateinit var par : MutableList<Int>

fun main(args: Array<String>) = with(Scanner(System.`in`)) {
   var n = nextInt();
   employeeBosslist = mutableListOf(mutableListOf(), mutableListOf())
   employeeValues = MutableList<Int>(n + 1, {0})
   answerValues = MutableList<Long>(n + 1, {0})
   par = MutableList<Int>(n + 1, {0})

   for(i in 2..n){
      employeeBosslist.add(mutableListOf())
      var inData = nextInt()
      employeeBosslist[i].add(inData)
      employeeBosslist[inData].add(i)
      par[i] = inData
   }
   
   childValue(1)
   answerValue(1)

   for(i in 1 .. n){
      print(answerValues[i].toString() + " ")
   }
}

fun childValue(n:Int):Int{
   var value = 0
   for(i in 0 until employeeBosslist[n].size){
      var next = employeeBosslist[n][i]
      if(next != par[n]){
         value += childValue(next)
      }
   }
   employeeValues[n] = value;
   return value + 1;
}

fun answerValue(n:Int){
   answerValues[n] = 1;
   for(i in 0 until employeeBosslist[n].size){
       var next = employeeBosslist[n][i]
       if(next != par[n]){
           answerValue(next)
           answerValues[n] += answerValues[next]
       }
   }

   answerValues[n] += employeeValues[n].toLong()
}
