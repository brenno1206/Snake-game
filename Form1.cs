using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging; // add this for the JPG compressor
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classic_Snakes_Game_Tutorial___MOO_ICT
{
    public partial class Form1 : Form
    {

        private List<Circle> Snake = new List<Circle>();
        private List<Circle> food = new List<Circle>();

        private Brush snakeHeadColor = Brushes.DarkGreen;
        private Brush snakeBodyColor = Brushes.LimeGreen;

        int maxWidth;
        int maxHeight;

        int score;
        int highScore;

        Random rand = new Random();



        bool goLeft, goRight, goDown, goUp;


        public Form1()
        {
            InitializeComponent();

            new Settings();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left && Settings.directions != "right")
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right && Settings.directions != "left")
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up && Settings.directions != "down")
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down && Settings.directions != "up")
            {
                goDown = true;
            }



        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }

        private void StartGame(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            // setting the directions

            if (goLeft)
            {
                Settings.directions = "left";
            }
            if (goRight)
            {
                Settings.directions = "right";
            }
            if (goDown)
            {
                Settings.directions = "down";
            }
            if (goUp)
            {
                Settings.directions = "up";
            }
            // end of directions

            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {

                    switch (Settings.directions)
                    {
                        case "left":
                            Snake[i].X--;
                            break;
                        case "right":
                            Snake[i].X++;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;
                    }

                    if (Snake[i].X < 0)
                    {
                        Snake[i].X = maxWidth;
                    }
                    if (Snake[i].X > maxWidth)
                    {
                        Snake[i].X = 0;
                    }
                    if (Snake[i].Y < 0)
                    {
                        Snake[i].Y = maxHeight;
                    }
                    if (Snake[i].Y > maxHeight)
                    {
                        Snake[i].Y = 0;
                    }


                    for (int j = 0; j < food.Count; j++) // Percorrendo todos os alimentos
                    {
                        if (Snake[i].X == food[j].X && Snake[i].Y == food[j].Y)
                        {
                            EatFood(j); // Passar o índice do alimento para ser removido
                            break; // Não precisa continuar verificando
                        }
                    }

                    for (int j = 1; j < Snake.Count; j++)
                    {

                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            GameOver();
                        }

                    }


                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }




            picCanvas.Invalidate();

        }

        private void UpdatePictureBoxGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            Brush snakeColour;

            for (int i = 0; i < Snake.Count; i++)
            {
                if (i == 0)
                {
                    snakeColour = snakeHeadColor;
                }
                else
                {
                    snakeColour = snakeBodyColor;
                }

                canvas.FillEllipse(snakeColour, new Rectangle
                    (
                    Snake[i].X * Settings.Width,
                    Snake[i].Y * Settings.Height,
                    Settings.Width, Settings.Height
                    ));
            }

            foreach (var f in food)
            {
                canvas.FillEllipse(Brushes.DarkRed, new Rectangle
            (
            f.X * Settings.Width,
            f.Y * Settings.Height,
            Settings.Width, Settings.Height
            ));
            }
        }

        private void RestartGame()
        {
            maxWidth = picCanvas.Width / Settings.Width - 1;
            maxHeight = picCanvas.Height / Settings.Height - 1;
            gameTimer.Interval = 100;

            Snake.Clear();

            startButton.Enabled = false;
            buttonChangeSkin.Enabled = false;
            button2.Enabled = false;

            score = 0;
            txtScore.Text = "Score: " + score;

            Circle head = new Circle { X = 10, Y = 5 };
            Snake.Add(head);

            for (int i = 0; i < 10; i++)
            {
                Circle body = new Circle();
                Snake.Add(body);
            }

            food.Add(new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) });


            gameTimer.Start();

        }

        private void EatFood(int foodIndex)
        {
            score += 1;

            txtScore.Text = "Score: " + score;

            Circle body = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };

            Snake.Add(body);
            food.RemoveAt(foodIndex);

            food.Add(new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) });

            if (score % 5 == 0 && gameTimer.Interval - 20 > 0)
            {
                gameTimer.Interval -= 20;
            }
        }

        private void GameOver()
        {
            gameTimer.Stop();
            startButton.Enabled = true;
            buttonChangeSkin.Enabled = true;
            button2.Enabled = true;

            if (score > highScore)
            {
                highScore = score;

                txtHighScore.Text = "High Score: " + Environment.NewLine + highScore;
                txtHighScore.ForeColor = Color.Maroon;
                txtHighScore.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void ChangeSkin(object sender, EventArgs e)
        {
            MenuColors.Show(buttonChangeSkin, new Point(0, buttonChangeSkin.Height));

        }
        private void SelectColor(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;

            Color selectedColor = clickedItem.BackColor;

            snakeBodyColor = new SolidBrush(selectedColor);

            Color darkerHeadColor = Color.FromArgb(
                Math.Max(0, selectedColor.R - 40),
                Math.Max(0, selectedColor.G - 40),
                Math.Max(0, selectedColor.B - 40)
            );
            snakeHeadColor = new SolidBrush(darkerHeadColor);
        }
        //logica do botao de adicionar comida 
        private void AddFood(object sender, EventArgs e)
        {

            if (maxWidth > 0 && maxHeight > 0)
            {
                Circle newFood = new Circle
                {
                    X = rand.Next(2, maxWidth),
                    Y = rand.Next(2, maxHeight)
                };

                food.Add(newFood);
                label3.Text = " " + food.Count;
            }
            else
            {
                MessageBox.Show("O jogo ainda não foi iniciado. Por favor, inicie ao menos uma vez.");
            }
        }
    }
}
