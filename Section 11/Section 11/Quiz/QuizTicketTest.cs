using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Section_11
{
    [TestClass]
    public class QuizTicketTest
    {
        [TestMethod]
        public void Test_Lecture()
        {
            Lecture newLecture = new Lecture(2, "5", "5/20/2020", "Guest Speaker", "Lecture", "New Hall", true, "Some info here", 12.99);
            Console.WriteLine(newLecture);
        }

        [TestMethod]
        public void Test_Musical()
        {
            Musical newMusical = new Musical(2, "5", "The Magic Flute", "Musical", "Theatre", "Gigi", "05/20/2020", true, true, false, 19.99);
            Console.WriteLine(newMusical);
        }

        [TestMethod]
        public void Test_Play()
        {
            Play newPlay = new Play(2, "5", "05/20/2020", "Death of a Salesman", "Play", "Theatre", true, 15, "Info here", 9.99);
            Console.WriteLine(newPlay);
        }
    }
}
