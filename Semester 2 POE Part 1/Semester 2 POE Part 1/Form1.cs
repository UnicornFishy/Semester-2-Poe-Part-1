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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Map m = new Map(10, 10, 10, 10, 3); 
        }

        private void EnemyStatsTextbox_TextChanged(object sender, EventArgs e)
        {
            EnemyStatsTextbox.Text += "/n";
            EnemyStatsTextbox.Text += Enemy.ToString(enemyInfo);
        }

        private void attackEnemyButton_Click(object sender, EventArgs e)
        {
            if(Character.CheckRange() == true)
            {
                Character.Attack();
            }
        }

        private void SelectEnemy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SelectEnemyDropDownList.Text == "Swamp Creature")
            {
                //idk man f this
            }
        }
    }
}
