namespace ClickBuster
{
    public partial class F_Menu : Form
    {
        public F_Menu()
        {
            InitializeComponent();
        }

        private void B_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void B_Syokyu_Click(object sender, EventArgs e)
        {
            F_Main fMain = new F_Main
            {
                Height = 400,
                Width = 400,
                EnmTim = 1000,
                Enms = 20,
                GmTim = 10000
            };
            fMain.FrmIni();
            fMain.Show();
            fMain.FormClosed += (s, args) => this.Show();

            this.Hide();
        }

        private void B_Chukyu_Click(object sender, EventArgs e)
        {
            F_Main fMain = new F_Main
            {
                Height = 500,   // フォームの高さ
                Width = 700,    // フォームの幅
                EnmTim = 800,   // 敵の動く速度
                Enms = 30,      // 敵の数
                GmTim = 15000   // 制限時間
            };

            fMain.FrmIni(); // 難易度初期化
            fMain.Show();
            this.Hide();

        }

        private void B_Jyokyu_Click(object sender, EventArgs e)
        {
            F_Main fMain = new F_Main
            {
                Height = 600,   // フォームの高さ
                Width = 800,    // フォームの幅
                EnmTim = 300,   // 敵の動く速度
                Enms = 40,      // 敵の数
                GmTim = 20000   // 制限時間
            };

            fMain.FrmIni(); // 難易度初期化
            fMain.Show();
            this.Hide();

        }
    }
}
