namespace CISDocumentProcessing.Forms
{
    partial class NewCustomerForm
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
            this.innTxt = new System.Windows.Forms.TextBox();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.innLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.bankLbl = new System.Windows.Forms.Label();
            this.phonebl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.addEmployeeLbl = new System.Windows.Forms.Label();
            this.bankTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBtn.Location = new System.Drawing.Point(20, 259);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(123, 43);
            this.cancelBtn.TabIndex = 44;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submitBtn.Location = new System.Drawing.Point(240, 259);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(123, 43);
            this.submitBtn.TabIndex = 43;
            this.submitBtn.Text = "Добавить";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // innTxt
            // 
            this.innTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.innTxt.Location = new System.Drawing.Point(159, 172);
            this.innTxt.Name = "innTxt";
            this.innTxt.Size = new System.Drawing.Size(202, 26);
            this.innTxt.TabIndex = 41;
            // 
            // phoneTxt
            // 
            this.phoneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTxt.Location = new System.Drawing.Point(159, 100);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(202, 26);
            this.phoneTxt.TabIndex = 39;
            // 
            // addressTxt
            // 
            this.addressTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressTxt.Location = new System.Drawing.Point(159, 208);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(202, 26);
            this.addressTxt.TabIndex = 42;
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTxt.Location = new System.Drawing.Point(159, 64);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(202, 26);
            this.nameTxt.TabIndex = 38;
            // 
            // innLbl
            // 
            this.innLbl.AutoSize = true;
            this.innLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.innLbl.Location = new System.Drawing.Point(89, 175);
            this.innLbl.Name = "innLbl";
            this.innLbl.Size = new System.Drawing.Size(54, 20);
            this.innLbl.TabIndex = 32;
            this.innLbl.Text = "ИНН*:";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressLbl.Location = new System.Drawing.Point(74, 211);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(69, 20);
            this.addressLbl.TabIndex = 30;
            this.addressLbl.Text = "Адресс:";
            // 
            // bankLbl
            // 
            this.bankLbl.AutoSize = true;
            this.bankLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bankLbl.Location = new System.Drawing.Point(87, 139);
            this.bankLbl.Name = "bankLbl";
            this.bankLbl.Size = new System.Drawing.Size(56, 20);
            this.bankLbl.TabIndex = 29;
            this.bankLbl.Text = "Банк*:";
            // 
            // phonebl
            // 
            this.phonebl.AutoSize = true;
            this.phonebl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phonebl.Location = new System.Drawing.Point(54, 103);
            this.phonebl.Name = "phonebl";
            this.phonebl.Size = new System.Drawing.Size(89, 20);
            this.phonebl.TabIndex = 28;
            this.phonebl.Text = "Телефон*:";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLbl.Location = new System.Drawing.Point(11, 67);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(132, 20);
            this.nameLbl.TabIndex = 27;
            this.nameLbl.Text = "Наименование*:";
            // 
            // addEmployeeLbl
            // 
            this.addEmployeeLbl.AutoSize = true;
            this.addEmployeeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addEmployeeLbl.Location = new System.Drawing.Point(97, 20);
            this.addEmployeeLbl.Name = "addEmployeeLbl";
            this.addEmployeeLbl.Size = new System.Drawing.Size(200, 26);
            this.addEmployeeLbl.TabIndex = 26;
            this.addEmployeeLbl.Text = "Добавить клиента";
            // 
            // bankTxt
            // 
            this.bankTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bankTxt.Location = new System.Drawing.Point(159, 136);
            this.bankTxt.Name = "bankTxt";
            this.bankTxt.Size = new System.Drawing.Size(202, 26);
            this.bankTxt.TabIndex = 40;
            // 
            // NewCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 321);
            this.Controls.Add(this.bankTxt);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.innTxt);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.innLbl);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.bankLbl);
            this.Controls.Add(this.phonebl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.addEmployeeLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewCustomerForm";
            this.Text = "Добавить клиента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox innTxt;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label innLbl;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.Label bankLbl;
        private System.Windows.Forms.Label phonebl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label addEmployeeLbl;
        private System.Windows.Forms.TextBox bankTxt;
    }
}