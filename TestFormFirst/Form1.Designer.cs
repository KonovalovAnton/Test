namespace TestFormFirst
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Mood = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.Walk = new System.Windows.Forms.ProgressBar();
            this.Hunger = new System.Windows.Forms.ProgressBar();
            this.Energy = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonIdle = new System.Windows.Forms.Button();
            this.buttonWalk = new System.Windows.Forms.Button();
            this.buttonSleep = new System.Windows.Forms.Button();
            this.buttonEat = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTimer = new System.Windows.Forms.Label();
            this.labelEnergyStatus = new System.Windows.Forms.Label();
            this.labelHungerStatus = new System.Windows.Forms.Label();
            this.labelWalkStatus = new System.Windows.Forms.Label();
            this.labelMoodStatus = new System.Windows.Forms.Label();
            this.labelEnergyPlus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Mood
            // 
            this.Mood.Location = new System.Drawing.Point(39, 388);
            this.Mood.Name = "Mood";
            this.Mood.Size = new System.Drawing.Size(100, 23);
            this.Mood.Step = 1;
            this.Mood.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mood";
            // 
            // Walk
            // 
            this.Walk.Location = new System.Drawing.Point(39, 346);
            this.Walk.Name = "Walk";
            this.Walk.Size = new System.Drawing.Size(100, 23);
            this.Walk.Step = 1;
            this.Walk.TabIndex = 2;
            // 
            // Hunger
            // 
            this.Hunger.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Hunger.Location = new System.Drawing.Point(39, 306);
            this.Hunger.Name = "Hunger";
            this.Hunger.Size = new System.Drawing.Size(100, 23);
            this.Hunger.Step = 1;
            this.Hunger.TabIndex = 3;
            // 
            // Energy
            // 
            this.Energy.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Energy.Location = new System.Drawing.Point(39, 264);
            this.Energy.Name = "Energy";
            this.Energy.Size = new System.Drawing.Size(100, 23);
            this.Energy.Step = 1;
            this.Energy.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Walk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hunger";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Energy";
            // 
            // buttonIdle
            // 
            this.buttonIdle.Location = new System.Drawing.Point(39, 66);
            this.buttonIdle.Name = "buttonIdle";
            this.buttonIdle.Size = new System.Drawing.Size(91, 57);
            this.buttonIdle.TabIndex = 8;
            this.buttonIdle.Text = "Do nothing";
            this.buttonIdle.UseVisualStyleBackColor = true;
            this.buttonIdle.Click += new System.EventHandler(this.ClickIdle);
            // 
            // buttonWalk
            // 
            this.buttonWalk.Location = new System.Drawing.Point(133, 66);
            this.buttonWalk.Name = "buttonWalk";
            this.buttonWalk.Size = new System.Drawing.Size(91, 57);
            this.buttonWalk.TabIndex = 9;
            this.buttonWalk.Text = "Go to walk";
            this.buttonWalk.UseVisualStyleBackColor = true;
            this.buttonWalk.Click += new System.EventHandler(this.ClickWalk);
            // 
            // buttonSleep
            // 
            this.buttonSleep.Location = new System.Drawing.Point(327, 66);
            this.buttonSleep.Name = "buttonSleep";
            this.buttonSleep.Size = new System.Drawing.Size(91, 57);
            this.buttonSleep.TabIndex = 11;
            this.buttonSleep.Text = "Go to sleep";
            this.buttonSleep.UseVisualStyleBackColor = true;
            this.buttonSleep.Click += new System.EventHandler(this.ClickSleep);
            // 
            // buttonEat
            // 
            this.buttonEat.Location = new System.Drawing.Point(230, 66);
            this.buttonEat.Name = "buttonEat";
            this.buttonEat.Size = new System.Drawing.Size(91, 57);
            this.buttonEat.TabIndex = 10;
            this.buttonEat.Text = "Eat smth";
            this.buttonEat.UseVisualStyleBackColor = true;
            this.buttonEat.Click += new System.EventHandler(this.ClickEat);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(424, 66);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(91, 57);
            this.buttonPlay.TabIndex = 12;
            this.buttonPlay.Text = "Go to play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.ClickPlay);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(90, 156);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(24, 13);
            this.labelStatus.TabIndex = 13;
            this.labelStatus.Text = "Idle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.SeaGreen;
            this.label6.Location = new System.Drawing.Point(44, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Status:";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(44, 27);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(49, 13);
            this.labelTimer.TabIndex = 15;
            this.labelTimer.Text = "00:00:00";
            // 
            // labelEnergyStatus
            // 
            this.labelEnergyStatus.AutoSize = true;
            this.labelEnergyStatus.Location = new System.Drawing.Point(80, 248);
            this.labelEnergyStatus.Name = "labelEnergyStatus";
            this.labelEnergyStatus.Size = new System.Drawing.Size(13, 13);
            this.labelEnergyStatus.TabIndex = 16;
            this.labelEnergyStatus.Text = "0";
            // 
            // labelHungerStatus
            // 
            this.labelHungerStatus.AutoSize = true;
            this.labelHungerStatus.Location = new System.Drawing.Point(80, 290);
            this.labelHungerStatus.Name = "labelHungerStatus";
            this.labelHungerStatus.Size = new System.Drawing.Size(13, 13);
            this.labelHungerStatus.TabIndex = 17;
            this.labelHungerStatus.Text = "0";
            // 
            // labelWalkStatus
            // 
            this.labelWalkStatus.AutoSize = true;
            this.labelWalkStatus.Location = new System.Drawing.Point(65, 330);
            this.labelWalkStatus.Name = "labelWalkStatus";
            this.labelWalkStatus.Size = new System.Drawing.Size(13, 13);
            this.labelWalkStatus.TabIndex = 18;
            this.labelWalkStatus.Text = "0";
            // 
            // labelMoodStatus
            // 
            this.labelMoodStatus.AutoSize = true;
            this.labelMoodStatus.Location = new System.Drawing.Point(67, 372);
            this.labelMoodStatus.Name = "labelMoodStatus";
            this.labelMoodStatus.Size = new System.Drawing.Size(13, 13);
            this.labelMoodStatus.TabIndex = 19;
            this.labelMoodStatus.Text = "0";
            // 
            // labelEnergyPlus
            // 
            this.labelEnergyPlus.AutoSize = true;
            this.labelEnergyPlus.Location = new System.Drawing.Point(186, 221);
            this.labelEnergyPlus.MaximumSize = new System.Drawing.Size(100, 100);
            this.labelEnergyPlus.Name = "labelEnergyPlus";
            this.labelEnergyPlus.Size = new System.Drawing.Size(13, 13);
            this.labelEnergyPlus.TabIndex = 20;
            this.labelEnergyPlus.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TestFormFirst.Properties.Resources.nothing;
            this.pictureBox1.Location = new System.Drawing.Point(327, 187);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = " Дата";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelEnergyPlus);
            this.Controls.Add(this.labelMoodStatus);
            this.Controls.Add(this.labelWalkStatus);
            this.Controls.Add(this.labelHungerStatus);
            this.Controls.Add(this.labelEnergyStatus);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonSleep);
            this.Controls.Add(this.buttonEat);
            this.Controls.Add(this.buttonWalk);
            this.Controls.Add(this.buttonIdle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Energy);
            this.Controls.Add(this.Hunger);
            this.Controls.Add(this.Walk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mood);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar Mood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar Walk;
        private System.Windows.Forms.ProgressBar Hunger;
        private System.Windows.Forms.ProgressBar Energy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonIdle;
        private System.Windows.Forms.Button buttonWalk;
        private System.Windows.Forms.Button buttonSleep;
        private System.Windows.Forms.Button buttonEat;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label labelEnergyStatus;
        private System.Windows.Forms.Label labelHungerStatus;
        private System.Windows.Forms.Label labelWalkStatus;
        private System.Windows.Forms.Label labelMoodStatus;
        private System.Windows.Forms.Label labelEnergyPlus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}

