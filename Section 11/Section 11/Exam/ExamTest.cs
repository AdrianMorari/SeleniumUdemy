using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Section_11.Exam
{
    [TestClass]
    public class ExamTest
    {
        [TestMethod]
        public void Test_Auto_Loan_Calc()
        {
            AutoLoan car = new AutoLoan("0001", "Sara", "Baker", .075, 12000, 4, 2015, "Taurus", "Ford", "Blue");
            decimal interest = car.CalculateInterest();
            Assert.AreEqual(interest, 2925);
            Console.WriteLine(car);
        }

        [TestMethod]
        public void Test_Home_Loan_Calc()
        {
            HomeLoan house = new HomeLoan("0001", "Sara", "Baker", .35, 210000, 30, "123 SE New Street", 3000, 2010);
            decimal interest = house.CalculateInterest();
            Assert.AreEqual(interest, 30100);
            Console.WriteLine(house);
        }
    }
}
