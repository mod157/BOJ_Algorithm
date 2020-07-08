import java.util.*

fun main(args: Array<String>) = with(Scanner(System.`in`)) {
   val cntT = nextInt()
   var TNum = Array(26, { 0 })
   var isAnswer = false;
   
   for(i in 1..cntT ){
      val str = next()
      TNum = Array(26, { 0 })

      for(c in str){
         TNum[c.toChar() - 'A']++
      }

      val cntW = nextInt()
      var spells:Array<String> = Array(cntW) { "" }

      for(n in 0 until cntW){
         spells[n] = next() 
      }

      for(n in 0 until cntW){
         var TNum_Checking = TNum.clone()
         for(j in 0 until spells[n].length){
            if(--TNum_Checking[spells[n][j] - 'A'] < 0){
               println("NO")
               isAnswer = true
               break;
            }
         }
         if(!isAnswer){
            println("YES")
         }
         isAnswer = false
      }
   }
}