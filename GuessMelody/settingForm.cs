using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Specialized;

namespace GuessMelody
{
    public partial class settingForm : Form
    {
        public settingForm()
        {
            InitializeComponent();
        }

        private void chooseMusicButton_Click(object sender, EventArgs e)
        {
            music = new FolderBrowserDialog(); 
            if (music.ShowDialog() == DialogResult.OK)
            {
                loadMusic(music.SelectedPath);
            }
        }

        private void loadMusic(string folder)
        {
            musicList.Items.Clear();
            musicArray = Directory.GetFiles(folder, "*.mp3", isSubFolder() ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
            musicList.Items.AddRange(musicArray);
        }

        private void okSetButton_Click(object sender, EventArgs e)
        {
            Controller.setMusic(musicArray);
            
            Controller.setAllDirectories(isSubFolder());
            Controller.setGameDuration(Convert.ToInt32(gameDurationComboBox.Text));
            if (music != null) Controller.setLastFolder(music.SelectedPath);
            Controller.setMelodyDuration(Convert.ToInt32(melodyDurationComboBox.Text));
            Controller.setRandomStart(randomStartCheckBox.Checked);
            Controller.setTimeToAns(Convert.ToInt32(timeToAnswerLabel.Text));
            Controller.setControlKey(keyPlayerOneComboBox.Text + keyPlayerTwoComboBox.Text);

            Controller.writeSettings();
            closeSetting();
        }

        private void cancelSetButton_Click(object sender, EventArgs e)
        {
            recoverParam();
            closeSetting();
        }
        
        public void recoverParam()
        {
            gameDurationComboBox.Text = Controller.getGameDuration().ToString();
            melodyDurationComboBox.Text = Controller.getMelodyDuration().ToString();
            subfoldersCheckBox.Checked = Controller.getAllDirectories();
            randomStartCheckBox.Checked = Controller.getRandomStart();
            loadMusic(Controller.getLastFolder());
            keyPlayerOneComboBox.Text = Controller.getControlKey(0).ToString();
            keyPlayerTwoComboBox.Text = Controller.getControlKey(1).ToString();
        }

        private void clearMusicButton_Click(object sender, EventArgs e)
        {
            musicList.Items.Clear();
            Controller.setMusic(new string[0]);
        }

        private void closeSetting()
        {
            this.Hide();
        }

        private bool isSubFolder()
        {
            return subfoldersCheckBox.Checked;
        }

        string[] musicArray = new string[0];
        FolderBrowserDialog music;

        private void settingForm_Load(object sender, EventArgs e)
        {
            recoverParam();
        }

    }
}
