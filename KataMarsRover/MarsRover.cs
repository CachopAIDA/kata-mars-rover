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
            foreach (char step in command)
            {
                if (step == 'M') 
				    Y = Y + 1;
            }
            return null;
        }
	}
}