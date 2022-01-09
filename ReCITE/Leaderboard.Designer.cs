
namespace ReCITE
{
    partial class Leaderboard
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
            this.className_lbl = new System.Windows.Forms.Label();
            this.leaderboard_lbl = new System.Windows.Forms.Label();
            this.proceed_btn = new System.Windows.Forms.PictureBox();
            this.webLeaderboard_pnl = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.toolbar_pnl = new System.Windows.Forms.Panel();
            this.minimize_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.reciteLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.proceed_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webLeaderboard_pnl)).BeginInit();
            this.toolbar_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reciteLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // className_lbl
            // 
            this.className_lbl.AutoSize = true;
            this.className_lbl.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.className_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(88)))), ((int)(((byte)(122)))));
            this.className_lbl.Location = new System.Drawing.Point(425, 60);
            this.className_lbl.Name = "className_lbl";
            this.className_lbl.Size = new System.Drawing.Size(404, 77);
            this.className_lbl.TabIndex = 6;
            this.className_lbl.Text = "Class Name";
            // 
            // leaderboard_lbl
            // 
            this.leaderboard_lbl.AutoSize = true;
            this.leaderboard_lbl.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.leaderboard_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(88)))), ((int)(((byte)(122)))));
            this.leaderboard_lbl.Location = new System.Drawing.Point(524, 137);
            this.leaderboard_lbl.Name = "leaderboard_lbl";
            this.leaderboard_lbl.Size = new System.Drawing.Size(208, 23);
            this.leaderboard_lbl.TabIndex = 7;
            this.leaderboard_lbl.Text = "Today\'s Leaderboard";
            // 
            // proceed_btn
            // 
            this.proceed_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proceed_btn.Image = global::ReCITE.Properties.Resources.proceed_btn;
            this.proceed_btn.Location = new System.Drawing.Point(996, 610);
            this.proceed_btn.Name = "proceed_btn";
            this.proceed_btn.Size = new System.Drawing.Size(192, 78);
            this.proceed_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.proceed_btn.TabIndex = 8;
            this.proceed_btn.TabStop = false;
            this.proceed_btn.Click += new System.EventHandler(this.proceed_btn_Click);
            // 
            // webLeaderboard_pnl
            // 
            this.webLeaderboard_pnl.CreationProperties = null;
            this.webLeaderboard_pnl.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webLeaderboard_pnl.Location = new System.Drawing.Point(176, 178);
            this.webLeaderboard_pnl.Name = "webLeaderboard_pnl";
            this.webLeaderboard_pnl.Size = new System.Drawing.Size(885, 426);
            this.webLeaderboard_pnl.TabIndex = 9;
            this.webLeaderboard_pnl.ZoomFactor = 1D;
            // 
            // toolbar_pnl
            // 
            this.toolbar_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(88)))), ((int)(((byte)(122)))));
            this.toolbar_pnl.Controls.Add(this.minimize_btn);
            this.toolbar_pnl.Controls.Add(this.exit_btn);
            this.toolbar_pnl.Controls.Add(this.reciteLogo);
            this.toolbar_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbar_pnl.Location = new System.Drawing.Point(0, 0);
            this.toolbar_pnl.Name = "toolbar_pnl";
            this.toolbar_pnl.Size = new System.Drawing.Size(1200, 40);
            this.toolbar_pnl.TabIndex = 10;
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
            // Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.toolbar_pnl);
            this.Controls.Add(this.webLeaderboard_pnl);
            this.Controls.Add(this.proceed_btn);
            this.Controls.Add(this.leaderboard_lbl);
            this.Controls.Add(this.className_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Leaderboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leaderboard";
            ((System.ComponentModel.ISupportInitialize)(this.proceed_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webLeaderboard_pnl)).EndInit();
            this.toolbar_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reciteLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label className_lbl;
        private System.Windows.Forms.Label leaderboard_lbl;
        private System.Windows.Forms.PictureBox proceed_btn;
        private Microsoft.Web.WebView2.WinForms.WebView2 webLeaderboard_pnl;
        private System.Windows.Forms.Panel toolbar_pnl;
        private System.Windows.Forms.Button minimize_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.PictureBox reciteLogo;
    }
}