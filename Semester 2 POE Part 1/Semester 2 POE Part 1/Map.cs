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
            
        }

        public void UpdateVision()
        {

        }


    }
}
