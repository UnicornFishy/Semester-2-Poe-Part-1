using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Tile
{
	protected int x;
	protected int y;
	protected tileType type;

	public int X { get { return x; } set { x = value; } };
	public int Y { get { return y; } set { y = value; } };

	public enum tileType { Hero, Enemy, Gold, weapon };

	public Tile(int X,int Y, tileType type)
	{
		this.x = X;
		this.y = y;
		this.type = type;
	}

	//Tile tile = new Tile(5, 7, tileType.Hero);
}
