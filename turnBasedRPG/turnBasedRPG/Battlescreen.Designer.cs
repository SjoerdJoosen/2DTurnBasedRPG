namespace turnBasedRPG
{
    partial class Battlescreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label HP;
            System.Windows.Forms.Label HP2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Battlescreen));
            this.Attack = new System.Windows.Forms.Button();
            this.playerHP = new System.Windows.Forms.Label();
            this.Defend = new System.Windows.Forms.Button();
            this.UsePotion = new System.Windows.Forms.Button();
            this.enemyHP = new System.Windows.Forms.Label();
            this.PlayerNameLabel = new System.Windows.Forms.Label();
            this.EnemyBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            HP = new System.Windows.Forms.Label();
            HP2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // HP
            // 
            HP.AutoSize = true;
            HP.Location = new System.Drawing.Point(12, 50);
            HP.Name = "HP";
            HP.Size = new System.Drawing.Size(25, 13);
            HP.TabIndex = 2;
            HP.Text = "HP:";
            // 
            // HP2
            // 
            HP2.AutoSize = true;
            HP2.Location = new System.Drawing.Point(517, 50);
            HP2.Name = "HP2";
            HP2.Size = new System.Drawing.Size(25, 13);
            HP2.TabIndex = 9;
            HP2.Text = "HP:";
            // 
            // Attack
            // 
            this.Attack.Location = new System.Drawing.Point(13, 335);
            this.Attack.Name = "Attack";
            this.Attack.Size = new System.Drawing.Size(125, 50);
            this.Attack.TabIndex = 0;
            this.Attack.Text = "Attack";
            this.Attack.UseVisualStyleBackColor = true;
            this.Attack.Click += new System.EventHandler(this.Attack_Click);
            // 
            // playerHP
            // 
            this.playerHP.AutoSize = true;
            this.playerHP.Location = new System.Drawing.Point(42, 50);
            this.playerHP.Name = "playerHP";
            this.playerHP.Size = new System.Drawing.Size(0, 13);
            this.playerHP.TabIndex = 3;
            // 
            // Defend
            // 
            this.Defend.Location = new System.Drawing.Point(138, 335);
            this.Defend.Name = "Defend";
            this.Defend.Size = new System.Drawing.Size(125, 50);
            this.Defend.TabIndex = 4;
            this.Defend.Text = "Defend";
            this.Defend.UseVisualStyleBackColor = true;
            this.Defend.Click += new System.EventHandler(this.Defend_Click);
            // 
            // UsePotion
            // 
            this.UsePotion.Location = new System.Drawing.Point(75, 384);
            this.UsePotion.Name = "UsePotion";
            this.UsePotion.Size = new System.Drawing.Size(125, 50);
            this.UsePotion.TabIndex = 6;
            this.UsePotion.Text = "Use potion";
            this.UsePotion.UseVisualStyleBackColor = true;
            this.UsePotion.Click += new System.EventHandler(this.UsePotion_Click_1);
            // 
            // enemyHP
            // 
            this.enemyHP.AutoSize = true;
            this.enemyHP.Location = new System.Drawing.Point(548, 50);
            this.enemyHP.Name = "enemyHP";
            this.enemyHP.Size = new System.Drawing.Size(0, 13);
            this.enemyHP.TabIndex = 10;
            // 
            // PlayerNameLabel
            // 
            this.PlayerNameLabel.AutoSize = true;
            this.PlayerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerNameLabel.Location = new System.Drawing.Point(12, 18);
            this.PlayerNameLabel.Name = "PlayerNameLabel";
            this.PlayerNameLabel.Size = new System.Drawing.Size(0, 17);
            this.PlayerNameLabel.TabIndex = 12;
            // 
            // EnemyBox
            // 
            this.EnemyBox.Image = global::turnBasedRPG.Properties.Resources.HardEnemy1;
            this.EnemyBox.Location = new System.Drawing.Point(520, 79);
            this.EnemyBox.Name = "EnemyBox";
            this.EnemyBox.Size = new System.Drawing.Size(250, 250);
            this.EnemyBox.TabIndex = 13;
            this.EnemyBox.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 384);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Battlescreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 439);
            this.Controls.Add(this.EnemyBox);
            this.Controls.Add(this.PlayerNameLabel);
            this.Controls.Add(this.enemyHP);
            this.Controls.Add(HP2);
            this.Controls.Add(this.UsePotion);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Defend);
            this.Controls.Add(this.playerHP);
            this.Controls.Add(HP);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Attack);
            this.Name = "Battlescreen";
            this.Text = "Battlescreen";
            ((System.ComponentModel.ISupportInitialize)(this.EnemyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Attack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Defend;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button UsePotion;
        private System.Windows.Forms.Label playerHP;
        private System.Windows.Forms.Label enemyHP;
        private System.Windows.Forms.Label PlayerNameLabel;
        public System.Windows.Forms.PictureBox EnemyBox;
    }
}

