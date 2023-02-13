using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        public void Game_KeyDown(object sender, KeyEventArgs e)
        {
            Score += map.Move((Keys)e.KeyValue);
            label1.Text = "分数：\n" + Convert.ToString(Score);
        }
        private void Game_Load(object sender, EventArgs e)
        {
            label1.Left = this.Width - 110;
            label2.Left = this.Width - 110;
            map.Initialize();
        }

        private void Game_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void Game_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
