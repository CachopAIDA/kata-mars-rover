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
		public string Orientation { get; set; }
		public int X { get; set; }
		public int Y { get; set; }

		public string Execute(string command)
		{
			throw new NotImplementedException();
		}
	}
}