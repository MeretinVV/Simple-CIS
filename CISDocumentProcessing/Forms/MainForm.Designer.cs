namespace CISDocumentProcessing
{
    partial class MainForm
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.addProjectBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.addPaymentBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showEmployeesBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.showProjectsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.showPaymentsBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitAccountBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.exitSystemBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.logInForm = new System.Windows.Forms.GroupBox();
            this.logInBtn = new System.Windows.Forms.Button();
            this.logInPasswordTxt = new System.Windows.Forms.TextBox();
            this.logInUserTxt = new System.Windows.Forms.TextBox();
            this.logInPasswrodLbl = new System.Windows.Forms.Label();
            this.logInUserLbl = new System.Windows.Forms.Label();
            this.logInLbl = new System.Windows.Forms.Label();
            this.showPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.titleLbl = new System.Windows.Forms.Label();
            this.sidePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mainMenuStrip.SuspendLayout();
            this.logInForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.mainMenuStrip.Enabled = false;
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(879, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeBtn,
            this.addProjectBtn,
            this.addPaymentBtn,
            this.addCustomerBtn});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.addToolStripMenuItem.Text = "Добавить";
            // 
            // addEmployeeBtn
            // 
            this.addEmployeeBtn.Name = "addEmployeeBtn";
            this.addEmployeeBtn.Size = new System.Drawing.Size(185, 22);
            this.addEmployeeBtn.Text = "Контракт о найме";
            this.addEmployeeBtn.Click += new System.EventHandler(this.addEmployeeBtn_Click);
            // 
            // addProjectBtn
            // 
            this.addProjectBtn.Name = "addProjectBtn";
            this.addProjectBtn.Size = new System.Drawing.Size(185, 22);
            this.addProjectBtn.Text = "Проектный договор";
            this.addProjectBtn.Click += new System.EventHandler(this.addProjectBtn_Click);
            // 
            // addPaymentBtn
            // 
            this.addPaymentBtn.Name = "addPaymentBtn";
            this.addPaymentBtn.Size = new System.Drawing.Size(185, 22);
            this.addPaymentBtn.Text = "Выплата";
            this.addPaymentBtn.Click += new System.EventHandler(this.addPaymentBtn_Click);
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(185, 22);
            this.addCustomerBtn.Text = "Клиент";
            this.addCustomerBtn.Click += new System.EventHandler(this.addCustomerBtn_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showEmployeesBtn,
            this.showProjectsBtn,
            this.showPaymentsBtn});
            this.showToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.showToolStripMenuItem.Text = "Просмотр";
            // 
            // showEmployeesBtn
            // 
            this.showEmployeesBtn.Name = "showEmployeesBtn";
            this.showEmployeesBtn.Size = new System.Drawing.Size(140, 22);
            this.showEmployeesBtn.Text = "Сотрудники";
            this.showEmployeesBtn.Click += new System.EventHandler(this.showEmployeesBtn_Click);
            // 
            // showProjectsBtn
            // 
            this.showProjectsBtn.Name = "showProjectsBtn";
            this.showProjectsBtn.Size = new System.Drawing.Size(140, 22);
            this.showProjectsBtn.Text = "Проекты";
            this.showProjectsBtn.Click += new System.EventHandler(this.showProjectsBtn_Click);
            // 
            // showPaymentsBtn
            // 
            this.showPaymentsBtn.Name = "showPaymentsBtn";
            this.showPaymentsBtn.Size = new System.Drawing.Size(140, 22);
            this.showPaymentsBtn.Text = "Выплаты";
            this.showPaymentsBtn.Click += new System.EventHandler(this.showPaymentsBtn_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitAccountBtn,
            this.exitSystemBtn});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.exitToolStripMenuItem.Text = "Выход";
            // 
            // exitAccountBtn
            // 
            this.exitAccountBtn.Name = "exitAccountBtn";
            this.exitAccountBtn.Size = new System.Drawing.Size(177, 22);
            this.exitAccountBtn.Text = "Из учетной записи";
            this.exitAccountBtn.Click += new System.EventHandler(this.exitAccountBtn_Click);
            // 
            // exitSystemBtn
            // 
            this.exitSystemBtn.Name = "exitSystemBtn";
            this.exitSystemBtn.Size = new System.Drawing.Size(177, 22);
            this.exitSystemBtn.Text = "Из программы";
            this.exitSystemBtn.Click += new System.EventHandler(this.exitSystemBtn_Click);
            // 
            // logInForm
            // 
            this.logInForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logInForm.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.logInForm.Controls.Add(this.logInBtn);
            this.logInForm.Controls.Add(this.logInPasswordTxt);
            this.logInForm.Controls.Add(this.logInUserTxt);
            this.logInForm.Controls.Add(this.logInPasswrodLbl);
            this.logInForm.Controls.Add(this.logInUserLbl);
            this.logInForm.Controls.Add(this.logInLbl);
            this.logInForm.Location = new System.Drawing.Point(236, 126);
            this.logInForm.Name = "logInForm";
            this.logInForm.Size = new System.Drawing.Size(406, 219);
            this.logInForm.TabIndex = 1;
            this.logInForm.TabStop = false;
            // 
            // logInBtn
            // 
            this.logInBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logInBtn.Location = new System.Drawing.Point(142, 159);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(123, 33);
            this.logInBtn.TabIndex = 5;
            this.logInBtn.Text = "Вход";
            this.logInBtn.UseVisualStyleBackColor = false;
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
            // 
            // logInPasswordTxt
            // 
            this.logInPasswordTxt.Location = new System.Drawing.Point(103, 120);
            this.logInPasswordTxt.Name = "logInPasswordTxt";
            this.logInPasswordTxt.Size = new System.Drawing.Size(230, 20);
            this.logInPasswordTxt.TabIndex = 4;
            this.logInPasswordTxt.Text = "7C4yU9W64O";
            // 
            // logInUserTxt
            // 
            this.logInUserTxt.Location = new System.Drawing.Point(103, 72);
            this.logInUserTxt.Name = "logInUserTxt";
            this.logInUserTxt.Size = new System.Drawing.Size(230, 20);
            this.logInUserTxt.TabIndex = 3;
            this.logInUserTxt.Text = "tLEtNiLFPl";
            // 
            // logInPasswrodLbl
            // 
            this.logInPasswrodLbl.AutoSize = true;
            this.logInPasswrodLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logInPasswrodLbl.Location = new System.Drawing.Point(16, 118);
            this.logInPasswrodLbl.Name = "logInPasswrodLbl";
            this.logInPasswrodLbl.Size = new System.Drawing.Size(71, 20);
            this.logInPasswrodLbl.TabIndex = 2;
            this.logInPasswrodLbl.Text = "Пароль:";
            // 
            // logInUserLbl
            // 
            this.logInUserLbl.AutoSize = true;
            this.logInUserLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logInUserLbl.Location = new System.Drawing.Point(16, 73);
            this.logInUserLbl.Name = "logInUserLbl";
            this.logInUserLbl.Size = new System.Drawing.Size(59, 20);
            this.logInUserLbl.TabIndex = 1;
            this.logInUserLbl.Text = "Логин:";
            // 
            // logInLbl
            // 
            this.logInLbl.AutoSize = true;
            this.logInLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logInLbl.Location = new System.Drawing.Point(80, 16);
            this.logInLbl.Name = "logInLbl";
            this.logInLbl.Size = new System.Drawing.Size(247, 26);
            this.logInLbl.TabIndex = 0;
            this.logInLbl.Text = "Вход в учетную запись";
            // 
            // showPanel
            // 
            this.showPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showPanel.AutoScroll = true;
            this.showPanel.Location = new System.Drawing.Point(274, 81);
            this.showPanel.Name = "showPanel";
            this.showPanel.Size = new System.Drawing.Size(593, 378);
            this.showPanel.TabIndex = 2;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleLbl.Location = new System.Drawing.Point(274, 52);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(201, 26);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Название объекта";
            this.titleLbl.Visible = false;
            // 
            // sidePanel
            // 
            this.sidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sidePanel.AutoScroll = true;
            this.sidePanel.Location = new System.Drawing.Point(12, 39);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(256, 419);
            this.sidePanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 470);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.logInForm);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.showPanel);
            this.MainMenuStrip = this.mainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(490, 340);
            this.Name = "MainForm";
            this.Text = "КИС \"Нарвское\"";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.logInForm.ResumeLayout(false);
            this.logInForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeBtn;
        private System.Windows.Forms.ToolStripMenuItem addProjectBtn;
        private System.Windows.Forms.ToolStripMenuItem addPaymentBtn;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showEmployeesBtn;
        private System.Windows.Forms.ToolStripMenuItem showProjectsBtn;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitAccountBtn;
        private System.Windows.Forms.ToolStripMenuItem exitSystemBtn;
        private System.Windows.Forms.GroupBox logInForm;
        private System.Windows.Forms.TextBox logInPasswordTxt;
        private System.Windows.Forms.TextBox logInUserTxt;
        private System.Windows.Forms.Label logInPasswrodLbl;
        private System.Windows.Forms.Label logInUserLbl;
        private System.Windows.Forms.Label logInLbl;
        private System.Windows.Forms.Button logInBtn;
        private System.Windows.Forms.FlowLayoutPanel showPanel;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.FlowLayoutPanel sidePanel;
        private System.Windows.Forms.ToolStripMenuItem showPaymentsBtn;
        private System.Windows.Forms.ToolStripMenuItem addCustomerBtn;
    }
}

