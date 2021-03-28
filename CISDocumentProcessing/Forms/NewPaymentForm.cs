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
using MySql.Data.MySqlClient;

namespace CISDocumentProcessing.Forms
{
    public partial class NewPaymentForm : Form
    {
        Dictionary<string, int> employeesIds;
        string dateFormat = "yyyy-MM-dd";
        public NewPaymentForm()
        {
            InitializeComponent();
            PopulateEmployees();
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
                        employeeBox.Items.Add(reader["EName"]);
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
            if (employeeBox.SelectedIndex < 0 || amountNum.Value <= 0 || typeBox.SelectedIndex < 0)
            {
                MessageBox.Show("Заполните все обязательные поля (отмеченные *)!");
                return;
            }
            string query = $"INSERT INTO employee_payment(EPDate, EId, EPAmount, EPType) " +
                           $"VALUES('{dateDate.Value.ToString(dateFormat)}', {employeesIds[(string)employeeBox.SelectedItem]}, " +
                           $"{amountNum.Value}, '{typeBox.SelectedItem}')";
            try
            {
                Aggregator.ExecuteNonQuery(query);
                MessageBox.Show("Выплата успешно добавлена.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
