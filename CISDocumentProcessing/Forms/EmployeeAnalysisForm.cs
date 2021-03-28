using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CISDocumentProcessing.Classes;
using CISDocumentProcessing.Controls;

namespace CISDocumentProcessing.Forms
{
    public partial class EmployeeAnalysisForm : Form
    {
        private Employee _emp;
        private string dateFormat = "dd/MM/yyyy";
        private int heightCursor = 216;
        public EmployeeAnalysisForm()
        {
            InitializeComponent();
        }

        public Employee Emp
        {
            get { return _emp; }
            set
            {
                _emp = value;

                this.Text = _emp.Name;
                if (_emp.Photo != null) photoBox.Image = _emp.Photo;
                nameLbl.Text = _emp.Name;
                birthdateLbl.Text = $"Дата рождения: {_emp.Birthdate.ToString(dateFormat)}";
                expLbl.Text = $"Опыт (в годах): {_emp.Experience}";
                mainLanguageLbl.Text = $"Основной язык: {_emp.MainLanguage}";
                salaryLbl.Text = $"Зарплата: {_emp.Salary} руб.";
                IdLbl.Text = $"ID: {_emp.Id}";
                addressLbl.Text = $"Адресс: {_emp.Address}";
                districtLbl.Text = $"Район: {_emp.District}";

                string ed = _emp.Education != string.Empty ? _emp.Education : "отсутствует";
                string perks = _emp.Perks != string.Empty ? _emp.Perks : "отсутствуют";
                string notes = _emp.Notes != string.Empty ? _emp.Notes : "отсутствуют";

                educationLbl.Text = $"Образование: {ed}";
                perksLbl.Text = $"Льготы: {perks}";
                notesLbl.Text = $"Замечания: {notes}";

                PopulateProjects();
                heightCursor += 10;
                PopulatePayments();
            }
        }
        private void PopulateProjects()
        {
            //Добавляем проекты сотрудника
            Label projectLedLbl = new Label();
            projectLedLbl.Text = "Проекты сотрудника:";
            projectLedLbl.AutoSize = true;
            projectLedLbl.Font = nameLbl.Font;
            projectLedLbl.Location = new Point(0, heightCursor);
            heightCursor += 25;
            mainPanel.Controls.Add(projectLedLbl);

            try
            {
                foreach(Project project in Aggregator.GetProjectsByEmployeeId(_emp.Id))
                {
                    // Создаем элемент списка для проекта
                    ProjectListItem projectItem = new ProjectListItem();
                    
                    projectItem.Project = project;
                    projectItem.Location = new Point(0, heightCursor);
                    heightCursor += projectItem.Size.Height;
                    mainPanel.Controls.Add(projectItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }
        private void PopulatePayments()
        {
            //Добавляем выплаты сотрудника
            Label projectLedLbl = new Label();
            projectLedLbl.Text = "Выплаты сотруднику:";
            projectLedLbl.AutoSize = true;
            projectLedLbl.Font = nameLbl.Font;
            projectLedLbl.Location = new Point(0, heightCursor);
            heightCursor += 25;
            mainPanel.Controls.Add(projectLedLbl);

            try
            {
                foreach (EmployeePayment payment in Aggregator.GetPaymentsByEmployeeId(_emp.Id))
                {
                    // Создаем элемент списка для проекта
                    EmployeePaymentListItem paymentItem = new EmployeePaymentListItem();

                    paymentItem.Payment = payment;
                    paymentItem.Location = new Point(0, heightCursor);
                    heightCursor += paymentItem.Size.Height;
                    mainPanel.Controls.Add(paymentItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
