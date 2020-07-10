import java.util.Scanner;
public class Answer{
    public static void main(String[] args){
        Scanner scan = new Scanner(System.in);
		int a = scan.nextInt();
		switch(a/10){
            case 10:
            case 9:
                System.out.print("A");
                break;
            case 8:
                System.out.print("B");
                break;
            case 7:
                System.out.print("C");
                break;
            case 6:
                System.out.print("D");
                break;
            default:
                System.out.print("F");
                break;
        }
    }
}