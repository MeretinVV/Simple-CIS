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
    public partial class ProjectAnalysisForm : Form
    {
        private Project _project;
        private Customer _customer;
        private string dateFormat = "dd/MM/yyyy";
        private int heightCursor = 250;
        public ProjectAnalysisForm()
        {
            InitializeComponent();
        }
        
        public Project Project
        {
            get { return _project; }
            set
            {
                _project = value;

                this.Text = _project.Name;
                nameLbl.Text = _project.Name;
                startDateLbl.Text = $"Дата начала: {_project.StartDate.ToString(dateFormat)}";
                endDateLbl.Text = $"Дата окончания: {_project.EndDate.ToString(dateFormat)}";
                costLbl.Text = $"Стоимость: {_project.Cost} руб.";
                leaderNameLbl.Text = $"Руководитель: {_project.LeaderName}";
                IdLbl.Text = $"ID: {_project.Id}";
                bonusAmountLbl.Text = $"Бонус за своевременное исполнение (в процентах от стоимости): {_project.BonusAmount}%";
                customerRepresentativeNameLbl.Text = _project.RepresentativeName;
                customerRepresentativePhoneLbl.Text = $"Телефон: {_project.RepresentativePhone}";

                _customer = Aggregator.GetCustomerById(_project.CustomerId);

                customerNameLbl.Text = _customer.Name;
                customerAddressLbl.Text = $"Адресс: {_customer.Address}";
                customerPhoneLbl.Text = $"Телефон: {_customer.Phone}";
                customerBankLbl.Text = $"Банк: {_customer.Bank}";
                customerInnLbl.Text = $"ИНН: {_customer.Inn}";

                PopulateParticipants();
            }
        }

        private void PopulateParticipants()
        {
            //Добавляем сотрудников проекта
            Label projectParticipantsLbl = new Label();
            projectParticipantsLbl.Text = "Участники проекта:";
            projectParticipantsLbl.AutoSize = true;
            projectParticipantsLbl.Font = nameLbl.Font;
            projectParticipantsLbl.Location = new Point(0, heightCursor);
            heightCursor += 25;
            mainPanel.Controls.Add(projectParticipantsLbl);

            try
            {
                foreach (Employee emp in Aggregator.GetEmployeesByProjectId(_project.Id))
                {
                    // Создаем элемент списка для сотрудника
                    EmployeeListItem empItem = new EmployeeListItem();

                    empItem.Emp = emp;
                    empItem.Location = new Point(0, heightCursor);
                    heightCursor += empItem.Size.Height;
                    mainPanel.Controls.Add(empItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }
        private void addParticipantLbl_MouseEnter(object sender, EventArgs e) => addParticipantLbl.ForeColor = Color.FromKnownColor(KnownColor.MenuHighlight);
        private void addParticipantLbl_MouseLeave(object sender, EventArgs e) => addParticipantLbl.ForeColor = Color.FromKnownColor(KnownColor.HotTrack);

        private void addParticipantLbl_Click(object sender, EventArgs e)
        {
            AddProjectParticipantForm addParticipantForm = new AddProjectParticipantForm();
            addParticipantForm.Project = _project;
            addParticipantForm.ProjectForm = this;
            addParticipantForm.ShowDialog();
        }
        public void addNewParticipantItem(int id)
        {
            Employee emp = Aggregator.GetEmployeeById(id);
            // Создаем элемент списка для нового сотрудника
            EmployeeListItem empItem = new EmployeeListItem();

            empItem.Emp = emp;
            empItem.Location = new Point(0, heightCursor);
            heightCursor += empItem.Size.Height;
            mainPanel.Controls.Add(empItem);
        }
    }
}
