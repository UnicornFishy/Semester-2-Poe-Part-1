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
            gameMap = new Map(5, 17, 5, 13, 5);
        }

        public bool MovePlayer(Character.movement move)
        {
            if (move == Character.movement.NoMovement) return false;

            Character.movement dir = gameMap.Heroprop.ReturnMove(move);
            if (dir == move)
            {
                gameMap.GetMap()[gameMap.Heroprop.X, gameMap.Heroprop.Y] = new EmptyTile(gameMap.Heroprop.X, gameMap.Heroprop.Y, " . ");
                gameMap.Heroprop.Move(move);
                gameMap.GetMap()[gameMap.Heroprop.X, gameMap.Heroprop.Y] = gameMap.Heroprop;
                gameMap.UpdateVision(gameMap.Heroprop);

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
