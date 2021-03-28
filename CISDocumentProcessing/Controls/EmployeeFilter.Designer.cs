namespace CISDocumentProcessing.Controls
{
    partial class EmployeeFilter
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.nameCheckBox = new System.Windows.Forms.CheckBox();
            this.expCheckBox = new System.Windows.Forms.CheckBox();
            this.mainLanguageCheckBox = new System.Windows.Forms.CheckBox();
            this.salaryCheckBox = new System.Windows.Forms.CheckBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.expMinNum = new System.Windows.Forms.NumericUpDown();
            this.expMaxNum = new System.Windows.Forms.NumericUpDown();
            this.salaryMaxNum = new System.Windows.Forms.NumericUpDown();
            this.salaryMinNum = new System.Windows.Forms.NumericUpDown();
            this.idCheckBox = new System.Windows.Forms.CheckBox();
            this.idNum = new System.Windows.Forms.NumericUpDown();
            this.clearBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.mainLanguageBox = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.expMinNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expMaxNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryMaxNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryMinNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(120, 178);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(13, 17);
            label1.TabIndex = 11;
            label1.Text = "-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(111, 283);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(13, 17);
            label2.TabIndex = 14;
            label2.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.Location = new System.Drawing.Point(14, 8);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(90, 26);
            label3.TabIndex = 16;
            label3.Text = "Фильтр";
            // 
            // nameCheckBox
            // 
            this.nameCheckBox.AutoSize = true;
            this.nameCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameCheckBox.Location = new System.Drawing.Point(19, 102);
            this.nameCheckBox.Name = "nameCheckBox";
            this.nameCheckBox.Size = new System.Drawing.Size(54, 21);
            this.nameCheckBox.TabIndex = 4;
            this.nameCheckBox.Text = "Имя";
            this.nameCheckBox.UseVisualStyleBackColor = true;
            // 
            // expCheckBox
            // 
            this.expCheckBox.AutoSize = true;
            this.expCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expCheckBox.Location = new System.Drawing.Point(19, 151);
            this.expCheckBox.Name = "expCheckBox";
            this.expCheckBox.Size = new System.Drawing.Size(63, 21);
            this.expCheckBox.TabIndex = 5;
            this.expCheckBox.Text = "Опыт";
            this.expCheckBox.UseVisualStyleBackColor = true;
            // 
            // mainLanguageCheckBox
            // 
            this.mainLanguageCheckBox.AutoSize = true;
            this.mainLanguageCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainLanguageCheckBox.Location = new System.Drawing.Point(19, 203);
            this.mainLanguageCheckBox.Name = "mainLanguageCheckBox";
            this.mainLanguageCheckBox.Size = new System.Drawing.Size(128, 21);
            this.mainLanguageCheckBox.TabIndex = 6;
            this.mainLanguageCheckBox.Text = "Основной язык";
            this.mainLanguageCheckBox.UseVisualStyleBackColor = true;
            // 
            // salaryCheckBox
            // 
            this.salaryCheckBox.AutoSize = true;
            this.salaryCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salaryCheckBox.Location = new System.Drawing.Point(19, 256);
            this.salaryCheckBox.Name = "salaryCheckBox";
            this.salaryCheckBox.Size = new System.Drawing.Size(91, 21);
            this.salaryCheckBox.TabIndex = 7;
            this.salaryCheckBox.Text = "Зарплата";
            this.salaryCheckBox.UseVisualStyleBackColor = true;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(19, 127);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(197, 20);
            this.nameTxt.TabIndex = 8;
            // 
            // expMinNum
            // 
            this.expMinNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expMinNum.Location = new System.Drawing.Point(19, 176);
            this.expMinNum.Name = "expMinNum";
            this.expMinNum.Size = new System.Drawing.Size(54, 23);
            this.expMinNum.TabIndex = 9;
            // 
            // expMaxNum
            // 
            this.expMaxNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expMaxNum.Location = new System.Drawing.Point(162, 176);
            this.expMaxNum.Name = "expMaxNum";
            this.expMaxNum.Size = new System.Drawing.Size(54, 23);
            this.expMaxNum.TabIndex = 10;
            this.expMaxNum.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // salaryMaxNum
            // 
            this.salaryMaxNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salaryMaxNum.Location = new System.Drawing.Point(138, 281);
            this.salaryMaxNum.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.salaryMaxNum.Name = "salaryMaxNum";
            this.salaryMaxNum.Size = new System.Drawing.Size(77, 23);
            this.salaryMaxNum.TabIndex = 13;
            this.salaryMaxNum.Value = new decimal(new int[] {
            40000,
            0,
            0,
            0});
            // 
            // salaryMinNum
            // 
            this.salaryMinNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salaryMinNum.Location = new System.Drawing.Point(19, 281);
            this.salaryMinNum.Name = "salaryMinNum";
            this.salaryMinNum.Size = new System.Drawing.Size(78, 23);
            this.salaryMinNum.TabIndex = 12;
            // 
            // idCheckBox
            // 
            this.idCheckBox.AutoSize = true;
            this.idCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idCheckBox.Location = new System.Drawing.Point(19, 50);
            this.idCheckBox.Name = "idCheckBox";
            this.idCheckBox.Size = new System.Drawing.Size(40, 21);
            this.idCheckBox.TabIndex = 17;
            this.idCheckBox.Text = "ID";
            this.idCheckBox.UseVisualStyleBackColor = true;
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
            this.idNum.TabIndex = 18;
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearBtn.Location = new System.Drawing.Point(19, 329);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(91, 32);
            this.clearBtn.TabIndex = 19;
            this.clearBtn.Text = "Сбросить";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submitBtn.Location = new System.Drawing.Point(123, 329);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(93, 32);
            this.submitBtn.TabIndex = 20;
            this.submitBtn.Text = "Применить";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // mainLanguageBox
            // 
            this.mainLanguageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainLanguageBox.FormattingEnabled = true;
            this.mainLanguageBox.Location = new System.Drawing.Point(19, 228);
            this.mainLanguageBox.Name = "mainLanguageBox";
            this.mainLanguageBox.Size = new System.Drawing.Size(197, 24);
            this.mainLanguageBox.TabIndex = 15;
            // 
            // EmployeeFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.idNum);
            this.Controls.Add(this.idCheckBox);
            this.Controls.Add(label3);
            this.Controls.Add(this.mainLanguageBox);
            this.Controls.Add(label2);
            this.Controls.Add(this.salaryMaxNum);
            this.Controls.Add(this.salaryMinNum);
            this.Controls.Add(label1);
            this.Controls.Add(this.expMaxNum);
            this.Controls.Add(this.expMinNum);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.salaryCheckBox);
            this.Controls.Add(this.mainLanguageCheckBox);
            this.Controls.Add(this.expCheckBox);
            this.Controls.Add(this.nameCheckBox);
            this.Name = "EmployeeFilter";
            this.Size = new System.Drawing.Size(230, 380);
            ((System.ComponentModel.ISupportInitialize)(this.expMinNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expMaxNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryMaxNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryMinNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox nameCheckBox;
        private System.Windows.Forms.CheckBox expCheckBox;
        private System.Windows.Forms.CheckBox mainLanguageCheckBox;
        private System.Windows.Forms.CheckBox salaryCheckBox;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.NumericUpDown expMinNum;
        private System.Windows.Forms.NumericUpDown expMaxNum;
        private System.Windows.Forms.NumericUpDown salaryMaxNum;
        private System.Windows.Forms.NumericUpDown salaryMinNum;
        private System.Windows.Forms.CheckBox idCheckBox;
        private System.Windows.Forms.NumericUpDown idNum;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.ComboBox mainLanguageBox;
    }
}
