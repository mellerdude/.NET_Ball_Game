//Omri Meller
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2_2
{
    public partial class GameForm : Form
    {

        private Timer timer = new Timer();
        public static gameDBDataContext database = new gameDBDataContext();
        private Boolean start = false;
        private Ball[] balls = new Ball[0];
        private String playerName;
        private Bitmap bmp;
        private Graphics grbmp;
        private DateTime startTime; // Variable to store the start time
        private int secondsPassed = 0; // Counter variable
        public GameForm()
        {
            InitializeComponent();
            KeyDown += CommonKeyDown;
            Load += Form1_Load;
        }

        private void InitializeGraphics()
        {
            bmp = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
            grbmp = Graphics.FromImage(bmp);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            timer.Interval = 50;
            timer.Tick += Timer_Tick;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (grbmp != null && bmp != null)
            {
                grbmp.Dispose(); // Release graphics resources
                bmp.Dispose(); // Release bitmap resources
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (bmp == null || grbmp == null)
            {
                InitializeGraphics();
            }

            grbmp.Clear(Color.White);

            foreach (Ball ball in balls)
            {
                int x = ball.locationX;
                int y = ball.locationY;
                int radius = ball.radius;
                int diameter = radius * 2;
                int ballX = x - radius;
                int ballY = y - radius;
                Color ballColor = ball.color;
                Brush brush = new SolidBrush(ballColor);

                grbmp.FillEllipse(brush, new Rectangle(ballX, ballY, diameter, diameter));

                brush.Dispose();
                if (ball.stop == false)
                    ball.move();
            }

            TimeSpan elapsedTime = DateTime.Now - startTime;
            secondsPassed = (int)elapsedTime.TotalSeconds; // Calculate the number of seconds passed

            Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (bmp != null && grbmp != null)
            {
                e.Graphics.DrawImage(bmp, 0, 0);
            }
        }


        private void plusButton_Click(object sender, EventArgs e)
        {
            addBall();

        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            removeBall();
        }
        private void S_Button_Click(object sender, EventArgs e)
        {
            if (balls.Length > 0)
            {
                balls[balls.Length - 1].stop = true;
            }
        }
        public class StyleInfo
        {
            public Font Font { get; set; }
            public string Text { get; set; }
            public Color Color { get; set; }
        }

        public delegate StyleInfo StyleDelegate();
        private void A_button_Click(object sender, EventArgs e)
        {
            StyleDelegate d = null;
            AboutBox ab = new AboutBox();
            int randomNumber = new Random().Next(1, 4);
            switch (randomNumber)
            {
                case 1:
                    d = new StyleDelegate(S1);
                    break;
                case 2:
                    d = new StyleDelegate(S2);
                    break;
                case 3:
                    d = new StyleDelegate(S3);
                    break;
            }
            ab.MyText(d);
            ab.ShowDialog();
        }


        private StyleInfo S1()
        {
            Font font = new Font("Arial", 40, FontStyle.Bold);
            string text = "HW2 is the best";
            Color color = Color.Blue;
            return new StyleInfo { Font = font, Text = text, Color = color };
        }

        private StyleInfo S2()
        {
            Font font = new Font("Courier New", 23, FontStyle.Italic);
            string text = "HW2 is ok";
            Color color = Color.Red;
            return new StyleInfo { Font = font, Text = text, Color = color };
        }

        private StyleInfo S3()
        {
            Font font = new Font("Times New Roman", 14, FontStyle.Italic);
            string text = "HW1 was better";
            Color color = Color.Gold;
            return new StyleInfo { Font = font, Text = text, Color = color };
        }

        private void end_button_Click(object sender, EventArgs e)
        {
            stopGame();
        }

        private void stopGame()
        {
            if (grbmp != null)
                grbmp.Clear(Color.White);
            Refresh();
            while (balls.Length != 0)
                removeBall();
            timer.Stop();

            start = false;

            if (!string.IsNullOrEmpty(playerName))
            {
                TblScore newScore = new TblScore
                {
                    Name = playerName,
                    Length = secondsPassed
                };

                database.TblScores.InsertOnSubmit(newScore);
                database.SubmitChanges();
            }
        }
        private void DB_button_Click(object sender, EventArgs e)
        {
            using (var dbForm = new DBForm())
            {
                dbForm.StartPosition = FormStartPosition.CenterParent;
                dbForm.ShowDialog(); // Show the database form
            }
        }
        private void CommonKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addBall();
            }
        }

        private void addBall()
        {
            if (!start)
            {
                if (enterNamePrompt())
                {
                    start = true;
                    startTime = DateTime.Now; // Store the current time as the start time
                    timer.Start();
                }
            }
            else
            {
                Ball newBall = new Ball(ClientRectangle.Width, ClientRectangle.Height);
                Array.Resize(ref balls, balls.Length + 1);
                balls[balls.Length - 1] = newBall;

                if (!timer.Enabled)
                {
                    timer.Start();
                }
            }
        }


        private void removeBall()
        {
            if (balls.Length > 0)
            {
                Array.Resize(ref balls, balls.Length - 1);
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ARE YOU SURE?", "DO U REALLY WANT TO EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //stopGame();

                // User confirmed, exit the program
                Application.Exit();
            }
        }

        private bool enterNamePrompt()
        {
            using (var inputForm = new EnterForm())
            {
                inputForm.StartPosition = FormStartPosition.CenterParent;

                DialogResult result = inputForm.ShowDialog(this); // Pass the main form as the owner

                if (result == DialogResult.OK)
                {
                    string enteredName = inputForm.EnteredName;
                    if (!string.IsNullOrWhiteSpace(enteredName) && enteredName.Length >= 1)
                    {
                        playerName = enteredName;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return false;
            }
        }
    }
}
