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
    public partial class gameForm : Form
    {
        private int scoreOne = 0, scoreTwo = 0;
        private int melodyDuration;
        private string currentMelody = "";
        private bool[] playerAnswered = new bool[2];

        public gameForm()
        {
            InitializeComponent();
        }

        private void makeMusic()
        {
            melodyDuration = Controller.getMelodyDuration();
            melodyDurationLabel.Text = melodyDuration.ToString();
            WMP.URL = Controller.getMusic();
            WMP.Ctlcontrols.play();
            currentMelody = System.IO.Path.GetFileNameWithoutExtension(WMP.URL);
            playerAnswered[0] = playerAnswered[1] = false;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            timer.Start();
            makeMusic();
        }

        private void gameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
            WMP.Ctlcontrols.stop();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            pauseGame();
        }

        private void pauseGame()
        {
            timer.Stop();
            WMP.Ctlcontrols.pause();
        }

        private void continueGame()
        {
            timer.Start();
            WMP.Ctlcontrols.play();
        }

        private void contButton_Click(object sender, EventArgs e)
        {
            continueGame();
        }

        private void endGame()
        {
            timer.Stop();
            WMP.Ctlcontrols.stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            melodyDurationLabel.Text = (--melodyDuration).ToString();
            ansTimeProgressBar.Value++;
            if (ansTimeProgressBar.Value >= ansTimeProgressBar.Maximum)
            {
                endGame();
            }
            if (melodyDuration == 0)
            {
                SoundPlayer ding = new SoundPlayer("Resources\\Ding.wav");
                ding.Play();
                makeMusic();
            }
        }

        private void gameForm_Load(object sender, EventArgs e)
        {
            counterMusicLabel.Text = Controller.getMelodyAmount().ToString();
            ansTimeProgressBar.Value = 0;
            ansTimeProgressBar.Minimum = 0;
            ansTimeProgressBar.Maximum = Controller.getGameDuration();
        }

        private void answer(string player)
        {
            pauseGame();
            messageForm mf = new messageForm();
            mf.setPlayer(player);
            mf.setRightAnswer(currentMelody);
            if (mf.ShowDialog() == DialogResult.Yes)
            {
                SoundPlayer sound = new SoundPlayer("Resources\\Yes.wav");
                sound.Play();
                changeScore(player, 1);
                makeMusic();
            }
            else
            {
                SoundPlayer sound = new SoundPlayer("Resources\\No.wav");
                sound.Play();
            }
            continueGame();
        }

        private void WMP_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (Controller.getRandomStart())
                if (WMP.openState == WMPLib.WMPOpenState.wmposMediaOpen)
                    WMP.Ctlcontrols.currentPosition = (new Random()).Next(0, (int)WMP.currentMedia.duration/2);
        }

        private void addScoreOneButton_Click(object sender, EventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case "addScoreOneButton": changeScore("Player One", 1); return;
                case "addScoreTwoButton": changeScore("Player Two", 1); return;
                case "takeScoreTwoButton": changeScore("Player Two", -1); return;
                case "takeScoreOneButton": changeScore("Player One", -1); return;
            }
        }

        private void changeScore(string player, int operation)
        {
            switch (player)
            {
                case "Player One": scoreOne += operation; break;
                case "Player Two": scoreTwo += operation; break;
            }
            scoreOneLabel.Text = scoreOne.ToString();
            scoreTwoLabel.Text = scoreTwo.ToString();
        }

        private void gameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (!timer.Enabled) return;
            char pressedKey = Convert.ToChar(e.KeyValue);
            if (!playerAnswered[0] && pressedKey == Controller.getControlKey(0))
                answer("Player One");
            else if (!playerAnswered[1] && pressedKey == Controller.getControlKey(1))
                answer("Player Two");
        }
    }
}
