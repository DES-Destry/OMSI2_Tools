namespace OMSI2_Tools.Forms
{
    partial class HofActionChoose
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
            this.InfoLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitButt = new System.Windows.Forms.Button();
            this.InstallButt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.HofToolsButt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfoLbl
            // 
            this.InfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLbl.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.InfoLbl.Location = new System.Drawing.Point(13, 46);
            this.InfoLbl.Name = "InfoLbl";
            this.InfoLbl.Size = new System.Drawing.Size(813, 98);
            this.InfoLbl.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.ExitButt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 43);
            this.panel1.TabIndex = 5;
            // 
            // ExitButt
            // 
            this.ExitButt.BackgroundImage = global::OMSI2_Tools.Properties.Resources.Exit;
            this.ExitButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButt.FlatAppearance.BorderSize = 0;
            this.ExitButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.ExitButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.ExitButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButt.Location = new System.Drawing.Point(795, 0);
            this.ExitButt.Name = "ExitButt";
            this.ExitButt.Size = new System.Drawing.Size(43, 43);
            this.ExitButt.TabIndex = 3;
            this.ExitButt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ExitButt.UseVisualStyleBackColor = true;
            this.ExitButt.Click += new System.EventHandler(this.CloseWindow);
            // 
            // InstallButt
            // 
            this.InstallButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.InstallButt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.InstallButt.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.InstallButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.InstallButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InstallButt.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InstallButt.Image = global::OMSI2_Tools.Properties.Resources.Install;
            this.InstallButt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InstallButt.Location = new System.Drawing.Point(13, 147);
            this.InstallButt.Name = "InstallButt";
            this.InstallButt.Size = new System.Drawing.Size(235, 54);
            this.InstallButt.TabIndex = 3;
            this.InstallButt.Text = "Install";
            this.InstallButt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.InstallButt.UseVisualStyleBackColor = true;
            this.InstallButt.Click += new System.EventHandler(this.Install);
            this.InstallButt.MouseEnter += new System.EventHandler(this.InstallInfo);
            this.InstallButt.MouseLeave += new System.EventHandler(this.InstallInfoClear);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Image = global::OMSI2_Tools.Properties.Resources.Reinstall;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(302, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "Reinstall";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Reinstall);
            this.button1.MouseEnter += new System.EventHandler(this.ReinstallInfo);
            this.button1.MouseLeave += new System.EventHandler(this.ReinstallInfoClear);
            // 
            // HofToolsButt
            // 
            this.HofToolsButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HofToolsButt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.HofToolsButt.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.HofToolsButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.HofToolsButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HofToolsButt.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HofToolsButt.Image = global::OMSI2_Tools.Properties.Resources.Uninstall;
            this.HofToolsButt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HofToolsButt.Location = new System.Drawing.Point(591, 147);
            this.HofToolsButt.Name = "HofToolsButt";
            this.HofToolsButt.Size = new System.Drawing.Size(235, 54);
            this.HofToolsButt.TabIndex = 3;
            this.HofToolsButt.Text = "Uninstall";
            this.HofToolsButt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HofToolsButt.UseVisualStyleBackColor = true;
            this.HofToolsButt.Click += new System.EventHandler(this.Unistall);
            this.HofToolsButt.MouseEnter += new System.EventHandler(this.UninstallInfo);
            this.HofToolsButt.MouseLeave += new System.EventHandler(this.UninstallInfoClear);
            // 
            // HofActionChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(838, 211);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InfoLbl);
            this.Controls.Add(this.InstallButt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HofToolsButt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HofActionChoose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HofActionChoose";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HofToolsButt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button InstallButt;
        private System.Windows.Forms.Label InfoLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ExitButt;
    }
}