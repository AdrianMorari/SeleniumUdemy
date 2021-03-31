using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Section12.Implementing_interfaces
{
    [TestClass]
    public class InterfaceTest
    {
        [TestMethod]
        public void Test_Traveler()
        {
            Professor prof1 = new Professor("1122", "Sara", "Burke", "32323", "Math");
            Professor prof2 = new Professor("1100", "John", "Cena", "0323", "Biology");
            Student stud1 = new Student("003", "James", "Blunt", "Computer Science", "2311");
            Student stud2 = new Student("065", "Liza", "Van Gough", "Geography", "1123");

            Person[] listOfPeople = new Person[4];

            listOfPeople[0] = prof1;
            listOfPeople[1] = prof2;
            listOfPeople[2] = stud1;
            listOfPeople[3] = stud2;

            foreach (Person someone in listOfPeople)
            {
                Console.WriteLine(someone);
            }
        }
    }
}
