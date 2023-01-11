using Kosaraju.MyStructs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosaraju
{
    public class Graf
    {
        Stack<int> stack;
        bool[] visited;
        int[][] H;
        int[][] G;
        List<List<int>> stronglies;
        List<int> strongly;
        int[] components;
        public List<List<int>> Kosaraju(int[][] g)
        {
            this.G = g;
            this.H = Invert(g);
            stack = new Stack<int>();
            visited = new bool[H.Length];
            components = new int[G.Length];
            for (int i = 0; i < components.Length; i++)
                components[i] = -1;

            for (int u = 0; u < G.Length; u++)
                DFS1(u);

            stronglies = new List<List<int>>();
            visited = new bool[H.Length];
            while (stack.Any())
            {
                strongly = new List<int>();
                DFS2(stack.Pop());
                if (strongly.Count != 0)
                {
                    stronglies.Add(strongly);
                    for (int i = 1; i < strongly.Count; i++)
                        components[strongly[i - 1]] = strongly[i];
                }
            }
            return stronglies;
        }
        public int[] GetStronglyConnectedComponent(int[][] g)
        {
            Kosaraju(g);
            return components;
        }
        void DFS1(int v)
        {
            if (visited[v])
                return;
            visited[v] = true;

            for (int i = 0; i < G[v].Length; i++)
            {
                int u = G[v][i];
                DFS1(u);
            }
            stack.Push(v);
        }
        void DFS2(int v, int idx = 0)
        {
            if (visited[v])
                return;
            visited[v] = true;
            for (int i = 0; i < H[v].Length; i++)
            {
                int u = H[v][i];
                DFS2(u);
            }
            strongly.Add(v);
        }
        int[][] Invert(int[][] vect)
        {
            SingleArray<int>[] invArr = new SingleArray<int>[vect.Length];
            for (int i = 0; i < invArr.Length; i++)
                invArr[i] = new SingleArray<int>();

            for (int i = 0; i < vect.Length; i++)
            {
                var u = vect[i];
                for (int j = 0; j < u.Length; j++)
                {
                    int v = vect[i][j];
                    invArr[v].Add(i, invArr[v].Size);
                }
            }
            int[][] inv = new int[invArr.Length][];
            for (int i = 0; i < inv.Length; i++)
                inv[i] = invArr[i].Array;
            return inv;
        }
    }
}
