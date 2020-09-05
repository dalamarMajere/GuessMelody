using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessMelody
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void gameButton_Click(object sender, EventArgs e)
        {
            game.ShowDialog();
        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            set.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        settingForm set = new settingForm();
        gameForm game = new gameForm();

        private void fMain_Load(object sender, EventArgs e)
        {
            Controller.readSettings();
            set.recoverParam();
        }
    }
}
