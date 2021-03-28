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
    public partial class NewCustomerForm : Form
    {
        public NewCustomerForm()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e) => this.Close();

        private void submitBtn_Click(object sender, EventArgs e)
        {
            // Проверяем заполнены ли все обязательные поля
            if (nameTxt.Text == string.Empty || phoneTxt.Text == string.Empty ||
                bankTxt.Text == string.Empty || innTxt.Text == string.Empty)
            {
                MessageBox.Show("Заполните все обязательные поля (отмеченные *)!");
                return;
            }
            string query = $"INSERT INTO customer(CName, CPhone, CBank, CInn";
            if (addressTxt.Text != string.Empty) query += ", CAddress";

            query += $") VALUES('{nameTxt.Text}', '{phoneTxt.Text}', '{bankTxt.Text}', '{innTxt.Text}'";
            if (addressTxt.Text != string.Empty) query += $", '{addressTxt.Text}'";
            query += ");";

            try
            {
                Aggregator.ExecuteNonQuery(query);
                MessageBox.Show("Клиент успешно добавлен.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
