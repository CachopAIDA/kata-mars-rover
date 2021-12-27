using System.Collections.Generic;

namespace KataMarsRover.Tests
{
	using System;
	using Xunit;

	public class MarsRoverSpecs
	{
		[Fact]
		public void Given_MMMM_gets_0_4_N()
		{
			const string inputCommand = "MMMM";
			const string expectedOutput = "0:4:N";
			IMarsRover marsRover = new MarsRover();

			var actualOutput = marsRover.Execute(inputCommand);

			Assert.Equal(expectedOutput, actualOutput);
		}

        [Fact]
        public void Given_MMMMMMMMMM_gets_0_0_N()
        {
            const string inputCommand = "MMMMMMMMMM";
            const string expectedOutput = "0:0:N";
            IMarsRover marsRover = new MarsRover();

            var actualOutput = marsRover.Execute(inputCommand);

            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void Given_MMRMMLM_gets_2_3_N()
        {
            const string inputCommand = "MMRMMLM";
            const string expectedOutput = "2:3:N";
            IMarsRover marsRover = new MarsRover();

            var actualOutput = marsRover.Execute(inputCommand);

            Assert.Equal(expectedOutput, actualOutput);
        }

        [Fact]
        public void Given_MMRRM_gets_0_1_S()
        {
            const string inputCommand = "MMRRM";
            const string expectedOutput = "0:1:S";
            IMarsRover marsRover = new MarsRover();

            var actualOutput = marsRover.Execute(inputCommand);

            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}