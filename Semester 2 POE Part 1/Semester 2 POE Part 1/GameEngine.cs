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
            switch(move)
            {
                case Character.movement.NoMovement:
                    return true;
                    break;
                case Character.movement.up:
                    map.Hero.Move(map.Hero.ReturnMove(Character.movement.up));
                    break;
                case Character.movement.down:
                    break;
                case Character.movement.right:
                    break;
                case Character.movement.left:
                    break;
            }
            return false;
        }
    }
}
