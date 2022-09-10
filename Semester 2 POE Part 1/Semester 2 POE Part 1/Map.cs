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

        public int GetMapHeight()
        {
            return mapHeight;
        }

        public int GetMapWidth()
        {
            return mapWidth;
        }

        public string GetSymbol(int X, int Y)
        {
            return map[X, Y].Symbol;
        }

        public Tile[,] GetMap()
        {
            return map;
        }

        public Enemy[] GetEnemies()
        {
            return enemies;
        }
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
                map[enemies[i].X, enemies[i].Y] = enemies[i];
            }

            hero = (Hero)Create(Tile.tileType.Hero);

            map[hero.X, hero.Y] = hero;
            
            MapFill();

            UpdateVision(hero);
            
            for (int i = 0; i < enemies.Length; i++)
            {
                UpdateVision(enemies[i]);
            }

        }

        public void UpdateVision(Character character)
        {
           

            //up
            character.VISION[0] = map[character.X - 1, character.Y];
            //down
            character.VISION[1] = map[character.X+ 1, character.Y];
            //left
            character.VISION[2] = map[character.X, character.Y-1];
            //right
            character.VISION[3] = map[character.X, character.Y+1];


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
            for (int x = 0; x < mapHeight; x++)
            {
                for (int y = 0; y < mapWidth; y++)
                {
                    if (map[x,y] == null)
                    {
                        map[x,y] = new EmptyTile(x,y," . ");
                    }
                }
            }
        }
    }
}
