
namespace Classic_Snakes_Game_Tutorial___MOO_ICT
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
            components = new System.ComponentModel.Container();
            startButton = new Button();
            picCanvas = new PictureBox();
            txtScore = new Label();
            txtHighScore = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            buttonChangeSkin = new Button();
            MenuColors = new ContextMenuStrip(components);
            greenToolStripMenuItem = new ToolStripMenuItem();
            redToolStripMenuItem = new ToolStripMenuItem();
            blueToolStripMenuItem = new ToolStripMenuItem();
            yellowToolStripMenuItem = new ToolStripMenuItem();
            purpleToolStripMenuItem1 = new ToolStripMenuItem();
            PinktoolStripMenuItem2 = new ToolStripMenuItem();
            BlackToolStripMenuItem3 = new ToolStripMenuItem();
            WhiteToolStripMenuItem4 = new ToolStripMenuItem();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            MenuColors.SuspendLayout();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.BackColor = Color.SkyBlue;
            startButton.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startButton.Location = new Point(1311, 28);
            startButton.Margin = new Padding(7, 6, 7, 6);
            startButton.Name = "startButton";
            startButton.Size = new Size(247, 139);
            startButton.TabIndex = 0;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += StartGame;
            // 
            // picCanvas
            // 
            picCanvas.BackColor = Color.Silver;
            picCanvas.Location = new Point(19, 30);
            picCanvas.Margin = new Padding(7, 6, 7, 6);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(1257, 971);
            picCanvas.TabIndex = 1;
            picCanvas.TabStop = false;
            picCanvas.Paint += UpdatePictureBoxGraphics;
            // 
            // txtScore
            // 
            txtScore.AutoSize = true;
            txtScore.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtScore.Location = new Point(1365, 510);
            txtScore.Margin = new Padding(7, 0, 7, 0);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(144, 37);
            txtScore.TabIndex = 2;
            txtScore.Text = "Score: 0";
            // 
            // txtHighScore
            // 
            txtHighScore.AutoSize = true;
            txtHighScore.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtHighScore.Location = new Point(1352, 559);
            txtHighScore.Margin = new Padding(7, 0, 7, 0);
            txtHighScore.Name = "txtHighScore";
            txtHighScore.Size = new Size(185, 37);
            txtHighScore.TabIndex = 2;
            txtHighScore.Text = "High Score";
            // 
            // gameTimer
            // 
            gameTimer.Interval = 10;
            gameTimer.Tick += GameTimerEvent;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1311, 587);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 4;
            // 
            // buttonChangeSkin
            // 
            buttonChangeSkin.BackColor = Color.LightGreen;
            buttonChangeSkin.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonChangeSkin.Location = new Point(1311, 331);
            buttonChangeSkin.Margin = new Padding(6);
            buttonChangeSkin.Name = "buttonChangeSkin";
            buttonChangeSkin.Size = new Size(247, 139);
            buttonChangeSkin.TabIndex = 0;
            buttonChangeSkin.Text = "Change Skin";
            buttonChangeSkin.UseVisualStyleBackColor = false;
            buttonChangeSkin.Click += ChangeSkin;
            // 
            // MenuColors
            // 
            MenuColors.BackColor = Color.Transparent;
            MenuColors.ImageScalingSize = new Size(32, 32);
            MenuColors.Items.AddRange(new ToolStripItem[] { greenToolStripMenuItem, redToolStripMenuItem, blueToolStripMenuItem, yellowToolStripMenuItem, purpleToolStripMenuItem1, PinktoolStripMenuItem2, BlackToolStripMenuItem3, WhiteToolStripMenuItem4 });
            MenuColors.Name = "contextMenuStrip1";
            MenuColors.RenderMode = ToolStripRenderMode.System;
            MenuColors.Size = new Size(174, 308);
            MenuColors.Text = "Colors Menu";
            // 
            // greenToolStripMenuItem
            // 
            greenToolStripMenuItem.BackColor = Color.ForestGreen;
            greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            greenToolStripMenuItem.Size = new Size(173, 38);
            greenToolStripMenuItem.Text = "GREEN";
            greenToolStripMenuItem.Click += SelectColor;
            // 
            // redToolStripMenuItem
            // 
            redToolStripMenuItem.BackColor = Color.Firebrick;
            redToolStripMenuItem.Name = "redToolStripMenuItem";
            redToolStripMenuItem.Size = new Size(173, 38);
            redToolStripMenuItem.Text = "RED";
            redToolStripMenuItem.Click += SelectColor;
            // 
            // blueToolStripMenuItem
            // 
            blueToolStripMenuItem.BackColor = SystemColors.HotTrack;
            blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            blueToolStripMenuItem.Size = new Size(173, 38);
            blueToolStripMenuItem.Text = "BLUE";
            blueToolStripMenuItem.Click += SelectColor;
            // 
            // yellowToolStripMenuItem
            // 
            yellowToolStripMenuItem.BackColor = Color.Gold;
            yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            yellowToolStripMenuItem.Size = new Size(173, 38);
            yellowToolStripMenuItem.Text = "YELLOW";
            yellowToolStripMenuItem.Click += SelectColor;
            // 
            // purpleToolStripMenuItem1
            // 
            purpleToolStripMenuItem1.BackColor = Color.BlueViolet;
            purpleToolStripMenuItem1.BackgroundImageLayout = ImageLayout.None;
            purpleToolStripMenuItem1.Name = "purpleToolStripMenuItem1";
            purpleToolStripMenuItem1.Size = new Size(173, 38);
            purpleToolStripMenuItem1.Text = "PURPLE";
            purpleToolStripMenuItem1.Click += SelectColor;
            // 
            // PinktoolStripMenuItem2
            // 
            PinktoolStripMenuItem2.BackColor = Color.DeepPink;
            PinktoolStripMenuItem2.Name = "PinktoolStripMenuItem2";
            PinktoolStripMenuItem2.Size = new Size(173, 38);
            PinktoolStripMenuItem2.Text = "PINK";
            PinktoolStripMenuItem2.Click += SelectColor;
            // 
            // BlackToolStripMenuItem3
            // 
            BlackToolStripMenuItem3.BackColor = Color.Black;
            BlackToolStripMenuItem3.Name = "BlackToolStripMenuItem3";
            BlackToolStripMenuItem3.Size = new Size(173, 38);
            BlackToolStripMenuItem3.Text = "BLACK";
            BlackToolStripMenuItem3.Click += SelectColor;
            // 
            // WhiteToolStripMenuItem4
            // 
            WhiteToolStripMenuItem4.BackColor = SystemColors.ButtonHighlight;
            WhiteToolStripMenuItem4.Name = "WhiteToolStripMenuItem4";
            WhiteToolStripMenuItem4.Size = new Size(173, 38);
            WhiteToolStripMenuItem4.Text = "WHITE";
            WhiteToolStripMenuItem4.Click += SelectColor;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCoral;
            button2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(1311, 179);
            button2.Margin = new Padding(7, 6, 7, 6);
            button2.Name = "button2";
            button2.Size = new Size(247, 139);
            button2.TabIndex = 5;
            button2.Text = "Add Food";
            button2.UseVisualStyleBackColor = false;
            button2.Click += AddFood;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1332, 691);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(180, 37);
            label2.TabIndex = 6;
            label2.Text = "Qtd. Food:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(1499, 691);
            label3.Margin = new Padding(7, 0, 7, 0);
            label3.Name = "label3";
            label3.Size = new Size(34, 37);
            label3.TabIndex = 7;
            label3.Text = "1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1621, 1060);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(buttonChangeSkin);
            Controls.Add(label1);
            Controls.Add(txtHighScore);
            Controls.Add(txtScore);
            Controls.Add(picCanvas);
            Controls.Add(startButton);
            Margin = new Padding(7, 6, 7, 6);
            Name = "Form1";
            Text = "Classic Snakes Game MOO ICT";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            MenuColors.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtHighScore;
        private System.Windows.Forms.Timer gameTimer;
        private Label label1;
        private Button buttonChangeSkin;
        private ContextMenuStrip MenuColors;
        private ToolStripMenuItem redToolStripMenuItem;
        private ToolStripMenuItem greenToolStripMenuItem;
        private ToolStripMenuItem blueToolStripMenuItem;
        private ToolStripMenuItem yellowToolStripMenuItem;
        private Button button2;
        private ToolStripMenuItem purpleToolStripMenuItem1;
        private ToolStripMenuItem PinktoolStripMenuItem2;
        private ToolStripMenuItem BlackToolStripMenuItem3;
        private ToolStripMenuItem WhiteToolStripMenuItem4;
        private Label label2;
        private Label label3;
    }
}

