using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StickerMemo
{
    public partial class Form1 : Form
    {
        static bool isTop = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton1_MouseHover(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void bunifuImageButton1_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = TransparencyKey;
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = TransparencyKey;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            SwitchTop();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            SwitchTop();
        }

        private void SwitchTop()
        {
            isTop = !isTop;
            this.TopMost = isTop;
            if (isTop)
            {
                bunifuImageButton2.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("icons8_Pin_50px_2");
            }
            else
            {
                bunifuImageButton2.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("icons8_Pin_50px_1");
            }
        }
    }
}
