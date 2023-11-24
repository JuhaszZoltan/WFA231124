namespace WFA001
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
            components = new System.ComponentModel.Container();
            btnHello = new Button();
            tbxName = new TextBox();
            lblWelcome = new Label();
            label1 = new Label();
            gbxCatGender = new GroupBox();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            cbShowDate = new CheckBox();
            lblDateTime = new Label();
            tmrTimeUpdate = new System.Windows.Forms.Timer(components);
            gbxCatGender.SuspendLayout();
            SuspendLayout();
            // 
            // btnHello
            // 
            btnHello.BackColor = Color.Pink;
            btnHello.Location = new Point(12, 118);
            btnHello.Margin = new Padding(5, 6, 5, 6);
            btnHello.Name = "btnHello";
            btnHello.Size = new Size(295, 58);
            btnHello.TabIndex = 0;
            btnHello.Text = "Hello!";
            btnHello.UseVisualStyleBackColor = false;
            // 
            // tbxName
            // 
            tbxName.Location = new Point(12, 50);
            tbxName.Margin = new Padding(5, 6, 5, 6);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(595, 36);
            tbxName.TabIndex = 1;
            // 
            // lblWelcome
            // 
            lblWelcome.Location = new Point(12, 193);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(295, 76);
            lblWelcome.TabIndex = 2;
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(141, 19);
            label1.TabIndex = 2;
            label1.Text = "Type your name here:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbxCatGender
            // 
            gbxCatGender.BackColor = Color.Transparent;
            gbxCatGender.Controls.Add(rbMale);
            gbxCatGender.Controls.Add(rbFemale);
            gbxCatGender.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            gbxCatGender.Location = new Point(12, 283);
            gbxCatGender.Name = "gbxCatGender";
            gbxCatGender.Size = new Size(295, 108);
            gbxCatGender.TabIndex = 3;
            gbxCatGender.TabStop = false;
            gbxCatGender.Text = "What is the gender of the cat?";
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            rbMale.ForeColor = Color.DodgerBlue;
            rbMale.Location = new Point(22, 66);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(72, 29);
            rbMale.TabIndex = 1;
            rbMale.Text = "male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Checked = true;
            rbFemale.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            rbFemale.ForeColor = Color.Magenta;
            rbFemale.Location = new Point(22, 31);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(89, 29);
            rbFemale.TabIndex = 0;
            rbFemale.TabStop = true;
            rbFemale.Text = "female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // cbShowDate
            // 
            cbShowDate.AutoSize = true;
            cbShowDate.BackColor = Color.Transparent;
            cbShowDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cbShowDate.Location = new Point(21, 412);
            cbShowDate.Name = "cbShowDate";
            cbShowDate.Size = new Size(196, 29);
            cbShowDate.TabIndex = 4;
            cbShowDate.Text = "show date and time";
            cbShowDate.UseVisualStyleBackColor = false;
            // 
            // lblDateTime
            // 
            lblDateTime.BackColor = Color.Transparent;
            lblDateTime.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblDateTime.Location = new Point(223, 411);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(384, 29);
            lblDateTime.TabIndex = 2;
            lblDateTime.TextAlign = ContentAlignment.MiddleRight;
            lblDateTime.Visible = false;
            // 
            // tmrTimeUpdate
            // 
            tmrTimeUpdate.Interval = 1000;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.sadCat;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(621, 466);
            Controls.Add(cbShowDate);
            Controls.Add(gbxCatGender);
            Controls.Add(label1);
            Controls.Add(lblDateTime);
            Controls.Add(lblWelcome);
            Controls.Add(tbxName);
            Controls.Add(btnHello);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "MainForm";
            Text = "Ez a WFA ismétlő óra";
            gbxCatGender.ResumeLayout(false);
            gbxCatGender.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHello;
        private TextBox tbxName;
        private Label lblWelcome;
        private Label label1;
        private GroupBox gbxCatGender;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private CheckBox cbShowDate;
        private Label lblDateTime;
        private System.Windows.Forms.Timer tmrTimeUpdate;
    }
}