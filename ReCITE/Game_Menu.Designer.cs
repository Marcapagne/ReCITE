
namespace ReCITE
{
    partial class Game_Menu
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
            this.game1_btn = new System.Windows.Forms.Button();
            this.selectGame_lbl = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.PictureBox();
            this.game2_btn = new System.Windows.Forms.Button();
            this.game3_btn = new System.Windows.Forms.Button();
            this.toolbar_pnl = new System.Windows.Forms.Panel();
            this.minimize_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.reciteLogo = new System.Windows.Forms.PictureBox();
            this.game4_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).BeginInit();
            this.toolbar_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reciteLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // game1_btn
            // 
            this.game1_btn.BackgroundImage = global::ReCITE.Properties.Resources.roundedrectangle;
            this.game1_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.game1_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.game1_btn.FlatAppearance.BorderSize = 0;
            this.game1_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.game1_btn.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.game1_btn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.game1_btn.Location = new System.Drawing.Point(376, 268);
            this.game1_btn.Name = "game1_btn";
            this.game1_btn.Size = new System.Drawing.Size(220, 57);
            this.game1_btn.TabIndex = 4;
            this.game1_btn.Text = "Game 1";
            this.game1_btn.UseVisualStyleBackColor = true;
            this.game1_btn.Click += new System.EventHandler(this.gamebtn_Click);
            // 
            // selectGame_lbl
            // 
            this.selectGame_lbl.AutoSize = true;
            this.selectGame_lbl.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectGame_lbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.selectGame_lbl.Location = new System.Drawing.Point(364, 172);
            this.selectGame_lbl.Name = "selectGame_lbl";
            this.selectGame_lbl.Size = new System.Drawing.Size(478, 77);
            this.selectGame_lbl.TabIndex = 3;
            this.selectGame_lbl.Text = "SELECT GAME";
            // 
            // back_btn
            // 
            this.back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_btn.Image = global::ReCITE.Properties.Resources.back_btn;
            this.back_btn.Location = new System.Drawing.Point(12, 46);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(93, 36);
            this.back_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_btn.TabIndex = 5;
            this.back_btn.TabStop = false;
            // 
            // game2_btn
            // 
            this.game2_btn.BackgroundImage = global::ReCITE.Properties.Resources.roundedrectangle;
            this.game2_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.game2_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.game2_btn.FlatAppearance.BorderSize = 0;
            this.game2_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.game2_btn.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.game2_btn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.game2_btn.Location = new System.Drawing.Point(613, 268);
            this.game2_btn.Name = "game2_btn";
            this.game2_btn.Size = new System.Drawing.Size(220, 57);
            this.game2_btn.TabIndex = 6;
            this.game2_btn.Text = "Game 2";
            this.game2_btn.UseVisualStyleBackColor = true;
            this.game2_btn.Click += new System.EventHandler(this.gamebtn_Click);
            // 
            // game3_btn
            // 
            this.game3_btn.BackgroundImage = global::ReCITE.Properties.Resources.roundedrectangle;
            this.game3_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.game3_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.game3_btn.FlatAppearance.BorderSize = 0;
            this.game3_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.game3_btn.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.game3_btn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.game3_btn.Location = new System.Drawing.Point(376, 344);
            this.game3_btn.Name = "game3_btn";
            this.game3_btn.Size = new System.Drawing.Size(220, 57);
            this.game3_btn.TabIndex = 7;
            this.game3_btn.Text = "Game 3";
            this.game3_btn.UseVisualStyleBackColor = true;
            this.game3_btn.Click += new System.EventHandler(this.gamebtn_Click);
            // 
            // toolbar_pnl
            // 
            this.toolbar_pnl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolbar_pnl.Controls.Add(this.minimize_btn);
            this.toolbar_pnl.Controls.Add(this.exit_btn);
            this.toolbar_pnl.Controls.Add(this.reciteLogo);
            this.toolbar_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbar_pnl.Location = new System.Drawing.Point(0, 0);
            this.toolbar_pnl.Name = "toolbar_pnl";
            this.toolbar_pnl.Size = new System.Drawing.Size(1184, 40);
            this.toolbar_pnl.TabIndex = 9;
            // 
            // minimize_btn
            // 
            this.minimize_btn.BackgroundImage = global::ReCITE.Properties.Resources.minimize;
            this.minimize_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.minimize_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimize_btn.FlatAppearance.BorderSize = 0;
            this.minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_btn.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minimize_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.minimize_btn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.minimize_btn.Location = new System.Drawing.Point(1104, 0);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(40, 40);
            this.minimize_btn.TabIndex = 5;
            this.minimize_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minimize_btn.UseVisualStyleBackColor = true;
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackgroundImage = global::ReCITE.Properties.Resources.exit;
            this.exit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exit_btn.ForeColor = System.Drawing.Color.LightCoral;
            this.exit_btn.Location = new System.Drawing.Point(1144, 0);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(40, 40);
            this.exit_btn.TabIndex = 4;
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // reciteLogo
            // 
            this.reciteLogo.Image = global::ReCITE.Properties.Resources.recite_logo_white;
            this.reciteLogo.Location = new System.Drawing.Point(540, 7);
            this.reciteLogo.Name = "reciteLogo";
            this.reciteLogo.Size = new System.Drawing.Size(112, 27);
            this.reciteLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.reciteLogo.TabIndex = 4;
            this.reciteLogo.TabStop = false;
            // 
            // game4_btn
            // 
            this.game4_btn.BackgroundImage = global::ReCITE.Properties.Resources.roundedrectangle;
            this.game4_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.game4_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.game4_btn.FlatAppearance.BorderSize = 0;
            this.game4_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.game4_btn.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.game4_btn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.game4_btn.Location = new System.Drawing.Point(613, 344);
            this.game4_btn.Name = "game4_btn";
            this.game4_btn.Size = new System.Drawing.Size(220, 57);
            this.game4_btn.TabIndex = 10;
            this.game4_btn.Text = "Game 4";
            this.game4_btn.UseVisualStyleBackColor = true;
            this.game4_btn.Click += new System.EventHandler(this.gamebtn_Click);
            // 
            // Game_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.game4_btn);
            this.Controls.Add(this.toolbar_pnl);
            this.Controls.Add(this.game3_btn);
            this.Controls.Add(this.game2_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.game1_btn);
            this.Controls.Add(this.selectGame_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).EndInit();
            this.toolbar_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reciteLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button game1_btn;
        private System.Windows.Forms.Label selectGame_lbl;
        private System.Windows.Forms.PictureBox back_btn;
        private System.Windows.Forms.Button game2_btn;
        private System.Windows.Forms.Button game3_btn;
        private System.Windows.Forms.Panel toolbar_pnl;
        private System.Windows.Forms.Button minimize_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.PictureBox reciteLogo;
        private System.Windows.Forms.Button game4_btn;
    }
}