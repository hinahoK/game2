namespace ClickBuster
{
    partial class F_Main
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
            components = new System.ComponentModel.Container();
            B_Start = new Button();
            L_Jikan = new Label();
            L_Tokuten = new Label();
            L_Sum = new Label();
            PG_Jikan = new ProgressBar();
            P_Enemy = new Panel();
            T_Enemy = new System.Windows.Forms.Timer(components);
            T_jikan = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // B_Start
            // 
            B_Start.Location = new Point(12, 12);
            B_Start.Name = "B_Start";
            B_Start.Size = new Size(80, 49);
            B_Start.TabIndex = 0;
            B_Start.Text = "スタート";
            B_Start.UseVisualStyleBackColor = true;
            B_Start.Click += B_Start_Click;
            // 
            // L_Jikan
            // 
            L_Jikan.Font = new Font("Yu Gothic UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 128);
            L_Jikan.Location = new Point(98, 12);
            L_Jikan.Name = "L_Jikan";
            L_Jikan.Size = new Size(66, 16);
            L_Jikan.TabIndex = 1;
            L_Jikan.Text = "残り時間";
            // 
            // L_Tokuten
            // 
            L_Tokuten.Font = new Font("Yu Gothic UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 128);
            L_Tokuten.Location = new Point(249, 12);
            L_Tokuten.Name = "L_Tokuten";
            L_Tokuten.Size = new Size(40, 16);
            L_Tokuten.TabIndex = 2;
            L_Tokuten.Text = "得点";
            // 
            // L_Sum
            // 
            L_Sum.Font = new Font("Yu Gothic UI", 6F, FontStyle.Regular, GraphicsUnit.Point, 128);
            L_Sum.Location = new Point(249, 45);
            L_Sum.Name = "L_Sum";
            L_Sum.Size = new Size(123, 16);
            L_Sum.TabIndex = 3;
            L_Sum.Text = "0";
            L_Sum.TextAlign = ContentAlignment.TopRight;
            // 
            // PG_Jikan
            // 
            PG_Jikan.Location = new Point(101, 35);
            PG_Jikan.Maximum = 10;
            PG_Jikan.Name = "PG_Jikan";
            PG_Jikan.Size = new Size(142, 26);
            PG_Jikan.TabIndex = 4;
            PG_Jikan.Value = 10;
            // 
            // P_Enemy
            // 
            P_Enemy.BackColor = Color.White;
            P_Enemy.BorderStyle = BorderStyle.Fixed3D;
            P_Enemy.Location = new Point(12, 67);
            P_Enemy.Name = "P_Enemy";
            P_Enemy.Size = new Size(360, 402);
            P_Enemy.TabIndex = 5;
            // 
            // T_Enemy
            // 
            T_Enemy.Interval = 1000;
            T_Enemy.Tick += T_Enemy_Tick;
            // 
            // T_jikan
            // 
            T_jikan.Interval = 1000;
            T_jikan.Tick += T_jikan_Tick;
            // 
            // F_Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 464);
            Controls.Add(P_Enemy);
            Controls.Add(PG_Jikan);
            Controls.Add(L_Sum);
            Controls.Add(L_Tokuten);
            Controls.Add(L_Jikan);
            Controls.Add(B_Start);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "F_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClickBuster";
            FormClosed += F_Main_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Button B_Start;
        private Label L_Jikan;
        private Label L_Tokuten;
        private Label L_Sum;
        private ProgressBar PG_Jikan;
        private Panel P_Enemy;
        private System.Windows.Forms.Timer T_Enemy;
        private System.Windows.Forms.Timer T_jikan;
    }
}