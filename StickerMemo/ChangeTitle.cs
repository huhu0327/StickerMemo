﻿using System;
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
    public partial class ChangeTitle : Form
    {
        public ChangeTitle()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {
            if (bunifuCustomTextbox1.Text.ToString() != "") Form1.ChangeTitle(bunifuCustomTextbox1.Text);
            this.Close();
        }

        private void bunifuCustomTextbox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
            else if(e.KeyCode == Keys.Enter)
            {
                if (bunifuCustomTextbox1.Text.ToString() != "") Form1.ChangeTitle(bunifuCustomTextbox1.Text);
                this.Close();
            }
        }
    }
}
