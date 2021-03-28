namespace CISDocumentProcessing
{
    partial class EmployeeListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLbl = new System.Windows.Forms.Label();
            this.IdLbl = new System.Windows.Forms.Label();
            this.birthdateLbl = new System.Windows.Forms.Label();
            this.mainLanguageLbl = new System.Windows.Forms.Label();
            this.salaryLbl = new System.Windows.Forms.Label();
            this.photoBox = new System.Windows.Forms.PictureBox();
            this.editLbl = new System.Windows.Forms.Label();
            this.analysisLbl = new System.Windows.Forms.Label();
            this.expLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLbl.Location = new System.Drawing.Point(141, 15);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(136, 17);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "Ф.И.О. Сотрудника";
            // 
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdLbl.Location = new System.Drawing.Point(466, 15);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(21, 17);
            this.IdLbl.TabIndex = 2;
            this.IdLbl.Text = "ID";
            // 
            // birthdateLbl
            // 
            this.birthdateLbl.AutoSize = true;
            this.birthdateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthdateLbl.Location = new System.Drawing.Point(141, 35);
            this.birthdateLbl.Name = "birthdateLbl";
            this.birthdateLbl.Size = new System.Drawing.Size(111, 17);
            this.birthdateLbl.TabIndex = 3;
            this.birthdateLbl.Text = "Дата рождения";
            // 
            // mainLanguageLbl
            // 
            this.mainLanguageLbl.AutoSize = true;
            this.mainLanguageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainLanguageLbl.Location = new System.Drawing.Point(141, 75);
            this.mainLanguageLbl.Name = "mainLanguageLbl";
            this.mainLanguageLbl.Size = new System.Drawing.Size(109, 17);
            this.mainLanguageLbl.TabIndex = 4;
            this.mainLanguageLbl.Text = "Основной язык";
            // 
            // salaryLbl
            // 
            this.salaryLbl.AutoSize = true;
            this.salaryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salaryLbl.Location = new System.Drawing.Point(141, 95);
            this.salaryLbl.Name = "salaryLbl";
            this.salaryLbl.Size = new System.Drawing.Size(72, 17);
            this.salaryLbl.TabIndex = 5;
            this.salaryLbl.Text = "Зарплата";
            // 
            // photoBox
            // 
            this.photoBox.BackgroundImage = global::CISDocumentProcessing.Properties.Resources.no_photo;
            this.photoBox.InitialImage = null;
            this.photoBox.Location = new System.Drawing.Point(15, 15);
            this.photoBox.Name = "photoBox";
            this.photoBox.Size = new System.Drawing.Size(120, 120);
            this.photoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photoBox.TabIndex = 0;
            this.photoBox.TabStop = false;
            // 
            // editLbl
            // 
            this.editLbl.AutoSize = true;
            this.editLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.editLbl.Location = new System.Drawing.Point(144, 115);
            this.editLbl.Name = "editLbl";
            this.editLbl.Size = new System.Drawing.Size(108, 17);
            this.editLbl.TabIndex = 6;
            this.editLbl.Text = "Редактировать";
            this.editLbl.Click += new System.EventHandler(this.editLbl_Click);
            this.editLbl.MouseEnter += new System.EventHandler(this.editLbl_MouseEnter);
            this.editLbl.MouseLeave += new System.EventHandler(this.editLbl_MouseLeave);
            // 
            // analysisLbl
            // 
            this.analysisLbl.AutoSize = true;
            this.analysisLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.analysisLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.analysisLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.analysisLbl.Location = new System.Drawing.Point(366, 115);
            this.analysisLbl.Name = "analysisLbl";
            this.analysisLbl.Size = new System.Drawing.Size(170, 17);
            this.analysisLbl.TabIndex = 7;
            this.analysisLbl.Text = "Подробная информация";
            this.analysisLbl.Click += new System.EventHandler(this.analysisLbl_Click);
            this.analysisLbl.MouseEnter += new System.EventHandler(this.analysisLbl_MouseEnter);
            this.analysisLbl.MouseLeave += new System.EventHandler(this.analysisLbl_MouseLeave);
            // 
            // expLbl
            // 
            this.expLbl.AutoSize = true;
            this.expLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expLbl.Location = new System.Drawing.Point(141, 55);
            this.expLbl.Name = "expLbl";
            this.expLbl.Size = new System.Drawing.Size(44, 17);
            this.expLbl.TabIndex = 8;
            this.expLbl.Text = "Опыт";
            // 
            // EmployeeListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.expLbl);
            this.Controls.Add(this.analysisLbl);
            this.Controls.Add(this.editLbl);
            this.Controls.Add(this.salaryLbl);
            this.Controls.Add(this.mainLanguageLbl);
            this.Controls.Add(this.birthdateLbl);
            this.Controls.Add(this.IdLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.photoBox);
            this.Name = "EmployeeListItem";
            this.Size = new System.Drawing.Size(550, 150);
            this.MouseEnter += new System.EventHandler(this.EmployeeListItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.EmployeeListItem_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.photoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox photoBox;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label IdLbl;
        private System.Windows.Forms.Label birthdateLbl;
        private System.Windows.Forms.Label mainLanguageLbl;
        private System.Windows.Forms.Label salaryLbl;
        private System.Windows.Forms.Label editLbl;
        private System.Windows.Forms.Label analysisLbl;
        private System.Windows.Forms.Label expLbl;
    }
}
