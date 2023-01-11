using Kosaraju;

static class Proggram
{
    public static void Main()
    {
        //https://www.pepcoding.com/resources/data-structures-and-algorithms-in-java-levelup/graphs/kosaraju%20_algorithm/topic

        // 0 <-- 3     7 <--- 6    11 <-- 10
        // |     ^     |      ^     |     ^
        // *     |     *      |     *     |
        // 1 --> 2 --> 4 -- > 5 <-- 8 --> 9 --> 12

        int[][] vect = new int[13][];
        vect[0] = new int[] { 1 };
        vect[1] = new int[] { 2 };
        vect[2] = new int[] { 3, 4 };
        vect[3] = new int[] { 0 };
        vect[4] = new int[] { 5 };
        vect[5] = new int[] { 6 };
        vect[6] = new int[] { 7 };
        vect[7] = new int[] { 4 };
        vect[8] = new int[] { 5, 9 };
        vect[9] = new int[] { 10, 12 };
        vect[10] = new int[] { 11 };
        vect[11] = new int[] { 8 };
        vect[12] = new int[] { };

        Graf graf = new Graf();
        var components = graf.Kosaraju(vect);


    }

}