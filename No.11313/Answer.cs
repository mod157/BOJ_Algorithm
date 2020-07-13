using System;
using System.Collections.Generic;
using System.Text;

class Answer{
    static void Main(string[] args)
    {
        String name = string.Empty;
        List<String> names = new List<String>();
        StringBuilder sb = new StringBuilder();
        int idx = 0;
        int pattenidx = 0;
        if(int.TryParse(Console.ReadLine(), out int n)){
            int[,] patten = new int[3,2]{{1, 2}, {-1, 1}, {-2, -1}};
            for(int i = 0 ; i < n; i++){
                names.Add(ChangeString(Console.ReadLine()));
            }
            names.Sort();

            int q = int.Parse(Console.ReadLine());
            for(int i = 0 ; i < q; i++){
                name = ChangeString(Console.ReadLine());
                idx = listIndexOf(names, name);
                pattenidx = idx % 3;
                sb.AppendLine(ChangeString(names[idx + patten[pattenidx,0]]));
                sb.AppendLine(ChangeString(names[idx + patten[pattenidx,1]]));
            }
            
            Console.Write(sb.ToString());
        }
      }
    private static int listIndexOf(List<String> names , String name){
		int bottom = 0;
		int mid = 0;
		int top = names.Count;
		while (bottom < top) {
			mid = (bottom + top) / 2;
			if (names[mid].CompareTo(name) < 0) {
				bottom = mid + 1;
			} else {
				top = mid;
			}
		}
		return bottom;
	}
    public static String ChangeString(string name){
        string[] names = name.Split(" ");
        return names[1] + " " + names[0]; 
    }
}
