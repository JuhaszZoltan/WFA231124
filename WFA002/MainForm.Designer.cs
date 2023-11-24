namespace WFA002
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMain = new Panel();
            menuMain = new MenuStrip();
            tsmiColorPicker = new ToolStripMenuItem();
            menuMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlMain.AutoSize = true;
            pnlMain.BackColor = Color.Aqua;
            pnlMain.Location = new Point(12, 27);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(281, 300);
            pnlMain.TabIndex = 0;
            // 
            // menuMain
            // 
            menuMain.Items.AddRange(new ToolStripItem[] { tsmiColorPicker });
            menuMain.Location = new Point(0, 0);
            menuMain.Name = "menuMain";
            menuMain.Size = new Size(305, 24);
            menuMain.TabIndex = 1;
            menuMain.Text = "menuStrip1";
            // 
            // tsmiColorPicker
            // 
            tsmiColorPicker.Name = "tsmiColorPicker";
            tsmiColorPicker.Size = new Size(80, 20);
            tsmiColorPicker.Text = "ColorPicker";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(305, 339);
            Controls.Add(pnlMain);
            Controls.Add(menuMain);
            MainMenuStrip = menuMain;
            Name = "MainForm";
            Text = "Pixel-Színező";
            menuMain.ResumeLayout(false);
            menuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlMain;
        private MenuStrip menuMain;
        private ToolStripMenuItem tsmiColorPicker;
    }
}