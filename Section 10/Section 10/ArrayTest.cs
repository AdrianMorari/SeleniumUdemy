using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_10
{
    [TestClass]
    public class ArrayTest
    {
        [TestMethod]
        public void Array_Test()
        {
            //14 positions, 0 - 13
            int[] scores = new int[14];

            //put a score in the first position
            scores[0] = 10;

            int score = scores[0];
            int numPositions = 10;
            int[] myArray = new int[numPositions];

        }

        [TestMethod]
        public void ForEach_Loop_Test()
        {
            int[] scores = { 2, 4, 6, 8, 10 };

            foreach(int count in scores)
            {
                Console.WriteLine(count);
            }
        }

        [TestMethod]
        public void Pass_Array_Method()
        {
            int[] scores = { 2, 4, 6, 8, 10 };
            int sum = TotalScores(scores);
            Assert.AreEqual(30, sum);
        }

        private int TotalScores(int[] scores)
        {
            int sum = 0;
            foreach (int score in scores)
            {
                sum += score;
            }
            return sum;
        }

        [TestMethod]
        public void Pass_Array_Element()
        {
            int[] scores = { 2, 4, 6, 8, 10 };
            foreach (int score in scores)
            {
                Console.WriteLine();
            }
        }
        public string CheckScore(int score)
        {
            if (score > 10)
            {
                return "Pass";
            }
            else
            {
                return "Fail";
            }
        }
    }
}
