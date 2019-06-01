namespace OMSI2_Tools
{
    partial class OMSI
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopPn = new System.Windows.Forms.Panel();
            this.ToolsLbl = new System.Windows.Forms.Label();
            this.ExitButt = new System.Windows.Forms.Button();
            this.OMSI2Pctr = new System.Windows.Forms.PictureBox();
            this.HofToolsButt = new System.Windows.Forms.Button();
            this.TopPn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OMSI2Pctr)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPn
            // 
            this.TopPn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.TopPn.Controls.Add(this.ToolsLbl);
            this.TopPn.Controls.Add(this.ExitButt);
            this.TopPn.Controls.Add(this.OMSI2Pctr);
            this.TopPn.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPn.Location = new System.Drawing.Point(0, 0);
            this.TopPn.Name = "TopPn";
            this.TopPn.Size = new System.Drawing.Size(850, 54);
            this.TopPn.TabIndex = 0;
            // 
            // ToolsLbl
            // 
            this.ToolsLbl.AutoSize = true;
            this.ToolsLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToolsLbl.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolsLbl.ForeColor = System.Drawing.Color.Maroon;
            this.ToolsLbl.Location = new System.Drawing.Point(229, 0);
            this.ToolsLbl.Name = "ToolsLbl";
            this.ToolsLbl.Size = new System.Drawing.Size(138, 58);
            this.ToolsLbl.TabIndex = 3;
            this.ToolsLbl.Text = "Tools";
            // 
            // ExitButt
            // 
            this.ExitButt.BackgroundImage = global::OMSI2_Tools.Properties.Resources.Exit;
            this.ExitButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButt.FlatAppearance.BorderSize = 0;
            this.ExitButt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.ExitButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.ExitButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButt.Location = new System.Drawing.Point(796, 0);
            this.ExitButt.Name = "ExitButt";
            this.ExitButt.Size = new System.Drawing.Size(54, 54);
            this.ExitButt.TabIndex = 2;
            this.ExitButt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ExitButt.UseVisualStyleBackColor = true;
            this.ExitButt.Click += new System.EventHandler(this.ExitButt_Click);
            // 
            // OMSI2Pctr
            // 
            this.OMSI2Pctr.Image = global::OMSI2_Tools.Properties.Resources.Start_BG;
            this.OMSI2Pctr.Location = new System.Drawing.Point(0, 0);
            this.OMSI2Pctr.Name = "OMSI2Pctr";
            this.OMSI2Pctr.Size = new System.Drawing.Size(273, 54);
            this.OMSI2Pctr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OMSI2Pctr.TabIndex = 1;
            this.OMSI2Pctr.TabStop = false;
            // 
            // HofToolsButt
            // 
            this.HofToolsButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HofToolsButt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.HofToolsButt.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.HofToolsButt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.HofToolsButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HofToolsButt.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HofToolsButt.Location = new System.Drawing.Point(603, 484);
            this.HofToolsButt.Name = "HofToolsButt";
            this.HofToolsButt.Size = new System.Drawing.Size(235, 54);
            this.HofToolsButt.TabIndex = 2;
            this.HofToolsButt.Text = "Hof tools";
            this.HofToolsButt.UseVisualStyleBackColor = true;
            this.HofToolsButt.Click += new System.EventHandler(this.HofChoose);
            // 
            // OMSI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.TopPn);
            this.Controls.Add(this.HofToolsButt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OMSI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OMSI2 Tools";
            this.TopPn.ResumeLayout(false);
            this.TopPn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OMSI2Pctr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPn;
        private System.Windows.Forms.PictureBox OMSI2Pctr;
        private System.Windows.Forms.Button ExitButt;
        private System.Windows.Forms.Label ToolsLbl;
        private System.Windows.Forms.Button HofToolsButt;
    }
}

