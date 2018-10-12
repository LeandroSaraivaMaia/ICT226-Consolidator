using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Consolidator;

namespace TestConsolidator
{
    [TestClass]
    public class TestStudent
    {
        [TestMethod]
        public void Student_Create_Sucess()
        {
            //given
            string name = "Adolf";
            string sex = "0";
            int interests = 3;
            Stack<Student> students = new Stack<Student>(); ;
            Student student;

            //then
            student = new Student(students, name, sex, interests);

            //when
            Assert.AreEqual(student.Name, name);
            Assert.AreEqual(student.Interests, interests);

            if (sex == "0")
            {
                sex = "Homme";
            }
            else if (sex == "1")
            {
                sex = "Femme";
            }
            Assert.AreEqual(student.SexString, sex);
        }
    }
}
