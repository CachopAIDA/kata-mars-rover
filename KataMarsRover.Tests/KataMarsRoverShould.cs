using Xunit;

namespace KataMarsRover.Tests
{
	using System;
	using System.Collections.Generic;
	using System.Text;

    public class KataMarsRoverShould
    {
        [Theory]
        [InlineData("M", "N", 0, 1)]
        [InlineData("MMM", "N", 0, 3)]
        [InlineData("MMMM", "N", 0, 4)]
        [InlineData("R", "E", 0, 0)]
        [InlineData("RM", "E", 1, 0)]
        [InlineData("RR", "S", 0, 0)]
        [InlineData("L", "W", 0, 0)]
        [InlineData("RRRR", "N", 0, 0)]
        public void move_to_position_with_orientation_after_execute_the_command(string input, string orientation, int x, int y)
        {
            var marsRover = new MarsRover();

            marsRover.Execute(input);
            
            var actualOrientation = marsRover.Orientation;
            var actualX = marsRover.X;
            var actualY = marsRover.Y;

            Assert.Equal(orientation, actualOrientation);
            Assert.Equal(x, actualX);
            Assert.Equal(y, actualY);
        }

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

        [Fact]
        public void Get_0_1_S_after_move_starting_from_0_2_facing_S()
        {
            var marsRover = new MarsRover()
            {
                Orientation = "S",
                X = 0,
                Y = 2
            };

            var result = marsRover.Execute("M");

            Assert.Equal("0:1:S", result);
        }

        [Fact]
        public void Get_9_0_W_after_move_starting_from_0_0_facing_W()
        {
            var marsRover = new MarsRover()
            {
                Orientation = "W",
                X = 0,
                Y = 0
            };

            var result = marsRover.Execute("M");

            Assert.Equal("9:0:W", result);
        }
    }
}