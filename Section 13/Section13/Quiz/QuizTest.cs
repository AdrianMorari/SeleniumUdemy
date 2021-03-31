using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Section13.Quiz
{
    [TestClass]
    public class QuizTest
    {
        //modify test to catch three different exceptions:
        //ArithmeticException
        //Exception
        //Use one try block to accomplish this task

        [TestMethod]
        public void Calculate_BMI()
        {
            //setup variables to calculate BMI
            string weight = "150";
            string heightInFeet = "6";
            string heightInInches = "72";
            BodyMassIndexCalculator bmi = null;

            //create instance of the BodyMassIndexCalculator, pass over all variables
            try
            {
                bmi = new BodyMassIndexCalculator
                    (int.Parse(weight), int.Parse(heightInFeet), int.Parse(heightInInches));
            }
            catch (ArithmeticException exc)
            {
                Console.WriteLine("Arithmetic Problem - " + exc.Message);
            }
            catch (FormatException exc)
            {
                Console.WriteLine("Number Format Problem - " + exc.Message);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

            //get result
            string result = bmi.ToString();

            //create Assertion
            StringAssert.Equals("BMI: 5.09", result);
        }
    }
}
