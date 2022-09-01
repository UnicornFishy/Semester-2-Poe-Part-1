using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester_2_POE_Part_1
{
    abstract class Character : Tile
    {
        protected int hp;
        protected int maxHp;
        protected int damage;

        public int HP { get { return hp; } set { hp = value; } }
        public int MaxHp { get { return maxHp; } set { maxHp = value; } }

        public int Damage { get { return damage; } set { damage = value; } }

        Tile[] characterVision = new Tile[3];

        public enum movement { NoMovement, up, down, left, right }

        //public virtual void Attack { }

        public bool isDead = false;

        public Character()
        {
            
            //This method is to denote whether or not the character is alive or dead. nested to not perma loop it.
            if (isDead == false)
            {
                if (hp <= 0)
                {
                    isDead = true;
                }
            }
        }
    }
}
