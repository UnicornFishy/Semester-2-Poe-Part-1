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
     





























}
