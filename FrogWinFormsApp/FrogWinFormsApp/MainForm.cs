using System.Media;

namespace FrogWinFormsApp
{
    public partial class MainForm : Form
    {
        int startLocationXEmptyPictureBox = 440;
        private SoundPlayer soundPlayerJump
            = new SoundPlayer(Properties.Resources.Windows_Startup);

        public MainForm()
        {
            InitializeComponent();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            Swap((PictureBox)sender);
            if (endGame())
            {
                if(scoreLabel.Text == "24")
                {
                    MessageBox.Show("Поздравляю! Вы выиграли за минимальное количество ходов!!!");
                    Application.Exit();
                }
                else
                {
                    var answer = MessageBox.Show("Вы выиграли, но результат может быть лучше. " +
                        "Хотите попробовать еще раз?", "Конец игры", MessageBoxButtons.YesNo);
                    if (answer == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                    Application.Exit();
                }
                
            }
        }

        private bool endGame()
        {
            if (leftPictureBox1.Location.X > emptyPictureBox.Location.X &&
                leftPictureBox2.Location.X > emptyPictureBox.Location.X &&
                leftPictureBox3.Location.X > emptyPictureBox.Location.X &&
                leftPictureBox4.Location.X > emptyPictureBox.Location.X &&
                emptyPictureBox.Location.X > rightPictureBox1.Location.X &&
                emptyPictureBox.Location.X > rightPictureBox2.Location.X &&
                emptyPictureBox.Location.X > rightPictureBox3.Location.X &&
                emptyPictureBox.Location.X > rightPictureBox4.Location.X)
            {
                return true;

            } 
            return false;
        }

        private void Swap(PictureBox clickedPicture)
        {
            double distance = Math.Abs(clickedPicture.Location.X - emptyPictureBox.Location.X) / emptyPictureBox.Width;

            if (distance > 2 || distance == 0 )
            {
                MessageBox.Show("Так прыгать нельзя!");
            }
            else if (distance <= 2)
            {
                soundPlayerJump.Play();
                
                var location = clickedPicture.Location;

                clickedPicture.Location = emptyPictureBox.Location;

                emptyPictureBox.Location = location;

                scoreLabel.Text = (Convert.ToInt32(scoreLabel.Text) + 1).ToString();
            }
        
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var welcomeForm = new WelcomeForm();
            welcomeForm.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}