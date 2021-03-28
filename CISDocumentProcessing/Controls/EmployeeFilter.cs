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
using MySql.Data.MySqlClient;

namespace CISDocumentProcessing.Controls
{
    public partial class EmployeeFilter : UserControl
    {
        public EmployeeFilter()
        {
            InitializeComponent();
            PopulateMainLanguages();
        }

        private void PopulateMainLanguages()
        {
            string query = "SELECT DISTINCT EMainLanguage FROM employee;";
            try
            {
                using(var reader = Aggregator.ExecuteReader(query))
                {
                    while (reader.Read()) mainLanguageBox.Items.Add(reader["EMainLanguage"]);
                }
            }
            catch(Exception ex)
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

            expCheckBox.Checked = false;
            expMinNum.Value = 0;
            expMaxNum.Value = 10;

            mainLanguageCheckBox.Checked = false;
            mainLanguageBox.SelectedIndex = -1;

            salaryCheckBox.Checked = false;
            salaryMinNum.Value = 0;
            salaryMaxNum.Value = 40000;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string filter = string.Empty;

            // Получаем WHERE выражение фильтра
            List<string> filterList = new List<string>();

            if (idCheckBox.Checked) filterList.Add($"(EId = {idNum.Value})");
            if (nameCheckBox.Checked) filterList.Add($"(LOWER(EName) LIKE '%{nameTxt.Text.ToLower()}%')");
            if (expCheckBox.Checked) filterList.Add($"(EExperience BETWEEN {expMinNum.Value} AND {expMaxNum.Value})");
            if (mainLanguageCheckBox.Checked) filterList.Add($"(EMainLanguage LIKE '%{mainLanguageBox.SelectedItem}%')");
            if (salaryCheckBox.Checked) filterList.Add($"(ECurrentSalary BETWEEN {salaryMinNum.Value} AND {salaryMaxNum.Value})");

            if(filterList.Count > 0) filter = "WHERE " + string.Join(" AND ", filterList);
            ((MainForm)this.Parent.Parent).ShowEmployees(filter);
        }
    }
}
