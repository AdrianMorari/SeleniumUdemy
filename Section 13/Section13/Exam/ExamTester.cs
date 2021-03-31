using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Section13.Exam
{
    [TestClass]
    public class ExamTester
    {
        //Create a try/catch block in each test that calls method and catches the
        //specific exception that is produced. Each method should be handled so that if an
        //exception occurs, the test will still pass.

        [TestMethod]
        public void Test_WeeklyWages()
        {
            try
            {
                ExamHelper.WeeklyWages();
            }
            catch (IndexOutOfRangeException ie)
            {
                Console.WriteLine("\n\nError in loop termination condition.");
                Console.WriteLine("\nException type: " + ie.Message + "\n\n\n");
            }
        }

        [TestMethod]
        public void Test_Calc_Result()
        {
            try
            {
                ExamHelper.CalculateResult();
            }
            catch (FormatException fe)
            {
                Console.WriteLine("\nError in parameter types.");
                Console.WriteLine("\nException type: " + fe.Message + "\n\n\n");
            }
        }

        [TestMethod]
        public void Test_Number_Check()
        {
            try
            {
                ExamHelper.NumberCheck();
            }
            catch(ArithmeticException ae)
            {
                Console.WriteLine("\nArithmetic Exception thrown.");
                Console.WriteLine("\nException type: " + ae.Message + "\n\n\n");
            }
        }
    }
}
