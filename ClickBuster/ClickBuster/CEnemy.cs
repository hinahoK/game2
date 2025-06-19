using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClickBuster
{
    public class CEnemy
    {
        // クラス内変数
        private PictureBox _pbImgEnemy;  // 敵の画像
        private Control _enemyOwner;      // 敵が出現するオーナー
        private Random _rnd = new Random(); // ランダム変数
        private int _intTokuten;         // 敵を倒した時の得点
        private int _intMvwd;            // 敵が動く際の幅
        private int _intMvud;            // 上下左右に動く
        private int _intMovePattern;     // 敵のパターン

        public event EventHandler OnClick;
        public void DoClick(object sender, EventArgs e)
        {
            OnClick?.Invoke(this, e);
        }

        private void _RandPlace()
        {
            //出現場所はオーナーの範囲内にする
            //高さ
            int intTop = _rnd.Next(((Control)_enemyOwner).Size.Height - _pbImgEnemy.Size.Height);
            _pbImgEnemy.Top = intTop;

            //横
            int intLeft = _rnd.Next(((Control)_enemyOwner).Size.Width - _pbImgEnemy.Size.Width);
            _pbImgEnemy.Left = intLeft;

            //敵のパターン(画像と得点)をランダムに指定する
            _intMovePattern = _rnd.Next(1,4);
            _pbImgEnemy.SizeMode = PictureBoxSizeMode.AutoSize;

            switch (_intMovePattern)
            {
                case 1:
                    _pbImgEnemy.Image = Image.FromFile("enemy1.gif");
                    _intTokuten = 500;
                    break;
                case 2:
                    _pbImgEnemy.Image = Image.FromFile("enemy2.gif");
                    _intTokuten = 1000;
                    break;
                case 3:
                    _pbImgEnemy.Image = Image.FromFile("enemy3.gif");
                    _intTokuten = 3000;
                    break;
            }

        }
        public CEnemy(Control owner, Random rand)
        {
            _pbImgEnemy = new PictureBox();
            _enemyOwner = owner;
            _rnd = rand;
            _intMvwd = 10;
            _intMvud = 0;

            _pbImgEnemy.Click += DoClick;
            _RandPlace();
            ((Control)_enemyOwner).Controls.Add(_pbImgEnemy);
        }
        public void MvEnm()
        {
            switch (_intMovePattern)
            {
                case 1:
                    int intMv = _rnd.Next(1, 5);

                    switch(intMv)
                    {
                        case 1:
                            if ((_pbImgEnemy.Top + _pbImgEnemy.Height + _intMvwd) < _enemyOwner.Height) {
                                _pbImgEnemy.Top += _intMvwd;
                            }
                            break;
                        case 2:
                            if ((_pbImgEnemy.Top - _intMvwd) > 0) {
                                _pbImgEnemy.Top -= _intMvwd;
                            }
                            break;
                        case 3:
                            if ((_pbImgEnemy.Left + _pbImgEnemy.Width + _intMvwd) < _enemyOwner.Width) {
                                _pbImgEnemy.Left += _intMvwd;
                            }
                            break;
                        case 4:
                            if ((_pbImgEnemy.Left - _intMvwd) > 0) 
                            {
                                _pbImgEnemy.Left -= _intMvwd;
                            }
                            break;
                    }
                    break;
                case 2:
                    if (_intMvud == 0)
                    {
                        _intMvud = _rnd.Next(1, 5);
                    }

                    switch (_intMvud)
                    {
                        case 1:
                            if ((_pbImgEnemy.Top + _pbImgEnemy.Height + _intMvwd) < _enemyOwner.Height)
                            {
                                _pbImgEnemy.Top += _intMvwd;
                            }
                            else
                            {
                                _intMvud = _rnd.Next(1, 5);
                            }
                            break;
                        case 2:
                            if ((_pbImgEnemy.Top - _intMvwd) > 0)
                            {
                                _pbImgEnemy.Top -= _intMvwd;
                            }
                            else
                            {
                                _intMvud = _rnd.Next(1, 5);
                            }
                            break;
                        case 3:
                            if ((_pbImgEnemy.Left + _pbImgEnemy.Width + _intMvwd) < _enemyOwner.Width)
                            {
                                _pbImgEnemy.Left += _intMvwd;
                            }
                            else
                            {
                                _intMvud = _rnd.Next(1, 5);
                            }
                            break;
                        case 4:
                            if ((_pbImgEnemy.Left - _intMvwd) > 0)
                            {
                                _pbImgEnemy.Left -= _intMvwd;
                            }
                            else
                            {
                                _intMvud = _rnd.Next(1, 5);
                            }
                            break;
                    }
                    break;
                case 3:
                    if (_intMvud == 0)
                    {
                        _intMvud = _rnd.Next(1, 5);
                    }

                    switch (_intMvud)
                    {
                        case 1:
                            if ((_pbImgEnemy.Top + _pbImgEnemy.Height + _intMvwd) < _enemyOwner.Height
                                &&
                                (_pbImgEnemy.Left + _pbImgEnemy.Width + _intMvwd) < _enemyOwner.Width)
                            {
                                _pbImgEnemy.Top += _intMvwd;
                                _pbImgEnemy.Left += _intMvwd;
                            }
                            else
                            {
                                if ((_pbImgEnemy.Top + _pbImgEnemy.Height + _intMvwd) > _enemyOwner.Height)
                                {
                                    _intMvud = 2;
                                }
                                else if ((_pbImgEnemy.Left + _pbImgEnemy.Width + _intMvwd) > _enemyOwner.Width)
                                {
                                    _intMvud = 3;
                                }
                            }
                            break;
                        case 2:
                            if ((_pbImgEnemy.Top - _intMvwd) > 0 &&
                                (_pbImgEnemy.Left + _pbImgEnemy.Width + _intMvwd) < _enemyOwner.Width)
                            {
                                _pbImgEnemy.Top -= _intMvwd;
                                _pbImgEnemy.Left += _intMvwd;
                            }
                            else
                            {
                                if ((_pbImgEnemy.Top - _intMvwd) < 0)
                                {
                                    _intMvud = 1;
                                }
                                else if ((_pbImgEnemy.Left + _pbImgEnemy.Width + _intMvwd) > _enemyOwner.Width)
                                {
                                    _intMvud = 4;
                                }
                            }
                            break;
                        case 3:
                            if ((_pbImgEnemy.Left - _intMvwd) > 0 &&
                                (_pbImgEnemy.Top + _pbImgEnemy.Height + _intMvwd) < _enemyOwner.Height)
                            {
                                _pbImgEnemy.Top += _intMvwd;
                                _pbImgEnemy.Left -= _intMvwd;
                            }
                            else
                            {
                                    if ((_pbImgEnemy.Left - _intMvwd) < 0)
                                {
                                    _intMvud = 1;
                                }
                                else if ((_pbImgEnemy.Top + _pbImgEnemy.Height + _intMvwd) > _enemyOwner.Height)
                                {
                                    _intMvud = 4;
                                }
                            }
                            break;
                        case 4:
                            if((_pbImgEnemy.Left - _intMvwd) > 0 &&
                                (_pbImgEnemy.Top - _intMvwd) > 0)
                            {
                                _pbImgEnemy.Top -= _intMvwd;
                                _pbImgEnemy.Left -= _intMvwd;
                            }
                            else
                            {
                                if ((_pbImgEnemy.Left - _intMvwd) < 0)
                                {
                                    _intMvud = 2;
                                }
                                else if ((_pbImgEnemy.Top - _intMvwd) < 0)
                                {
                                    _intMvud = 3;
                                }
                            }
                            break;
                    }
                    break;
            }
        }

        public void EnemyDown()
        {
            _RandPlace();
        }

        public int GetTokuten()
        {
            return _intTokuten;
        }

        ~CEnemy()
        {
        }
    }
}
