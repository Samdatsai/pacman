namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool guop, godown, goleft, goright = false;
        int pacmanspeed = 1;
        int score = 0;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            guop = godown = goleft = goright = false;
            if (e.KeyCode == Keys.Up)
            {
                guop = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 5;
            timer1.Enabled = Enabled;
        }

        //private void Form1_KeyUp(object sender, KeyEventArgs e)
        //{
        //  if (e.KeyCode == Keys.Up)
        //{
        //  guop = false;
        //}
        //if (e.KeyCode == Keys.Down)
        //{
        //  godown = false;
        //}
        //if (e.KeyCode == Keys.Left)
        //{
        //  goleft = false;
        //}
        //if (e.KeyCode == Keys.Right)
        //{
        //  goright = false;
        //}
        //}

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (guop)
            {
                pictureBox2.Top -= pacmanspeed;
                pictureBox2.Image = Properties.Resources.pacmanup;
            }
            else if (godown)
            {
                pictureBox2.Top += pacmanspeed;
                pictureBox2.Image = Properties.Resources.pacmandown;
            }
            else if (goleft)
            {
                pictureBox2.Left -= pacmanspeed;
                pictureBox2.Image = Properties.Resources.pacmanleft;
            }
            else if (goright)
            {
                pictureBox2.Left += pacmanspeed;
                pictureBox2.Image = Properties.Resources.pacman;
            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox23.Bounds))
            {
                if (pictureBox23.Visible)
                {
                    score += 1;

                }

                pictureBox23.Visible = false;
            }
            if (pictureBox2.Bounds.IntersectsWith(panel1.Bounds))
            {
                guop = godown = goleft = goright = false;
            }
            label2.Text = "Score: " + score;

        }


    }
}