
namespace ReCITE
{
    partial class Student_List
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
            this.back_btn = new System.Windows.Forms.PictureBox();
            this.start_btn = new System.Windows.Forms.PictureBox();
            this.add_btn = new System.Windows.Forms.PictureBox();
            this.webStudentList_pnl = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.toolbar_pnl = new System.Windows.Forms.Panel();
            this.minimize_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.reciteLogo = new System.Windows.Forms.PictureBox();
            this.className_tb = new System.Windows.Forms.TextBox();
            this.edit_btn = new System.Windows.Forms.PictureBox();
            this.check_btn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webStudentList_pnl)).BeginInit();
            this.toolbar_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reciteLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_btn.Image = global::ReCITE.Properties.Resources.back_btn;
            this.back_btn.Location = new System.Drawing.Point(12, 46);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(93, 36);
            this.back_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_btn.TabIndex = 1;
            this.back_btn.TabStop = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // start_btn
            // 
            this.start_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start_btn.Image = global::ReCITE.Properties.Resources.start_btn;
            this.start_btn.Location = new System.Drawing.Point(1011, 612);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(177, 76);
            this.start_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.start_btn.TabIndex = 2;
            this.start_btn.TabStop = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_btn.Image = global::ReCITE.Properties.Resources.add_student;
            this.add_btn.Location = new System.Drawing.Point(839, 102);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(215, 58);
            this.add_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.add_btn.TabIndex = 5;
            this.add_btn.TabStop = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // webStudentList_pnl
            // 
            this.webStudentList_pnl.CreationProperties = null;
            this.webStudentList_pnl.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webStudentList_pnl.Location = new System.Drawing.Point(169, 166);
            this.webStudentList_pnl.Margin = new System.Windows.Forms.Padding(0);
            this.webStudentList_pnl.Name = "webStudentList_pnl";
            this.webStudentList_pnl.Size = new System.Drawing.Size(885, 426);
            this.webStudentList_pnl.TabIndex = 6;
            this.webStudentList_pnl.ZoomFactor = 1D;
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
            this.toolbar_pnl.TabIndex = 7;
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
            // className_tb
            // 
            this.className_tb.BackColor = System.Drawing.SystemColors.Menu;
            this.className_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.className_tb.Enabled = false;
            this.className_tb.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.className_tb.Location = new System.Drawing.Point(169, 82);
            this.className_tb.Name = "className_tb";
            this.className_tb.Size = new System.Drawing.Size(526, 78);
            this.className_tb.TabIndex = 8;
            // 
            // edit_btn
            // 
            this.edit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_btn.Image = global::ReCITE.Properties.Resources.edit;
            this.edit_btn.Location = new System.Drawing.Point(701, 82);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(40, 40);
            this.edit_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.edit_btn.TabIndex = 9;
            this.edit_btn.TabStop = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // check_btn
            // 
            this.check_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check_btn.Image = global::ReCITE.Properties.Resources.check;
            this.check_btn.Location = new System.Drawing.Point(701, 82);
            this.check_btn.Name = "check_btn";
            this.check_btn.Size = new System.Drawing.Size(40, 40);
            this.check_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.check_btn.TabIndex = 10;
            this.check_btn.TabStop = false;
            this.check_btn.Click += new System.EventHandler(this.check_btn_Click);
            // 
            // Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.className_tb);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.toolbar_pnl);
            this.Controls.Add(this.webStudentList_pnl);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.check_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webStudentList_pnl)).EndInit();
            this.toolbar_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reciteLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.check_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox back_btn;
        private System.Windows.Forms.PictureBox start_btn;
        private System.Windows.Forms.PictureBox add_btn;
        private Microsoft.Web.WebView2.WinForms.WebView2 webStudentList_pnl;
        private System.Windows.Forms.Panel toolbar_pnl;
        private System.Windows.Forms.Button minimize_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.PictureBox reciteLogo;
        private System.Windows.Forms.TextBox className_tb;
        private System.Windows.Forms.PictureBox edit_btn;
        private System.Windows.Forms.PictureBox check_btn;
    }
}