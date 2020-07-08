import java.util.Scanner;
public class Answer{
    public static void main(String[] args){
        int a = scan.nextInt();
        int b = scan.nextInt();
        System.out.println(a*(b%10)+ "\n" + a*(b%100/10) + "\n" + a*(b/100) + "\n" + a*b);
    }

    static Scanner scan = new Scanner(System.in);
}