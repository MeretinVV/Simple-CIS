namespace CISDocumentProcessing.Forms
{
    partial class ProjectAnalysisForm
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
            this.customerInnLbl = new System.Windows.Forms.Label();
            this.customerBankLbl = new System.Windows.Forms.Label();
            this.customerPhoneLbl = new System.Windows.Forms.Label();
            this.customerInfoLbl = new System.Windows.Forms.Label();
            this.IdLbl = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.customerAddressLbl = new System.Windows.Forms.Label();
            this.customerRepresentativeInfoLbl = new System.Windows.Forms.Label();
            this.leaderNameLbl = new System.Windows.Forms.Label();
            this.customerRepresentativePhoneLbl = new System.Windows.Forms.Label();
            this.customerRepresentativeNameLbl = new System.Windows.Forms.Label();
            this.customerNameLbl = new System.Windows.Forms.Label();
            this.bonusAmountLbl = new System.Windows.Forms.Label();
            this.costLbl = new System.Windows.Forms.Label();
            this.endDateLbl = new System.Windows.Forms.Label();
            this.startDateLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.addParticipantLbl = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerInnLbl
            // 
            this.customerInnLbl.AutoSize = true;
            this.customerInnLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerInnLbl.Location = new System.Drawing.Point(0, 220);
            this.customerInnLbl.Name = "customerInnLbl";
            this.customerInnLbl.Size = new System.Drawing.Size(38, 17);
            this.customerInnLbl.TabIndex = 22;
            this.customerInnLbl.Text = "ИНН";
            // 
            // customerBankLbl
            // 
            this.customerBankLbl.AutoSize = true;
            this.customerBankLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerBankLbl.Location = new System.Drawing.Point(0, 200);
            this.customerBankLbl.Name = "customerBankLbl";
            this.customerBankLbl.Size = new System.Drawing.Size(40, 17);
            this.customerBankLbl.TabIndex = 21;
            this.customerBankLbl.Text = "Банк";
            // 
            // customerPhoneLbl
            // 
            this.customerPhoneLbl.AutoSize = true;
            this.customerPhoneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerPhoneLbl.Location = new System.Drawing.Point(0, 180);
            this.customerPhoneLbl.Name = "customerPhoneLbl";
            this.customerPhoneLbl.Size = new System.Drawing.Size(68, 17);
            this.customerPhoneLbl.TabIndex = 20;
            this.customerPhoneLbl.Text = "Телефон";
            // 
            // customerInfoLbl
            // 
            this.customerInfoLbl.AutoSize = true;
            this.customerInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerInfoLbl.Location = new System.Drawing.Point(0, 120);
            this.customerInfoLbl.Name = "customerInfoLbl";
            this.customerInfoLbl.Size = new System.Drawing.Size(178, 17);
            this.customerInfoLbl.TabIndex = 19;
            this.customerInfoLbl.Text = "Информация о заказчике";
            // 
            // IdLbl
            // 
            this.IdLbl.AutoSize = true;
            this.IdLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdLbl.Location = new System.Drawing.Point(583, 10);
            this.IdLbl.Name = "IdLbl";
            this.IdLbl.Size = new System.Drawing.Size(21, 17);
            this.IdLbl.TabIndex = 11;
            this.IdLbl.Text = "ID";
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Controls.Add(this.addParticipantLbl);
            this.mainPanel.Controls.Add(this.customerAddressLbl);
            this.mainPanel.Controls.Add(this.customerRepresentativeInfoLbl);
            this.mainPanel.Controls.Add(this.leaderNameLbl);
            this.mainPanel.Controls.Add(this.customerRepresentativePhoneLbl);
            this.mainPanel.Controls.Add(this.customerRepresentativeNameLbl);
            this.mainPanel.Controls.Add(this.customerNameLbl);
            this.mainPanel.Controls.Add(this.bonusAmountLbl);
            this.mainPanel.Controls.Add(this.costLbl);
            this.mainPanel.Controls.Add(this.endDateLbl);
            this.mainPanel.Controls.Add(this.startDateLbl);
            this.mainPanel.Controls.Add(this.nameLbl);
            this.mainPanel.Controls.Add(this.customerInnLbl);
            this.mainPanel.Controls.Add(this.customerBankLbl);
            this.mainPanel.Controls.Add(this.customerPhoneLbl);
            this.mainPanel.Controls.Add(this.customerInfoLbl);
            this.mainPanel.Controls.Add(this.IdLbl);
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(665, 570);
            this.mainPanel.TabIndex = 25;
            // 
            // customerAddressLbl
            // 
            this.customerAddressLbl.AutoSize = true;
            this.customerAddressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerAddressLbl.Location = new System.Drawing.Point(0, 160);
            this.customerAddressLbl.Name = "customerAddressLbl";
            this.customerAddressLbl.Size = new System.Drawing.Size(55, 17);
            this.customerAddressLbl.TabIndex = 33;
            this.customerAddressLbl.Text = "Адресс";
            // 
            // customerRepresentativeInfoLbl
            // 
            this.customerRepresentativeInfoLbl.AutoSize = true;
            this.customerRepresentativeInfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerRepresentativeInfoLbl.Location = new System.Drawing.Point(293, 120);
            this.customerRepresentativeInfoLbl.Name = "customerRepresentativeInfoLbl";
            this.customerRepresentativeInfoLbl.Size = new System.Drawing.Size(282, 17);
            this.customerRepresentativeInfoLbl.TabIndex = 32;
            this.customerRepresentativeInfoLbl.Text = "Информация о представителе заказчика";
            // 
            // leaderNameLbl
            // 
            this.leaderNameLbl.AutoSize = true;
            this.leaderNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leaderNameLbl.Location = new System.Drawing.Point(0, 70);
            this.leaderNameLbl.Name = "leaderNameLbl";
            this.leaderNameLbl.Size = new System.Drawing.Size(100, 17);
            this.leaderNameLbl.TabIndex = 31;
            this.leaderNameLbl.Text = "Руководитель";
            // 
            // customerRepresentativePhoneLbl
            // 
            this.customerRepresentativePhoneLbl.AutoSize = true;
            this.customerRepresentativePhoneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerRepresentativePhoneLbl.Location = new System.Drawing.Point(293, 160);
            this.customerRepresentativePhoneLbl.Name = "customerRepresentativePhoneLbl";
            this.customerRepresentativePhoneLbl.Size = new System.Drawing.Size(172, 17);
            this.customerRepresentativePhoneLbl.TabIndex = 30;
            this.customerRepresentativePhoneLbl.Text = "Телефон представителя";
            // 
            // customerRepresentativeNameLbl
            // 
            this.customerRepresentativeNameLbl.AutoSize = true;
            this.customerRepresentativeNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerRepresentativeNameLbl.Location = new System.Drawing.Point(293, 140);
            this.customerRepresentativeNameLbl.Name = "customerRepresentativeNameLbl";
            this.customerRepresentativeNameLbl.Size = new System.Drawing.Size(139, 17);
            this.customerRepresentativeNameLbl.TabIndex = 29;
            this.customerRepresentativeNameLbl.Text = "Имя представителя";
            // 
            // customerNameLbl
            // 
            this.customerNameLbl.AutoSize = true;
            this.customerNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerNameLbl.Location = new System.Drawing.Point(0, 140);
            this.customerNameLbl.Name = "customerNameLbl";
            this.customerNameLbl.Size = new System.Drawing.Size(70, 17);
            this.customerNameLbl.TabIndex = 28;
            this.customerNameLbl.Text = "Заказчик";
            // 
            // bonusAmountLbl
            // 
            this.bonusAmountLbl.AutoSize = true;
            this.bonusAmountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bonusAmountLbl.Location = new System.Drawing.Point(0, 90);
            this.bonusAmountLbl.Name = "bonusAmountLbl";
            this.bonusAmountLbl.Size = new System.Drawing.Size(47, 17);
            this.bonusAmountLbl.TabIndex = 27;
            this.bonusAmountLbl.Text = "Бонус";
            // 
            // costLbl
            // 
            this.costLbl.AutoSize = true;
            this.costLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLbl.Location = new System.Drawing.Point(0, 50);
            this.costLbl.Name = "costLbl";
            this.costLbl.Size = new System.Drawing.Size(78, 17);
            this.costLbl.TabIndex = 26;
            this.costLbl.Text = "Стоимость";
            // 
            // endDateLbl
            // 
            this.endDateLbl.AutoSize = true;
            this.endDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endDateLbl.Location = new System.Drawing.Point(293, 30);
            this.endDateLbl.Name = "endDateLbl";
            this.endDateLbl.Size = new System.Drawing.Size(117, 17);
            this.endDateLbl.TabIndex = 25;
            this.endDateLbl.Text = "Дата окончания";
            // 
            // startDateLbl
            // 
            this.startDateLbl.AutoSize = true;
            this.startDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startDateLbl.Location = new System.Drawing.Point(0, 30);
            this.startDateLbl.Name = "startDateLbl";
            this.startDateLbl.Size = new System.Drawing.Size(94, 17);
            this.startDateLbl.TabIndex = 24;
            this.startDateLbl.Text = "Дата начала";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLbl.Location = new System.Drawing.Point(0, 10);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(72, 17);
            this.nameLbl.TabIndex = 23;
            this.nameLbl.Text = "Название";
            // 
            // addParticipantLbl
            // 
            this.addParticipantLbl.AutoSize = true;
            this.addParticipantLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addParticipantLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addParticipantLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.addParticipantLbl.Location = new System.Drawing.Point(410, 250);
            this.addParticipantLbl.Name = "addParticipantLbl";
            this.addParticipantLbl.Size = new System.Drawing.Size(220, 17);
            this.addParticipantLbl.TabIndex = 34;
            this.addParticipantLbl.Text = "Добавить сотрудника к проекту";
            this.addParticipantLbl.Click += new System.EventHandler(this.addParticipantLbl_Click);
            this.addParticipantLbl.MouseEnter += new System.EventHandler(this.addParticipantLbl_MouseEnter);
            this.addParticipantLbl.MouseLeave += new System.EventHandler(this.addParticipantLbl_MouseLeave);
            // 
            // ProjectAnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 594);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProjectAnalysisForm";
            this.Text = "ProjectAnalysisForm";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label customerInnLbl;
        private System.Windows.Forms.Label customerBankLbl;
        private System.Windows.Forms.Label customerPhoneLbl;
        private System.Windows.Forms.Label customerInfoLbl;
        private System.Windows.Forms.Label IdLbl;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label customerNameLbl;
        private System.Windows.Forms.Label bonusAmountLbl;
        private System.Windows.Forms.Label costLbl;
        private System.Windows.Forms.Label endDateLbl;
        private System.Windows.Forms.Label startDateLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label customerRepresentativeInfoLbl;
        private System.Windows.Forms.Label leaderNameLbl;
        private System.Windows.Forms.Label customerRepresentativePhoneLbl;
        private System.Windows.Forms.Label customerRepresentativeNameLbl;
        private System.Windows.Forms.Label customerAddressLbl;
        private System.Windows.Forms.Label addParticipantLbl;
    }
}