namespace memes
{
    public partial class Form1 : Form
    {

        int num = 0;
        public Form1()
        {
            InitializeComponent();

            pictureBox1.Image = Properties.Resources.burger;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num++;

            if (num == 0) pictureBox1.Image = Properties.Resources.burger;
            else if (num == 1) pictureBox1.Image = Properties.Resources.jinu;
            else if (num == 2) pictureBox1.Image = Properties.Resources.homework;
            else if (num == 3) pictureBox1.Image = Properties.Resources.sign1;
            else if (num == 4) pictureBox1.Image = Properties.Resources.sign2;
            else if (num == 5) pictureBox1.Image = Properties.Resources.sign3;
            else if (num == 6) pictureBox1.Image = Properties.Resources.sign4;
            else if (num == 7) pictureBox1.Image = Properties.Resources.sign5;
            else if (num == 8) pictureBox1.Image = Properties.Resources.duck;
            else if (num == 9) pictureBox1.Image = Properties.Resources.ohio;
            else if (num == 10) pictureBox1.Image = Properties.Resources.ad;
            else if (num == 11) pictureBox1.Image = Properties.Resources.test;
            else if (num == 12) pictureBox1.Image = Properties.Resources.focus;

            if (num > 12)
                num = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num--;

            if (num < 0)
                num = 12;

            if (num == 0) pictureBox1.Image = Properties.Resources.burger;
            else if (num == 1) pictureBox1.Image = Properties.Resources.jinu;
            else if (num == 2) pictureBox1.Image = Properties.Resources.homework;
            else if (num == 3) pictureBox1.Image = Properties.Resources.sign1;
            else if (num == 4) pictureBox1.Image = Properties.Resources.sign2;
            else if (num == 5) pictureBox1.Image = Properties.Resources.sign3;
            else if (num == 6) pictureBox1.Image = Properties.Resources.sign4;
            else if (num == 7) pictureBox1.Image = Properties.Resources.sign5;
            else if (num == 8) pictureBox1.Image = Properties.Resources.duck;
            else if (num == 9) pictureBox1.Image = Properties.Resources.ohio;
            else if (num == 10) pictureBox1.Image = Properties.Resources.ad;
            else if (num == 11) pictureBox1.Image = Properties.Resources.test;
            else if (num == 12) pictureBox1.Image = Properties.Resources.focus;
        }
    }
}