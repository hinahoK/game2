namespace ClickBuster
{
    partial class F_Menu
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
            B_Syokyu = new Button();
            B_Chukyu = new Button();
            B_Jyokyu = new Button();
            B_Close = new Button();
            SuspendLayout();
            // 
            // B_Syokyu
            // 
            B_Syokyu.Location = new Point(12, 12);
            B_Syokyu.Name = "B_Syokyu";
            B_Syokyu.Size = new Size(260, 74);
            B_Syokyu.TabIndex = 0;
            B_Syokyu.Text = "初級";
            B_Syokyu.UseVisualStyleBackColor = true;
            B_Syokyu.Click += B_Syokyu_Click;
            // 
            // B_Chukyu
            // 
            B_Chukyu.Location = new Point(12, 92);
            B_Chukyu.Name = "B_Chukyu";
            B_Chukyu.Size = new Size(260, 74);
            B_Chukyu.TabIndex = 1;
            B_Chukyu.Text = "中級";
            B_Chukyu.UseVisualStyleBackColor = true;
            B_Chukyu.Click += B_Chukyu_Click;
            // 
            // B_Jyokyu
            // 
            B_Jyokyu.Location = new Point(12, 172);
            B_Jyokyu.Name = "B_Jyokyu";
            B_Jyokyu.Size = new Size(260, 74);
            B_Jyokyu.TabIndex = 2;
            B_Jyokyu.Text = "上級";
            B_Jyokyu.UseVisualStyleBackColor = true;
            B_Jyokyu.Click += B_Jyokyu_Click;
            // 
            // B_Close
            // 
            B_Close.Location = new Point(12, 275);
            B_Close.Name = "B_Close";
            B_Close.Size = new Size(260, 74);
            B_Close.TabIndex = 3;
            B_Close.Text = "終了";
            B_Close.UseVisualStyleBackColor = true;
            B_Close.Click += B_Close_Click;
            // 
            // F_Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 354);
            Controls.Add(B_Close);
            Controls.Add(B_Jyokyu);
            Controls.Add(B_Chukyu);
            Controls.Add(B_Syokyu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "F_Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClickBuster";
            ResumeLayout(false);
        }

        #endregion

        private Button B_Syokyu;
        private Button B_Chukyu;
        private Button B_Jyokyu;
        private Button B_Close;
    }
}
