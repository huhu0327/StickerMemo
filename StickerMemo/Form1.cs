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

        static string titleName = "새 메모";

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

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            DialogResult dr = fontDialog1.ShowDialog();

            if(dr == DialogResult.OK)
            bunifuCustomTextbox1.Font = fontDialog1.Font;
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();

            bunifuCustomTextbox1.ForeColor = colorDialog1.Color;
        }

        private void bunifuCustomLabel1_DoubleClick(object sender, EventArgs e)
        {
            ChangeTitle ct = new ChangeTitle();
            ct.ShowDialog();
        }

        public static void ChangeTitle(string text)
        {
           titleName = text;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            bunifuCustomLabel1.Text = titleName;
        }
    }
}
