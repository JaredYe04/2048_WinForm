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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = "选择尺寸：" + trackBar1.Value + "*" + trackBar1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            
            int Size = trackBar1.Value;
            Tile[,] tiles= new Tile[Size, Size];
            for(int i = 1; i <= Size; i++)
            {
                for (int j = 1; j <= Size; j++)
                {
                    tiles[i-1, j-1] = new Tile(0, j, i, game.Width, game.Height);
                    //tiles[i - 1, j - 1].button.KeyDown += game.Game_KeyDown;
                    game.Controls.Add(tiles[i - 1, j - 1].button);
                }
            }
            game.map = new Map(Size, tiles);
            game.Width = game.Height = Size * 115;
            game.Width += 110;
            
            game.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
