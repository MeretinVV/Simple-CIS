namespace CISDocumentProcessing.Controls
{
    partial class ProjectFilter
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
            this.leaderBox = new System.Windows.Forms.ComboBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.leaderCheckBox = new System.Windows.Forms.CheckBox();
            this.costCheckBox = new System.Windows.Forms.CheckBox();
            this.nameCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maxDate = new System.Windows.Forms.DateTimePicker();
            this.minDate = new System.Windows.Forms.DateTimePicker();
            this.dateCheckBox = new System.Windows.Forms.CheckBox();
            this.customerBox = new System.Windows.Forms.ComboBox();
            this.customerCheckBox = new System.Windows.Forms.CheckBox();
            this.costMaxNum = new System.Windows.Forms.NumericUpDown();
            this.costMinNum = new System.Windows.Forms.NumericUpDown();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.idNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costMaxNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costMinNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.Location = new System.Drawing.Point(14, 10);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(90, 26);
            label3.TabIndex = 33;
            label3.Text = "Фильтр";
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submitBtn.Location = new System.Drawing.Point(123, 412);
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
            this.clearBtn.Location = new System.Drawing.Point(19, 412);
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
            this.idNum.Location = new System.Drawing.Point(19, 77);
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
            this.idCheckBox.Location = new System.Drawing.Point(19, 52);
            this.idCheckBox.Name = "idCheckBox";
            this.idCheckBox.Size = new System.Drawing.Size(40, 21);
            this.idCheckBox.TabIndex = 34;
            this.idCheckBox.Text = "ID";
            this.idCheckBox.UseVisualStyleBackColor = true;
            // 
            // leaderBox
            // 
            this.leaderBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leaderBox.FormattingEnabled = true;
            this.leaderBox.Location = new System.Drawing.Point(19, 320);
            this.leaderBox.Name = "leaderBox";
            this.leaderBox.Size = new System.Drawing.Size(197, 24);
            this.leaderBox.TabIndex = 32;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(19, 129);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(197, 20);
            this.nameTxt.TabIndex = 25;
            // 
            // leaderCheckBox
            // 
            this.leaderCheckBox.AutoSize = true;
            this.leaderCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leaderCheckBox.Location = new System.Drawing.Point(19, 295);
            this.leaderCheckBox.Name = "leaderCheckBox";
            this.leaderCheckBox.Size = new System.Drawing.Size(119, 21);
            this.leaderCheckBox.TabIndex = 23;
            this.leaderCheckBox.Text = "Руководитель";
            this.leaderCheckBox.UseVisualStyleBackColor = true;
            // 
            // costCheckBox
            // 
            this.costCheckBox.AutoSize = true;
            this.costCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costCheckBox.Location = new System.Drawing.Point(19, 243);
            this.costCheckBox.Name = "costCheckBox";
            this.costCheckBox.Size = new System.Drawing.Size(97, 21);
            this.costCheckBox.TabIndex = 22;
            this.costCheckBox.Text = "Стоимость";
            this.costCheckBox.UseVisualStyleBackColor = true;
            // 
            // nameCheckBox
            // 
            this.nameCheckBox.AutoSize = true;
            this.nameCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameCheckBox.Location = new System.Drawing.Point(19, 104);
            this.nameCheckBox.Name = "nameCheckBox";
            this.nameCheckBox.Size = new System.Drawing.Size(91, 21);
            this.nameCheckBox.TabIndex = 21;
            this.nameCheckBox.Text = "Название";
            this.nameCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(23, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 60;
            this.label4.Text = "До:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(23, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 59;
            this.label5.Text = "От:";
            // 
            // maxDate
            // 
            this.maxDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxDate.Location = new System.Drawing.Point(59, 214);
            this.maxDate.Name = "maxDate";
            this.maxDate.Size = new System.Drawing.Size(157, 23);
            this.maxDate.TabIndex = 58;
            // 
            // minDate
            // 
            this.minDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minDate.Location = new System.Drawing.Point(59, 185);
            this.minDate.Name = "minDate";
            this.minDate.Size = new System.Drawing.Size(157, 23);
            this.minDate.TabIndex = 57;
            // 
            // dateCheckBox
            // 
            this.dateCheckBox.AutoSize = true;
            this.dateCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateCheckBox.Location = new System.Drawing.Point(20, 158);
            this.dateCheckBox.Name = "dateCheckBox";
            this.dateCheckBox.Size = new System.Drawing.Size(187, 21);
            this.dateCheckBox.TabIndex = 56;
            this.dateCheckBox.Text = "Период начала проекта";
            this.dateCheckBox.UseVisualStyleBackColor = true;
            // 
            // customerBox
            // 
            this.customerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerBox.FormattingEnabled = true;
            this.customerBox.Location = new System.Drawing.Point(19, 372);
            this.customerBox.Name = "customerBox";
            this.customerBox.Size = new System.Drawing.Size(197, 24);
            this.customerBox.TabIndex = 62;
            // 
            // customerCheckBox
            // 
            this.customerCheckBox.AutoSize = true;
            this.customerCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerCheckBox.Location = new System.Drawing.Point(19, 347);
            this.customerCheckBox.Name = "customerCheckBox";
            this.customerCheckBox.Size = new System.Drawing.Size(89, 21);
            this.customerCheckBox.TabIndex = 61;
            this.customerCheckBox.Text = "Заказчик";
            this.customerCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(111, 266);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(13, 17);
            label1.TabIndex = 65;
            label1.Text = "-";
            // 
            // costMaxNum
            // 
            this.costMaxNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costMaxNum.Location = new System.Drawing.Point(138, 266);
            this.costMaxNum.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.costMaxNum.Name = "costMaxNum";
            this.costMaxNum.Size = new System.Drawing.Size(78, 23);
            this.costMaxNum.TabIndex = 64;
            this.costMaxNum.Value = new decimal(new int[] {
            400000,
            0,
            0,
            0});
            // 
            // costMinNum
            // 
            this.costMinNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costMinNum.Location = new System.Drawing.Point(19, 266);
            this.costMinNum.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.costMinNum.Name = "costMinNum";
            this.costMinNum.Size = new System.Drawing.Size(78, 23);
            this.costMinNum.TabIndex = 63;
            // 
            // ProjectFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(label1);
            this.Controls.Add(this.costMaxNum);
            this.Controls.Add(this.costMinNum);
            this.Controls.Add(this.customerBox);
            this.Controls.Add(this.customerCheckBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maxDate);
            this.Controls.Add(this.minDate);
            this.Controls.Add(this.dateCheckBox);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.idNum);
            this.Controls.Add(this.idCheckBox);
            this.Controls.Add(label3);
            this.Controls.Add(this.leaderBox);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.leaderCheckBox);
            this.Controls.Add(this.costCheckBox);
            this.Controls.Add(this.nameCheckBox);
            this.Name = "ProjectFilter";
            this.Size = new System.Drawing.Size(230, 460);
            ((System.ComponentModel.ISupportInitialize)(this.idNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costMaxNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costMinNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.NumericUpDown idNum;
        private System.Windows.Forms.CheckBox idCheckBox;
        private System.Windows.Forms.ComboBox leaderBox;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.CheckBox leaderCheckBox;
        private System.Windows.Forms.CheckBox costCheckBox;
        private System.Windows.Forms.CheckBox nameCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker maxDate;
        private System.Windows.Forms.DateTimePicker minDate;
        private System.Windows.Forms.CheckBox dateCheckBox;
        private System.Windows.Forms.ComboBox customerBox;
        private System.Windows.Forms.CheckBox customerCheckBox;
        private System.Windows.Forms.NumericUpDown costMaxNum;
        private System.Windows.Forms.NumericUpDown costMinNum;
    }
}
