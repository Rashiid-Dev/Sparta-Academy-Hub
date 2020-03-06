using NUnit.Framework;
using SpartaAcademyHubWPF;

namespace AcademyHubTestsApp
{
    public class CoursesPrintTests
    {
        private Program _prm;
        [SetUp]
        public void Setup()
        {
            _prm = new Program();
        }


        [TestCase]
        public void CheckCourseCount()
        {
            // Count the returned list
            Assert.AreEqual(4, _prm.CoursesPrint().Count);
        }

        [TestCase]
        public void FailCheckCourseCount()
        {
            // Count the returned list
            Assert.AreEqual(5, _prm.CoursesPrint().Count);
        }

        // Checking the strings in the list that was returned
        [Test]
        public void BusinessSkillsSCheckCoursePrint()
        {
            
                Assert.AreEqual("Business Skills Course will take place at Birmingham Academy and it will take 1 week to complete.", _prm.CoursesPrint()[0]);
            

        }

        [Test]
        public void AgileSqlCheckCoursePrint()
        {

            Assert.AreEqual("Agile + SQL Course will take place at Birmingham Academy and it will take 1 week to complete.", _prm.CoursesPrint()[1]);


        }

        [Test]
        public void CsharpBasicsCheckCoursePrint()
        {

            Assert.AreEqual("C# Basics Course will take place at Birmingham Academy and it will take 1 week to complete.", _prm.CoursesPrint()[2]);


        }

        [Test]
        public void CSharpProjectCheckCoursePrint()
        {

            Assert.AreEqual("C# Project week Course will take place at Birmingham Academy and it will take 1 week to complete.", _prm.CoursesPrint()[3]);


        }

    }

    public class AcademyPrintTests
    {
        private Program _prm;
        [SetUp]
        public void Setup()
        {
            _prm = new Program();
        }


        [TestCase]
        public void CheckAcademyCount()
        {
            // Count the returned list
            Assert.AreEqual(2, _prm.AcademiesMake().Count);
        }

        [TestCase]
        public void FailCheckAcademyCount()
        {
            // Count the returned list
            Assert.AreEqual(1, _prm.AcademiesMake().Count);
        }

        // Checking the strings in the list that was returned
        [Test]
        public void BirminghamAcademyCheckAcademiesMake()
        {

            Assert.AreEqual("Birmingham Academy", _prm.AcademiesMake()[1]);


        }

        [Test]
        public void LondonHQCheckAcademiesMake()
        {

            Assert.AreEqual("London HQ", _prm.AcademiesMake()[0]);


        }

       
    }

}

