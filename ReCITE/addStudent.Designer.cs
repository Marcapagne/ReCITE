
namespace ReCITE
{
    partial class addStudent
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
            this.studentName_tb = new System.Windows.Forms.TextBox();
            this.studentName_lbl = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentName_tb
            // 
            this.studentName_tb.Location = new System.Drawing.Point(104, 20);
            this.studentName_tb.Name = "studentName_tb";
            this.studentName_tb.Size = new System.Drawing.Size(283, 23);
            this.studentName_tb.TabIndex = 0;
            // 
            // studentName_lbl
            // 
            this.studentName_lbl.AutoSize = true;
            this.studentName_lbl.Location = new System.Drawing.Point(12, 23);
            this.studentName_lbl.Name = "studentName_lbl";
            this.studentName_lbl.Size = new System.Drawing.Size(86, 15);
            this.studentName_lbl.TabIndex = 1;
            this.studentName_lbl.Text = "Student Name:";
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.LimeGreen;
            this.add_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.add_btn.Location = new System.Drawing.Point(0, 61);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(399, 31);
            this.add_btn.TabIndex = 2;
            this.add_btn.Text = "Add Student";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // addStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 92);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.studentName_lbl);
            this.Controls.Add(this.studentName_tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "addStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox studentName_tb;
        private System.Windows.Forms.Label studentName_lbl;
        private System.Windows.Forms.Button add_btn;
    }
}