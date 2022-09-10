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
                gameMap.Hero.Move(move);
                return true;
            }
            else
            {
                return false;
            }

            
        }
    }
}
