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
                if (step == 'L')
	                RotateLeft();
            }
            return $"{X}:{Y}:{Orientation}";
        }

        private void RotateRight()
        {
	        if (compass == Compass.W)
		        compass = Compass.N;
			else
				compass += 1;
        }

        private void RotateLeft()
        {
	        if (compass == Compass.N)
		        compass = Compass.W;
			else
				compass -= 1;
        }

		private void Move()
        {
            switch (Orientation)
            {
                case "S":
                    Y = (Y - 1) % 10;
                    break;
                case "N":
                    Y = (Y + 1) % 10;
                    break;
                case "E":
                    X = (X + 1) % 10;
                    break;
                case "W":
                    X = (X - 1) % 10;
                    break;
            }
        }

		private enum Compass { N, E, S, W} ;
    }
}