using WFA001.Properties;

namespace WFA001
{
    public partial class MainForm : Form
    {
        //a Random MINDIG static!!!
        static Random rnd = new();

        public MainForm()
        {
            InitializeComponent();
            Icon = Resources.suni;
            lblWelcome.BackColor = Color.FromArgb(100, Color.RosyBrown);
            tbxName.TextChanged += TbxName_TextChanged;
            btnHello.Click += BtnHello_Click;
            rbFemale.CheckedChanged += RbGender_CheckedChanged;
            rbMale.CheckedChanged += RbGender_CheckedChanged;
            cbShowDate.CheckedChanged += CbShowDate_CheckedChanged;
            tmrTimeUpdate.Tick += TmrTimeUpdate_Tick;
        }

        private void TmrTimeUpdate_Tick(object? sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("yyyy. MMM dd. (dddd) HH:mm:ss");
        }

        private void CbShowDate_CheckedChanged(object? sender, EventArgs e)
        {
            if (cbShowDate.Checked)
            {
                lblDateTime.Visible = true;
                tmrTimeUpdate.Start();
            }
            else
            {
                lblDateTime.Visible = false;
                tmrTimeUpdate.Stop();
            }
        }

        private void RbGender_CheckedChanged(object? sender, EventArgs e)
        {
            btnHello.BackColor = rbFemale.Checked ? Color.LightPink : Color.LightBlue;
        }

        private void BtnHello_Click(object? sender, EventArgs e)
        {
            lblWelcome.Text = $"Hello, {tbxName.Text}! <3";
        }

        private void TbxName_TextChanged(object? sender, EventArgs e)
        {
            tbxName.BackColor = Color.FromArgb(
                red: rnd.Next(256),
                green: rnd.Next(256),
                blue: rnd.Next(256));
        }
    }
}