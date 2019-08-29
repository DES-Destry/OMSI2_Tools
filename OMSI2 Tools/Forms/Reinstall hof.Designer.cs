namespace OMSI2_Tools.Forms
{
    partial class Reinstall_hof
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
            this.InstallingPn = new System.Windows.Forms.Panel();
            this.InstallingPctr = new System.Windows.Forms.PictureBox();
            this.ExitButt = new System.Windows.Forms.Button();
            this.InstallingLbl = new System.Windows.Forms.Label();
            this.DeleteAllButt = new System.Windows.Forms.Button();
            this.DragAndDropLbl = new System.Windows.Forms.Label();
            this.SelectAllButt = new System.Windows.Forms.Button();
            this.UpdateButt = new System.Windows.Forms.Button();
            this.DeleteButt = new System.Windows.Forms.Button();
            this.AddButt = new System.Windows.Forms.Button();
            this.InstallButt = new System.Windows.Forms.Button();
            this.HofInstallList = new System.Windows.Forms.CheckedListBox();
            this.InstallingProgress = new OMSI2_Tools.Forms.NewProgressBar();
            this.InstallingPn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InstallingPctr)).BeginInit();
            this.SuspendLayout();
            // 
            // InstallingPn
            // 
            this.InstallingPn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.InstallingPn.Controls.Add(this.InstallingPctr);
            this.InstallingPn.Controls.Add(this.ExitButt);
            this.InstallingPn.Controls.Add(this.InstallingLbl);
            this.InstallingPn.Dock = System.Windows.Forms.DockStyle.Top;
            this.InstallingPn.Location = new System.Drawing.Point(0, 0);
            this.InstallingPn.Name = "InstallingPn";
            this.InstallingPn.Size = new System.Drawing.Size(638, 63);
            this.InstallingPn.TabIndex = 2;
            // 
            // InstallingPctr
            // 
            this.InstallingPctr.Image = global::OMSI2_Tools.Properties.Resources.Reinstall;
            this.InstallingPctr.Location = new System.Drawing.Point(275, 0);
            this.InstallingPctr.Name = "InstallingPctr";
            this.InstallingPctr.Size = new System.Drawing.Size(63, 63);
            this.InstallingPctr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.InstallingPctr.TabIndex = 4;
            this.InstallingPctr.TabStop = false;
            // 
            // ExitButt
            // 
            this.ExitButt.BackgroundImage = global::OMSI2_Tools.Properties.Resources.Exit;
            this.ExitButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButt.FlatAppearance.BorderSize = 0;
            this.ExitButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.ExitButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.ExitButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButt.Location = new System.Drawing.Point(575, 0);
            this.ExitButt.Name = "ExitButt";
            this.ExitButt.Size = new System.Drawing.Size(63, 63);
            this.ExitButt.TabIndex = 3;
            this.ExitButt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ExitButt.UseVisualStyleBackColor = true;
            this.ExitButt.Click += new System.EventHandler(this.Exit_butt);
            // 
            // InstallingLbl
            // 
            this.InstallingLbl.AutoSize = true;
            this.InstallingLbl.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InstallingLbl.ForeColor = System.Drawing.Color.Maroon;
            this.InstallingLbl.Location = new System.Drawing.Point(3, 5);
            this.InstallingLbl.Name = "InstallingLbl";
            this.InstallingLbl.Size = new System.Drawing.Size(282, 58);
            this.InstallingLbl.TabIndex = 0;
            this.InstallingLbl.Text = "Reinstalling";
            // 
            // DeleteAllButt
            // 
            this.DeleteAllButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeleteAllButt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(0)))));
            this.DeleteAllButt.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.DeleteAllButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(0)))));
            this.DeleteAllButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteAllButt.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteAllButt.Image = global::OMSI2_Tools.Properties.Resources.Delete_Hof;
            this.DeleteAllButt.Location = new System.Drawing.Point(326, 439);
            this.DeleteAllButt.Name = "DeleteAllButt";
            this.DeleteAllButt.Size = new System.Drawing.Size(300, 54);
            this.DeleteAllButt.TabIndex = 7;
            this.DeleteAllButt.Text = "Delete all";
            this.DeleteAllButt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteAllButt.UseVisualStyleBackColor = true;
            this.DeleteAllButt.Click += new System.EventHandler(this.Delete_all);
            // 
            // DragAndDropLbl
            // 
            this.DragAndDropLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DragAndDropLbl.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.DragAndDropLbl.Location = new System.Drawing.Point(0, 404);
            this.DragAndDropLbl.Name = "DragAndDropLbl";
            this.DragAndDropLbl.Size = new System.Drawing.Size(638, 25);
            this.DragAndDropLbl.TabIndex = 13;
            this.DragAndDropLbl.Text = "Drag and drop *.hof files at list to add";
            this.DragAndDropLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectAllButt
            // 
            this.SelectAllButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SelectAllButt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.SelectAllButt.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.SelectAllButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.SelectAllButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectAllButt.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectAllButt.Image = global::OMSI2_Tools.Properties.Resources.Uncheck_All;
            this.SelectAllButt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SelectAllButt.Location = new System.Drawing.Point(13, 499);
            this.SelectAllButt.Name = "SelectAllButt";
            this.SelectAllButt.Size = new System.Drawing.Size(613, 54);
            this.SelectAllButt.TabIndex = 8;
            this.SelectAllButt.Text = "Uncheck all";
            this.SelectAllButt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SelectAllButt.UseVisualStyleBackColor = true;
            this.SelectAllButt.Click += new System.EventHandler(this.Select_all);
            this.SelectAllButt.MouseEnter += new System.EventHandler(this.WhiteImage);
            this.SelectAllButt.MouseLeave += new System.EventHandler(this.StockImage);
            // 
            // UpdateButt
            // 
            this.UpdateButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UpdateButt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.UpdateButt.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.UpdateButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.UpdateButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButt.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateButt.Image = global::OMSI2_Tools.Properties.Resources.Update;
            this.UpdateButt.Location = new System.Drawing.Point(12, 137);
            this.UpdateButt.Name = "UpdateButt";
            this.UpdateButt.Size = new System.Drawing.Size(54, 54);
            this.UpdateButt.TabIndex = 9;
            this.UpdateButt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UpdateButt.UseVisualStyleBackColor = true;
            this.UpdateButt.Click += new System.EventHandler(this.Update);
            // 
            // DeleteButt
            // 
            this.DeleteButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeleteButt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(0)))));
            this.DeleteButt.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.DeleteButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(61)))), ((int)(((byte)(0)))));
            this.DeleteButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButt.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButt.Image = global::OMSI2_Tools.Properties.Resources.Delete_Hof;
            this.DeleteButt.Location = new System.Drawing.Point(12, 197);
            this.DeleteButt.Name = "DeleteButt";
            this.DeleteButt.Size = new System.Drawing.Size(54, 54);
            this.DeleteButt.TabIndex = 10;
            this.DeleteButt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteButt.UseVisualStyleBackColor = true;
            this.DeleteButt.Click += new System.EventHandler(this.Delete);
            // 
            // AddButt
            // 
            this.AddButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddButt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.AddButt.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.AddButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.AddButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButt.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButt.Image = global::OMSI2_Tools.Properties.Resources.Add_Hof;
            this.AddButt.Location = new System.Drawing.Point(12, 77);
            this.AddButt.Name = "AddButt";
            this.AddButt.Size = new System.Drawing.Size(54, 54);
            this.AddButt.TabIndex = 11;
            this.AddButt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddButt.UseVisualStyleBackColor = true;
            this.AddButt.Click += new System.EventHandler(this.Add_hof);
            // 
            // InstallButt
            // 
            this.InstallButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.InstallButt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.InstallButt.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.InstallButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.InstallButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InstallButt.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InstallButt.Image = global::OMSI2_Tools.Properties.Resources.Reinstall;
            this.InstallButt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InstallButt.Location = new System.Drawing.Point(13, 439);
            this.InstallButt.Name = "InstallButt";
            this.InstallButt.Size = new System.Drawing.Size(298, 54);
            this.InstallButt.TabIndex = 12;
            this.InstallButt.Text = "Reinstall";
            this.InstallButt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.InstallButt.UseVisualStyleBackColor = true;
            this.InstallButt.Click += new System.EventHandler(this.Reinstall);
            // 
            // HofInstallList
            // 
            this.HofInstallList.AllowDrop = true;
            this.HofInstallList.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HofInstallList.FormattingEnabled = true;
            this.HofInstallList.Location = new System.Drawing.Point(72, 77);
            this.HofInstallList.Name = "HofInstallList";
            this.HofInstallList.Size = new System.Drawing.Size(497, 324);
            this.HofInstallList.TabIndex = 6;
            this.HofInstallList.Click += new System.EventHandler(this.Changed);
            this.HofInstallList.DragDrop += new System.Windows.Forms.DragEventHandler(this.DropFiles);
            this.HofInstallList.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterList);
            this.HofInstallList.DragOver += new System.Windows.Forms.DragEventHandler(this.Pulse);
            this.HofInstallList.DragLeave += new System.EventHandler(this.DragLeaveList);
            // 
            // InstallingProgress
            // 
            this.InstallingProgress.ForeColor = System.Drawing.Color.Orange;
            this.InstallingProgress.Location = new System.Drawing.Point(12, 559);
            this.InstallingProgress.Name = "InstallingProgress";
            this.InstallingProgress.Size = new System.Drawing.Size(614, 29);
            this.InstallingProgress.TabIndex = 14;
            this.InstallingProgress.Visible = false;
            // 
            // Reinstall_hof
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 560);
            this.Controls.Add(this.InstallingProgress);
            this.Controls.Add(this.DeleteAllButt);
            this.Controls.Add(this.DragAndDropLbl);
            this.Controls.Add(this.SelectAllButt);
            this.Controls.Add(this.UpdateButt);
            this.Controls.Add(this.DeleteButt);
            this.Controls.Add(this.AddButt);
            this.Controls.Add(this.InstallButt);
            this.Controls.Add(this.HofInstallList);
            this.Controls.Add(this.InstallingPn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reinstall_hof";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reinstall_hof";
            this.Load += new System.EventHandler(this.LoadHofs);
            this.InstallingPn.ResumeLayout(false);
            this.InstallingPn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InstallingPctr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InstallingPn;
        private System.Windows.Forms.PictureBox InstallingPctr;
        private System.Windows.Forms.Button ExitButt;
        private System.Windows.Forms.Label InstallingLbl;
        private System.Windows.Forms.Button DeleteAllButt;
        private System.Windows.Forms.Label DragAndDropLbl;
        private System.Windows.Forms.Button SelectAllButt;
        private System.Windows.Forms.Button UpdateButt;
        private System.Windows.Forms.Button DeleteButt;
        private System.Windows.Forms.Button AddButt;
        private System.Windows.Forms.Button InstallButt;
        private System.Windows.Forms.CheckedListBox HofInstallList;
        private NewProgressBar InstallingProgress;
    }
}