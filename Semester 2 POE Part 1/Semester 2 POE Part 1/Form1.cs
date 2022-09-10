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
        }

        private void EnemyStatsTextbox_TextChanged(object sender, EventArgs e)
        {
            EnemyStatsTextbox.Text += "/n";
            //EnemyStatsTextbox.Text += Enemy.ToString(enemyInfo);
        }

        private void attackEnemyButton_Click(object sender, EventArgs e)
        {
            //if(Character.CheckRange() == true)
            {
                //Character.Attack();
            }
        }

        private void SelectEnemy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SelectEnemyDropDownList.Text == "Swamp Creature")
            {
                //idk man f this
            }
        }


        private void leftButton_Click(object sender, EventArgs e)
        {

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
        }
    }
}
