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

        [Fact]
        public void after_input_MMMM_is_at_0_4_facing_N()
        {
            var marsRover = new MarsRover();

            marsRover.Execute("MMMM");

            var actualOrientation = marsRover.Orientation;
            var actualX = marsRover.X;
            var actualY = marsRover.Y;

            Assert.Equal("N", actualOrientation);
            Assert.Equal(0, actualX);
            Assert.Equal(4, actualY);
        }

        [Fact]
        public void after_input_M_the_result_is_01N()
        {
            var marsRover = new MarsRover();

            var result = marsRover.Execute("M");

            Assert.Equal("0:1:N", result);
        }

        [Fact]
        public void Get_0_0_N_after_move_starting_from_0_9_facing_north()
        {
            var marsRover = new MarsRover()
            {
                Orientation = "N",
                X = 0,
                Y = 9
            };

            var result = marsRover.Execute("M");

            Assert.Equal("0:0:N", result);
        }
    }
}