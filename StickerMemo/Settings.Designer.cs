namespace StickerMemo
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titlepanel = new System.Windows.Forms.Panel();
            this.wrappanel = new System.Windows.Forms.Panel();
            this.contentpanel = new System.Windows.Forms.Panel();
            this.listpanel = new System.Windows.Forms.Panel();
            this.wrappanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlepanel
            // 
            this.titlepanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.titlepanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlepanel.Location = new System.Drawing.Point(0, 0);
            this.titlepanel.Name = "titlepanel";
            this.titlepanel.Size = new System.Drawing.Size(420, 32);
            this.titlepanel.TabIndex = 1;
            // 
            // wrappanel
            // 
            this.wrappanel.Controls.Add(this.contentpanel);
            this.wrappanel.Controls.Add(this.listpanel);
            this.wrappanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wrappanel.Location = new System.Drawing.Point(0, 32);
            this.wrappanel.Name = "wrappanel";
            this.wrappanel.Size = new System.Drawing.Size(420, 370);
            this.wrappanel.TabIndex = 2;
            // 
            // contentpanel
            // 
            this.contentpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentpanel.Location = new System.Drawing.Point(125, 0);
            this.contentpanel.Name = "contentpanel";
            this.contentpanel.Size = new System.Drawing.Size(295, 370);
            this.contentpanel.TabIndex = 1;
            // 
            // listpanel
            // 
            this.listpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.listpanel.Location = new System.Drawing.Point(0, 0);
            this.listpanel.Name = "listpanel";
            this.listpanel.Size = new System.Drawing.Size(125, 370);
            this.listpanel.TabIndex = 0;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 402);
            this.Controls.Add(this.wrappanel);
            this.Controls.Add(this.titlepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.wrappanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel titlepanel;
        private System.Windows.Forms.Panel wrappanel;
        private System.Windows.Forms.Panel listpanel;
        private System.Windows.Forms.Panel contentpanel;
    }
}