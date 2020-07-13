import java.util.Scanner;
public class Main{
    public static Scanner scan = new Scanner(System.in);
    public static void main(String[] args){
        new Main().Answer();
    }
    public void Answer(){
        int n = scan.nextInt();
        int sum = 0;
		for(int i = 1; i <= n; i++){
            sum += i;
        }
        System.out.print(sum);
    }
}