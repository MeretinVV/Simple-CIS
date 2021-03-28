using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using CISDocumentProcessing.Classes;

namespace CISDocumentProcessing.Forms
{
    public partial class NewEmployeeForm : Form
    {
        string photoFilePath = string.Empty;
        string dateFormat = "yyyy-MM-dd";

        public NewEmployeeForm()
        {
            InitializeComponent();
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
            string query = $"INSERT INTO employee(EName, EAddress, EDistrict, EExperience, EBirthdate, EMainLanguage, ECurrentSalary";
            if (educationTxt.Text != string.Empty) query += ", EEducation";
            if (perksTxt.Text != string.Empty) query += ", EPerks";
            if (photoFilePath != string.Empty) query += ", EPhoto";
            if (notexTxt.Text != string.Empty) query += ", ENotes";
            
            query += $") VALUES('{nameTxt.Text}', '{addressTxt.Text}', '{districtTxt.Text}', '{expNum.Value}', " +
                    $"'{birthDateDate.Value.ToString(dateFormat)}', '{mainLanguageTxt.Text}', '{salaryNum.Value}'";
            if (educationTxt.Text != string.Empty) query += $", '{educationTxt.Text}'";
            if (perksTxt.Text != string.Empty) query += $", '{perksTxt.Text}'";
            if (photoFilePath != string.Empty) query += $", x'{GetFileHexString(photoFilePath)}'";
            if (notexTxt.Text != string.Empty) query += $", '{notexTxt.Text}'";
            query += ");";

            try
            {
                Aggregator.ExecuteNonQuery(query);
                MessageBox.Show("Сотрудник успешно добавлен.");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
