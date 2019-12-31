using System;
using System.Collections.Generic;
using System.Drawing;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
using System.Web.Services;
using System.Data.SqlClient;
using System.Net;

namespace Snake
{    public partial class Form1 : Form
    {

        public static WebProxy CreateProxyWithHostAndPort()
        {
            return new WebProxy("192.168.100.254", 8080);
        }


        DataSet ds = new DataSet();


        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();

        public Form1()
        {

            InitializeComponent();




            ScoreBoard();

            string usernametemp = Settings.Username;
            usernamelabel.Text = usernametemp;


            new Settings();

            gameTimer.Interval = 1000 / Settings.Speed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();


            StartGame();
        }

        private void StartGame()
        {
            lblGameOver.Visible = false;
            lblGameOverScore.Visible = false;
            lblGameOverScore2.Visible = false;
            lblGameOverPress.Visible = false;
            label1.Visible = true;
            lblScore.Visible = true;


            new Settings();


            Snake.Clear();
            Circle head = new Circle { X = 10, Y = 5 };
            Snake.Add(head);


            lblScore.Text = Settings.Score.ToString();
            GenerateFood();

        }


        private void GenerateFood()
        {
            int maxXPos = pbCanvas.Size.Width / Settings.Width;
            int maxYPos = pbCanvas.Size.Height / Settings.Height;

            Random random = new Random();
            food = new Circle { X = random.Next(0, maxXPos), Y = random.Next(0, maxYPos) };
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
                string gameOver = "Fim do Jogo!";
                lblGameOver.Text = gameOver;
                string gameOverScore = "Pontuação Final";
                lblGameOverScore.Text = gameOverScore;
                string gameOverScore2 = "" + Settings.Score + "";
                lblGameOverScore2.Text = gameOverScore2.PadLeft(7, '0');
                string gameOverPress = "Press Enter to try again";
                lblGameOverPress.Text = gameOverPress;

                label1.Visible = false;
                lblScore.Visible = false;

                lblGameOver.Visible = true;
                lblGameOverScore.Visible = true;
                lblGameOverScore2.Visible = true;
                lblGameOverPress.Visible = true;



            }
        }


        private void MovePlayer()
        {
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }

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

            GenerateFood();
        }

        private void Die()
        {
            Settings.GameOver = true;
            InsertDB();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblGameOver_Click(object sender, EventArgs e)
        {

        }

        private void InsertDB()
        {
            
            
            if (Settings.Score != 0)
            
            
                try
                {
                    string connetionString;
                    SqlConnection cnn;
                    connetionString = @"Data Source=sql.freeasphost.net\MSSQL2016;Initial Catalog=nevespt_snakegame;User ID=nevespt;Password=107vista";
                    cnn = new SqlConnection(connetionString);
                    cnn.Open();
                    SqlCommand myCommand = new SqlCommand("INSERT INTO dbo.scores(username,score) VALUES('" + usernamelabel.Text + "','" + Settings.Score + "')", cnn);
                    myCommand.ExecuteNonQuery();

                    ScoreBoard();

                    MessageBox.Show("Pontuação Enviada!");
                    cnn.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Não foi possivel enviar a Pontuação! \nVerifique a ligação à rede!");
                }
            else
                MessageBox.Show("Não podes tar uma pontuação tão baixa!");





        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnClose1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnClose1_MouseHover(object sender, EventArgs e)
        {
            BtnClose1.Image = BtnClose1Hover.Image;
        }

        private void BtnClos1e_MouseLeave(object sender, EventArgs e)
        {
            BtnClose1.Image = BtnClose1Normal.Image;
        }


        private void ScoreBoard()
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=sql.freeasphost.net\MSSQL2016;Initial Catalog=nevespt_snakegame;User ID=nevespt;Password=107vista";
            cnn = new SqlConnection(connetionString);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("SELECT * FROM dbo.scores ORDER BY score desc ", cnn);

            ds.Clear();
            
            da.Fill(ds);

            dg.DataSource = ds.Tables[0]; 


        }
    }
}
