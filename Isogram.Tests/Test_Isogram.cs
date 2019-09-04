using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using isogram_csharp_problem;

namespace Isogram.Tests
{
    public class Test_Isogram
    {
        [Theory]
        [InlineData("", true)]
        [InlineData("isogram", true)]
        [InlineData("eleven", false)]
        [InlineData("Alphabet", true)]
        [InlineData("subdermatoglyphic", true)]
        [InlineData("thumbscrew-japingly", true)]
        [InlineData("six-year-old", true)]
        [InlineData("raj s", true)]

        public void Theory_Check(string value, bool expected)
        {
            Assert.Equal(expected, isogram.check(value));
        }

    }
}
