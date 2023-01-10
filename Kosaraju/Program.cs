using Kosaraju;

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

        int[][] vect2 = new int[13][];
        vect2[0] = new int[] { 1 };
        vect2[1] = new int[] { 2 };
        vect2[2] = new int[] { 3, 4 };
        vect2[3] = new int[] { 0 };
        vect2[4] = new int[] { 5 };
        vect2[5] = new int[] { 6 };
        vect2[6] = new int[] { 7 };
        vect2[7] = new int[] { 4 };
        vect2[8] = new int[] { 5, 9 };
        vect2[9] = new int[] { 10, 12 };
        vect2[10] = new int[] { 11 };
        vect2[11] = new int[] { 8 };
        vect2[12] = new int[] { };

        int[][] vect3 = new int[8][];
        vect3[0] = new int[] { 1 };
        vect3[1] = new int[] { 2 };
        vect3[2] = new int[] { 3, 4 };
        vect3[6] = new int[] { 0 };
        vect3[4] = new int[] { 5 };
        vect3[5] = new int[] { 6 };
        vect3[3] = new int[] { 4, 7 };
        vect3[7] = new int[] { };


        Graf graf = new Graf();
        graf.Kosaraju(vect2);
    }

}