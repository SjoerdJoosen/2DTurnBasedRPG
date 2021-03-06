﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace turnBasedRPG
{
    public partial class Battlescreen : Form
    {
        public static PlayerManager playermanager { get; private set; }
        public Player player { get; private set; }
        
        public Battlescreen(Player player)
        {
            InitializeComponent();
            this.player = player;
            PlayerNameLabel.Text = Player.playerName;
            EnemyBox.Image = Properties.Resources.HardEnemy1;

            playermanager = new PlayerManager();
            enemyHP.Text = PlayerManager.enemy.CurrentHealth.ToString();
            playerHP.Text = PlayerManager.player.CurrentHealth.ToString();
        }

        private void Attack_Click(object sender, EventArgs e)
        {
            playermanager.Attack();
            enemyHP.Text = PlayerManager.enemy.CurrentHealth.ToString();
            playerHP.Text = PlayerManager.player.CurrentHealth.ToString();
            playermanager.EndGame();
        }

        private void Defend_Click(object sender, EventArgs e)
        {
            playermanager.Defend();
            playerHP.Text = PlayerManager.player.CurrentHealth.ToString();
            playermanager.EndGame();
        }

        private void UsePotion_Click_1(object sender, EventArgs e)
        {
            playermanager.UsePotion();
            playerHP.Text = PlayerManager.player.CurrentHealth.ToString();
            playermanager.EndGame();
        }
        
    }
}
