import java.util.Scanner;

public class Answer{
    public static void main(String[] args){
        Scanner scan = new Scanner(System.in);
        int i = 0, j = 0, k = 0;
        int[] TNum = new int[26];
        int[] TNum_Checking = new int[26];
        String str;

        int cntT = scan.nextInt();
        int cntW = 0;
        boolean isAnswer = false;

        for(i = 0 ; i < cntT; i++)
        {
            str = scan.next();
            for(j = 0; j < TNum.length; j++){
                TNum[j] = 0;
            }

            for(j = 0 ; j < str.length(); j++)
            {
                TNum[str.charAt(j) - 'A']++;
            }

            cntW = scan.nextInt();
            String[] spells = new String[cntW];
            
            for(j = 0 ; j < cntW; j++)
            {
                spells[j] = scan.next();
            }

            for(j = 0 ; j < cntW; j++){
                TNum_Checking = TNum.clone();
                for(k = 0; k < spells[j].length(); k++){
                    if(--TNum_Checking[spells[j].charAt(k) - 'A'] < 0)
                    {
                        System.out.println("NO");
                        isAnswer = true;
                        break;
                    }
                }
                if(!isAnswer){
                    System.out.println("YES");
                }
                isAnswer = false;
            }
        }
    }
}