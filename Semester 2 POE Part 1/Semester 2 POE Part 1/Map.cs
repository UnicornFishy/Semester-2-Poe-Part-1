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
                        map[i, j] = new Obstacle(i, j);
                    }
                    
                }
            }

            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = (Enemy)Create(Tile.tileType.Enemy);
            }

            hero = (Hero)Create(Tile.tileType.Hero);


        }

        public void UpdateVision()
        {
            Tile[] heroVision = new Tile[5];
            heroVision[0] = map[hero.X+1,hero.Y];
            heroVision[1] = map[hero.X-1,hero.Y];
            heroVision[2] = map[hero.X,hero.Y-1];
            heroVision[3] = map[hero.X,hero.Y+1];
            heroVision[5] = map[hero.X,hero.Y];

            // hero.SetVision(heroVision);

            foreach (Enemy enemy in enemies)
            {
                Tile[] enemyVision = new Tile[5];
                enemyVision[0] = map[enemy.X + 1, enemy.Y];
                enemyVision[1] = map[enemy.X - 1, enemy.Y];
                enemyVision[2] = map[enemy.X, enemy.Y - 1];
                enemyVision[3] = map[enemy.X, enemy.Y + 1];
                enemyVision[4] = map[enemy.X, enemy.Y];

               // enemy.SetVision(enemyVision);
            }
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
                    return null;
                case Tile.tileType.weapon:
                    return null;
                default:
                    return null;
            }
        }
    }
}
