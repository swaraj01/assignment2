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
    public class triangletest
    {
            [Test]
            public void analyze_inputside1_expectLengthEquals8()
            {
                //Arrange
                int s1 = 8;
                int s2= 6;
                int s3 = 6;
                Trianglesolver triangletest = new Trianglesolver();

                //Act
                int length = triangletest.analyze(s1, s2,s3);

                //Assert
                Assert.AreEqual(length, l);
            }
        }
}
