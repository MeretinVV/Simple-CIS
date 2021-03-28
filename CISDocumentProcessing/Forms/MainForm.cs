using CISDocumentProcessing.Classes;
using CISDocumentProcessing.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using CISDocumentProcessing.Controls;

namespace CISDocumentProcessing
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            OpenLogInForm();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            if (Aggregator.InitiateConnection(logInUserTxt.Text, logInPasswordTxt.Text))
            {
                logInUserTxt.Text = string.Empty;
                logInPasswordTxt.Text = string.Empty;
                logInForm.Visible = false;
                mainMenuStrip.Enabled = true;
            }
            else MessageBox.Show("Не удалось установить соеденение, проверьте введенные данные.");
        }

        private void OpenLogInForm()
        {
            mainMenuStrip.Enabled = false;
            titleLbl.Visible = false;
            showPanel.Controls.Clear();
            sidePanel.Controls.Clear();
            logInForm.Visible = true;
        }

        public void ShowEmployees(string filter = "")
        {
            showPanel.Controls.Clear();
            try
            {
                titleLbl.Text = "Сотрудники";
                foreach (Employee emp in Aggregator.GetEmployees(filter))
                {
                    // Создаем элемент списка для сотрудника
                    EmployeeListItem empItem = new EmployeeListItem();

                    empItem.Emp = emp;
                    showPanel.Controls.Add(empItem);
                }
                
                if(showPanel.Controls.Count == 0) titleLbl.Text = "Нет сотрудников";
                titleLbl.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        public void ShowPayments(string filter = "")
        {
            showPanel.Controls.Clear();
            try
            {
                titleLbl.Text = "Выплаты";
                foreach (EmployeePayment payment in Aggregator.GetPayments(filter))
                {
                    // Создаем элемент списка для выплаты
                    EmployeePaymentListItem paymentItem = new EmployeePaymentListItem();
                    paymentItem.Payment = payment;
                    showPanel.Controls.Add(paymentItem);
                }

                if (showPanel.Controls.Count == 0) titleLbl.Text = "Нет выплат";
                titleLbl.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        public void ShowProjects(string filter = "")
        {
            showPanel.Controls.Clear();
            try
            {
                foreach (Project project in Aggregator.GetProjects(filter))
                {
                    // Создаем элемент списка для проекта
                    ProjectListItem projectItem = new ProjectListItem();
                    projectItem.Project = project;
                    showPanel.Controls.Add(projectItem);
                }

                if (showPanel.Controls.Count == 0) titleLbl.Text = "Нет проектов";
                titleLbl.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private void exitAccountBtn_Click(object sender, EventArgs e) => OpenLogInForm();
        private void addEmployeeBtn_Click(object sender, EventArgs e) => new NewEmployeeForm().ShowDialog();
        private void addPaymentBtn_Click(object sender, EventArgs e) => new NewPaymentForm().ShowDialog();
        private void addCustomerBtn_Click(object sender, EventArgs e) => new NewCustomerForm().ShowDialog();
        private void addProjectBtn_Click(object sender, EventArgs e) => new NewProjectForm().ShowDialog();
        private void exitSystemBtn_Click(object sender, EventArgs e) => Environment.Exit(0);
        private void showEmployeesBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Controls.Clear();
            sidePanel.Controls.Add(new EmployeeFilter());
            
            ShowEmployees();
        }

        private void showPaymentsBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Controls.Clear();
            sidePanel.Controls.Add(new EmployeePaymentFilter());

            ShowPayments();
        }

        private void showProjectsBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Controls.Clear();
            sidePanel.Controls.Add(new ProjectFilter());

            ShowProjects();
        }
    }
}
