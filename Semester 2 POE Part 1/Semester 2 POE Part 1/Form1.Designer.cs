namespace Semester_2_POE_Part_1
{
    partial class Form1
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
            this.upButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.mapDisplayTextBox = new System.Windows.Forms.TextBox();
            this.playerStatsLabel = new System.Windows.Forms.Label();
            this.EnemyStatsTextbox = new System.Windows.Forms.RichTextBox();
            this.SelectEnemyDropDownList = new System.Windows.Forms.ComboBox();
            this.attackEnemyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // upButton
            // 
            this.upButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.upButton.Location = new System.Drawing.Point(353, 181);
            this.upButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(57, 57);
            this.upButton.TabIndex = 0;
            this.upButton.Text = "Up";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // leftButton
            // 
            this.leftButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.leftButton.Location = new System.Drawing.Point(284, 253);
            this.leftButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(57, 57);
            this.leftButton.TabIndex = 1;
            this.leftButton.Text = "Left";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // downButton
            // 
            this.downButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.downButton.Location = new System.Drawing.Point(353, 253);
            this.downButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(57, 57);
            this.downButton.TabIndex = 2;
            this.downButton.Text = "Down";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rightButton.Location = new System.Drawing.Point(423, 253);
            this.rightButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(57, 57);
            this.rightButton.TabIndex = 3;
            this.rightButton.Text = "Right";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // mapDisplayTextBox
            // 
            this.mapDisplayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mapDisplayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapDisplayTextBox.Location = new System.Drawing.Point(60, 32);
            this.mapDisplayTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mapDisplayTextBox.Multiline = true;
            this.mapDisplayTextBox.Name = "mapDisplayTextBox";
            this.mapDisplayTextBox.ReadOnly = true;
            this.mapDisplayTextBox.Size = new System.Drawing.Size(206, 277);
            this.mapDisplayTextBox.TabIndex = 4;
            // 
            // playerStatsLabel
            // 
            this.playerStatsLabel.AutoSize = true;
            this.playerStatsLabel.Location = new System.Drawing.Point(311, 32);
            this.playerStatsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerStatsLabel.Name = "playerStatsLabel";
            this.playerStatsLabel.Size = new System.Drawing.Size(144, 13);
            this.playerStatsLabel.TabIndex = 5;
            this.playerStatsLabel.Text = "Player stats comes here wow";
            // 
            // EnemyStatsTextbox
            // 
            this.EnemyStatsTextbox.Location = new System.Drawing.Point(482, 32);
            this.EnemyStatsTextbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EnemyStatsTextbox.Name = "EnemyStatsTextbox";
            this.EnemyStatsTextbox.ReadOnly = true;
            this.EnemyStatsTextbox.Size = new System.Drawing.Size(110, 157);
            this.EnemyStatsTextbox.TabIndex = 6;
            this.EnemyStatsTextbox.Text = "";
            this.EnemyStatsTextbox.TextChanged += new System.EventHandler(this.EnemyStatsTextbox_TextChanged);
            // 
            // SelectEnemyDropDownList
            // 
            this.SelectEnemyDropDownList.FormattingEnabled = true;
            this.SelectEnemyDropDownList.Location = new System.Drawing.Point(489, 201);
            this.SelectEnemyDropDownList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SelectEnemyDropDownList.Name = "SelectEnemyDropDownList";
            this.SelectEnemyDropDownList.Size = new System.Drawing.Size(92, 21);
            this.SelectEnemyDropDownList.TabIndex = 7;
            this.SelectEnemyDropDownList.SelectedIndexChanged += new System.EventHandler(this.SelectEnemy_SelectedIndexChanged);
            // 
            // attackEnemyButton
            // 
            this.attackEnemyButton.Location = new System.Drawing.Point(508, 237);
            this.attackEnemyButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.attackEnemyButton.Name = "attackEnemyButton";
            this.attackEnemyButton.Size = new System.Drawing.Size(56, 19);
            this.attackEnemyButton.TabIndex = 8;
            this.attackEnemyButton.Text = "Attack";
            this.attackEnemyButton.UseVisualStyleBackColor = true;
            this.attackEnemyButton.Click += new System.EventHandler(this.attackEnemyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 370);
            this.Controls.Add(this.attackEnemyButton);
            this.Controls.Add(this.SelectEnemyDropDownList);
            this.Controls.Add(this.EnemyStatsTextbox);
            this.Controls.Add(this.playerStatsLabel);
            this.Controls.Add(this.mapDisplayTextBox);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.upButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.TextBox mapDisplayTextBox;
        private System.Windows.Forms.Label playerStatsLabel;
        private System.Windows.Forms.RichTextBox EnemyStatsTextbox;
        private System.Windows.Forms.ComboBox SelectEnemyDropDownList;
        private System.Windows.Forms.Button attackEnemyButton;
    }
}

