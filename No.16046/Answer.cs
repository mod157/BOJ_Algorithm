using System;
using System.Collections.Generic;
using System.Text;

public class Edge{
    private int idx;
    private int leftnode;
    private int rightnode;
    private int weight;
    private String color;

    public Edge(int n, String str){
        this.idx = n;
        String[] s = str.Split(" ");
        this.leftnode = int.Parse(s[0]);
        this.rightnode = int.Parse(s[1]);
        this.weight = int.Parse(s[2]);
        this.color = s[3];
        if(leftnode > rightnode){
            int temp = 0;
            temp = leftnode;
            leftnode = rightnode;
            rightnode = temp;
        }
    }
    public Boolean isColor(String c){
        return color.Equals(c);
    }

    public int GetLeftNode(){
        return leftnode;
    }
    
    public int GetRightNode(){
        return rightnode;
    }

    public int GetWeight(){
        return weight;
    }

    public String GetColor(){
        return color;
    }

    public Boolean EqualsEdge(Edge edge){
        return this.idx == edge.idx;
    }
}

public class Node
{   private int num;
    private List<Edge> _neighbors;

    public Node(int num)
    {                
        this.num = num;
    }

    public List<Edge> Neighbors
    {
        get
        {
            _neighbors = _neighbors ?? new List<Edge>();
            return _neighbors;
        }
    }

    public int EdgeCount(){
        return _neighbors.Count;
    }
}
public class Graph
{
    private List<Node> _nodeList;

    public Graph()
    {
        _nodeList = new List<Node>();
    }

    public Node AddNode(Node node)
    {
        _nodeList.Add(node);
        return node;
    }
    public Edge AddEdge(Edge edge){
        _nodeList[edge.GetLeftNode()].Neighbors.Add(edge);
        return edge;
    }
    public List<Node> GetNodes(){
        return _nodeList;
    }
   internal void DebugPrintLinks()
    {
        Console.WriteLine("PRINT -------------------");
        foreach (Node node in _nodeList)
        {                
            foreach (var n in node.Neighbors)
            {
                string s = String.Format("{0} {1} {2} {3}", n.GetLeftNode(), n.GetRightNode(), n.GetWeight(), n.GetColor());
                Console.WriteLine(s);
            }                
        }
    }
}

class AnswerClass{
    public static StringBuilder sb = new StringBuilder();
    public Graph g = new Graph();
    public Boolean[] visit;

    public Stack<int> stack = new Stack<int>();
    int INF = 1000000000;
    int[] distance;

    int node;
    static void Main(string[] args)
    {
       new AnswerClass().Answer();
    }
    public Boolean isAllNodeVisit( Boolean[] visit ){
        foreach(Boolean i in visit){
            if(!i){
                return false;
            }
        }
        return true;
    }
    public void DFS(int n, int goal){
        visit[n] = true;
        stack.Push(n);
        Console.WriteLine(n + "] :" + g.GetNodes()[n].EdgeCount());
        if(isAllNodeVisit(visit)){
            int count = stack.Count;
            foreach(int i in stack.ToArray()){
                Console.Write(i + " ");
            }
            stack.Pop();
            return;
        }

        foreach(Edge edge in g.GetNodes()[n].Neighbors){
            if(!visit[edge.GetRightNode()]){
                DFS(edge.GetRightNode(), goal);
                visit[edge.GetRightNode()] = false;
            }
        }

        stack.Pop();
    }

    void dijkstra(int start) {
        distance[start] = 0; // 탐색 시작하는 노드의 최소비용은 0

        priority_queue<pair<int, int> > pq; // 힙구조 유지
        
        pq.push(make_pair(start, 0));
        
        // 가까운 순서대로 처리 -> 큐 사용
        while(!pq.empty()) { // 우선순위 큐가 비어있지 않다면 
            int current = pq.top().first; // 큐의 가장 위에는 가장 적은 비용을 가진 node의 정보가 들어있다.

            // 짧은 것이 먼저 오도록 음수화
            int distance = -pq.top().second;

            pq.pop();

            // 최단 거리가 아닌 경우 스킵
            if(d[current] < distance) continue;

            for(int i = 0; i < a[current].size(); i++) {
                // 선택된 노드의 인접노드를 담아줌 
                int next = a[current][i].first;

                // 선택된 노드를 거쳐서 인접노드로 가는 비용 계산
                int nextDistance = distance + a[current][i].second;

                // 기존의 비용과 비교
                if(nextDistance < d[next]) {
                    d[next] = nextDistance;
                    pq.push(make_pair(next, -nextDistance));
                }
            }
        }
    }
    
    public void Answer(){
        int[] n = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
        node = n[0];
        visit = new Boolean[node + 1];
        distance = new int[node + 1];
        int edges = n[1];
        String s = "";
        int startNum = 0;

        for(int i = 1; i <= number; i++) {
            distance[i] = INF;
        }
        for(int i = 0; i <= node; i++){
            g.AddNode(new Node(i));
        }
        for(int i = 0; i < edges; i++){
            s = Console.ReadLine();
            g.AddEdge(new Edge(i, s));
            if(s.IndexOf("G") != -1){
                startNum++;
            }
        }
       
        g.DebugPrintLinks();

        if(node - 1 > startNum){
            for(int i = 0; i < node - 1; i++){
                sb.AppendLine("-1");
            }
        }
        
        //DFS(1, node);
        dijkstra(1);

        //Console.Write(sb.ToString());
    }
}

