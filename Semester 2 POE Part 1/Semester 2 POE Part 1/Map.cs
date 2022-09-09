using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester_2_POE_Part_1
{
    internal class Map
    {
        private Tile[,] map;
        private int mapHeight;
        private int mapWidth;
        private Enemy[] enemies;
        private Hero hero;
        private Random random = new Random();

        public Hero Hero { get { return hero; } set { hero = value; } }

        public Map(int minHeight, int maxHeight, int minWidth, int maxWidth, int enemyNumber)
        {
            this.mapHeight = random.Next(minHeight,maxHeight);
            this.mapWidth = random.Next(minWidth,maxWidth);
            map = new Tile[mapHeight,mapWidth];
            enemies = new Enemy[enemyNumber];

            for (int i = 0; i < mapHeight; i++)
            {
                for (int j = 0; j < mapWidth; j++)
                {
                    if (i == 0 || i == mapHeight - 1 || j == 0 || j == mapWidth - 1)
                    {
                        map[i, j] = new Obstacle(i, j, "X");
                    }
                    
                }
            }

            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = (Enemy)Create(Tile.tileType.Enemy);
            }

            hero = (Hero)Create(Tile.tileType.Hero);

            UpdateVision(hero);
            foreach (Enemy enemy in enemies)
            {
                UpdateVision(enemy);
            }

            MapFill();
        }

        public void UpdateVision(Character character)
        {
            Tile[] tmp = new Tile[4];

            //up
            tmp[0] = map[character.X, character.Y + 1];
            //down
            tmp[1] = map[character.X, character.Y - 1];
            //left
            tmp[2] = map[character.X - 1, character.Y];
            //right
            tmp[3] = map[character.X + 1, character.Y];

            character.VISION = tmp;
        }

        private Tile Create(Tile.tileType type)
        {
            int X;
            int Y;
            bool validPosition = false;
            do
            {
                X = random.Next(mapHeight);
                Y = random.Next(mapWidth);

                if (map[X,Y] == null)
                {
                    validPosition = true;
                }

            } while (validPosition == false);

            switch (type)
            {
                case Tile.tileType.Hero:
                    return new Hero(X, Y, 2, 10, 10, "H");
                case Tile.tileType.Enemy:
                    return new SwampCreature(X,Y);
                case Tile.tileType.Gold:
                    return null;                //these return null because we have not implemented gold or weapons in the game yet
                case Tile.tileType.weapon:
                    return null;                //these return null because we have not implemented gold or weapons in the game yet
                default:
                    return null;
            }
        }

        public void MapFill()
        {
            for (int x = 0; x < mapWidth; x++)
            {
                for (int y = 0; y < mapHeight; y++)
                {
                    if (map[x,y] == null)
                    {
                        map[x,y] = new EmptyTile(x,y);
                    }
                }
            }
        }
    }
}
