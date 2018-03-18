using NumberParserExtended.Common.Configurations;
using System;
using Xunit;

namespace NumberParserExtended.XUnitTestProject
{
    public class NumberUnitTest1
    {

        [Fact]
        public void TestNumber1()
        {
            NumberOneConfiguration number1 = new NumberOneConfiguration();
            var field = number1.Field;
            Assert.True(field.Content == '|');
            Assert.True(field.Bottom.Content == '|');
            Assert.True(field.Bottom.Bottom.Content == '|');
            Assert.True(field.Bottom.Bottom.Bottom.Content == '|');
        }

        [Fact]

        public void TestNumber2()
        {
            NumberTwoConfiguration two = new NumberTwoConfiguration();

            Assert.True(two.Field.Content == '-');
            Assert.True(two.Field.Right.Content == '-');
            Assert.True(two.Field.Right.Right.Content == '-');
            Assert.True(two.Field.Right.Right.Bottom.Content == '|');
            Assert.True(two.Field.Right.Right.Bottom.BottomLeft.Content == '_');
            Assert.True(two.Field.Right.Right.Bottom.BottomLeft.BottomLeft.Content == '|');
            Assert.True(two.Field.Right.Right.Bottom.BottomLeft.BottomLeft.Bottom.Content == '-');
            Assert.True(two.Field.Right.Right.Bottom.BottomLeft.BottomLeft.Bottom.Right.Content == '-');
            Assert.True(two.Field.Right.Right.Bottom.BottomLeft.BottomLeft.Bottom.Right.Right.Content == '-');
        }

        [Fact]
        public void TestNumber3()
        {
            NumberThreeConfiguration three = new NumberThreeConfiguration();

            Assert.True(three.Field.Content == '-');
            Assert.True(three.Field.Right.Content == '-');
            Assert.True(three.Field.Right.Right.Content == '-');
            Assert.True(three.Field.Right.Right.BottomLeft.Content == '/');
            Assert.True(three.Field.Right.Right.BottomLeft.Bottom.Content == '\\');
            Assert.True(three.Field.Right.Right.BottomLeft.Bottom.Bottom.Content == '-');
            Assert.True(three.Field.Right.Right.BottomLeft.Bottom.Bottom.Left.Content == '-');
        }

        [Fact]
        public void TestNumber4()
        {
            NumberFourConfiguration four = new NumberFourConfiguration();

            Assert.True(four.Field.Content == '|');
            Assert.True(four.Field.Bottom.Content == '|');
            Assert.True(four.Field.Bottom.Right.Content == '_');
            Assert.True(four.Field.Bottom.Right.Right.Content == '_');
            Assert.True(four.Field.Bottom.Right.Right.Right.Content == '_');
            Assert.True(four.Field.Bottom.Right.Right.Right.Right.Content == '|');
            Assert.True(four.Field.Bottom.Right.Right.Right.Right.Top.Content == '|');
            Assert.True(four.Field.Bottom.Right.Right.Right.Right.Bottom.Content == '|');
            Assert.True(four.Field.Bottom.Right.Right.Right.Right.Bottom.Bottom.Content == '|');
        }

        [Fact]
        public void TestNumber5()
        {
            NumberFiveConfiguration five = new NumberFiveConfiguration();

            Assert.True(five.Field.Content == '-');
            Assert.True(five.Field.Left.Content == '-');
            Assert.True(five.Field.Left.Left.Content == '-');
            Assert.True(five.Field.Left.Left.Left.Content == '-');
            Assert.True(five.Field.Left.Left.Left.Left.Content == '-');
            Assert.True(five.Field.Left.Left.Left.Left.Bottom.Content == '|');
            Assert.True(five.Field.Left.Left.Left.Left.Bottom.Right.Content == '_');
            Assert.True(five.Field.Left.Left.Left.Left.Bottom.Right.Right.Content == '_');
            Assert.True(five.Field.Left.Left.Left.Left.Bottom.Right.Right.Right.Content == '_');
            Assert.True(five.Field.Left.Left.Left.Left.Bottom.Right.Right.Right.BottomRight.Content == '|');
            Assert.True(five.Field.Left.Left.Left.Left.Bottom.Right.Right.Right.BottomRight.Bottom.Content == '|');
            Assert.True(five.Field.Left.Left.Left.Left.Bottom.Right.Right.Right.BottomRight.Bottom.Left.Content == '_');
            Assert.True(five.Field.Left.Left.Left.Left.Bottom.Right.Right.Right.BottomRight.Bottom.Left.Left.Content == '_');
            Assert.True(five.Field.Left.Left.Left.Left.Bottom.Right.Right.Right.BottomRight.Bottom.Left.Left.Left.Content == '_');
            Assert.True(five.Field.Left.Left.Left.Left.Bottom.Right.Right.Right.BottomRight.Bottom.Left.Left.Left.Left.Content == '_');
        }
    }
}
