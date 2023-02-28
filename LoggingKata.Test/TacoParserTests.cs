using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("33.635282,-86.684056,Taco Bell Birmingham...", -86.684056)]
        [InlineData("33.544403,-85.073656,Taco Bell Carrollton...", -85.073656)]
        [InlineData("33.168176,-87.521815,Taco Bell Tuscaloosa...", -87.521815)]
        [InlineData("30.486758,-84.315552,Taco Bell Tallahassee...", -84.315552)]
        [InlineData("32.364153,-86.269979,Taco Bell Montgomery...", -86.269979)]

        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var tacoParserInstance = new TacoParser();
            //Act
            var actual = tacoParserInstance.Parse(line);
            //Assert
            Assert.Equal(expected, actual.Location.Longitude);
        }


        //TODO: Create a test ShouldParseLatitude

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("33.635282,-86.684056,Taco Bell Birmingham...", 33.635282)]
        [InlineData("33.544403,-85.073656,Taco Bell Carrollton...", 33.544403)]
        [InlineData("33.168176,-87.521815,Taco Bell Tuscaloosa...", 33.168176)]
        [InlineData("30.486758,-84.315552,Taco Bell Tallahassee...", 30.486758)]
        [InlineData("32.364153,-86.269979,Taco Bell Montgomery...", 32.364153)]

        public void ShouldParseLatitude(string line, double expected)

        {
            //Arrange
            var tacoParserInstance = new TacoParser();
            //Act
            var actual = tacoParserInstance.Parse(line);
            //Assert
            Assert.Equal(expected, actual.Location.Latitude);
        }

    }

}
