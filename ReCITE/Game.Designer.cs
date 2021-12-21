
namespace ReCITE
{
    partial class Game
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
            this.end_btn = new System.Windows.Forms.Button();
            this.game3_btn = new System.Windows.Forms.Button();
            this.game2_btn = new System.Windows.Forms.Button();
            this.game1_btn = new System.Windows.Forms.Button();
            this.gameImage = new System.Windows.Forms.PictureBox();
            this.leadeboard_pnl = new System.Windows.Forms.Panel();
            this.leaderboard_lbl = new System.Windows.Forms.Label();
            this.addPoint_btn = new System.Windows.Forms.Button();
            this.webGame_pnl = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.toolbar_pnl = new System.Windows.Forms.Panel();
            this.minimize_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.reciteLogo = new System.Windows.Forms.PictureBox();
            this.userControl_pnl = new System.Windows.Forms.Panel();
            this.game_pnl = new System.Windows.Forms.Panel();
            this.game4_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gameImage)).BeginInit();
            this.leadeboard_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webGame_pnl)).BeginInit();
            this.toolbar_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reciteLogo)).BeginInit();
            this.userControl_pnl.SuspendLayout();
            this.game_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // end_btn
            // 
            this.end_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.end_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.end_btn.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.end_btn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.end_btn.Location = new System.Drawing.Point(0, 602);
            this.end_btn.Name = "end_btn";
            this.end_btn.Size = new System.Drawing.Size(200, 58);
            this.end_btn.TabIndex = 2;
            this.end_btn.Text = "END";
            this.end_btn.UseVisualStyleBackColor = true;
            this.end_btn.Click += new System.EventHandler(this.end_btn_Click);
            // 
            // game3_btn
            // 
            this.game3_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.game3_btn.Location = new System.Drawing.Point(7, 164);
            this.game3_btn.Margin = new System.Windows.Forms.Padding(0);
            this.game3_btn.Name = "game3_btn";
            this.game3_btn.Size = new System.Drawing.Size(184, 39);
            this.game3_btn.TabIndex = 6;
            this.game3_btn.Text = "Game 3";
            this.game3_btn.UseVisualStyleBackColor = true;
            // 
            // game2_btn
            // 
            this.game2_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.game2_btn.Location = new System.Drawing.Point(7, 119);
            this.game2_btn.Margin = new System.Windows.Forms.Padding(0);
            this.game2_btn.Name = "game2_btn";
            this.game2_btn.Size = new System.Drawing.Size(184, 39);
            this.game2_btn.TabIndex = 5;
            this.game2_btn.Text = "Game 2";
            this.game2_btn.UseVisualStyleBackColor = true;
            // 
            // game1_btn
            // 
            this.game1_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.game1_btn.Location = new System.Drawing.Point(7, 76);
            this.game1_btn.Margin = new System.Windows.Forms.Padding(0);
            this.game1_btn.Name = "game1_btn";
            this.game1_btn.Size = new System.Drawing.Size(184, 39);
            this.game1_btn.TabIndex = 4;
            this.game1_btn.Text = "Game 1";
            this.game1_btn.UseVisualStyleBackColor = true;
            // 
            // gameImage
            // 
            this.gameImage.Image = global::ReCITE.Properties.Resources.game;
            this.gameImage.Location = new System.Drawing.Point(53, 6);
            this.gameImage.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.gameImage.Name = "gameImage";
            this.gameImage.Size = new System.Drawing.Size(98, 58);
            this.gameImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gameImage.TabIndex = 3;
            this.gameImage.TabStop = false;
            // 
            // leadeboard_pnl
            // 
            this.leadeboard_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leadeboard_pnl.Controls.Add(this.leaderboard_lbl);
            this.leadeboard_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.leadeboard_pnl.Location = new System.Drawing.Point(0, 0);
            this.leadeboard_pnl.Name = "leadeboard_pnl";
            this.leadeboard_pnl.Size = new System.Drawing.Size(200, 334);
            this.leadeboard_pnl.TabIndex = 2;
            // 
            // leaderboard_lbl
            // 
            this.leaderboard_lbl.AutoSize = true;
            this.leaderboard_lbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.leaderboard_lbl.Location = new System.Drawing.Point(68, 3);
            this.leaderboard_lbl.Name = "leaderboard_lbl";
            this.leaderboard_lbl.Size = new System.Drawing.Size(73, 30);
            this.leaderboard_lbl.TabIndex = 2;
            this.leaderboard_lbl.Text = "Today\'s \r\nLeaderboard";
            this.leaderboard_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addPoint_btn
            // 
            this.addPoint_btn.BackColor = System.Drawing.Color.Transparent;
            this.addPoint_btn.BackgroundImage = global::ReCITE.Properties.Resources.add_point_btn;
            this.addPoint_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addPoint_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPoint_btn.FlatAppearance.BorderSize = 0;
            this.addPoint_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.addPoint_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.addPoint_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPoint_btn.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addPoint_btn.ForeColor = System.Drawing.Color.Transparent;
            this.addPoint_btn.Location = new System.Drawing.Point(750, 53);
            this.addPoint_btn.Name = "addPoint_btn";
            this.addPoint_btn.Size = new System.Drawing.Size(230, 56);
            this.addPoint_btn.TabIndex = 3;
            this.addPoint_btn.UseVisualStyleBackColor = false;
            // 
            // webGame_pnl
            // 
            this.webGame_pnl.CreationProperties = null;
            this.webGame_pnl.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webGame_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webGame_pnl.Location = new System.Drawing.Point(0, 40);
            this.webGame_pnl.Name = "webGame_pnl";
            this.webGame_pnl.Size = new System.Drawing.Size(1000, 660);
            this.webGame_pnl.Source = new System.Uri("file:///C:/Users/junie/Desktop/webGame.html", System.UriKind.Absolute);
            this.webGame_pnl.TabIndex = 1;
            this.webGame_pnl.ZoomFactor = 1D;
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
            this.toolbar_pnl.Size = new System.Drawing.Size(1200, 40);
            this.toolbar_pnl.TabIndex = 8;
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
            this.minimize_btn.Location = new System.Drawing.Point(1120, 0);
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
            this.exit_btn.Location = new System.Drawing.Point(1160, 0);
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
            // userControl_pnl
            // 
            this.userControl_pnl.Controls.Add(this.game_pnl);
            this.userControl_pnl.Controls.Add(this.end_btn);
            this.userControl_pnl.Controls.Add(this.leadeboard_pnl);
            this.userControl_pnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.userControl_pnl.Location = new System.Drawing.Point(1000, 40);
            this.userControl_pnl.Name = "userControl_pnl";
            this.userControl_pnl.Size = new System.Drawing.Size(200, 660);
            this.userControl_pnl.TabIndex = 9;
            // 
            // game_pnl
            // 
            this.game_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.game_pnl.Controls.Add(this.game4_btn);
            this.game_pnl.Controls.Add(this.gameImage);
            this.game_pnl.Controls.Add(this.game3_btn);
            this.game_pnl.Controls.Add(this.game1_btn);
            this.game_pnl.Controls.Add(this.game2_btn);
            this.game_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.game_pnl.Location = new System.Drawing.Point(0, 334);
            this.game_pnl.Name = "game_pnl";
            this.game_pnl.Size = new System.Drawing.Size(200, 268);
            this.game_pnl.TabIndex = 3;
            // 
            // game4_btn
            // 
            this.game4_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.game4_btn.Location = new System.Drawing.Point(7, 209);
            this.game4_btn.Margin = new System.Windows.Forms.Padding(0);
            this.game4_btn.Name = "game4_btn";
            this.game4_btn.Size = new System.Drawing.Size(184, 39);
            this.game4_btn.TabIndex = 10;
            this.game4_btn.Text = "Game 4";
            this.game4_btn.UseVisualStyleBackColor = true;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.addPoint_btn);
            this.Controls.Add(this.webGame_pnl);
            this.Controls.Add(this.userControl_pnl);
            this.Controls.Add(this.toolbar_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.gameImage)).EndInit();
            this.leadeboard_pnl.ResumeLayout(false);
            this.leadeboard_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webGame_pnl)).EndInit();
            this.toolbar_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reciteLogo)).EndInit();
            this.userControl_pnl.ResumeLayout(false);
            this.game_pnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button end_btn;
        private System.Windows.Forms.Button game3_btn;
        private System.Windows.Forms.Button game2_btn;
        private System.Windows.Forms.Button game1_btn;
        private System.Windows.Forms.PictureBox gameImage;
        private System.Windows.Forms.Panel leadeboard_pnl;
        private System.Windows.Forms.Label leaderboard_lbl;
        private System.Windows.Forms.Button addPoint_btn;
        private Microsoft.Web.WebView2.WinForms.WebView2 webGame_pnl;
        private System.Windows.Forms.Panel toolbar_pnl;
        private System.Windows.Forms.Button minimize_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.PictureBox reciteLogo;
        private System.Windows.Forms.Panel userControl_pnl;
        private System.Windows.Forms.Panel game_pnl;
        private System.Windows.Forms.Button game4_btn;
    }
}