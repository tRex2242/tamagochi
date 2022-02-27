
namespace tamagochi
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
            this.lblGameOver = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEatCur = new System.Windows.Forms.Label();
            this.dinoeat = new System.Windows.Forms.Button();
            this.hap = new System.Windows.Forms.Button();
            this.slp = new System.Windows.Forms.Button();
            this.live = new System.Windows.Forms.PictureBox();
            this.sleep = new System.Windows.Forms.PictureBox();
            this.hapy = new System.Windows.Forms.PictureBox();
            this.clear = new System.Windows.Forms.PictureBox();
            this.eat = new System.Windows.Forms.PictureBox();
            this.dino = new System.Windows.Forms.PictureBox();
            this.lblEatMax = new System.Windows.Forms.Label();
            this.lblSleepCur = new System.Windows.Forms.Label();
            this.lblSleepMax = new System.Windows.Forms.Label();
            this.lblHappyMax = new System.Windows.Forms.Label();
            this.lblHappyCur = new System.Windows.Forms.Label();
            this.lblClearMax = new System.Windows.Forms.Label();
            this.lblClearCur = new System.Windows.Forms.Label();
            this.lblHPMax = new System.Windows.Forms.Label();
            this.lblHPCur = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.game_timer = new System.Windows.Forms.Timer(this.components);
            this.Очередь = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btmAction = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.live)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hapy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGameOver.Location = new System.Drawing.Point(12, 637);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(445, 31);
            this.lblGameOver.TabIndex = 24;
            this.lblGameOver.Text = "О нет, Даня умер! Это ужастно!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(360, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Это Даня, позаботься о нём!";
            // 
            // lblEatCur
            // 
            this.lblEatCur.AutoSize = true;
            this.lblEatCur.Location = new System.Drawing.Point(139, 95);
            this.lblEatCur.Name = "lblEatCur";
            this.lblEatCur.Size = new System.Drawing.Size(35, 13);
            this.lblEatCur.TabIndex = 27;
            this.lblEatCur.Text = "label2";
            // 
            // dinoeat
            // 
            this.dinoeat.BackgroundImage = global::tamagochi.Properties.Resources.d_eat;
            this.dinoeat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dinoeat.Location = new System.Drawing.Point(489, 462);
            this.dinoeat.Name = "dinoeat";
            this.dinoeat.Size = new System.Drawing.Size(205, 206);
            this.dinoeat.TabIndex = 23;
            this.dinoeat.UseVisualStyleBackColor = true;
            this.dinoeat.Click += new System.EventHandler(this.button4_Click);
            // 
            // hap
            // 
            this.hap.BackgroundImage = global::tamagochi.Properties.Resources.d_play;
            this.hap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hap.Location = new System.Drawing.Point(731, 459);
            this.hap.Name = "hap";
            this.hap.Size = new System.Drawing.Size(202, 212);
            this.hap.TabIndex = 22;
            this.hap.UseVisualStyleBackColor = true;
            this.hap.Click += new System.EventHandler(this.hap_Click);
            // 
            // slp
            // 
            this.slp.BackgroundImage = global::tamagochi.Properties.Resources.d_sleep;
            this.slp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.slp.Location = new System.Drawing.Point(731, 229);
            this.slp.Name = "slp";
            this.slp.Size = new System.Drawing.Size(202, 206);
            this.slp.TabIndex = 21;
            this.slp.UseVisualStyleBackColor = true;
            this.slp.Click += new System.EventHandler(this.slp_Click);
            // 
            // live
            // 
            this.live.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.live.Image = global::tamagochi.Properties.Resources.live;
            this.live.Location = new System.Drawing.Point(864, 95);
            this.live.Name = "live";
            this.live.Size = new System.Drawing.Size(95, 86);
            this.live.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.live.TabIndex = 9;
            this.live.TabStop = false;
            // 
            // sleep
            // 
            this.sleep.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.sleep.Image = global::tamagochi.Properties.Resources.sleep;
            this.sleep.Location = new System.Drawing.Point(254, 95);
            this.sleep.Name = "sleep";
            this.sleep.Size = new System.Drawing.Size(82, 86);
            this.sleep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sleep.TabIndex = 8;
            this.sleep.TabStop = false;
            // 
            // hapy
            // 
            this.hapy.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.hapy.Image = global::tamagochi.Properties.Resources.happy;
            this.hapy.Location = new System.Drawing.Point(447, 95);
            this.hapy.Name = "hapy";
            this.hapy.Size = new System.Drawing.Size(92, 86);
            this.hapy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hapy.TabIndex = 7;
            this.hapy.TabStop = false;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clear.Image = global::tamagochi.Properties.Resources.clear;
            this.clear.Location = new System.Drawing.Point(651, 95);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(86, 86);
            this.clear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.clear.TabIndex = 6;
            this.clear.TabStop = false;
            // 
            // eat
            // 
            this.eat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.eat.Image = global::tamagochi.Properties.Resources.eat;
            this.eat.Location = new System.Drawing.Point(44, 95);
            this.eat.Name = "eat";
            this.eat.Size = new System.Drawing.Size(89, 86);
            this.eat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eat.TabIndex = 5;
            this.eat.TabStop = false;
            // 
            // dino
            // 
            this.dino.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dino.Image = global::tamagochi.Properties.Resources.dino;
            this.dino.Location = new System.Drawing.Point(33, 213);
            this.dino.Name = "dino";
            this.dino.Size = new System.Drawing.Size(406, 399);
            this.dino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dino.TabIndex = 0;
            this.dino.TabStop = false;
            // 
            // lblEatMax
            // 
            this.lblEatMax.AutoSize = true;
            this.lblEatMax.Location = new System.Drawing.Point(139, 168);
            this.lblEatMax.Name = "lblEatMax";
            this.lblEatMax.Size = new System.Drawing.Size(35, 13);
            this.lblEatMax.TabIndex = 28;
            this.lblEatMax.Text = "label2";
            // 
            // lblSleepCur
            // 
            this.lblSleepCur.AutoSize = true;
            this.lblSleepCur.Location = new System.Drawing.Point(342, 95);
            this.lblSleepCur.Name = "lblSleepCur";
            this.lblSleepCur.Size = new System.Drawing.Size(35, 13);
            this.lblSleepCur.TabIndex = 29;
            this.lblSleepCur.Text = "label2";
            // 
            // lblSleepMax
            // 
            this.lblSleepMax.AutoSize = true;
            this.lblSleepMax.Location = new System.Drawing.Point(342, 168);
            this.lblSleepMax.Name = "lblSleepMax";
            this.lblSleepMax.Size = new System.Drawing.Size(35, 13);
            this.lblSleepMax.TabIndex = 30;
            this.lblSleepMax.Text = "label2";
            // 
            // lblHappyMax
            // 
            this.lblHappyMax.AutoSize = true;
            this.lblHappyMax.Location = new System.Drawing.Point(545, 168);
            this.lblHappyMax.Name = "lblHappyMax";
            this.lblHappyMax.Size = new System.Drawing.Size(35, 13);
            this.lblHappyMax.TabIndex = 31;
            this.lblHappyMax.Text = "label2";
            // 
            // lblHappyCur
            // 
            this.lblHappyCur.AutoSize = true;
            this.lblHappyCur.Location = new System.Drawing.Point(545, 95);
            this.lblHappyCur.Name = "lblHappyCur";
            this.lblHappyCur.Size = new System.Drawing.Size(35, 13);
            this.lblHappyCur.TabIndex = 32;
            this.lblHappyCur.Text = "label2";
            // 
            // lblClearMax
            // 
            this.lblClearMax.AutoSize = true;
            this.lblClearMax.Location = new System.Drawing.Point(743, 168);
            this.lblClearMax.Name = "lblClearMax";
            this.lblClearMax.Size = new System.Drawing.Size(35, 13);
            this.lblClearMax.TabIndex = 33;
            this.lblClearMax.Text = "label2";
            // 
            // lblClearCur
            // 
            this.lblClearCur.AutoSize = true;
            this.lblClearCur.Location = new System.Drawing.Point(743, 95);
            this.lblClearCur.Name = "lblClearCur";
            this.lblClearCur.Size = new System.Drawing.Size(35, 13);
            this.lblClearCur.TabIndex = 34;
            this.lblClearCur.Text = "label2";
            // 
            // lblHPMax
            // 
            this.lblHPMax.AutoSize = true;
            this.lblHPMax.Location = new System.Drawing.Point(965, 168);
            this.lblHPMax.Name = "lblHPMax";
            this.lblHPMax.Size = new System.Drawing.Size(35, 13);
            this.lblHPMax.TabIndex = 35;
            this.lblHPMax.Text = "label2";
            // 
            // lblHPCur
            // 
            this.lblHPCur.AutoSize = true;
            this.lblHPCur.Location = new System.Drawing.Point(965, 95);
            this.lblHPCur.Name = "lblHPCur";
            this.lblHPCur.Size = new System.Drawing.Size(35, 13);
            this.lblHPCur.TabIndex = 36;
            this.lblHPCur.Text = "label2";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::tamagochi.Properties.Resources.d_clear;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(483, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 206);
            this.button1.TabIndex = 38;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // game_timer
            // 
            this.game_timer.Tick += new System.EventHandler(this.game_timer_Tick);
            // 
            // Очередь
            // 
            this.Очередь.AutoSize = true;
            this.Очередь.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Очередь.Location = new System.Drawing.Point(1074, 61);
            this.Очередь.Name = "Очередь";
            this.Очередь.Size = new System.Drawing.Size(65, 16);
            this.Очередь.TabIndex = 39;
            this.Очередь.Text = "Очередь";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1077, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 61);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1077, 410);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 61);
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(1077, 333);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(66, 61);
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(1077, 249);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(65, 61);
            this.pictureBox4.TabIndex = 44;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(1076, 168);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(65, 61);
            this.pictureBox5.TabIndex = 45;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(1078, 497);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(65, 61);
            this.pictureBox6.TabIndex = 46;
            this.pictureBox6.TabStop = false;
            // 
            // btmAction
            // 
            this.btmAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btmAction.Location = new System.Drawing.Point(1037, 575);
            this.btmAction.Name = "btmAction";
            this.btmAction.Size = new System.Drawing.Size(130, 82);
            this.btmAction.TabIndex = 49;
            this.btmAction.Text = "DO IT!!!";
            this.btmAction.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 683);
            this.Controls.Add(this.btmAction);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Очередь);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblHPCur);
            this.Controls.Add(this.lblHPMax);
            this.Controls.Add(this.lblClearCur);
            this.Controls.Add(this.lblClearMax);
            this.Controls.Add(this.lblHappyCur);
            this.Controls.Add(this.lblHappyMax);
            this.Controls.Add(this.lblSleepMax);
            this.Controls.Add(this.lblSleepCur);
            this.Controls.Add(this.lblEatMax);
            this.Controls.Add(this.lblEatCur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dinoeat);
            this.Controls.Add(this.hap);
            this.Controls.Add(this.slp);
            this.Controls.Add(this.live);
            this.Controls.Add(this.sleep);
            this.Controls.Add(this.hapy);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.eat);
            this.Controls.Add(this.dino);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.live)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hapy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox dino;
        private System.Windows.Forms.PictureBox eat;
        private System.Windows.Forms.PictureBox clear;
        private System.Windows.Forms.PictureBox hapy;
        private System.Windows.Forms.PictureBox sleep;
        private System.Windows.Forms.PictureBox live;
        private System.Windows.Forms.Button btEat_click;
        private System.Windows.Forms.Button slp;
        private System.Windows.Forms.Button hap;
        private System.Windows.Forms.Button dinoeat;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEatCur;
        private System.Windows.Forms.Label lblEatMax;
        private System.Windows.Forms.Label lblSleepCur;
        private System.Windows.Forms.Label lblSleepMax;
        private System.Windows.Forms.Label lblHappyMax;
        private System.Windows.Forms.Label lblHappyCur;
        private System.Windows.Forms.Label lblClearMax;
        private System.Windows.Forms.Label lblClearCur;
        private System.Windows.Forms.Label lblHPMax;
        private System.Windows.Forms.Label lblHPCur;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer game_timer;
        private System.Windows.Forms.Label Очередь;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btmAction;
    }
}

