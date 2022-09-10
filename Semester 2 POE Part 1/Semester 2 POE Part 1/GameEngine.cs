using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester_2_POE_Part_1
{
    internal class GameEngine
    {
        private Map gameMap;
        public Map getMap() { return gameMap; }

        public GameEngine()
        {
            gameMap = new Map(10, 10, 10, 10, 3);
        }

        public bool MovePlayer(Character.movement move)
        {
            if (move == Character.movement.NoMovement) return false;

            Character.movement dir = gameMap.Hero.ReturnMove(move);
            if (dir == move)
            {
                gameMap.GetMap()[gameMap.Hero.X, gameMap.Hero.Y] = new EmptyTile(gameMap.Hero.X, gameMap.Hero.Y, " . ");
                gameMap.Hero.Move(move);
                gameMap.GetMap()[gameMap.Hero.X, gameMap.Hero.Y] = gameMap.Hero;
                gameMap.UpdateVision(gameMap.Hero);

                for (int i = 0; i < gameMap.GetEnemies().Length; i++)
                {
                    gameMap.UpdateVision(gameMap.GetEnemies()[i]);
                }
                return true;
            }
            else
            {
                return false;
            }

            
        }
    }
}
