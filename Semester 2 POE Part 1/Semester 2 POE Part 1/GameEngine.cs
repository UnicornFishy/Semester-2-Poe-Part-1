using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester_2_POE_Part_1
{
    internal class GameEngine
    {
        private Map map;
        public Map getMap() { return map; }

        public bool MovePlayer(Character.movement move)
        {
            if (move == Character.movement.NoMovement) return false;

            Character.movement dir = map.Hero.ReturnMove(move);
            if (dir == move)
            {
                map.Hero.Move(move);
                return true;
            }
            else
            {
                return false;
            }

            
        }
    }
}
