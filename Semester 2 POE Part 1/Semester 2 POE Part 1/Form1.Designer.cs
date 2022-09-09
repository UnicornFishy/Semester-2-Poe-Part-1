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
            this.SuspendLayout();
            // 
            // upButton
            // 
            this.upButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.upButton.Location = new System.Drawing.Point(559, 223);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(76, 70);
            this.upButton.TabIndex = 0;
            this.upButton.Text = "Up";
            this.upButton.UseVisualStyleBackColor = true;
            // 
            // leftButton
            // 
            this.leftButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.leftButton.Location = new System.Drawing.Point(467, 311);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(76, 70);
            this.leftButton.TabIndex = 1;
            this.leftButton.Text = "Left";
            this.leftButton.UseVisualStyleBackColor = true;
            // 
            // downButton
            // 
            this.downButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.downButton.Location = new System.Drawing.Point(559, 311);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(76, 70);
            this.downButton.TabIndex = 2;
            this.downButton.Text = "Down";
            this.downButton.UseVisualStyleBackColor = true;
            // 
            // rightButton
            // 
            this.rightButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rightButton.Location = new System.Drawing.Point(652, 311);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(76, 70);
            this.rightButton.TabIndex = 3;
            this.rightButton.Text = "Right";
            this.rightButton.UseVisualStyleBackColor = true;
            // 
            // mapDisplayTextBox
            // 
            this.mapDisplayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mapDisplayTextBox.Location = new System.Drawing.Point(80, 40);
            this.mapDisplayTextBox.Multiline = true;
            this.mapDisplayTextBox.Name = "mapDisplayTextBox";
            this.mapDisplayTextBox.ReadOnly = true;
            this.mapDisplayTextBox.Size = new System.Drawing.Size(274, 341);
            this.mapDisplayTextBox.TabIndex = 4;
            // 
            // playerStatsLabel
            // 
            this.playerStatsLabel.AutoSize = true;
            this.playerStatsLabel.Location = new System.Drawing.Point(488, 46);
            this.playerStatsLabel.Name = "playerStatsLabel";
            this.playerStatsLabel.Size = new System.Drawing.Size(180, 16);
            this.playerStatsLabel.TabIndex = 5;
            this.playerStatsLabel.Text = "Player stats comes here wow";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playerStatsLabel);
            this.Controls.Add(this.mapDisplayTextBox);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.upButton);
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
    }
}

