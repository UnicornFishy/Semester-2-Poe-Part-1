using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Tile
{
	protected int X;
	protected int Y;

	public int x { get { return X; } set { X = value; } };
	public int y { get { return Y; } set { Y = value; } };

	public enum tileType { Hero, Enemy, Gold, weapon };

	public Tile( X, Y)
	{

	}
}
