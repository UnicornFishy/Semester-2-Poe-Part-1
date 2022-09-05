using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester_2_POE_Part_1
{
    public abstract class Character : Tile
    {
        protected int hp;
        protected int maxHp;
        protected int damage;

        public int HP { get { return hp; } set { hp = value; } }
        public int MaxHp { get { return maxHp; } set { maxHp = value; } }

        public int Damage { get { return damage; } set { damage = value; } }

        protected List<Tile> vision = new List<Tile>();
        protected tileType tile;

        public List<Tile> VISION { get { return vision; } set { vision = value; } }
        private List<Tile> Vision{ get { return Vision; }set { Vision = value; }}
        public tileType Tile { get { return tile; } set { tile = value; } }

        public void SetVision(Tile[,] characterSight)
        {
            this.VISION.Clear();                                    //postions in the list array
            this.VISION.Add(characterSight[this.X + 1,this.Y]);     //0
            this.Vision.Add(characterSight[this.X - 1,this.Y]);     //1
            this.Vision.Add(characterSight[this.X, this.Y - 1]);    //2
            this.Vision.Add(characterSight[this.X, this.Y + 1]);    //3
            this.VISION.Add(characterSight[this.X, this.Y]);        //4
        }

        private movement Movement;
        public movement MOVEMENT { get { return Movement; } set { Movement = value; } }
        public enum movement { NoMovement, up, down, left, right }
        public void Move(movement move)
        {
            switch (move)
            {
                case movement.NoMovement:
                    this.X = X;
                    this.Y = Y;
                    break;

                case movement.up:
                    this.X = X--;
                    break;

                case movement.down:
                    this.X = X++;

                    break;

                case movement.right:
                    this.Y = Y++;
                    break;

                case movement.left:
                    this.Y = Y--;
                    break;
            }
        }

        public abstract movement ReturnMove(movement move = 0);

        public virtual void Attack(Character Target)
        {
            Target.HP -= Damage;
        }

        public bool isDead()
        {
            if (HP <= 0)
            {
                return true;
            }
            return false;
        }

        public virtual bool CheckRange()
        {
            //needs to return true or false
            return true;
        }

        private int distanceTo(Character Target)
        {
            //private int diagnal = 2;
            //private int vertical = 1;
            //private int horozontal = 1;

            return 2;
        }

        public abstract override string ToString();

        public Character(int X, int Y, int DAMAGE, int HP, int MaxHP, string symbol)
        {
            
            //This method is to denote whether or not the character is alive or dead. nested to not perma loop it.
           
        }
    }
}
