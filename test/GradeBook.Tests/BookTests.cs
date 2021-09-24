using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesGradeStats()
        {
            //arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            //act
            var result = book.GetStatistics();

            //assert
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);
        }

        [Fact]
        public void BookHandlesEmptyGrades()
        {
            //arrange
            var book = new Book("");

            //assert and act
            var emptyness = Assert.Throws<ArgumentException>(() => book.GetStatistics());

            //assert exception message
            Assert.Equal("No grades found", emptyness.Message);
        }

        [Fact]
        public void BookThowsExceptionTryingToAddInvalidGrades()
        {
            //arrange
            var book = new Book("");

            //assert and act
            var toobig = Assert.Throws<ArgumentException>(() => book.AddGrade(105));
            var toosmall = Assert.Throws<ArgumentException>(() => book.AddGrade(-1));

            //assert exception message
            Assert.Equal("Invalid value", toobig.Message);
            Assert.Equal("Invalid value", toosmall.Message);


        }
    }
}
