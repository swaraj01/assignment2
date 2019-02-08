using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ConsoleApp7;

namespace triangletest
{
    [TestFixture]
    public  class triangletest
    {
            [Test]
               public void analyze_inputsides666_expectresultequilateral()
            {
                //Arrange
                int s1 = 6;
                int s2 = 6;
                int s3 = 6;
             
            //used these values to check equilateral triagle i.e. all 3 sides are equal
                //Act
                string y = "equilateral triangle";
                string x = Trianglesolver.analyze(s1,s2,s3);

                //Assert
                
            Assert.AreEqual(x,y);
        }
        [Test]
        public void analyze_inputsides946_expectresultscalenetriangle()
        {
            //Arrange
            int s1 = 9;
            int s2 = 4;
            int s3 = 6;

            //used these values to check scalene triangle i.e. all 3 sides are unequal 
            //Act
            string y = "scalene triangle";
            string x = Trianglesolver.analyze(s1, s2, s3);

            //Assert

            Assert.AreEqual(x, y);
        }
        [Test]
        public void analyze_inputsides445_expectresultisoscelestriangle()
        {
            //Arrange
            int s1 = 4;
            int s2 = 4;
            int s3 = 5;
            //used these values to  check isosceles  triangle i.e checking side1 and side2 equal

            //Act
            string y = "isosceles triangle";
            string x = Trianglesolver.analyze(s1, s2, s3);

            //Assert

            Assert.AreEqual(x, y);
        }
        [Test]
        public void analyze_inputsides855_expectresultisoscelestriangle()
        {
            //Arrange
            int s1 = 8;
            int s2 = 5;
            int s3 = 5;
            //used these values to  check isosceles  triangle i.e checking side2 and side3 equal

            //Act
            string y = "isosceles triangle";
            string x = Trianglesolver.analyze(s1, s2, s3);

            //Assert

            Assert.AreEqual(x, y);
        }
        [Test]
        public void analyze_inputsides757_expectresultisoscelestriangle()
        {
            //Arrange
            int s1 = 7;
            int s2 = 5;
            int s3 = 7;
            //used these values to  check isosceles  triangle i.e checking side1 and side3 equal

            //Act
            string y = "isosceles triangle";
            string x = Trianglesolver.analyze(s1, s2, s3);

            //Assert

            Assert.AreEqual(x, y);
        }
        [Test]
        public void analyze_inputsides439_expectresultnotatriangle()
        {
            //Arrange
            int s1 = 4;
            int s2 = 3;
            int s3 = 9;
            //used values as sum of side1 and side2 entered is less than the side3, i.e. not a triangle


            //Act
            string y = "not a triangle";
            string x = Trianglesolver.analyze(s1, s2, s3);

            //Assert

            Assert.AreEqual(x, y);
        }
        [Test]
        public void analyze_inputsides5113_expectresultnotatriangle()
        {
            //Arrange
            int s1 = 5;
            int s2 = 11;
            int s3 = 3;
            //used values as sum of side1 and side3 entered is less than the side2, i.e. not a triangle

            //Act
            string y = "not a triangle";
            string x = Trianglesolver.analyze(s1, s2, s3);

            //Assert

            Assert.AreEqual(x, y);
        }
        [Test]
        public void analyze_inputsides732_expectresultnotatriangle()
        {
            //Arrange
            int s1 = 7;
            int s2 = 3;
            int s3 = 2;
            //used values as sum of side2 and side3 entered is less than the side1, i.e. not a triangle

            //Act
            string y = "not a triangle";
            string x = Trianglesolver.analyze(s1, s2, s3);

            //Assert

            Assert.AreEqual(x, y);
        }
    }
}
