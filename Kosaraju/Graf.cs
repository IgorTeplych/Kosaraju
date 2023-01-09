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
        bool[] isVisit;
        int[] component;
        int[][] H;
        int[][] G;
        int idx = 1;
        public void Kosaraju(int[][] g)
        {
            this.G = g;
            this.H = Invert(g);
            stack = new Stack<int>();
            isVisit = new bool[H.Length];
            component = new int[H.Length];
            for (int i = 0; i < H.Length; i++)
            {
                component[i] = -1;
            }

            for (int u = 0; u < H.Length; u++)
            {
                if (!isVisit[u])
                {
                    DFS1(u);
                }
            }
            idx = 1;
            for (int i = 0; i < component.Length; i++)
            {
                int u = stack.Pop();
                if (component[u] < 0)
                {
                    DFS2(u);
                    idx++;
                }
            }
        }
        void DFS1(int v)
        {
            isVisit[v] = true;
            stack.Push(v);
            for (int i = 0; i < H[v].Length; i++)
            {
                var u = H[v][i];
                if (!isVisit[u])
                {
                    DFS1(u);
                }
            }
        }

        void DFS2(int v)
        {
            component[v] = idx;
            for(int i = 0; i < G[v].Length; i++)
            {
                var u = G[v][i];
                if (component[u] < 0)
                    DFS2(u);
            }
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
