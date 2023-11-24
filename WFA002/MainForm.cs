namespace WFA002
{
    public partial class MainForm : Form
    {
        private Label[,] pixelSzinezo = new Label[25, 25];
        private Color color = Color.LightCoral;

        public MainForm()
        {
            InitializeComponent();
            FillPanel();
            tsmiColorPicker.Click += TsmiColorPicker_Click;
        }

        private void TsmiColorPicker_Click(object sender, EventArgs e)
        {
            ColorDialog colDia = new();
            DialogResult res = colDia.ShowDialog();
            if (res == DialogResult.OK)
            {
                color = colDia.Color;
            }
        }

        private void FillPanel()
        {
            for (int s = 0; s < pixelSzinezo.GetLength(0); s++)
            {
                for (int o = 0; o < pixelSzinezo.GetLength(1); o++)
                {
                    pixelSzinezo[s, o] = new()
                    {
                        AutoSize = false,
                        Bounds = new(
                            x: o * 20,
                            y: s * 20,
                            width: 20,
                            height: 20),
                        //BackColor = (s*o % 2) == 0 
                        //? Color.Black 
                        //: Color.White,
                        BackColor = Color.White,
                    };
                    pixelSzinezo[s, o].Click += Lbl_Click;
                    pnlMain.Controls.Add(pixelSzinezo[s, o]);
                }
            }
        }

        private void Lbl_Click(object sender, EventArgs e)
        {
            if ((sender as Label).BackColor == Color.White)
            {
                (sender as Label).BackColor = color;
            }
            else (sender as Label).BackColor = Color.White;
        }
    }
}