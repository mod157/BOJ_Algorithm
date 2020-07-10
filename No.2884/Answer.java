import java.util.Scanner;
public class Answer{
    public static void main(String[] args){
        Scanner scan = new Scanner(System.in);
		int a = scan.nextInt();
        int b = scan.nextInt();
        if(b < 45){
            if(a == 0){
                a = 23;
            }else{
                a--;
            }
            b += 15;
        }else{
            b -= 45;
        }
		System.out.print(a + " " + b);
    }
}