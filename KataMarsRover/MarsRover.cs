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
	    public int X { get; set; } = 0;

	    public int Y { get; set; } = 0;

	    public string Orientation
	    {
		    get => compass.ToString();
		    set => compass = (Compass)Enum.Parse(typeof(Compass), value);
	    }

	    private Compass compass = Compass.N;

		public string Execute(string command)
		{
            foreach (char step in command)
            {
                if (step == 'M') 
				    Move();
                if (step == 'R')
                    RotateRight();
            }
            return $"{X}:{Y}:{Orientation}";
        }

        private void RotateRight()
        {
	        compass += 1;
        }

        private void Move()
        {
            if(Orientation == "N")
                Y = (Y + 1) % 10;
            else
                X = (X + 1) % 10;
        }

		private enum Compass { N, E, S, W} ;
    }
}