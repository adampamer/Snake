using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();
        public static int Width=20;
        public static int Height=20;
        public Form1()
        {
           InitializeComponent();

            
            new Settings();

           
            
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();
           
            StartGame();
        }
         public void Settings2()
        {
            Width = 20;
            Height = 20;
         }
        private void növekedikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Width += 2;
           
            
            
        }
        
        
        private void StartGame()
        {
            lblGameOver.Visible = false;
             
           
           
            new Settings();

            
            Snake.Clear();
            Circle head = new Circle {X = 10, Y = 5};
            Snake.Add(head);


            lblScore.Text = Settings.Score.ToString();
            
            GenerateFood();

        }

        
        private void GenerateFood()
        {
            int maxXPos = pbCanvas.Size.Width / Width;
            int maxYPos = pbCanvas.Size.Height / Height;

            Random random = new Random();
            food = new Circle {X = random.Next(0, maxXPos), Y = random.Next(0, maxYPos)};
        }


        private void UpdateScreen(object sender, EventArgs e)
        {
            
            if (Settings.GameOver)
            {
                
                if (Input.KeyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }
            else
            {
                if (Input.KeyPressed(Keys.Right) && Settings.direction != Direction.Left)
                    Settings.direction = Direction.Right;
                else if (Input.KeyPressed(Keys.Left) && Settings.direction != Direction.Right)
                    Settings.direction = Direction.Left;
                else if (Input.KeyPressed(Keys.Up) && Settings.direction != Direction.Down)
                    Settings.direction = Direction.Up;
                else if (Input.KeyPressed(Keys.Down) && Settings.direction != Direction.Up)
                    Settings.direction = Direction.Down;

                MovePlayer();
            }

            pbCanvas.Invalidate();

        }

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if (!Settings.GameOver)
            {
               

                
                for (int i = 0; i < Snake.Count; i++)
                {
                    Brush snakeColour;
                    if (i == 0)
                        snakeColour = Brushes.Black;    
                    else
                       snakeColour = Brushes.Green;    

                    
                    canvas.FillEllipse(snakeColour,
                        new Rectangle(Snake[i].X * Width,
                                      Snake[i].Y * Height,
                                      Width, Height));


                   
                    canvas.FillEllipse(Brushes.Red,
                        new Rectangle(food.X * Width,
                             food.Y * Height, Width, Height));

                }
            }
            else
            {
                string gameOver = "Game over \nElért pontok: " + Settings.Score + "\nEnter lenyomásával \nfojtatódik a játék";
                lblGameOver.Text = gameOver;
                lblGameOver.Visible = true;
            }
        }


        private void MovePlayer()
        {
            pbCanvas.BackColor = Color.DarkBlue;
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                
                if (i == 0)
                {
                    switch (Settings.direction)
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


                   
                    int maxXPos = pbCanvas.Size.Width / Width;
                    int maxYPos = pbCanvas.Size.Height / Height;

                    
                    if (Snake[i].X < 0 || Snake[i].Y < 0
                        || Snake[i].X >= maxXPos || Snake[i].Y >= maxYPos)
                    {
                        Die();
                    }


                    
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X &&
                           Snake[i].Y == Snake[j].Y)
                        {
                            Die();
                        }
                    }

                    
                    if (Snake[0].X == food.X && Snake[0].Y == food.Y)
                    {
                        Eat();
                    }

                }
                else
                {
                    
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }
        int h ;
        private void Eat()
        {
           
            Circle circle = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };
            Snake.Add(circle);

            
            Settings.Score += Settings.Points;
            lblScore.Text = Settings.Score.ToString();
            if (Settings.Score != 0&&h<Settings.Score)
            {
                h = Int16.Parse(Settings.Score.ToString());
                label2.Text = Convert.ToString(h);
            }
            GenerateFood();
        }

        private void Die()
        {
            Settings.GameOver = true;
        }

        

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

       

         int i = 0;
        private void legeslegnehezebbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameTimer.Interval = 90 / Settings.Speed;
            
            i++;
            if(i%2==0)
           pbCanvas.BackColor = Color.DarkBlue;
            else
            { 
                pbCanvas.BackColor = Color.Red;
            }
        }

        private void nehézToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameTimer.Interval = 1000 / Settings.Speed;
        }

        private void könnyűToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameTimer.Interval = 3000 / Settings.Speed;
        }

        private void közepesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameTimer.Interval = 1700 / Settings.Speed;
        }
        private void csökkenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Height -= 2;
        }

        private void növekedikToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          Width += 2;
        }

        private void csökkenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Width -= 2;
        }

        private void pbCanvas_Click(object sender, EventArgs e)
        {

        }

        
       
    }
}
