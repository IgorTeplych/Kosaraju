namespace Kosaraju.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestGraf1()
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

            var comp1 = components[0];
            Assert.AreEqual(comp1[0], 9);
            Assert.AreEqual(comp1[1], 10);
            Assert.AreEqual(comp1[2], 11);
            Assert.AreEqual(comp1[3], 8);

            var comp2 = components[1];
            Assert.AreEqual(comp2[0], 12);

            var comp3 = components[2];
            Assert.AreEqual(comp3[0], 1);
            Assert.AreEqual(comp3[1], 2);
            Assert.AreEqual(comp3[2], 3);
            Assert.AreEqual(comp3[3], 0);

            var comp4 = components[3];
            Assert.AreEqual(comp4[0], 5);
            Assert.AreEqual(comp4[1], 6);
            Assert.AreEqual(comp4[2], 7);
            Assert.AreEqual(comp4[3], 4);
        }
        public void TestGetComponentsMethod()
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
            var components = graf.GetStronglyConnectedComponent(vect);

            Assert.AreEqual(components[0], -1);
            Assert.AreEqual(components[1], 2);
            Assert.AreEqual(components[2], 3);
            Assert.AreEqual(components[3], 0);
            Assert.AreEqual(components[4], -1);
            Assert.AreEqual(components[5], 6);
            Assert.AreEqual(components[6], 7);
            Assert.AreEqual(components[7], 4);
            Assert.AreEqual(components[8], -1);
            Assert.AreEqual(components[9], 10);
            Assert.AreEqual(components[10], 11);
            Assert.AreEqual(components[11], 8);
            Assert.AreEqual(components[12], 12);
        }

        [Test]
        public void TestGraf2()
        {
            //https://www.programiz.com/dsa/strongly-connected-components

            // 0 <-- 1      - 5 <-
            // |     ^     |     |
            // *     |     *     |
            // 3 --> 2 <-- 4 --> 6 <-- 7

            int[][] vect = new int[8][];
            vect[0] = new int[] { 1 };
            vect[1] = new int[] { 2 };
            vect[2] = new int[] { 3, 4 };
            vect[3] = new int[] { 0 };
            vect[4] = new int[] { 5 };
            vect[5] = new int[] { 6 };
            vect[6] = new int[] { 4, 7 };
            vect[7] = new int[] { };

            Graf graf = new Graf();
            var components = graf.Kosaraju(vect);

            var comp1 = components[0];
            Assert.AreEqual(comp1[0], 1);
            Assert.AreEqual(comp1[1], 2);
            Assert.AreEqual(comp1[2], 3);
            Assert.AreEqual(comp1[3], 0);

            var comp2 = components[1];
            Assert.AreEqual(comp2[0], 5);
            Assert.AreEqual(comp2[1], 6);
            Assert.AreEqual(comp2[2], 4);

            var comp3 = components[2];
            Assert.AreEqual(comp3[0], 7);
        }
        [Test]
        public void TestGraf3()
        {
            //           4 <-- 5 --> 6
            //           ^     ^
            //           |     |
            //  -> 0 --> 3 ----
            // |   |     |
            // |   *     *
            // |   1 --> 2
            // |_________|

            int[][] vect = new int[7][];
            vect[0] = new int[] { 1, 3 };
            vect[1] = new int[] { 2 };
            vect[2] = new int[] { 0 };
            vect[3] = new int[] { 2, 4, 5 };
            vect[4] = new int[] { };
            vect[5] = new int[] { 4, 6 };
            vect[6] = new int[] { };

            Graf graf = new Graf();
            var components = graf.Kosaraju(vect);

            var comp1 = components[0];
            Assert.AreEqual(comp1[0], 1);
            Assert.AreEqual(comp1[1], 3);
            Assert.AreEqual(comp1[2], 2);
            Assert.AreEqual(comp1[3], 0);

            var comp2 = components[1];
            Assert.AreEqual(comp2[0], 5);

            var comp3 = components[2];
            Assert.AreEqual(comp3[0], 6);

            var comp4 = components[3];
            Assert.AreEqual(comp4[0], 4);
        }

    }
}