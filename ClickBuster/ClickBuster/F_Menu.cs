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
                Height = 500,   // �t�H�[���̍���
                Width = 700,    // �t�H�[���̕�
                EnmTim = 800,   // �G�̓������x
                Enms = 30,      // �G�̐�
                GmTim = 15000   // ��������
            };

            fMain.FrmIni(); // ��Փx������
            fMain.Show();
            this.Hide();

        }

        private void B_Jyokyu_Click(object sender, EventArgs e)
        {
            F_Main fMain = new F_Main
            {
                Height = 600,   // �t�H�[���̍���
                Width = 800,    // �t�H�[���̕�
                EnmTim = 300,   // �G�̓������x
                Enms = 40,      // �G�̐�
                GmTim = 20000   // ��������
            };

            fMain.FrmIni(); // ��Փx������
            fMain.Show();
            this.Hide();

        }
    }
}
