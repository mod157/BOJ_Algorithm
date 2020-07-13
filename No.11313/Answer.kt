import java.util.Scanner;
fun main(args: Array<String>) = with(Scanner(System.`in`)) {
    val n = nextInt()
    val patten : Array<Int> = arrayOf(1, 2, -1, 1, -2, -1)
    var names : MutableList<String> = arrayListOf()
    var sb : StringBuilder = StringBuilder("")
    for(i in 0 until n){
        var fname = next();
        var lname = next();
        names.add(lname + " " + fname)
    }

    names.sort();

    val q = nextInt()
    for(i in 0 until q){
        val fname = next();
        val lname = next();
        var name = lname + " " + fname
        val idx = listIndexOf(names, name);
        val pattenidx = idx % 3 * 2
        sb.appendln(changeString(names[idx + patten[pattenidx]]))
        sb.appendln(changeString(names[idx + patten[pattenidx+1]]))
    }    
    print(sb.toString())
}

fun listIndexOf(names : MutableList<String> , name : String) : Int {
    var bottom = 0;
    var mid = 0;
    var top = names.size;
    while (bottom < top) {
        mid = (bottom + top) / 2;
        if (names[mid].compareTo(name) < 0) {
            bottom = mid + 1;
        } else {
            top = mid;
        }
    }
    return bottom;
}

fun changeString(name : String) : String{
    var names = name.split(" ");
    return names[1] + " " + names[0];
}