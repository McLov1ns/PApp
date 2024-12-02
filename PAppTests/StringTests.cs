using PApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PautTests
{
    public class StringTests
    {
        [Theory]
        [InlineData("Hello world", 2)]
        [InlineData("This is a test", 4)]
        [InlineData("Count the words", 3)]
        public void TestWordCount(string text, int expected)
        {
            Assert.Equal(expected, Calculations.WordCount(text));
        }

        [Theory]
        [InlineData("Hello world", "world", true)]
        [InlineData("This is a test", "python", false)]
        [InlineData("Find the substring", "substring", true)]
        public void TestSubstring(string text, string sub, bool expected)
        {
            Assert.Equal(expected, Calculations.Substring(text, sub));
        }

        [Theory]
        [InlineData("Hello world", "HELLO WORLD")]
        [InlineData("Python", "PYTHON")]
        [InlineData("To UpperCase", "TO UPPERCASE")]
        public void TestToUpperCase(string text, string expected)
        {
            Assert.Equal(expected, Calculations.ToUpperCase(text));
        }

        [Fact]
        public void TestFileReading()
        {
            string text = TestData.GetTextFromFile("C:\\Users\\MEGABOOK\\source\\repos\\PApp\\PApp\\sample.txt");
            Assert.NotNull(text);
        }
    }
}
