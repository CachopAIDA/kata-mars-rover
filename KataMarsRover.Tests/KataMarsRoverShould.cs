using Xunit;

namespace KataMarsRover.Tests
{
	using System;
	using System.Collections.Generic;
	using System.Text;

	public class KataMarsRoverShould
	{
		[Fact]
		public void Initially_be_at_0_0_facing_N()
		{
			var marsRover = new MarsRover();

			var actualOrientation = marsRover.Orientation;
			var actualX = marsRover.X;
			var actualY = marsRover.Y;

			Assert.Equal("N", actualOrientation);
			Assert.Equal(0, actualX);
			Assert.Equal(0, actualY);
		}

        [Fact]
        public void after_input_M_is_at_0_1_facing_N()
        {
            var marsRover = new MarsRover();

            marsRover.Execute("M");

            var actualOrientation = marsRover.Orientation;
            var actualX = marsRover.X;
            var actualY = marsRover.Y;

            Assert.Equal("N", actualOrientation);
            Assert.Equal(0, actualX);
            Assert.Equal(1, actualY);
        }

        [Fact]
        public void after_input_MMM_is_at_0_3_facing_N()
        {
            var marsRover = new MarsRover();

            marsRover.Execute("MMM");

            var actualOrientation = marsRover.Orientation;
            var actualX = marsRover.X;
            var actualY = marsRover.Y;

            Assert.Equal("N", actualOrientation);
            Assert.Equal(0, actualX);
            Assert.Equal(3, actualY);
        }
    }
}