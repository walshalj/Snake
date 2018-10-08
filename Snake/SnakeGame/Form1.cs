using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace Snake_Game
{
    public partial class frm_snakeGame : Form
    {
        List<Point> Snake = new List<Point>();
        Point apples = new Point();

        public frm_snakeGame()
        {
            InitializeComponent();

            new settings();

            //Game speed and timer
            m_snakeSpeed();
        }



        private void m_startGame()
        {
            
            //Set new game settings 
            new settings();

            //Create new player objects
            Snake.Clear();
            Point head = new Point { X = 10, Y = 5 };
            Snake.Add(head);
            btn_newGame.Enabled = false;

            lbl_userScore.Text = settings.Score.ToString();

            m_generateApples();          
        }


       
        private void m_generateApples()
        {
            //Place apples on the play area
            int X = picture_Box.Size.Width / settings.Width;
            int Y = picture_Box.Size.Height / settings.Width;

            Random random = new Random();
            apples = new Point { X = random.Next(0, X), Y = random.Next(0, Y) };
        }



        private void m_moveSnake()
        {
            //snake directions
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (settings.direction)
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

                    //Get X and Y Positions
                    int XPos = picture_Box.Size.Width / settings.Width;
                    int YPos = picture_Box.Size.Height / settings.Height;

                    //Checks if snake hits a wall 
                    if (Snake[i].X < 0 || Snake[i].Y < 0
                        || Snake[i].X >= XPos || Snake[i].Y >= YPos)
                    {
                        m_snakeDies();
                    }

                    //Checks if snake hits itself
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X &&
                           Snake[i].Y == Snake[j].Y)
                        {
                            m_snakeDies();
                        }
                    }

                    //Checks if snake has eaten an apple
                    if (Snake[0].X == apples.X && Snake[0].Y == apples.Y)
                    {
                        m_Grow();
                    }
                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }

            }
        }



        private void m_Grow()
        {
            //grow the snake
            Point point = new Point
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };
            Snake.Add(new Point());

            //update score
            settings.Score += settings.Points;
            lbl_userScore.Text = settings.Score.ToString();
            m_generateApples();
        }



        private void m_snakeSpeed()
        {
            //game timer
            gameTimer.Interval = 1000 / settings.Speed;
            gameTimer.Tick += updateScreen;
            gameTimer.Start();
        }



        private void m_snakeDies()
        {           
            //displays the message box when the snake dies.
            settings.GameOver = true;
            btn_newGame.Enabled = true;
            m_userNameBox();
            System.IO.File.AppendAllText( "Scores.txt", settings.Score.ToString() + Environment.NewLine);
        }



        private void m_userNameBox()
        {
            if (toolStripTxtBox_userName.TextLength > 0)
            {
                MessageBox.Show("Game over!\n\n" + toolStripTxtBox_userName + ",  " + "\n" + "Your score is:  " + settings.Score + "\n\nPress Enter to try again!");
            }
            else
            {
                MessageBox.Show("Game over!\n\n" + "\n" + "Your score is:  " + settings.Score + "\n\nPress Enter to try again!");
            }
        }



        private void m_scoreMessage()
        {
            int i_Message;
            i_Message = Convert.ToInt32(lbl_userScore.Text);
            string s_iMsg;

            if (i_Message > 100) { s_iMsg = "You are a winner!"; }
                else if (i_Message >= 70 && i_Message <= 100) { s_iMsg = "You are doing well!"; }
                else if (i_Message >= 50 && i_Message < 70) { s_iMsg = "Hunt more!"; }
                else if (i_Message >= 30 && i_Message < 50) { s_iMsg = "Keep hunting!"; }
                else if (i_Message >= 10 && i_Message < 30) { s_iMsg = "Woohoo!"; }

                else { s_iMsg = "Goodluck"; };

                lbl_iMsg.Text = s_iMsg;

        }



        private void m_showShortcuts()
        {
            try
            {
                string s_TextContent;
                s_TextContent = System.IO.File.ReadAllText("shortcuts.txt");

                MessageBox.Show(s_TextContent);
            }
            catch
            {
                MessageBox.Show("File not found!");
            }

        }



        private void updateScreen(object sender, EventArgs e)
        {
            if (settings.GameOver)
            {
                //Check if Enter key is pressed
                if (KeyInput.KeyPressed(Keys.Enter))
                {
                    m_startGame();                   
                }               
            }
            else
            {
                if (KeyInput.KeyPressed(Keys.Right) && settings.direction != Direction.Left)
                    settings.direction = Direction.Right;
                else if (KeyInput.KeyPressed(Keys.Left) && settings.direction != Direction.Right)
                    settings.direction = Direction.Left;
                else if (KeyInput.KeyPressed(Keys.Up) && settings.direction != Direction.Down)
                    settings.direction = Direction.Up;
                else if (KeyInput.KeyPressed(Keys.Down) && settings.direction != Direction.Up)
                    settings.direction = Direction.Down;

                m_moveSnake();
                m_scoreMessage();
            }
            picture_Box.Invalidate();
        }



        private void picture_Box_Paint(object sender, PaintEventArgs e)
        {
            {
                Graphics canvas = e.Graphics;

                if (!settings.GameOver)
                {
                    //draw snake
                    for (int i = 0; i < Snake.Count; i++)
                    {
                        Brush snakeColour;
                        if (i == 0)
                            snakeColour = Brushes.Black;     
                        else
                            snakeColour = Brushes.SeaGreen;    
                      
                        canvas.FillRectangle(snakeColour,
                            new Rectangle(Snake[i].X * settings.Width,
                                          Snake[i].Y * settings.Height,
                                          settings.Width, settings.Height));

                        //draw apples
                        canvas.FillRectangle(Brushes.Red,
                            new Rectangle(apples.X * settings.Width,
                                 apples.Y * settings.Height, settings.Width, settings.Height));
                    }
                }
                else
                {
                    //Display game over label
                }
            }
        }


    
        private void btn_newGame_Click(object sender, EventArgs e)
        {      
            {
                // new game button is pressed
                btn_newGame.Enabled = false;

                //set settings to default
                new settings();

                //create new player object
                Snake.Clear();
                Point head = new Point { X = 10, Y = 5 };
                Snake.Add(head);
                lbl_userScore.Text = settings.Score.ToString();
                m_generateApples();
            }
        }



        private void frm_snakeGame_KeyDown(object sender, KeyEventArgs e)
        {
            KeyInput.ChangeState(e.KeyCode, true);
        }



        private void frm_snakeGame_KeyUp(object sender, KeyEventArgs e)
        {
            KeyInput.ChangeState(e.KeyCode, false);
        }

      
          
        private void score_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Scores c_Score = new Scores();
            c_Score.m_readScores();
            (new Scores()).ShowDialog();
        }

        

        private void shortcutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_showShortcuts();
        }

       

        private void exit_ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            {
                DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Close();
                }
                else
                {

                }
            }
           
        }



        private void frm_snakeGame_Enter(object sender, EventArgs e)
        {

        }
    }
}
