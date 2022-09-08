using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester_2_POE_Part_1
{
     internal class Enemy : Character
    {
        public override movement ReturnMove(movement enemyMovement)
        {
            throw new NotImplementedException();
        }

        protected Random random = new Random();
        protected Enemy(int X, int Y, int DAMAGE, int HP, int MaxHP, string symbol) : base(X,Y, HP, MaxHP, DAMAGE, symbol)
        {

        }

        public override string ToString()
        {
            //EnemyClassName at[X, Y] (Amount DMG)
            string enemyInfo = "The " + symbol; //need to add enemy name
            enemyInfo += "is at " + X.ToString() + Y.ToString();
            enemyInfo += "and it deals " + Damage.ToString() + " damage";

            return enemyInfo;
        }

    }
     class SwampCreature : Enemy
    {
        public SwampCreature(int X, int Y) : base(X, Y, 10, 10, 1, "SC")
        {

        }
        public override movement ReturnMove(movement enemyMovementSwampCreature)
        {
            Random rnd = new Random();
            int randomEnemyMovementDirection = rnd.Next(5);

            switch (randomEnemyMovementDirection)
            {
                case 0:
                    if((this.VISION[0] is Obstacle) || (this.VISION[0] is Hero))            // !Hero and !Obstacle do not work
                    {
                        //how do I make it loop?
                        break;
                    }
                    else { enemyMovementSwampCreature = movement.up; } 
                    break;
                case 1:
                    if ((this.VISION[1] is Obstacle) || (this.VISION[1] is Hero))            // !Hero and !Obstacle do not work
                    {
                        break;
                    }
                    else { enemyMovementSwampCreature = movement.down; }
                    
                    break;
                case 2:
                    if ((this.VISION[2] is Obstacle) || (this.VISION[2] is Hero))            // !Hero and !Obstacle do not work
                    {
                        break;
                    }
                    else { enemyMovementSwampCreature = movement.left; }
              
                    break;
                case 3:
                    if ((this.VISION[3] is Obstacle) || (this.VISION[3] is Hero))            // !Hero and !Obstacle do not work
                    {
                        break;
                    }
                    else { enemyMovementSwampCreature = movement.right; }
                    
                    break;
               case 4:
                    if ((this.VISION[4] is Obstacle) || (this.VISION[4] is Hero))            // !Hero and !Obstacle do not work
                    {
                        break;
                    }
                    else { enemyMovementSwampCreature = movement.NoMovement; }
                    
                    break;
            }
            return enemyMovementSwampCreature;
        }
    }





























}
