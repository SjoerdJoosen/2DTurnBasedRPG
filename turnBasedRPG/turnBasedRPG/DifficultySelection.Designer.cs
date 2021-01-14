namespace turnBasedRPG
{
    partial class DifficultySelection
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
            this.cb_DifficultySelect = new System.Windows.Forms.ComboBox();
            this.GoToBattlescreen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PlayerNameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cb_DifficultySelect
            // 
            this.cb_DifficultySelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_DifficultySelect.FormattingEnabled = true;
            this.cb_DifficultySelect.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard",
            "Impossible"});
            this.cb_DifficultySelect.Location = new System.Drawing.Point(16, 124);
            this.cb_DifficultySelect.Name = "cb_DifficultySelect";
            this.cb_DifficultySelect.Size = new System.Drawing.Size(166, 21);
            this.cb_DifficultySelect.TabIndex = 4;
            this.cb_DifficultySelect.SelectedIndexChanged += new System.EventHandler(this.cb_DifficultySelect_SelectedIndexChanged);
            // 
            // GoToBattlescreen
            // 
            this.GoToBattlescreen.Font = new System.Drawing.Font("HP Simplified", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToBattlescreen.Location = new System.Drawing.Point(16, 155);
            this.GoToBattlescreen.Name = "GoToBattlescreen";
            this.GoToBattlescreen.Size = new System.Drawing.Size(166, 93);
            this.GoToBattlescreen.TabIndex = 5;
            this.GoToBattlescreen.Text = "Go to game!";
            this.GoToBattlescreen.UseVisualStyleBackColor = true;
            this.GoToBattlescreen.Click += new System.EventHandler(this.GoToBattlescreen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HP Simplified", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select your difficulty:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HP Simplified", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Insert Player Name:";
            // 
            // PlayerNameBox
            // 
            this.PlayerNameBox.Location = new System.Drawing.Point(18, 37);
            this.PlayerNameBox.Name = "PlayerNameBox";
            this.PlayerNameBox.Size = new System.Drawing.Size(164, 20);
            this.PlayerNameBox.TabIndex = 8;
            // 
            // DifficultySelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 294);
            this.Controls.Add(this.PlayerNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GoToBattlescreen);
            this.Controls.Add(this.cb_DifficultySelect);
            this.Name = "DifficultySelection";
            this.Text = "DifficultySelect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_DifficultySelect;
        private System.Windows.Forms.Button GoToBattlescreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PlayerNameBox;
    }
}