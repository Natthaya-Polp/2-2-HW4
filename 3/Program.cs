using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int nodes = int.Parse(Console.ReadLine());
        List<int>[] List = new List<int>[nodes];

        for (int i = 0; i < nodes; i++)
        {
            List[i] = new List<int>();
        }

        while (true)
        {
            int startNode = int.Parse(Console.ReadLine());

            if (startNode < 0 || startNode >= nodes)
            {
                break;
            }

            int endNode = int.Parse(Console.ReadLine());

            if (endNode < 0 || endNode >= nodes)
            {
                break;
            }

            List[startNode].Add(endNode);
        }

        int startCheck = int.Parse(Console.ReadLine());
        int endCheck = int.Parse(Console.ReadLine());

        bool[] visited = new bool[nodes];
        bool reachable = Check(List, visited, startCheck, endCheck);

        if (reachable)
        {
            Console.WriteLine("Reachable");
        }
        else
        {
            Console.WriteLine("Unreachable");
        }
    }

    static bool Check(List<int>[] adjList, bool[] visited, int i, int j)
    {
        visited[i] = true;

        if (i == j)
        {
            return true;
        }
        
        foreach (int neighbor in adjList[i])
        {
            if (!visited[neighbor])
            {
                bool reachable = Check(adjList, visited, neighbor, j);
                if (reachable)
                {
                    return true;
                }
            }
        }
        return false;
    }
}