namespace CISDocumentProcessing.Controls
{
    partial class EmployeePaymentListItem
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
            this.employeeLbl = new System.Windows.Forms.Label();
            this.amountLbl = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.typeLbl = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            this.editLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // employeeLbl
            // 
            this.employeeLbl.AutoSize = true;
            this.employeeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.employeeLbl.Location = new System.Drawing.Point(3, 12);
            this.employeeLbl.Name = "employeeLbl";
            this.employeeLbl.Size = new System.Drawing.Size(41, 17);
            this.employeeLbl.TabIndex = 0;
            this.employeeLbl.Text = "Кому";
            // 
            // amountLbl
            // 
            this.amountLbl.AutoSize = true;
            this.amountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountLbl.Location = new System.Drawing.Point(3, 32);
            this.amountLbl.Name = "amountLbl";
            this.amountLbl.Size = new System.Drawing.Size(57, 17);
            this.amountLbl.TabIndex = 1;
            this.amountLbl.Text = "Размер";
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLbl.Location = new System.Drawing.Point(3, 52);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(42, 17);
            this.dateLbl.TabIndex = 2;
            this.dateLbl.Text = "Дата";
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeLbl.Location = new System.Drawing.Point(434, 32);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(95, 17);
            this.typeLbl.TabIndex = 3;
            this.typeLbl.Text = "Тип выплаты";
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idLbl.Location = new System.Drawing.Point(434, 12);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(21, 17);
            this.idLbl.TabIndex = 4;
            this.idLbl.Text = "ID";
            // 
            // editLbl
            // 
            this.editLbl.AutoSize = true;
            this.editLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.editLbl.Location = new System.Drawing.Point(3, 72);
            this.editLbl.Name = "editLbl";
            this.editLbl.Size = new System.Drawing.Size(108, 17);
            this.editLbl.TabIndex = 7;
            this.editLbl.Text = "Редактировать";
            this.editLbl.Click += new System.EventHandler(this.editLbl_Click);
            this.editLbl.MouseEnter += new System.EventHandler(this.editLbl_MouseEnter);
            this.editLbl.MouseLeave += new System.EventHandler(this.editLbl_MouseLeave);
            // 
            // EmployeePaymentListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.editLbl);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.amountLbl);
            this.Controls.Add(this.employeeLbl);
            this.Name = "EmployeePaymentListItem";
            this.Size = new System.Drawing.Size(550, 100);
            this.MouseEnter += new System.EventHandler(this.EmployeePaymentListItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.EmployeePaymentListItem_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label employeeLbl;
        private System.Windows.Forms.Label amountLbl;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label editLbl;
    }
}
