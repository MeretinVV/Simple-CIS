namespace CISDocumentProcessing.Forms
{
    partial class EditPaymentForm
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
            this.editPaymentLbl = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.dateDate = new System.Windows.Forms.DateTimePicker();
            this.amountNum = new System.Windows.Forms.NumericUpDown();
            this.typeLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.amountLbl = new System.Windows.Forms.Label();
            this.employeeLbl = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.employeeBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.amountNum)).BeginInit();
            this.SuspendLayout();
            // 
            // editPaymentLbl
            // 
            this.editPaymentLbl.AutoSize = true;
            this.editPaymentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editPaymentLbl.Location = new System.Drawing.Point(120, 21);
            this.editPaymentLbl.Name = "editPaymentLbl";
            this.editPaymentLbl.Size = new System.Drawing.Size(259, 26);
            this.editPaymentLbl.TabIndex = 1;
            this.editPaymentLbl.Text = "Редактировать выплату";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBtn.Location = new System.Drawing.Point(35, 219);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(123, 43);
            this.cancelBtn.TabIndex = 51;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submitBtn.Location = new System.Drawing.Point(282, 219);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(123, 43);
            this.submitBtn.TabIndex = 50;
            this.submitBtn.Text = "Подтвердить";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // dateDate
            // 
            this.dateDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateDate.Location = new System.Drawing.Point(165, 62);
            this.dateDate.Name = "dateDate";
            this.dateDate.Size = new System.Drawing.Size(240, 26);
            this.dateDate.TabIndex = 46;
            // 
            // amountNum
            // 
            this.amountNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountNum.Location = new System.Drawing.Point(165, 134);
            this.amountNum.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.amountNum.Name = "amountNum";
            this.amountNum.Size = new System.Drawing.Size(240, 26);
            this.amountNum.TabIndex = 48;
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeLbl.Location = new System.Drawing.Point(31, 171);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(118, 20);
            this.typeLbl.TabIndex = 31;
            this.typeLbl.Text = "Тип выплаты*:";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLbl.Location = new System.Drawing.Point(91, 69);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(58, 20);
            this.dateLbl.TabIndex = 30;
            this.dateLbl.Text = "Дата*:";
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountLbl.Location = new System.Drawing.Point(74, 137);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(75, 20);
            this.amountLbl.TabIndex = 27;
            this.amountLbl.Text = "Размер*:";
            // 
            // employeeLbl
            // 
            this.employeeLbl.AutoSize = true;
            this.employeeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeLbl.Location = new System.Drawing.Point(48, 103);
            this.employeeLbl.Name = "employeeLbl";
            this.employeeLbl.Size = new System.Drawing.Size(101, 20);
            this.employeeLbl.TabIndex = 26;
            this.employeeLbl.Text = "Сотрудник*:";
            // 
            // typeBox
            // 
            this.typeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "Зарплата",
            "Премия",
            "Возмещение"});
            this.typeBox.Location = new System.Drawing.Point(165, 171);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(240, 24);
            this.typeBox.TabIndex = 49;
            // 
            // employeeBox
            // 
            this.employeeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeBox.FormattingEnabled = true;
            this.employeeBox.Location = new System.Drawing.Point(165, 99);
            this.employeeBox.Name = "employeeBox";
            this.employeeBox.Size = new System.Drawing.Size(240, 24);
            this.employeeBox.TabIndex = 47;
            // 
            // EditPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 281);
            this.Controls.Add(this.employeeBox);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.dateDate);
            this.Controls.Add(this.amountNum);
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.amountLbl);
            this.Controls.Add(this.employeeLbl);
            this.Controls.Add(this.editPaymentLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditPaymentForm";
            this.Text = "Редактировать выплату";
            ((System.ComponentModel.ISupportInitialize)(this.amountNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label editPaymentLbl;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.DateTimePicker dateDate;
        private System.Windows.Forms.NumericUpDown amountNum;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label amountLbl;
        private System.Windows.Forms.Label employeeLbl;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.ComboBox employeeBox;
    }
}