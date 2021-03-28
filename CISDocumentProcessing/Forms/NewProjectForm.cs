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
    public partial class NewProjectForm : Form
    {
        Dictionary<string, int> employeesIds;
        Dictionary<string, int> customersIds;
        string dateFormat = "yyyy-MM-dd";

        public NewProjectForm()
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
                $"INSERT INTO project(PName, PStartDate, PEndDate, PCost, PLeaderEId, CId, " +
                $"PCRepresentativeName, PCRepresentativePhone, PBonusAmount) " +
                $"VALUES('{nameTxt.Text}', '{startDate.Value.ToString(dateFormat)}', " +
                $"'{endDate.Value.ToString(dateFormat)}', {costNum.Value}, " +
                $"{employeesIds[(string)leaderBox.SelectedItem]}, {customersIds[(string)customerBox.SelectedItem]}, " +
                $"'{representativeNameTxt.Text}', '{representativePhoneTxt.Text}', {bonusNum.Value})";

            try
            {
                Aggregator.ExecuteNonQuery(query);

                MessageBox.Show("Проект успешно добавлен.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
