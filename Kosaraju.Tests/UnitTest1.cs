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

            Assert.AreEqual(2, 2);
        }
    }
}