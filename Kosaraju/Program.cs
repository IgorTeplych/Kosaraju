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

        int[][] vectInv = new int[7][];
        vectInv[0] = new int[] { 2 };
        vectInv[1] = new int[] { 0 };
        vectInv[2] = new int[] { 1, 3 };
        vectInv[3] = new int[] { 0 };
        vectInv[4] = new int[] { 3, 5 };
        vectInv[5] = new int[] { 3 };
        vectInv[6] = new int[] { 5 };


        int[][] vect2 = new int[7][];
        vect2[0] = new int[] { 1, 3 };
        vect2[1] = new int[] { 2 };
        vect2[2] = new int[] { 6 };
        vect2[3] = new int[] { 2, 4, 5 };
        vect2[4] = new int[] { };
        vect2[5] = new int[] { 4, 6 };
        vect2[6] = new int[] { };

        Graf graf = new Graf();
        graf.Kosaraju(vect);
    }

}