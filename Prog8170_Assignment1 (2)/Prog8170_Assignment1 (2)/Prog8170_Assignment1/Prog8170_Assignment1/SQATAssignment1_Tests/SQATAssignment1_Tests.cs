using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prog8170_Assignment1;
using NUnit.Framework;

namespace SQATAssignment1_Tests
{

    [TestFixture]

    class SQATAssignment1_Tests
    {
        [Test]
        public void GetLength_input2_expectLenghtEquals2()
        {
            //Arrange
            int l = 2;
            int w = 6;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int length = testRectangle.GetLength();
            Assert.AreEqual(length, l);

        }

        [Test]
        public void SetLength_input4_expectLenghtEquals4()
        {
            //Arrange
            int l = 4;
            int w = 5;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int length = testRectangle.SetLength(4);
            Assert.AreEqual(length, l);

        }

        [Test]
        public void GetWidth_input5_expectWidthEquals5()
        {
            //Arrange
            int l = 3;
            int w = 5;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int width = testRectangle.GetWidth();
            Assert.AreEqual(width, w);

        }

        [Test]
        public void SetWidth_input6_expectWidthEquals3()
        {
            //Arrange
            int l = 6;
            int w = 3;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int width = testRectangle.SetWidth(3);
            Assert.AreEqual(width, w);

        }

        [Test]
        public void GetPerimeter_inputLength1_inputWidth1_expectPerimeterEquals3()
        {
            //Arrange
            int l = 1;
            int w = 1;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int Perimeter = testRectangle.GetPerimeter();
            Assert.AreEqual(Perimeter, 4 );

        }

        public void GetArea_inputLength6_inputWidth3_expectAreaEquals18()
        {
            //Arrange
            int l = 6;
            int w = 3;
            Rectangle testRectangle = new Rectangle(l, w);

            //Act
            int Area = testRectangle.GetArea();
            Assert.AreEqual(Area, 18 );

        }
    }
}