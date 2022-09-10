﻿using System;
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

        protected Tile[] vision = new Tile[4];
        protected tileType tile;

        public Tile[] VISION { get { return vision; } set { vision = value; } }     //vision [ 0 , 1 , 2 , 3 ] = { up, down, left, right }

        //private List<Tile> Vision{ get { return vision; }set { vision = value; }}
        public tileType Tile { get { return tile; } set { tile = value; } }


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

        public virtual void Attack(Character target)
        {
            target.HP -= Damage;
        }

        public bool isDead()
        {
            if (HP <= 0)
            {
                return true;
            }
            return false;
        }

        public virtual bool CheckRange(Character target)
        {
            //needs to return true or false

            
            if(DistanceTo(target) > 1)
            {
                return false;
            }
            else if(DistanceTo(target) <= 1 && DistanceTo(target)>0)
            {
                return true;
            }

            return false;

        }

        private int DistanceTo(Character Target)
        {
            int distX;
            int distY;

            distX = Math.Abs(Target.X - this.X);
            distY = Math.Abs(Target.Y = this.Y);

            return distX + distY;
        }

        public abstract override string ToString();

        public Character(int X, int Y, int DAMAGE, int HP, int MaxHP, string symbol)
        {
            
            //This method is to denote whether or not the character is alive or dead. nested to not perma loop it.
           
        }
    }
}
