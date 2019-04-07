using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class SnakeGame : Form
    {
        private List<Square> Snake = new List<Square>();
        private Square food = new Square();

        public SnakeGame()
        {
            InitializeComponent();

            //default settings
            new Settings();

            //game speed + timer
            gameTimer.Enabled = true;
            gameTimer.Interval = 1000 / Settings.Speed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();

            //game start
            StartGame();
        }

        private void StartGame()
        {
            lblGameOver.Visible = false; // reset gameover label to invisible state after gamestart

            new Settings();

            //creating new player object
            Snake.Clear();
            Square head = new Square();
            head.X = 10;
            head.Y = 5;
            Snake.Add(head);

            labelScore.Text = Settings.Score.ToString();
            GenerateFood();
        }

        private void GenerateFood()
        {
            int maxXPosition = gameArea.Size.Width / Settings.Width;
            int maxYPosition = gameArea.Size.Height / Settings.Height;

            Random random = new Random();
            food = new Square();
            food.X = random.Next(0, maxXPosition);
            food.Y = random.Next(0, maxYPosition); 
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            if (Settings.GameOver)
            {
                if (Inputs.KeyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }
            else
            {
                if (Inputs.KeyPressed(Keys.Right) && Settings.Direction != Direction.Left)
                    Settings.Direction = Direction.Right;
                else if (Inputs.KeyPressed(Keys.Left) && Settings.Direction != Direction.Right)
                    Settings.Direction = Direction.Left;
                else if (Inputs.KeyPressed(Keys.Up) && Settings.Direction != Direction.Down)
                    Settings.Direction = Direction.Up;
                else if (Inputs.KeyPressed(Keys.Down) && Settings.Direction != Direction.Up)
                    Settings.Direction = Direction.Down;

                MovePlayer();
            }

            gameArea.Invalidate();
        }

        private void MovePlayer()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                //move head
                if (i == 0)
                {
                    switch (Settings.Direction)
                    {
                        case Direction.Right:
                            Snake[i].X++;
                            break;
                        case Direction.Left:
                            Snake[i].X--;
                            break;
                        case Direction.Up:
                            Snake[i].Y--;
                            break;
                        case Direction.Down:
                            Snake[i].Y++;
                            break;
                    }
                    // Get maximum X and Y pos
                    int maxXPos = gameArea.Size.Width / Settings.Width;
                    int maxYPos = gameArea.Size.Height / Settings.Height;

                    //detect collision with borders
                    if (Snake[i].X < 0 || Snake[i].Y < 0 || Snake[i].X >= maxXPos || Snake[i].Y >= maxYPos)
                    {
                        Die();
                    }
                    
                    //detect collision with food
                    if (Snake[0].X == food.X && Snake[0].Y == food.Y)
                    {
                        Eat();
                    }
                }
                // move body
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
                ////detect collision with body
                //for (int j = 0; j < Snake.Count; j++)
                //{
                //    if (Snake[i].X == Snake[j].X
                //        && Snake[i].Y == Snake[j].X)
                //    {
                //        Die();
                //    }
                //}
            }
            
        }

        private void Eat()
        {
            Square food = new Square();
            food.X = Snake[Snake.Count - 1].X;
            food.Y = Snake[Snake.Count - 1].Y;

            Snake.Add(food);

            Settings.Score += Settings.Points;
            labelScore.Text = Settings.Score.ToString();

            GenerateFood();
        }

        private void Die()
        {
            Settings.GameOver = true;
        }

        private void gameArea_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            if (!Settings.GameOver)
            {
                Brush snakeColour;

                for (int i = 0; i < Snake.Count; i++)
                {
                    if (i == 0)
                    {
                        snakeColour = Brushes.Black;
                    }
                    else
                    {
                        snakeColour = Brushes.Crimson;
                    }

                    canvas.FillEllipse(snakeColour,
                        new Rectangle(Snake[i].X * Settings.Width,
                        Snake[i].Y * Settings.Height,
                        Settings.Width, Settings.Height));

                    canvas.FillEllipse(Brushes.BlueViolet,
                        new Rectangle(food.X * Settings.Width, food.Y * Settings.Height, Settings.Width, Settings.Height));
                }
            }

            else
            {
                string gameOver = "Game over \nYour score was: " + Settings.Score + "\nPress ENTER to try again";
                lblGameOver.Text = gameOver;
                lblGameOver.Visible = true;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Inputs.ChangeState(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Inputs.ChangeState(e.KeyCode, false);
        }
    }
}
