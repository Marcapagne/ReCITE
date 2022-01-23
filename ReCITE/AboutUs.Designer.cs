
namespace ReCITE
{
    partial class AboutUs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutUs));
            this.toolbar_pnl = new System.Windows.Forms.Panel();
            this.minimize_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.reciteLogo = new System.Windows.Forms.PictureBox();
            this.back_btn = new System.Windows.Forms.PictureBox();
            this.webView_AboutUs = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.toolbar_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reciteLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView_AboutUs)).BeginInit();
            this.SuspendLayout();
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
            this.toolbar_pnl.TabIndex = 12;
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
            // back_btn
            // 
            this.back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_btn.Image = global::ReCITE.Properties.Resources.back_btn;
            this.back_btn.Location = new System.Drawing.Point(12, 658);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(93, 36);
            this.back_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_btn.TabIndex = 13;
            this.back_btn.TabStop = false;
            this.back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // webView_AboutUs
            // 
            this.webView_AboutUs.CreationProperties = null;
            this.webView_AboutUs.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView_AboutUs.Location = new System.Drawing.Point(12, 52);
            this.webView_AboutUs.Name = "webView_AboutUs";
            this.webView_AboutUs.Size = new System.Drawing.Size(1176, 642);
            this.webView_AboutUs.TabIndex = 14;
            this.webView_AboutUs.ZoomFactor = 1D;
            // 
            // AboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.toolbar_pnl);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.webView_AboutUs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutUs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AboutUs";
            this.toolbar_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reciteLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webView_AboutUs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel toolbar_pnl;
        private System.Windows.Forms.Button minimize_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.PictureBox reciteLogo;
        private System.Windows.Forms.PictureBox back_btn;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView_AboutUs;
    }
}