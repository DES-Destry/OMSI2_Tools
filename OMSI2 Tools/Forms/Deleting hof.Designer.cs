namespace OMSI2_Tools.Forms
{
    partial class Deleting_hof
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
            this.DeletingPn = new System.Windows.Forms.Panel();
            this.UninstalPctr = new System.Windows.Forms.PictureBox();
            this.DeletingLbl = new System.Windows.Forms.Label();
            this.NoButt = new System.Windows.Forms.Button();
            this.YesButt = new System.Windows.Forms.Button();
            this.DeleteLbl = new System.Windows.Forms.Label();
            this.DeletingProgress = new OMSI2_Tools.Forms.NewProgressBar();
            this.DeletingPn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UninstalPctr)).BeginInit();
            this.SuspendLayout();
            // 
            // DeletingPn
            // 
            this.DeletingPn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(1)))));
            this.DeletingPn.Controls.Add(this.UninstalPctr);
            this.DeletingPn.Controls.Add(this.DeletingLbl);
            this.DeletingPn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeletingPn.Location = new System.Drawing.Point(0, 0);
            this.DeletingPn.Name = "DeletingPn";
            this.DeletingPn.Size = new System.Drawing.Size(585, 54);
            this.DeletingPn.TabIndex = 0;
            // 
            // UninstalPctr
            // 
            this.UninstalPctr.Image = global::OMSI2_Tools.Properties.Resources.Uninstall;
            this.UninstalPctr.Location = new System.Drawing.Point(211, -1);
            this.UninstalPctr.Name = "UninstalPctr";
            this.UninstalPctr.Size = new System.Drawing.Size(54, 54);
            this.UninstalPctr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UninstalPctr.TabIndex = 1;
            this.UninstalPctr.TabStop = false;
            // 
            // DeletingLbl
            // 
            this.DeletingLbl.AutoSize = true;
            this.DeletingLbl.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeletingLbl.ForeColor = System.Drawing.Color.Maroon;
            this.DeletingLbl.Location = new System.Drawing.Point(-4, -5);
            this.DeletingLbl.Name = "DeletingLbl";
            this.DeletingLbl.Size = new System.Drawing.Size(219, 58);
            this.DeletingLbl.TabIndex = 0;
            this.DeletingLbl.Text = "Deleting";
            // 
            // NoButt
            // 
            this.NoButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(1)))));
            this.NoButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NoButt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.NoButt.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.NoButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.NoButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoButt.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoButt.Location = new System.Drawing.Point(348, 173);
            this.NoButt.Name = "NoButt";
            this.NoButt.Size = new System.Drawing.Size(195, 70);
            this.NoButt.TabIndex = 3;
            this.NoButt.Text = "NO";
            this.NoButt.UseVisualStyleBackColor = false;
            this.NoButt.Click += new System.EventHandler(this.Exit);
            // 
            // YesButt
            // 
            this.YesButt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(1)))));
            this.YesButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.YesButt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.YesButt.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.YesButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.YesButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YesButt.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YesButt.Location = new System.Drawing.Point(35, 173);
            this.YesButt.Name = "YesButt";
            this.YesButt.Size = new System.Drawing.Size(195, 70);
            this.YesButt.TabIndex = 3;
            this.YesButt.Text = "YES";
            this.YesButt.UseVisualStyleBackColor = false;
            this.YesButt.Click += new System.EventHandler(this.Delete);
            // 
            // DeleteLbl
            // 
            this.DeleteLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteLbl.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.DeleteLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteLbl.Location = new System.Drawing.Point(-1, 53);
            this.DeleteLbl.Name = "DeleteLbl";
            this.DeleteLbl.Size = new System.Drawing.Size(586, 56);
            this.DeleteLbl.TabIndex = 4;
            this.DeleteLbl.Text = "Are you sure?";
            this.DeleteLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeletingProgress
            // 
            this.DeletingProgress.Location = new System.Drawing.Point(6, 113);
            this.DeletingProgress.Name = "DeletingProgress";
            this.DeletingProgress.Size = new System.Drawing.Size(567, 33);
            this.DeletingProgress.TabIndex = 5;
            this.DeletingProgress.Visible = false;
            // 
            // Deleting_hof
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(585, 261);
            this.Controls.Add(this.DeletingProgress);
            this.Controls.Add(this.DeleteLbl);
            this.Controls.Add(this.YesButt);
            this.Controls.Add(this.NoButt);
            this.Controls.Add(this.DeletingPn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Deleting_hof";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deleting_hof";
            this.DeletingPn.ResumeLayout(false);
            this.DeletingPn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UninstalPctr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DeletingPn;
        private System.Windows.Forms.Button NoButt;
        private System.Windows.Forms.Button YesButt;
        private System.Windows.Forms.Label DeleteLbl;
        private System.Windows.Forms.Label DeletingLbl;
        private System.Windows.Forms.PictureBox UninstalPctr;
        private NewProgressBar DeletingProgress;
    }
}