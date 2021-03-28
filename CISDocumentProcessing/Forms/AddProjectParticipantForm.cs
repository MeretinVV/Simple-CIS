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
    public partial class AddProjectParticipantForm : Form
    {
        Dictionary<string, int> employeesIds;
        private Project _project;
        public ProjectAnalysisForm ProjectForm;
        public AddProjectParticipantForm()
        {
            InitializeComponent();
        }
        private void cancelBtn_Click(object sender, EventArgs e) => this.Close();
        public Project Project
        {
            get { return _project; }
            set
            {
                _project = value;
                projectLbl.Text = $"Проект: {_project.Name}";
                PopulateEmployees();
            }
        }
        private void PopulateEmployees()
        {
            employeesIds = new Dictionary<string, int>();
            string query = 
                $"SELECT EId, EName FROM employee " +
                $"WHERE EId NOT IN (" +
                $"SELECT EId FROM employee_project " +
                $"WHERE PId={_project.Id});";
            
            try
            {
                using (var reader = Aggregator.ExecuteReader(query))
                {
                    while (reader.Read())
                    {
                        employeesIds.Add((string)reader["EName"], (int)reader["EId"]);
                        employeeBox.Items.Add(reader["EName"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при создании фильтра: {ex.Message}");
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            // Проверяем заполнены ли все обязательные поля
            if (employeeBox.SelectedIndex < 0)
            {
                MessageBox.Show("Заполните все обязательные поля (отмеченные *)!");
                return;
            }
            string query =
                $"INSERT INTO employee_project(EId, PId) " +
                $"VALUES({employeesIds[(string)employeeBox.SelectedItem]}, {_project.Id});";
            try
            {
                Aggregator.ExecuteNonQuery(query);
                MessageBox.Show("Участник проекта успешно добавлен.");
                ProjectForm.addNewParticipantItem(employeesIds[(string)employeeBox.SelectedItem]);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
