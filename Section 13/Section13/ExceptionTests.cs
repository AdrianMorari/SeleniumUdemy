using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Section13
{
    [TestClass]
    public class ExceptionTests
    {
        [TestMethod]
        public void Test_Exceptions()
        {
            int totalScores = 10;
            int countOfScores = 0;

            if (countOfScores == 0 || totalScores == 0)
            {
                
            }
            else
            {
                double average = totalScores / countOfScores;
            }
        }

        [TestMethod]
        public void Test_Division()
        {
            ExceptionHelper.DivisionTest();
        }

        [TestMethod]
        public void Test_StateCheck()
        {
            try
            {
                ExceptionHelper.CheckStateOK("MA");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
