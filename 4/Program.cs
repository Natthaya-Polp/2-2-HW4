using System;

class Program {
    static void Main(string[] args) 
    {
        int numNodes;
        numNodes = int.Parse(Console.ReadLine());
        bool[,] graph = new bool[numNodes, numNodes];
        int startNode, endNode;

        while (true) 
        {
            startNode = int.Parse(Console.ReadLine());

            if (startNode < 0 || startNode >= numNodes) break;

            endNode = int.Parse(Console.ReadLine());

            if (endNode < 0 || endNode >= numNodes) break;

            if (startNode == endNode) continue;

            graph[startNode, endNode] = true;
            graph[endNode, startNode] = true;
        }

        int count = 0;
        for (int i = 0; i < numNodes; i++)
        {
            char symbol = 'A';
            bool hasEdge = false;

            for (int j = 0; j < numNodes; j++) 
            {
                if (graph[i, j]) 
                {
                    hasEdge = true;
                    break;
                }
            }

            if (hasEdge) count++;
            else symbol++;
        }

        Console.WriteLine(count-2);
    }
}
