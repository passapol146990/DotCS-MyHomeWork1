namespace MyHomeWork1_C_
{
    public partial class GameRandomNumber : Form
    {
        int SELECT = 0;
        int SCORE = 0;
        public GameRandomNumber()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        void SetSelect(int num) 
        {
            select.Text = num.ToString(); 
            this.SELECT = num;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetSelect(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetSelect(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetSelect(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SetSelect(4);
        }

        private void Random_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int random = rnd.Next(0, 4);
            oldRandom.Text = random.ToString();
            if (this.SELECT == random)
            {
                MessageBox.Show("successfully.","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.SCORE++;
                score.Text = this.SCORE.ToString();
            }
            else
            {
                MessageBox.Show("Faild.","Falid",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
