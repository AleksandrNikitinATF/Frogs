using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrogWinFormsApp
{
    public partial class WelcomeForm : Form
    {
        private const string quote = "\"";
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void правилаИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Добро пожаловавть в игру" + quote + "Лягушки" + quote + ".\r\n\r\n" + "Цель игры — расположить лягушек, которые смотрят влево, в левую часть, а которые смотрят вправо - в правую часть за минимальное количество прыжков.\r\n\r\nПрыгать можно на пустую кувшинку, если она находится рядом или перепрыгнуть через 1 соседнюю лягушку");
        }

        private void рестартToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
