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
        BasicStructures.PriorityQueue<int> queue;
        Stack<int> stack;
        bool[] isVisit;
        int[][] H;
        int[][] G;
        public void Kosaraju(int[][] g)
        {
            this.G = g;
            this.H = Invert(g);
            stack = new Stack<int>();
            queue = new BasicStructures.PriorityQueue<int>();
            isVisit = new bool[H.Length];

            for (int u = 0; u < H.Length; u++)
            {
                if (!isVisit[u])
                {
                    DFS1(u);
                }
            }

            while (queue.Size > 0)
            {
                var vr = queue.Dequeue();
            }
        }
        void DFS1(int v)
        {
            isVisit[v] = true;
            for (int i = 0; i < H[v].Length; i++)
            {
                var u = H[v][i];
                if (!isVisit[u])
                {
                    DFS1(u);
                }
            }
            Console.WriteLine(v);
            queue.Enqueue(v);
            stack.Push(v);
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
            {
                inv[i] = invArr[i].Array;
            }
            return inv;
        }
    }
}
