using System.Collections.Generic;

namespace KataMarsRover.Tests
{
	using System;
	using Xunit;

	public class MarsRoverSpecs
	{
		[Fact]
		public void Given_MMMM_gets_4_0_N()
		{
			const string inputCommand = "MMMM";
			const string expectedOutput = "4:0:N";
			IMarsRover marsRover = new MarsRover();

			var actualOutput = marsRover.Execute(inputCommand);

			Assert.Equal(expectedOutput, actualOutput);
		}
	}
}