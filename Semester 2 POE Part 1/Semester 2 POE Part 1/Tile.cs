using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester_2_POE_Part_1
{
	public abstract class Tile
	{
		protected int x;
		protected int y;
		protected tileType type;

		public int X { get { return x; } set { x = value; } }
		public int Y { get { return y; } set { y = value; } }

		public enum tileType { Hero, Enemy, Gold, weapon };

		public Tile(int X, int Y, tileType type)
		{
			this.x = X;
			this.y = Y;
			this.type = type;
		}

        protected Tile(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

		protected Tile()
        {

        }

        //Tile tile = new Tile(5, 7, tileType.Hero);
    }
}
