using Kosaraju;
using Kosaraju.MyStructs;

static class Proggram
{
    public static void Main()
    {
        int[][] vect = new int[7][];
        vect[0] = new int[] { 1, 3 };
        vect[1] = new int[] { 2 };
        vect[2] = new int[] { 0 };
        vect[3] = new int[] { 2, 4, 5 };
        vect[4] = new int[] { };
        vect[5] = new int[] { 4, 6 };
        vect[6] = new int[] { };


        Graf graf = new Graf();
        graf.Kosaraju(vect);
    }

}