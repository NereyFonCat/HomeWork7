﻿namespace WF_Udvoitel
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
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnCommand1 = new System.Windows.Forms.Button();
            this.btnCommand2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.программаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.lblGoalText = new System.Windows.Forms.Label();
            this.lblStepsText = new System.Windows.Forms.Label();
            this.lblStepsCount = new System.Windows.Forms.Label();
            this.lblGoal = new System.Windows.Forms.Label();
            this.lblCurrentValue = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(159, 101);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(46, 17);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "label1";
            // 
            // btnCommand1
            // 
            this.btnCommand1.Location = new System.Drawing.Point(269, 43);
            this.btnCommand1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCommand1.Name = "btnCommand1";
            this.btnCommand1.Size = new System.Drawing.Size(100, 28);
            this.btnCommand1.TabIndex = 1;
            this.btnCommand1.Text = "button1";
            this.btnCommand1.UseVisualStyleBackColor = true;
            this.btnCommand1.Click += new System.EventHandler(this.btnCommand1_Click);
            // 
            // btnCommand2
            // 
            this.btnCommand2.Location = new System.Drawing.Point(269, 89);
            this.btnCommand2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCommand2.Name = "btnCommand2";
            this.btnCommand2.Size = new System.Drawing.Size(100, 28);
            this.btnCommand2.TabIndex = 2;
            this.btnCommand2.Text = "button2";
            this.btnCommand2.UseVisualStyleBackColor = true;
            this.btnCommand2.Click += new System.EventHandler(this.btnCommand2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(269, 134);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 28);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "button3";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.программаToolStripMenuItem,
            this.menuCancel});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(385, 30);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // программаToolStripMenuItem
            // 
            this.программаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStart,
            this.menuStop});
            this.программаToolStripMenuItem.Name = "программаToolStripMenuItem";
            this.программаToolStripMenuItem.Size = new System.Drawing.Size(65, 26);
            this.программаToolStripMenuItem.Text = "Меню";
            // 
            // menuStart
            // 
            this.menuStart.Name = "menuStart";
            this.menuStart.Size = new System.Drawing.Size(173, 26);
            this.menuStart.Text = "Играть";
            this.menuStart.Click += new System.EventHandler(this.menuStart_Click);
            // 
            // menuStop
            // 
            this.menuStop.Name = "menuStop";
            this.menuStop.Size = new System.Drawing.Size(173, 26);
            this.menuStop.Text = "Остановить";
            this.menuStop.Click += new System.EventHandler(this.menuStop_Click);
            // 
            // menuCancel
            // 
            this.menuCancel.Name = "menuCancel";
            this.menuCancel.Size = new System.Drawing.Size(158, 26);
            this.menuCancel.Text = "Отменить действие";
            this.menuCancel.Click += new System.EventHandler(this.menuCancel_Click);
            // 
            // lblGoalText
            // 
            this.lblGoalText.AutoSize = true;
            this.lblGoalText.Location = new System.Drawing.Point(11, 49);
            this.lblGoalText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGoalText.Name = "lblGoalText";
            this.lblGoalText.Size = new System.Drawing.Size(46, 17);
            this.lblGoalText.TabIndex = 5;
            this.lblGoalText.Text = "Цель:";
            // 
            // lblStepsText
            // 
            this.lblStepsText.AutoSize = true;
            this.lblStepsText.Location = new System.Drawing.Point(11, 150);
            this.lblStepsText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStepsText.Name = "lblStepsText";
            this.lblStepsText.Size = new System.Drawing.Size(52, 17);
            this.lblStepsText.TabIndex = 6;
            this.lblStepsText.Text = "Ходов:";
            // 
            // lblStepsCount
            // 
            this.lblStepsCount.AutoSize = true;
            this.lblStepsCount.Location = new System.Drawing.Point(139, 150);
            this.lblStepsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStepsCount.Name = "lblStepsCount";
            this.lblStepsCount.Size = new System.Drawing.Size(0, 17);
            this.lblStepsCount.TabIndex = 7;
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.Location = new System.Drawing.Point(72, 49);
            this.lblGoal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(0, 17);
            this.lblGoal.TabIndex = 8;
            // 
            // lblCurrentValue
            // 
            this.lblCurrentValue.AutoSize = true;
            this.lblCurrentValue.Location = new System.Drawing.Point(11, 101);
            this.lblCurrentValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentValue.Name = "lblCurrentValue";
            this.lblCurrentValue.Size = new System.Drawing.Size(137, 17);
            this.lblCurrentValue.TabIndex = 9;
            this.lblCurrentValue.Text = "Текущее значение:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 177);
            this.Controls.Add(this.lblCurrentValue);
            this.Controls.Add(this.lblGoal);
            this.Controls.Add(this.lblStepsCount);
            this.Controls.Add(this.lblStepsText);
            this.Controls.Add(this.lblGoalText);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCommand2);
            this.Controls.Add(this.btnCommand1);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Doubler";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnCommand1;
        private System.Windows.Forms.Button btnCommand2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem программаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStart;
        private System.Windows.Forms.ToolStripMenuItem menuStop;
        private System.Windows.Forms.ToolStripMenuItem menuCancel;
        private System.Windows.Forms.Label lblGoalText;
        private System.Windows.Forms.Label lblStepsText;
        private System.Windows.Forms.Label lblStepsCount;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.Label lblCurrentValue;
    }
}
