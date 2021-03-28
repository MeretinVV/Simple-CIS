namespace CISDocumentProcessing.Controls
{
    partial class EmployeePaymentFilter
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label1;
            this.submitBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.idNum = new System.Windows.Forms.NumericUpDown();
            this.idCheckBox = new System.Windows.Forms.CheckBox();
            this.amountMaxNum = new System.Windows.Forms.NumericUpDown();
            this.amountMinNum = new System.Windows.Forms.NumericUpDown();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.dateCheckBox = new System.Windows.Forms.CheckBox();
            this.typeCheckBox = new System.Windows.Forms.CheckBox();
            this.amounCheckBox = new System.Windows.Forms.CheckBox();
            this.nameCheckBox = new System.Windows.Forms.CheckBox();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.minDate = new System.Windows.Forms.DateTimePicker();
            this.maxDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.idNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountMaxNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountMinNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.Location = new System.Drawing.Point(14, 8);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(90, 26);
            label3.TabIndex = 33;
            label3.Text = "Фильтр";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(111, 176);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(13, 17);
            label1.TabIndex = 28;
            label1.Text = "-";
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submitBtn.Location = new System.Drawing.Point(123, 351);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(93, 32);
            this.submitBtn.TabIndex = 37;
            this.submitBtn.Text = "Применить";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearBtn.Location = new System.Drawing.Point(19, 351);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(91, 32);
            this.clearBtn.TabIndex = 36;
            this.clearBtn.Text = "Сбросить";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // idNum
            // 
            this.idNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idNum.Location = new System.Drawing.Point(19, 75);
            this.idNum.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.idNum.Name = "idNum";
            this.idNum.Size = new System.Drawing.Size(78, 23);
            this.idNum.TabIndex = 35;
            // 
            // idCheckBox
            // 
            this.idCheckBox.AutoSize = true;
            this.idCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idCheckBox.Location = new System.Drawing.Point(19, 50);
            this.idCheckBox.Name = "idCheckBox";
            this.idCheckBox.Size = new System.Drawing.Size(40, 21);
            this.idCheckBox.TabIndex = 34;
            this.idCheckBox.Text = "ID";
            this.idCheckBox.UseVisualStyleBackColor = true;
            // 
            // amountMaxNum
            // 
            this.amountMaxNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountMaxNum.Location = new System.Drawing.Point(138, 176);
            this.amountMaxNum.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.amountMaxNum.Name = "amountMaxNum";
            this.amountMaxNum.Size = new System.Drawing.Size(78, 23);
            this.amountMaxNum.TabIndex = 27;
            this.amountMaxNum.Value = new decimal(new int[] {
            40000,
            0,
            0,
            0});
            // 
            // amountMinNum
            // 
            this.amountMinNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountMinNum.Location = new System.Drawing.Point(19, 176);
            this.amountMinNum.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.amountMinNum.Name = "amountMinNum";
            this.amountMinNum.Size = new System.Drawing.Size(78, 23);
            this.amountMinNum.TabIndex = 26;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(19, 127);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(197, 20);
            this.nameTxt.TabIndex = 25;
            // 
            // dateCheckBox
            // 
            this.dateCheckBox.AutoSize = true;
            this.dateCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateCheckBox.Location = new System.Drawing.Point(19, 256);
            this.dateCheckBox.Name = "dateCheckBox";
            this.dateCheckBox.Size = new System.Drawing.Size(137, 21);
            this.dateCheckBox.TabIndex = 24;
            this.dateCheckBox.Text = "Период времени";
            this.dateCheckBox.UseVisualStyleBackColor = true;
            // 
            // typeCheckBox
            // 
            this.typeCheckBox.AutoSize = true;
            this.typeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeCheckBox.Location = new System.Drawing.Point(19, 203);
            this.typeCheckBox.Name = "typeCheckBox";
            this.typeCheckBox.Size = new System.Drawing.Size(114, 21);
            this.typeCheckBox.TabIndex = 23;
            this.typeCheckBox.Text = "Тип выплаты";
            this.typeCheckBox.UseVisualStyleBackColor = true;
            // 
            // amounCheckBox
            // 
            this.amounCheckBox.AutoSize = true;
            this.amounCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amounCheckBox.Location = new System.Drawing.Point(19, 151);
            this.amounCheckBox.Name = "amounCheckBox";
            this.amounCheckBox.Size = new System.Drawing.Size(138, 21);
            this.amounCheckBox.TabIndex = 22;
            this.amounCheckBox.Text = "Размер выплаты";
            this.amounCheckBox.UseVisualStyleBackColor = true;
            // 
            // nameCheckBox
            // 
            this.nameCheckBox.AutoSize = true;
            this.nameCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameCheckBox.Location = new System.Drawing.Point(19, 102);
            this.nameCheckBox.Name = "nameCheckBox";
            this.nameCheckBox.Size = new System.Drawing.Size(54, 21);
            this.nameCheckBox.TabIndex = 21;
            this.nameCheckBox.Text = "Имя";
            this.nameCheckBox.UseVisualStyleBackColor = true;
            // 
            // typeBox
            // 
            this.typeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "Зарплата",
            "Премия",
            "Возмещение"});
            this.typeBox.Location = new System.Drawing.Point(19, 228);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(196, 24);
            this.typeBox.TabIndex = 51;
            // 
            // minDate
            // 
            this.minDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minDate.Location = new System.Drawing.Point(58, 283);
            this.minDate.Name = "minDate";
            this.minDate.Size = new System.Drawing.Size(157, 23);
            this.minDate.TabIndex = 52;
            // 
            // maxDate
            // 
            this.maxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxDate.Location = new System.Drawing.Point(58, 312);
            this.maxDate.Name = "maxDate";
            this.maxDate.Size = new System.Drawing.Size(157, 23);
            this.maxDate.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(22, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "От:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(22, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 55;
            this.label4.Text = "До:";
            // 
            // EmployeePaymentFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maxDate);
            this.Controls.Add(this.minDate);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.idNum);
            this.Controls.Add(this.idCheckBox);
            this.Controls.Add(label3);
            this.Controls.Add(label1);
            this.Controls.Add(this.amountMaxNum);
            this.Controls.Add(this.amountMinNum);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.dateCheckBox);
            this.Controls.Add(this.typeCheckBox);
            this.Controls.Add(this.amounCheckBox);
            this.Controls.Add(this.nameCheckBox);
            this.Name = "EmployeePaymentFilter";
            this.Size = new System.Drawing.Size(230, 400);
            ((System.ComponentModel.ISupportInitialize)(this.idNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountMaxNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountMinNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.NumericUpDown idNum;
        private System.Windows.Forms.CheckBox idCheckBox;
        private System.Windows.Forms.NumericUpDown amountMaxNum;
        private System.Windows.Forms.NumericUpDown amountMinNum;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.CheckBox dateCheckBox;
        private System.Windows.Forms.CheckBox typeCheckBox;
        private System.Windows.Forms.CheckBox amounCheckBox;
        private System.Windows.Forms.CheckBox nameCheckBox;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.DateTimePicker minDate;
        private System.Windows.Forms.DateTimePicker maxDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}
