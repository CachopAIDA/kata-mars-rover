using System.Collections.Generic;

namespace KataMarsRover
{
	using System;

	public interface IMarsRover
	{
		string Execute(string command);
	}

	public class MarsRover : IMarsRover
    {
        public string Orientation { get; set; } = "N";
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;

		public string Execute(string command)
		{
			throw new NotImplementedException();
		}
	}
}