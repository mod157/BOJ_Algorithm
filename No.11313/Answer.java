import java.util.Arrays;
import java.util.ArrayList;
import java.util.Scanner;
import java.util.Collections;

public class Answer {
	public static void main(String[] args)  {
		int[] patten = {  1, 2 , -1, 1, -2, -1 };
		Scanner sc = new Scanner(System.in);
		int n = sc.nextInt();
		String fname = "";
		String lname = "";
		StringBuilder sb = new StringBuilder();
		ArrayList<String> names = new ArrayList<String>();
		for (int i = 0; i < n; i++) {
			fname = sc.next();
			lname = sc.next();
			names.add(lname + " " + fname);
		}
		Collections.sort(names);
		
		int q = sc.nextInt();
		for (int i = 0; i < q; i++) {
			fname = sc.next();
			lname = sc.next();
			int k = listIndexOf(names, (lname + " " + fname));
			int m = k % 3 * 2;
			sb.append(changeString(names.get(k + patten[m])) + "\n");
			sb.append(changeString(names.get(k + patten[m + 1])) + "\n");
		}
		System.out.print(sb.toString());
		sc.close();
	}

	private static int listIndexOf(ArrayList<String> names , String name){
		int bottom = 0;
		int mid = 0;
		int top = names.size();
		while (bottom < top) {
			mid = (bottom + top) / 2;
			if (names.get(mid).compareTo(name) < 0) {
				bottom = mid + 1;
			} else {
				top = mid;
			}
		}
		return bottom;
	}

	private static String changeString(String s) {
		String[] spl = s.split("\\s++");
		return spl[1] + " " + spl[0];
	}
}
