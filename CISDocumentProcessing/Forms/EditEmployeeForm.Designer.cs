namespace CISDocumentProcessing.Forms
{
    partial class EditEmployeeForm
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
            this.photoFileNameLbl = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.photoBtn = new System.Windows.Forms.Button();
            this.birthDateDate = new System.Windows.Forms.DateTimePicker();
            this.salaryNum = new System.Windows.Forms.NumericUpDown();
            this.expNum = new System.Windows.Forms.NumericUpDown();
            this.notexTxt = new System.Windows.Forms.TextBox();
            this.perksTxt = new System.Windows.Forms.TextBox();
            this.educationTxt = new System.Windows.Forms.TextBox();
            this.mainLanguageTxt = new System.Windows.Forms.TextBox();
            this.districtTxt = new System.Windows.Forms.TextBox();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.notesLbl = new System.Windows.Forms.Label();
            this.photoLbl = new System.Windows.Forms.Label();
            this.perksLbl = new System.Windows.Forms.Label();
            this.educationLbl = new System.Windows.Forms.Label();
            this.currentSalaryLbl = new System.Windows.Forms.Label();
            this.mainLanguageLbl = new System.Windows.Forms.Label();
            this.birthDateLbl = new System.Windows.Forms.Label();
            this.districtLbl = new System.Windows.Forms.Label();
            this.expLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.editEmployeeLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salaryNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expNum)).BeginInit();
            this.SuspendLayout();
            // 
            // photoFileNameLbl
            // 
            this.photoFileNameLbl.AutoSize = true;
            this.photoFileNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.photoFileNameLbl.Location = new System.Drawing.Point(180, 424);
            this.photoFileNameLbl.Name = "photoFileNameLbl";
            this.photoFileNameLbl.Size = new System.Drawing.Size(99, 20);
            this.photoFileNameLbl.TabIndex = 51;
            this.photoFileNameLbl.Text = "Не выбрано";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBtn.Location = new System.Drawing.Point(43, 498);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(123, 43);
            this.cancelBtn.TabIndex = 50;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submitBtn.Location = new System.Drawing.Point(263, 498);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(123, 43);
            this.submitBtn.TabIndex = 49;
            this.submitBtn.Text = "Подтвердить";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // photoBtn
            // 
            this.photoBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.photoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.photoBtn.Location = new System.Drawing.Point(182, 389);
            this.photoBtn.Name = "photoBtn";
            this.photoBtn.Size = new System.Drawing.Size(83, 32);
            this.photoBtn.TabIndex = 47;
            this.photoBtn.Text = "Обзор";
            this.photoBtn.UseVisualStyleBackColor = false;
            this.photoBtn.Click += new System.EventHandler(this.photoBtn_Click);
            // 
            // birthDateDate
            // 
            this.birthDateDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthDateDate.Location = new System.Drawing.Point(182, 214);
            this.birthDateDate.Name = "birthDateDate";
            this.birthDateDate.Size = new System.Drawing.Size(200, 26);
            this.birthDateDate.TabIndex = 42;
            // 
            // salaryNum
            // 
            this.salaryNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salaryNum.Location = new System.Drawing.Point(182, 285);
            this.salaryNum.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.salaryNum.Name = "salaryNum";
            this.salaryNum.Size = new System.Drawing.Size(204, 26);
            this.salaryNum.TabIndex = 44;
            // 
            // expNum
            // 
            this.expNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expNum.Location = new System.Drawing.Point(182, 179);
            this.expNum.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.expNum.Name = "expNum";
            this.expNum.Size = new System.Drawing.Size(202, 26);
            this.expNum.TabIndex = 41;
            // 
            // notexTxt
            // 
            this.notexTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notexTxt.Location = new System.Drawing.Point(184, 453);
            this.notexTxt.Name = "notexTxt";
            this.notexTxt.Size = new System.Drawing.Size(202, 26);
            this.notexTxt.TabIndex = 48;
            // 
            // perksTxt
            // 
            this.perksTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perksTxt.Location = new System.Drawing.Point(182, 354);
            this.perksTxt.Name = "perksTxt";
            this.perksTxt.Size = new System.Drawing.Size(202, 26);
            this.perksTxt.TabIndex = 46;
            // 
            // educationTxt
            // 
            this.educationTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.educationTxt.Location = new System.Drawing.Point(182, 319);
            this.educationTxt.Name = "educationTxt";
            this.educationTxt.Size = new System.Drawing.Size(202, 26);
            this.educationTxt.TabIndex = 45;
            // 
            // mainLanguageTxt
            // 
            this.mainLanguageTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainLanguageTxt.Location = new System.Drawing.Point(182, 249);
            this.mainLanguageTxt.Name = "mainLanguageTxt";
            this.mainLanguageTxt.Size = new System.Drawing.Size(202, 26);
            this.mainLanguageTxt.TabIndex = 43;
            // 
            // districtTxt
            // 
            this.districtTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.districtTxt.Location = new System.Drawing.Point(182, 144);
            this.districtTxt.Name = "districtTxt";
            this.districtTxt.Size = new System.Drawing.Size(202, 26);
            this.districtTxt.TabIndex = 40;
            // 
            // addressTxt
            // 
            this.addressTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressTxt.Location = new System.Drawing.Point(182, 109);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(202, 26);
            this.addressTxt.TabIndex = 39;
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTxt.Location = new System.Drawing.Point(182, 74);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(202, 26);
            this.nameTxt.TabIndex = 38;
            // 
            // notesLbl
            // 
            this.notesLbl.AutoSize = true;
            this.notesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notesLbl.Location = new System.Drawing.Point(68, 456);
            this.notesLbl.Name = "notesLbl";
            this.notesLbl.Size = new System.Drawing.Size(98, 20);
            this.notesLbl.TabIndex = 37;
            this.notesLbl.Text = "Замечания:";
            // 
            // photoLbl
            // 
            this.photoLbl.AutoSize = true;
            this.photoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.photoLbl.Location = new System.Drawing.Point(111, 392);
            this.photoLbl.Name = "photoLbl";
            this.photoLbl.Size = new System.Drawing.Size(55, 20);
            this.photoLbl.TabIndex = 36;
            this.photoLbl.Text = "Фото:";
            // 
            // perksLbl
            // 
            this.perksLbl.AutoSize = true;
            this.perksLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perksLbl.Location = new System.Drawing.Point(96, 357);
            this.perksLbl.Name = "perksLbl";
            this.perksLbl.Size = new System.Drawing.Size(70, 20);
            this.perksLbl.TabIndex = 35;
            this.perksLbl.Text = "Льготы:";
            // 
            // educationLbl
            // 
            this.educationLbl.AutoSize = true;
            this.educationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.educationLbl.Location = new System.Drawing.Point(56, 322);
            this.educationLbl.Name = "educationLbl";
            this.educationLbl.Size = new System.Drawing.Size(110, 20);
            this.educationLbl.TabIndex = 34;
            this.educationLbl.Text = "Образование";
            // 
            // currentSalaryLbl
            // 
            this.currentSalaryLbl.AutoSize = true;
            this.currentSalaryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentSalaryLbl.Location = new System.Drawing.Point(72, 287);
            this.currentSalaryLbl.Name = "currentSalaryLbl";
            this.currentSalaryLbl.Size = new System.Drawing.Size(94, 20);
            this.currentSalaryLbl.TabIndex = 33;
            this.currentSalaryLbl.Text = "Зарплата*:";
            // 
            // mainLanguageLbl
            // 
            this.mainLanguageLbl.AutoSize = true;
            this.mainLanguageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainLanguageLbl.Location = new System.Drawing.Point(33, 252);
            this.mainLanguageLbl.Name = "mainLanguageLbl";
            this.mainLanguageLbl.Size = new System.Drawing.Size(133, 20);
            this.mainLanguageLbl.TabIndex = 32;
            this.mainLanguageLbl.Text = "Основной язык*:";
            // 
            // birthDateLbl
            // 
            this.birthDateLbl.AutoSize = true;
            this.birthDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthDateLbl.Location = new System.Drawing.Point(28, 217);
            this.birthDateLbl.Name = "birthDateLbl";
            this.birthDateLbl.Size = new System.Drawing.Size(138, 20);
            this.birthDateLbl.TabIndex = 31;
            this.birthDateLbl.Text = "Дата рождения*:";
            // 
            // districtLbl
            // 
            this.districtLbl.AutoSize = true;
            this.districtLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.districtLbl.Location = new System.Drawing.Point(101, 147);
            this.districtLbl.Name = "districtLbl";
            this.districtLbl.Size = new System.Drawing.Size(65, 20);
            this.districtLbl.TabIndex = 30;
            this.districtLbl.Text = "Район*:";
            // 
            // expLbl
            // 
            this.expLbl.AutoSize = true;
            this.expLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expLbl.Location = new System.Drawing.Point(36, 181);
            this.expLbl.Name = "expLbl";
            this.expLbl.Size = new System.Drawing.Size(130, 20);
            this.expLbl.TabIndex = 29;
            this.expLbl.Text = "Опыт (в годах)*:";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressLbl.Location = new System.Drawing.Point(91, 112);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(75, 20);
            this.addressLbl.TabIndex = 28;
            this.addressLbl.Text = "Адресс*:";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLbl.Location = new System.Drawing.Point(97, 77);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(69, 20);
            this.nameLbl.TabIndex = 27;
            this.nameLbl.Text = "Ф.И.О.*:";
            // 
            // editEmployeeLbl
            // 
            this.editEmployeeLbl.AutoSize = true;
            this.editEmployeeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editEmployeeLbl.Location = new System.Drawing.Point(32, 20);
            this.editEmployeeLbl.Name = "editEmployeeLbl";
            this.editEmployeeLbl.Size = new System.Drawing.Size(351, 26);
            this.editEmployeeLbl.TabIndex = 26;
            this.editEmployeeLbl.Text = "Редактировать контракт о наймe";
            // 
            // EditEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 561);
            this.Controls.Add(this.photoFileNameLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.photoBtn);
            this.Controls.Add(this.birthDateDate);
            this.Controls.Add(this.salaryNum);
            this.Controls.Add(this.expNum);
            this.Controls.Add(this.notexTxt);
            this.Controls.Add(this.perksTxt);
            this.Controls.Add(this.educationTxt);
            this.Controls.Add(this.mainLanguageTxt);
            this.Controls.Add(this.districtTxt);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.notesLbl);
            this.Controls.Add(this.photoLbl);
            this.Controls.Add(this.perksLbl);
            this.Controls.Add(this.educationLbl);
            this.Controls.Add(this.currentSalaryLbl);
            this.Controls.Add(this.mainLanguageLbl);
            this.Controls.Add(this.birthDateLbl);
            this.Controls.Add(this.districtLbl);
            this.Controls.Add(this.expLbl);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.editEmployeeLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditEmployeeForm";
            this.Text = "Редактировать контракт о найме";
            ((System.ComponentModel.ISupportInitialize)(this.salaryNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label photoFileNameLbl;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button photoBtn;
        private System.Windows.Forms.DateTimePicker birthDateDate;
        private System.Windows.Forms.NumericUpDown salaryNum;
        private System.Windows.Forms.NumericUpDown expNum;
        private System.Windows.Forms.TextBox notexTxt;
        private System.Windows.Forms.TextBox perksTxt;
        private System.Windows.Forms.TextBox educationTxt;
        private System.Windows.Forms.TextBox mainLanguageTxt;
        private System.Windows.Forms.TextBox districtTxt;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label notesLbl;
        private System.Windows.Forms.Label photoLbl;
        private System.Windows.Forms.Label perksLbl;
        private System.Windows.Forms.Label educationLbl;
        private System.Windows.Forms.Label currentSalaryLbl;
        private System.Windows.Forms.Label mainLanguageLbl;
        private System.Windows.Forms.Label birthDateLbl;
        private System.Windows.Forms.Label districtLbl;
        private System.Windows.Forms.Label expLbl;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label editEmployeeLbl;
    }
}