using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semester_2_POE_Part_1
{
    public partial class Form1 : Form
    {
        GameEngine engine;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            engine = new GameEngine();            

            DisplayMap();

            engine.getMap().GetEnemies();

            string[] entires = new string[engine.getMap().GetEnemies().Length];

            for (int i = 0; i < entires.Length; i++) //drop down menu entries
            {
                entires[i] = engine.getMap().GetEnemies()[i].ToString();
                SelectEnemyDropDownList.Items.Add(entires[i]);
            }




        }

        private void EnemyStatsTextbox_TextChanged(object sender, EventArgs e)
        {
            //EnemyStatsTextbox.Text += "/n";
            //EnemyStatsTextbox.Text += Enemy.ToString(enemyInfo);
            
        }

        private void attackEnemyButton_Click(object sender, EventArgs e)
        {
            if(SelectEnemyDropDownList.SelectedIndex == null)
            {
                return; // to catch any errors if nothing in entered
            }
            try
            {
                if (engine.getMap().Heroprop.CheckRange(engine.getMap().GetEnemies()[SelectEnemyDropDownList.SelectedIndex]) == true)
                {
                    engine.getMap().Heroprop.Attack(engine.getMap().GetEnemies()[SelectEnemyDropDownList.SelectedIndex]);
                    EnemyStatsTextbox.Text = "Attack Success";
                    EnemyStatsTextbox.Text += engine.getMap().GetEnemies()[SelectEnemyDropDownList.SelectedIndex].ToString();
                    //check if enemies are dead, if they are dead create a new array without the dead ones
                    //set enemies method to overwrite the eneimes array + update combobox
                }
                else
                {
                    EnemyStatsTextbox.Text = "Attack Failed";
                }
            }
            catch(IndexOutOfRangeException exception)
            {
                EnemyStatsTextbox.Text = "Enemy is unalived";
            }
            

            int tmp = -1;

            for (int i = 0; i < engine.getMap().GetEnemies().Length; i++)
            {
                if (engine.getMap().GetEnemies()[i].isDead() == true)
                {
                    tmp = i;
                }
            }

            if(tmp != -1)
            {
                Enemy[] noDeadEnemies = new Enemy[engine.getMap().GetEnemies().Length -1 ];
                int j = 0;
                bool tempbool = true;
                for(int i = 0; i < engine.getMap().GetEnemies().Length; i++)
                {
                    //add all elements into new array except the dead one
                    if(j == tmp && tempbool == true)
                    {
                        tempbool = false;
                        
                        continue;
                    }
                    noDeadEnemies[j] = engine.getMap().GetEnemies()[i];
                    j++;
                }

                engine.getMap().SetEnemies(noDeadEnemies); //update the array to be the living enemies

                string[] entires = new string[engine.getMap().GetEnemies().Length]; //drop down menu entries

                SelectEnemyDropDownList.Items.Clear();

                for (int i = 0; i < entires.Length; i++)
                {
                    entires[i] = engine.getMap().GetEnemies()[i].ToString();
                    SelectEnemyDropDownList.Items.Add(entires[i]);
                }

            }
            
            

        }

        private void SelectEnemy_SelectedIndexChanged(object sender, EventArgs e)
        {
            //add iteams to the iteam array
            //update ++ update on attack
            //if (SelectEnemyDropDownList.Text == "Swamp Creature")
            //{
                //idk man f this
            //}
        }



        private void DisplayMap()
        {
            mapDisplayTextBox.Clear();
            for (int i = 0; i < engine.getMap().GetMapHeight(); i++)
            {
                for (int j = 0; j < engine.getMap().GetMapWidth(); j++)
                {
                    mapDisplayTextBox.Text += engine.getMap().GetSymbol(i, j);
                }
                mapDisplayTextBox.Text += Environment.NewLine;
            }

            playerStatsLabel.Text = engine.getMap().Heroprop.ToString();
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            engine.MovePlayer(Character.movement.up);
            engine.getMap().MapFill();
            DisplayMap();
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            engine.MovePlayer(Character.movement.down);
            engine.getMap().MapFill(); 
            DisplayMap();
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            engine.MovePlayer(Character.movement.right);
            engine.getMap().MapFill();
            DisplayMap();
        }
        private void leftButton_Click(object sender, EventArgs e)
        {
            engine.MovePlayer(Character.movement.left);
            engine.getMap().MapFill();
            DisplayMap();
        }
    }
}
