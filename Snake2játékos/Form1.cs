using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {

        private List<Circle> Snake = new List<Circle>();
        private List<Circle2> Snake2 = new List<Circle2>();
        private Circle food = new Circle();
        private Circle2 food2 = new Circle2();
            
        public Form1()
        {
            InitializeComponent();
            
            
            new Settings();
            new Settings2();
            gameTimer2.Tick += UpdateScreen2;
            gameTimer2.Start();
            
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();
           
            StartGame();
            StartGame2();
        }
        //---------------------------------------------------
        //+++++++++++++++++++++++++++++++++++++++++++++++++++
        private void StartGame2()
        {
            Settings2.Valami.Width2 = 20;
            Settings2.Valami.Height2 = 20;
            Settings2.Valami.Speed2 = 10;
            Settings2.Valami.GameOver2 = false;
            Settings2.Valami.direction2 = Settings2.Direction2.Down;
            Settings2.Valami.Score2 = 0;
            Settings2.Valami.Points2 = 100;
            lblGameOver2.Visible = false;
            Over.Visible = false;
            

            new Settings2();


            Snake2.Clear();
            Circle2 head2 = new Circle2 { X2 = 10, Y2 = 5 };
            Snake2.Add(head2);


            lblScore2.Text = Settings2.Valami.Score2.ToString();

            GenerateFood2(); 

        }
        //+++++++++++++++++++++++++++++++++++++++++++++++++++
        //---------------------------------------------------
        private void StartGame()
        {
            lblGameOver.Visible = false;
            Over.Visible = false;
           
           
            new Settings();

            
            Snake.Clear();
            Circle head = new Circle {X = 10, Y = 5};
            Snake.Add(head);


            lblScore.Text = Settings.Score.ToString();
            
            GenerateFood();

        }
        //----------------------------------------------------
        //+++++++++++++++++++++++++++++++++++++++++++++++++++
        private void GenerateFood2()
        {
            
            Int32 maxXPos2 = pbCanvas2.Size.Width / Settings2.Valami.Width2;
            Int32 maxYPos2 = pbCanvas2.Size.Height / Settings2.Valami.Height2;

            Random random2 = new Random();
            food2 = new Circle2 { X2 = random2.Next(0,maxXPos2), Y2 = random2.Next(0, maxYPos2) };
        }
        //+++++++++++++++++++++++++++++++++++++++++++++++++++
        //---------------------------------------------------
        private void GenerateFood()
        {
            int maxXPos = pbCanvas.Size.Width / Settings.Width;
            int maxYPos = pbCanvas.Size.Height / Settings.Height;

            Random random = new Random();
            food = new Circle {X = random.Next(0, maxXPos), Y = random.Next(0, maxYPos)};
        }
        //---------------------------------------------------
        //+++++++++++++++++++++++++++++++++++++++++++++++++++
        private void UpdateScreen2(object sender, EventArgs e)
        {

            if (Settings2.Valami.GameOver2)
            {
                
                   
                
                if (Input2.KeyPressed2(Keys.Enter))
                {
                    StartGame2();
                }
            }
            else
            {
                if (Input2.KeyPressed2(Keys.D) && Settings2.Valami.direction2 != Settings2.Direction2.Left)
                {
                    Settings2.Valami.direction2 = Settings2.Direction2.Right;
                }

                else if (Input2.KeyPressed2(Keys.A) && Settings2.Valami.direction2 != Settings2.Direction2.Right)
                {
                    Settings2.Valami.direction2 = Settings2.Direction2.Left ;
                }

                else if (Input2.KeyPressed2(Keys.W) && Settings2.Valami.direction2 != Settings2.Direction2.Down)
                {
                    Settings2.Valami.direction2 = Settings2.Direction2.Up;
                }

                else if (Input2.KeyPressed2(Keys.S) && Settings2.Valami.direction2 != Settings2.Direction2.Up)
                {
                    Settings2.Valami.direction2 = Settings2.Direction2.Down;
                }


                MovePlayer2();
            }

            pbCanvas2.Invalidate();

        }
        //+++++++++++++++++++++++++++++++++++++++++++++++++++
        //---------------------------------------------------
        
           
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
                {
                  Settings.direction = Direction.Right;
                }
                    
                else if (Input.KeyPressed(Keys.Left) && Settings.direction != Direction.Right)
                {
                  Settings.direction = Direction.Left;
                }
                    
                else if (Input.KeyPressed(Keys.Up) && Settings.direction != Direction.Down)
                {
                 Settings.direction = Direction.Up;
                }
                    
                else if (Input.KeyPressed(Keys.Down) && Settings.direction != Direction.Up)
                {
                 Settings.direction = Direction.Down;
                }

                
                MovePlayer();
            }

            pbCanvas.Invalidate();
            
        }
        //--------------------------------------------------
        //+++++++++++++++++++++++++++++++++++++++++++++++++++
        private void pbCanvas2_Paint(object sender,  PaintEventArgs e)
        {
            Graphics canvas2 = e.Graphics;

            if (!Settings2.Valami.GameOver2)
            {
                /*if (!Settings.GameOver && !Settings2.Valami.GameOver2)
                {

                }
                else
                {
                    if (Settings.Score > Settings2.Valami.Score2)
                    {
                        string a = "Az Első játékos nyert!\nPontszáma:\n" + Settings2.Valami.Score2;
                        Over.Text = a;
                    }
                    else if (Settings.Score < Settings2.Valami.Score2)
                    {
                        Over.Text = "Az Másodok játékos nyert!\nPontszáma:\n" + Settings.Score;
                    }
                    Over.Visible = true;
                }*/
                
                    

                for (int i = 0; i < Snake2.Count; i++)
                {
                    Brush snakeColour2;
                    if (i == 0)
                        snakeColour2 = Brushes.Black;
                    else
                        snakeColour2 = Brushes.Green;


                    canvas2.FillEllipse(snakeColour2,
                        new Rectangle(Snake2[i].X2 * Settings2.Valami.Width2,
                                      Snake2[i].Y2 * Settings2.Valami.Height2,
                                      Settings2.Valami.Width2, Settings2.Valami.Height2));



                    canvas2.FillEllipse(Brushes.Red,
                        new Rectangle(food2.X2 * Settings2.Valami.Width2,
                             food2.Y2 * Settings2.Valami.Height2, Settings2.Valami.Width2, Settings2.Valami.Height2));

                }
            }
            else
            {
                if (Settings.GameOver == true && Settings2.Valami.GameOver2 == true)
                {
                    if (int.Parse(lblScore.Text) < int.Parse(lblScore2.Text))
                    {
                        string a = "Az Player2 játékos nyert!\nPontszáma:\n" + Settings2.Valami.Score2;
                        Over.Text = a;
                    }
                    if (int.Parse(lblScore.Text) > int.Parse(lblScore2.Text))
                    {
                        Over.Text = "Az Player1 játékos nyert!\nPontszáma:\n" + Settings.Score;
                    }
                    if (int.Parse(lblScore.Text) == int.Parse(lblScore2.Text))
                    {
                         Over.Text = "Döntetlen!";
                    }
                    Over.Visible = true;
                }
               
                string gameOver2 = "Game over \nElért pontok: " + Settings2.Valami.Score2 + "\nEnter lenyomásával \nfojtatódik a játék";
                lblGameOver2.Text = gameOver2;
               // lblGameOver2.Visible = true;
            }
        }
        //+++++++++++++++++++++++++++++++++++++++++++++++++++
        //---------------------------------------------------
        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if (!Settings.GameOver)
            {
                
                   
                
               /* if (!Settings.GameOver && !Settings2.Valami.GameOver2)
               {
               }
                else
                {

                    if (Settings.Score > Settings2.Valami.Score2)
                    {
                        string a="Az Első játékos nyert!\nPontszáma:\n"+Settings2.Valami.Score2;
                        Over.Text =a ;
                    }
                    else if (Settings.Score < Settings2.Valami.Score2)
                    {
                        Over.Text = "Az Másodok játékos nyert!\nPontszáma:\n" + Settings.Score;
                    }
                    Over.Visible = true;
                }*/

                
                for (int i = 0; i < Snake.Count; i++)
                {
                    Brush snakeColour;
                    if (i == 0)
                        snakeColour = Brushes.Black;    
                    else
                        snakeColour = Brushes.Green;    

                    
                    canvas.FillEllipse(snakeColour,
                        new Rectangle(Snake[i].X * Settings.Width,
                                      Snake[i].Y * Settings.Height,
                                      Settings.Width, Settings.Height));


                   
                    canvas.FillEllipse(Brushes.Red,
                        new Rectangle(food.X * Settings.Width,
                             food.Y * Settings.Height, Settings.Width, Settings.Height));

                }
            }
            else
            {
                if (Settings.GameOver == true && Settings2.Valami.GameOver2 == true)
                {
                    if (int.Parse(lblScore.Text) <int.Parse(lblScore2.Text))
                    {
                        string a = "Az Mű játékos nyert!\nPontszáma:\n" + Settings2.Valami.Score2;
                        Over.Text = a;
                    }
                    else if (int.Parse(lblScore.Text) > int.Parse(lblScore2.Text))
                    {
                        Over.Text = "Az Eredeti játékos nyert!\nPontszáma:\n" + Settings.Score;
                    }
                    if (int.Parse(lblScore.Text) == int.Parse(lblScore2.Text))
                    {
                        Over.Text = "Döntetlen!";
                    }
                    Over.Visible = true;
                }
                string gameOver = "Game over \nElért pontok: " + Settings.Score + "\nEnter lenyomásával \nfojtatódik a játék";
                lblGameOver.Text = gameOver;
                //lblGameOver.Visible = true;
            }
        }
        //---------------------------------------------------
        //+++++++++++++++++++++++++++++++++++++++++++++++++++
        private void MovePlayer2()
        {
            pbCanvas2.BackColor = Color.DarkBlue;
            for (int i = Snake2.Count - 1; i >= 0; i--)
            {

                if (i == 0)
                {
                    switch (Settings2.Valami.direction2)
                    {
                        case Settings2.Direction2.Right:
                            Snake2[i].X2++;
                            break;
                        case Settings2.Direction2.Left:
                            Snake2[i].X2--;
                            break;
                        case Settings2.Direction2.Up:
                            Snake2[i].Y2--;
                            break;
                        case Settings2.Direction2.Down:
                            Snake2[i].Y2++;
                            break;
                    }



                    int maxXPos = pbCanvas2.Size.Width / Settings2.Valami.Width2;
                    int maxYPos = pbCanvas2.Size.Height / Settings2.Valami.Height2;


                    if (Snake2[i].X2 < 0 || Snake2[i].Y2 < 0
                        || Snake2[i].X2 >= maxXPos || Snake2[i].Y2 >= maxYPos)
                    {
                        Die2();
                    }



                    for (int j = 1; j < Snake2.Count; j++)
                    {
                        if (Snake2[i].X2 == Snake2[j].X2 &&
                           Snake2[i].Y2 == Snake2[j].Y2)
                        {
                            Die2();
                        }
                    }


                    if (Snake2[0].X2 == food2.X2 && Snake2[0].Y2 == food2.Y2)
                    {
                        Eat2();
                    }

                }
                else
                {

                    Snake2[i].X2 = Snake2[i - 1].X2;
                    Snake2[i].Y2 = Snake2[i - 1].Y2;
                }
            }
        }
        //+++++++++++++++++++++++++++++++++++++++++++++++++++
       //----------------------------------------------------
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


                   
                    int maxXPos = pbCanvas.Size.Width / Settings.Width;
                    int maxYPos = pbCanvas.Size.Height / Settings.Height;

                    
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
        //---------------------------------------------------


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
            Input2.ChangeState2(e.KeyCode, true);
        }
        private void Form1_KeyDown2(object sender, KeyEventArgs e)
        {
            //Input.ChangeState(e.KeyCode, true);
            Input2.ChangeState2(e.KeyCode, true);
        }
        private void Form1_KeyUp2(object sender, KeyEventArgs e)
        {
            //Input.ChangeState(e.KeyCode, false);
            Input2.ChangeState2(e.KeyCode, false);
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
            Input2.ChangeState2(e.KeyCode, false);
        }
        //+++++++++++++++++++++++++++++++++++++++++++++++++++
        int h2;
        private void Eat2()
        {

            Circle2 circle = new Circle2
            {
                X2 = Snake2[Snake2.Count - 1].X2,
                Y2 = Snake2[Snake2.Count - 1].Y2
            };
            Snake2.Add(circle);


            Settings2.Valami.Score2 += Settings2.Valami.Points2;
            lblScore2.Text = Settings2.Valami.Score2.ToString();
            if (Settings2.Valami.Score2 != 0 && h2 < Settings2.Valami.Score2)
            {
                h2 = Int16.Parse(Settings2.Valami.Score2.ToString());
                label5.Text = Convert.ToString(h2);
            }
            GenerateFood2();
        }
        //+++++++++++++++++++++++++++++++++++++++++++++++++++
        //---------------------------------------------------
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
        //---------------------------------------------------
        //+++++++++++++++++++++++++++++++++++++++++++++++++++
        private void Die2()
        {
            Settings2.Valami.GameOver2 = true;
        }
        //+++++++++++++++++++++++++++++++++++++++++++++++++++
        //---------------------------------------------------
        private void Die()
        {
            Settings.GameOver = true;
        }
        //---------------------------------------------------
       

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

       

       

       
    }
}
