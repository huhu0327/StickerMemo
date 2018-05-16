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

namespace StickerMemo
{
    public partial class Form1 : Form
    {
        bool isTop = false;

        static string titleName = "새 메모";

        bool isHidden = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
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
            this.Close();
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

            if (dr == DialogResult.OK)
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

        #region 파일 저장
        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "텍스트 문서(*.txt)|*.txt|모든 파일(*.*)|*.*";
            saveFileDialog1.FileName = bunifuCustomLabel1.Text;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(bunifuCustomTextbox1.Text);

                sw.Close();
            }
        }
        #endregion

        #region 파일 열기
        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "텍스트 문서(*.txt)|*.txt|모든 파일(*.*)|*.*";
            openFileDialog1.FileName = "";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                bunifuCustomTextbox1.Text = sr.ReadToEnd();
                bunifuCustomTextbox1.Select(bunifuCustomTextbox1.TextLength - 1, 0);

                sr.Close();
            }
        }
        #endregion

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        void ShowDrawer()
        {
            panel1.Width -= 10;
            if(panel1.Width <= 455)
            {
                timer1.Stop();
                this.Refresh();
                isHidden = false;
            }
        }

        void HideDrawer()
        {
            panel1.Width += 10;
            if (panel1.Width >= 515)
            {
                timer1.Stop();
                this.Refresh();
                isHidden = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isHidden)
            {
                ShowDrawer();
            }
            else
            {
                HideDrawer();
            }
        }
    }
}
