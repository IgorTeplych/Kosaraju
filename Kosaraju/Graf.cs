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
        List<List<int>> components;
        List<int> component;
        public List<List<int>> Kosaraju(int[][] g)
        {
            this.G = g;
            this.H = Invert(g);
            stack = new Stack<int>();
            visited = new bool[H.Length];
            for (int u = 0; u < G.Length; u++)
                DFS1(u);

            components = new List<List<int>>();
            visited = new bool[H.Length];
            while (stack.Any())
            {
                component = new List<int>();
                DFS2(stack.Pop());
                if (component.Count != 0)
                    components.Add(component);
            }
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
            component.Add(v);
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
