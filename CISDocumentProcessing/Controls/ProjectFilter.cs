using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CISDocumentProcessing.Classes;

namespace CISDocumentProcessing.Controls
{
    public partial class ProjectFilter : UserControl
    {
        private string _dateFormat = "yyyy-MM-dd";
        public ProjectFilter()
        {
            InitializeComponent();
            PopulateEmployees();
            PopulateCustomers();
        }

        private void PopulateEmployees()
        {
            string query = "SELECT EId, EName FROM employee;";
            try
            {
                using (var reader = Aggregator.ExecuteReader(query))
                {
                    while (reader.Read())
                    {
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
            try
            {
                using (var reader = Aggregator.ExecuteReader(query))
                {
                    while (reader.Read())
                    {
                        customerBox.Items.Add(reader["CName"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при создании фильтра: {ex.Message}");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            idCheckBox.Checked = false;
            idNum.Value = 0;

            nameCheckBox.Checked = false;
            nameTxt.Text = string.Empty;

            dateCheckBox.Checked = false;
            minDate.Value = DateTime.Now;
            maxDate.Value = DateTime.Now;

            costCheckBox.Checked = false;
            costMaxNum.Value = 0;
            costMaxNum.Value = 0;

            leaderCheckBox.Checked = false;
            leaderBox.SelectedIndex = -1;

            customerCheckBox.Checked = false;
            customerBox.SelectedIndex = -1;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string filter = string.Empty;

            // Получаем WHERE выражение фильтра
            List<string> filterList = new List<string>();

            if (idCheckBox.Checked) filterList.Add($"(PId = {idNum.Value})");
            if (nameCheckBox.Checked) filterList.Add($"(LOWER(PName) LIKE '%{nameTxt.Text.ToLower()}%')");
            if (dateCheckBox.Checked) filterList.Add($"(PStartDate BETWEEN '{minDate.Value.ToString(_dateFormat)}' AND " +
                                                     $"'{maxDate.Value.ToString(_dateFormat)}')");
            if (costCheckBox.Checked) filterList.Add($"(PCost BETWEEN {costMinNum.Value} AND {costMaxNum.Value})");
            if (leaderCheckBox.Checked) filterList.Add($"(EName LIKE '%{leaderBox.SelectedItem}%')");
            if (customerCheckBox.Checked) filterList.Add($"(CName LIKE '%{customerBox.SelectedItem}%')");

            if (filterList.Count > 0) filter = "WHERE " + string.Join(" AND ", filterList);
            ((MainForm)this.Parent.Parent).ShowProjects(filter);
        }
    }
}
