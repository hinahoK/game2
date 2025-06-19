using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickBuster
{
    public partial class F_Main : Form
    {
        public void FrmIni()
        {
            // フォームのサイズでコントロールを配置する
            P_Enemy.Height = this.Height - P_Enemy.Top - 45;
            P_Enemy.Width = this.Width - 40;

            // 合計得点の初期化
            L_Sum.Text = "0";

            // 敵の動くスピード
            T_Enemy.Interval = EnmTim;

            // 残り時間の初期化
            PG_Jikan.Maximum = GmTim / 1000;
            PG_Jikan.Value = PG_Jikan.Maximum;
        }
        public int Enms { get; set; } = 10;
        public int EnmTim { get; set; } = 500;
        public int GmTim { get; set; } = 60000;

        private Random _rnd = new Random();


        // 複数の敵を格納する変数
        private List<CEnemy> _enemies = new List<CEnemy>();

        public F_Main()
        {
            InitializeComponent();
        }

        private void F_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            F_Menu fMenu = new F_Menu();
            fMenu.Show();
        }

        private void B_Start_Click(object sender, EventArgs e)
        {
            B_Start.Enabled = false;

            for (int i = 0; i < Enms; i++)
            {
                CEnemy enemy = new CEnemy(P_Enemy, _rnd);
                _enemies.Add(enemy);

                enemy.OnClick += EnmOnClick;

                Application.DoEvents();
            }

            T_Enemy.Enabled = true;
            T_jikan.Enabled = true;
        }

        private void T_Enemy_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < _enemies.Count; i++)
            {
                ((CEnemy)_enemies[i]).MvEnm();

                Application.DoEvents();
            }
        }

        private void T_jikan_Tick(object sender, EventArgs e)
        {
            if (PG_Jikan.Value > PG_Jikan.Minimum)
            {
                PG_Jikan.Value -= 1;
            }
            else
            {
                PG_Jikan.Value = PG_Jikan.Minimum;

                T_Enemy.Enabled = false;
                T_jikan.Enabled = false;

                MessageBox.Show($"終了です\nあなたの得点は {L_Sum.Text} です", "ゲーム終了");

                this.Close();
            }
        }

        public void EnmOnClick(object sender, EventArgs e)
        {
            L_Sum.Text = (int.Parse(L_Sum.Text) + ((CEnemy)sender).GetTokuten()).ToString();

            ((CEnemy)sender).EnemyDown();
        }
    }
}
