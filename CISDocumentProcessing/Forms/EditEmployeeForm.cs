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
using System.IO;

namespace CISDocumentProcessing.Forms
{
    public partial class EditEmployeeForm : Form
    {
        private Employee _emp;
        private string dateFormat = "yyyy-MM-dd";
        string photoFilePath = string.Empty;

        public EditEmployeeForm()
        {
            InitializeComponent();
        }

        public Employee Emp
        {
            get { return _emp; }
            set
            {
                _emp = value;

                nameTxt.Text = _emp.Name;
                addressTxt.Text = _emp.Address;
                districtTxt.Text = _emp.District;
                expNum.Value = _emp.Experience;
                birthDateDate.Value = _emp.Birthdate;
                mainLanguageTxt.Text = _emp.MainLanguage;
                salaryNum.Value = _emp.Salary;
                educationTxt.Text = _emp.Education;
                perksTxt.Text = _emp.Perks;
                notexTxt.Text = _emp.Notes;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e) => this.Close();

        private void photoBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    photoFilePath = openFileDialog.FileName;
                    photoFileNameLbl.Text = Path.GetFileName(photoFilePath);
                }
            }
        }

        private string GetFileHexString(string filePath)
        {
            byte[] bytes = File.ReadAllBytes(filePath);
            var x = BitConverter.ToString(bytes).Replace("-", " ");
            return BitConverter.ToString(bytes).Replace("-", "");
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            // Проверяем заполнены ли все обязательные поля
            if (nameTxt.Text == string.Empty || addressTxt.Text == string.Empty ||
                districtTxt.Text == string.Empty || mainLanguageTxt.Text == string.Empty)
            {
                MessageBox.Show("Заполните все обязательные поля (отмеченные *)!");
                return;
            }

            string query = 
                $"UPDATE employee SET EName='{nameTxt.Text}', EAddress='{addressTxt.Text}', EExperience={expNum.Value}, " +
                $"EBirthDate='{birthDateDate.Value.ToString(dateFormat)}', EMainLanguage='{mainLanguageTxt.Text}', " +
                $"ECurrentSalary={salaryNum.Value}";

            if (educationTxt.Text != string.Empty) query += $", EEducation='{educationTxt.Text}'";
            if (perksTxt.Text != string.Empty) query += $", EPerks='{perksTxt.Text}'";
            if (photoFilePath != string.Empty) query += $", x'{GetFileHexString(photoFilePath)}'";
            if (notexTxt.Text != string.Empty) query += $", ENotes'{notexTxt.Text}'";
            query += $" WHERE EId={_emp.Id};";

            try
            {
                Aggregator.ExecuteNonQuery(query);
                MessageBox.Show("Сотрудник успешно изменен.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }


    }
}
