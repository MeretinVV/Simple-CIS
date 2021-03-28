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

namespace CISDocumentProcessing.Forms
{
    public partial class EditProjectForm : Form
    {
        Dictionary<string, int> employeesIds;
        Dictionary<string, int> customersIds;
        string dateFormat = "yyyy-MM-dd";
        private Project _project;

        public EditProjectForm()
        {
            InitializeComponent();
            PopulateEmployees();
            PopulateCustomers();
        }
        private void PopulateEmployees()
        {
            string query = "SELECT EId, EName FROM employee;";
            employeesIds = new Dictionary<string, int>();
            try
            {
                using (var reader = Aggregator.ExecuteReader(query))
                {
                    while (reader.Read())
                    {
                        employeesIds.Add((string)reader["EName"], (int)reader["EId"]);
                        leaderBox.Items.Add(reader["EName"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при создании фильтра: {ex.Message}");
            }
        }

        private void PopulateCustomers()
        {
            string query = "SELECT CId, CName FROM customer;";
            customersIds = new Dictionary<string, int>();
            try
            {
                using (var reader = Aggregator.ExecuteReader(query))
                {
                    while (reader.Read())
                    {
                        customersIds.Add((string)reader["CName"], (int)reader["CId"]);
                        customerBox.Items.Add(reader["CName"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при создании фильтра: {ex.Message}");
            }
        }

        public Project Project
        {
            get { return _project; }
            set
            {
                _project = value;

                nameTxt.Text = _project.Name;
                startDate.Value = _project.StartDate;
                endDate.Value = _project.EndDate;
                costNum.Value = _project.Cost;
                leaderBox.SelectedItem = _project.LeaderName;
                customerBox.SelectedItem = _project.CustomerName;
                representativeNameTxt.Text = _project.RepresentativeName;
                representativePhoneTxt.Text = _project.RepresentativePhone;
                bonusNum.Value = _project.BonusAmount;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e) => this.Close();

        private void submitBtn_Click(object sender, EventArgs e)
        {
            // Проверяем заполнены ли все обязательные поля
            if (nameTxt.Text == string.Empty || costNum.Value <= 0 ||
                leaderBox.SelectedIndex < 0 || customerBox.SelectedIndex < 0 ||
                representativeNameTxt.Text == string.Empty || representativePhoneTxt.Text == string.Empty)
            {
                MessageBox.Show("Заполните все обязательные поля (отмеченные *)!");
                return;
            }
            string query =
                $"UPDATE project SET PName='{nameTxt.Text}', PStartDate='{startDate.Value.ToString(dateFormat)}', " +
                $"PEndDate='{endDate.Value.ToString(dateFormat)}', PCost={costNum.Value}, " +
                $"PLeaderEId={employeesIds[(string)leaderBox.SelectedItem]}, CId={customersIds[(string)customerBox.SelectedItem]}, " +
                $"PCRepresentativeName='{representativeNameTxt.Text}', PCRepresentativePhone='{representativePhoneTxt.Text}', " +
                $"PBonusAmount={bonusNum.Value} WHERE PId={_project.Id}";

            try
            {
                Aggregator.ExecuteNonQuery(query);

                MessageBox.Show("Проект успешно изменен.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
