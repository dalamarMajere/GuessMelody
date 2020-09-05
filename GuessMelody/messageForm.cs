using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace GuessMelody
{
    public partial class messageForm : Form
    {
        private int timeToAns;
        private string rightAnswer;
        SoundPlayer tickerSound = new SoundPlayer("Resources\\Answer.wav");

        public messageForm()
        {
            InitializeComponent();
        }

        private void messageForm_Load(object sender, EventArgs e)
        {
            timeToAns = Controller.getTimeToAns();
            timer1.Start();
            tickerSound.PlayLooping();
        }

        public void setPlayer(string player)
        {
            playerLabel.Text = player;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerLabel.Text = (--timeToAns).ToString();
            if (timeToAns == 0)
            {
                timer1.Stop();
            }
        }

        private void messageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            tickerSound.Stop();
            timer1.Stop();
        }

        private void showAnswerLabel_MouseClick(object sender, MouseEventArgs e)
        {
            showAnswerLabel.Text = rightAnswer;
        }

        public void setRightAnswer(string ans)
        {
            rightAnswer = ans;
        }
    }
}
