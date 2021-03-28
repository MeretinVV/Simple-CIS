namespace CISDocumentProcessing.Forms
{
    partial class NewProjectForm
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.costNum = new System.Windows.Forms.NumericUpDown();
            this.representativeNameTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.representativeNameLbl = new System.Windows.Forms.Label();
            this.costLbl = new System.Windows.Forms.Label();
            this.startDateLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.addEmployeeLbl = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.endDateLbl = new System.Windows.Forms.Label();
            this.leaderBox = new System.Windows.Forms.ComboBox();
            this.leaderLbl = new System.Windows.Forms.Label();
            this.customerLbl = new System.Windows.Forms.Label();
            this.customerBox = new System.Windows.Forms.ComboBox();
            this.representativePhoneTxt = new System.Windows.Forms.TextBox();
            this.representativePhoneLbl = new System.Windows.Forms.Label();
            this.bonusNum = new System.Windows.Forms.NumericUpDown();
            this.bonusLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.costNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonusNum)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBtn.Location = new System.Drawing.Point(61, 442);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(123, 43);
            this.cancelBtn.TabIndex = 48;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submitBtn.Location = new System.Drawing.Point(281, 442);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(123, 43);
            this.submitBtn.TabIndex = 47;
            this.submitBtn.Text = "Добавить";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // startDate
            // 
            this.startDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startDate.Location = new System.Drawing.Point(229, 107);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(200, 26);
            this.startDate.TabIndex = 39;
            // 
            // costNum
            // 
            this.costNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costNum.Location = new System.Drawing.Point(229, 189);
            this.costNum.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.costNum.Name = "costNum";
            this.costNum.Size = new System.Drawing.Size(200, 26);
            this.costNum.TabIndex = 41;
            // 
            // representativeNameTxt
            // 
            this.representativeNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.representativeNameTxt.Location = new System.Drawing.Point(229, 308);
            this.representativeNameTxt.Name = "representativeNameTxt";
            this.representativeNameTxt.Size = new System.Drawing.Size(198, 26);
            this.representativeNameTxt.TabIndex = 44;
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTxt.Location = new System.Drawing.Point(229, 66);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(200, 26);
            this.nameTxt.TabIndex = 38;
            // 
            // representativeNameLbl
            // 
            this.representativeNameLbl.AutoSize = true;
            this.representativeNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.representativeNameLbl.Location = new System.Drawing.Point(50, 309);
            this.representativeNameLbl.Name = "representativeNameLbl";
            this.representativeNameLbl.Size = new System.Drawing.Size(164, 20);
            this.representativeNameLbl.TabIndex = 34;
            this.representativeNameLbl.Text = "Имя представтеля*:";
            // 
            // costLbl
            // 
            this.costLbl.AutoSize = true;
            this.costLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLbl.Location = new System.Drawing.Point(111, 189);
            this.costLbl.Name = "costLbl";
            this.costLbl.Size = new System.Drawing.Size(103, 20);
            this.costLbl.TabIndex = 33;
            this.costLbl.Text = "Стоимость*:";
            // 
            // startDateLbl
            // 
            this.startDateLbl.AutoSize = true;
            this.startDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startDateLbl.Location = new System.Drawing.Point(97, 109);
            this.startDateLbl.Name = "startDateLbl";
            this.startDateLbl.Size = new System.Drawing.Size(117, 20);
            this.startDateLbl.TabIndex = 31;
            this.startDateLbl.Text = "Дата начала*:";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLbl.Location = new System.Drawing.Point(121, 69);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(93, 20);
            this.nameLbl.TabIndex = 27;
            this.nameLbl.Text = "Название*:";
            // 
            // addEmployeeLbl
            // 
            this.addEmployeeLbl.AutoSize = true;
            this.addEmployeeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addEmployeeLbl.Location = new System.Drawing.Point(75, 10);
            this.addEmployeeLbl.Name = "addEmployeeLbl";
            this.addEmployeeLbl.Size = new System.Drawing.Size(314, 26);
            this.addEmployeeLbl.TabIndex = 26;
            this.addEmployeeLbl.Text = "Добавить проектный договор";
            // 
            // endDate
            // 
            this.endDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endDate.Location = new System.Drawing.Point(229, 148);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(200, 26);
            this.endDate.TabIndex = 40;
            // 
            // endDateLbl
            // 
            this.endDateLbl.AutoSize = true;
            this.endDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endDateLbl.Location = new System.Drawing.Point(72, 149);
            this.endDateLbl.Name = "endDateLbl";
            this.endDateLbl.Size = new System.Drawing.Size(142, 20);
            this.endDateLbl.TabIndex = 51;
            this.endDateLbl.Text = "Дата окончания*:";
            // 
            // leaderBox
            // 
            this.leaderBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leaderBox.FormattingEnabled = true;
            this.leaderBox.Location = new System.Drawing.Point(229, 230);
            this.leaderBox.Name = "leaderBox";
            this.leaderBox.Size = new System.Drawing.Size(197, 24);
            this.leaderBox.TabIndex = 42;
            // 
            // leaderLbl
            // 
            this.leaderLbl.AutoSize = true;
            this.leaderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leaderLbl.Location = new System.Drawing.Point(86, 229);
            this.leaderLbl.Name = "leaderLbl";
            this.leaderLbl.Size = new System.Drawing.Size(128, 20);
            this.leaderLbl.TabIndex = 54;
            this.leaderLbl.Text = "Руководитель*:";
            // 
            // customerLbl
            // 
            this.customerLbl.AutoSize = true;
            this.customerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerLbl.Location = new System.Drawing.Point(139, 269);
            this.customerLbl.Name = "customerLbl";
            this.customerLbl.Size = new System.Drawing.Size(75, 20);
            this.customerLbl.TabIndex = 56;
            this.customerLbl.Text = "Клиент*:";
            // 
            // customerBox
            // 
            this.customerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerBox.FormattingEnabled = true;
            this.customerBox.Location = new System.Drawing.Point(229, 269);
            this.customerBox.Name = "customerBox";
            this.customerBox.Size = new System.Drawing.Size(198, 24);
            this.customerBox.TabIndex = 43;
            // 
            // representativePhoneTxt
            // 
            this.representativePhoneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.representativePhoneTxt.Location = new System.Drawing.Point(229, 349);
            this.representativePhoneTxt.Name = "representativePhoneTxt";
            this.representativePhoneTxt.Size = new System.Drawing.Size(198, 26);
            this.representativePhoneTxt.TabIndex = 45;
            // 
            // representativePhoneLbl
            // 
            this.representativePhoneLbl.AutoSize = true;
            this.representativePhoneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.representativePhoneLbl.Location = new System.Drawing.Point(11, 349);
            this.representativePhoneLbl.Name = "representativePhoneLbl";
            this.representativePhoneLbl.Size = new System.Drawing.Size(203, 20);
            this.representativePhoneLbl.TabIndex = 57;
            this.representativePhoneLbl.Text = "Телефон представтеля*:";
            // 
            // bonusNum
            // 
            this.bonusNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bonusNum.Location = new System.Drawing.Point(229, 390);
            this.bonusNum.Name = "bonusNum";
            this.bonusNum.Size = new System.Drawing.Size(77, 26);
            this.bonusNum.TabIndex = 46;
            // 
            // bonusLbl
            // 
            this.bonusLbl.AutoSize = true;
            this.bonusLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bonusLbl.Location = new System.Drawing.Point(45, 389);
            this.bonusLbl.Name = "bonusLbl";
            this.bonusLbl.Size = new System.Drawing.Size(169, 20);
            this.bonusLbl.TabIndex = 59;
            this.bonusLbl.Text = "Бонус (в процентах)*:";
            // 
            // NewProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 511);
            this.Controls.Add(this.bonusNum);
            this.Controls.Add(this.bonusLbl);
            this.Controls.Add(this.representativePhoneTxt);
            this.Controls.Add(this.representativePhoneLbl);
            this.Controls.Add(this.customerLbl);
            this.Controls.Add(this.customerBox);
            this.Controls.Add(this.leaderLbl);
            this.Controls.Add(this.leaderBox);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.endDateLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.costNum);
            this.Controls.Add(this.representativeNameTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.representativeNameLbl);
            this.Controls.Add(this.costLbl);
            this.Controls.Add(this.startDateLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.addEmployeeLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewProjectForm";
            this.Text = "Добавить проектный договор";
            ((System.ComponentModel.ISupportInitialize)(this.costNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonusNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.NumericUpDown costNum;
        private System.Windows.Forms.TextBox representativeNameTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label representativeNameLbl;
        private System.Windows.Forms.Label costLbl;
        private System.Windows.Forms.Label startDateLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label addEmployeeLbl;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Label endDateLbl;
        private System.Windows.Forms.ComboBox leaderBox;
        private System.Windows.Forms.Label leaderLbl;
        private System.Windows.Forms.Label customerLbl;
        private System.Windows.Forms.ComboBox customerBox;
        private System.Windows.Forms.TextBox representativePhoneTxt;
        private System.Windows.Forms.Label representativePhoneLbl;
        private System.Windows.Forms.NumericUpDown bonusNum;
        private System.Windows.Forms.Label bonusLbl;
    }
}