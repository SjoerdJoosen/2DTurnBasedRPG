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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label HP2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Battlescreen));
            this.Attack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.playerHP = new System.Windows.Forms.Label();
            this.Defend = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.UsePotion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.enemyHP = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            HP = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            HP2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // HP
            // 
            HP.AutoSize = true;
            HP.Location = new System.Drawing.Point(13, 22);
            HP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            HP.Name = "HP";
            HP.Size = new System.Drawing.Size(31, 17);
            HP.TabIndex = 2;
            HP.Text = "HP:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(13, 52);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(199, 17);
            label2.TabIndex = 7;
            label2.Text = "Turns until potion replenishes:";
            // 
            // HP2
            // 
            HP2.AutoSize = true;
            HP2.Location = new System.Drawing.Point(691, 22);
            HP2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            HP2.Name = "HP2";
            HP2.Size = new System.Drawing.Size(31, 17);
            HP2.TabIndex = 9;
            HP2.Text = "HP:";
            // 
            // Attack
            // 
            this.Attack.Location = new System.Drawing.Point(17, 506);
            this.Attack.Margin = new System.Windows.Forms.Padding(4);
            this.Attack.Name = "Attack";
            this.Attack.Size = new System.Drawing.Size(167, 62);
            this.Attack.TabIndex = 0;
            this.Attack.Text = "Attack";
            this.Attack.UseVisualStyleBackColor = true;
            this.Attack.Click += new System.EventHandler(this.Attack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 130);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 369);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // playerHP
            // 
            this.playerHP.AutoSize = true;
            this.playerHP.Location = new System.Drawing.Point(53, 22);
            this.playerHP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerHP.Name = "playerHP";
            this.playerHP.Size = new System.Drawing.Size(0, 17);
            this.playerHP.TabIndex = 3;
            // 
            // Defend
            // 
            this.Defend.Location = new System.Drawing.Point(183, 506);
            this.Defend.Margin = new System.Windows.Forms.Padding(4);
            this.Defend.Name = "Defend";
            this.Defend.Size = new System.Drawing.Size(167, 62);
            this.Defend.TabIndex = 4;
            this.Defend.Text = "Defend";
            this.Defend.UseVisualStyleBackColor = true;
            this.Defend.Click += new System.EventHandler(this.Defend_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(17, 566);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 62);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // UsePotion
            // 
            this.UsePotion.Location = new System.Drawing.Point(99, 566);
            this.UsePotion.Margin = new System.Windows.Forms.Padding(4);
            this.UsePotion.Name = "UsePotion";
            this.UsePotion.Size = new System.Drawing.Size(167, 62);
            this.UsePotion.TabIndex = 6;
            this.UsePotion.Text = "Use potion";
            this.UsePotion.UseVisualStyleBackColor = true;
            this.UsePotion.Click += new System.EventHandler(this.UsePotion_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 8;
            // 
            // enemyHP
            // 
            this.enemyHP.AutoSize = true;
            this.enemyHP.Location = new System.Drawing.Point(731, 22);
            this.enemyHP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.enemyHP.Name = "enemyHP";
            this.enemyHP.Size = new System.Drawing.Size(0, 17);
            this.enemyHP.TabIndex = 10;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(694, 130);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(333, 369);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // Battlescreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 660);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.enemyHP);
            this.Controls.Add(HP2);
            this.Controls.Add(this.label1);
            this.Controls.Add(label2);
            this.Controls.Add(this.UsePotion);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Defend);
            this.Controls.Add(this.playerHP);
            this.Controls.Add(HP);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Attack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Battlescreen";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label enemyHP;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

