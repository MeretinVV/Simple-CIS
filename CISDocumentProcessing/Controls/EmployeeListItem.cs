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
using CISDocumentProcessing.Forms;
using System.IO;

namespace CISDocumentProcessing
{
    public partial class EmployeeListItem : UserControl
    {
        private Employee _emp;
        private string dateFormat = "dd/MM/yyyy";

        public EmployeeListItem()
        {
            InitializeComponent();
        }

        [Category("Custom Props")]
        public Employee Emp
        {
            get { return _emp; }
            set
            {
                _emp = value;

                if(_emp.Photo != null) photoBox.Image = _emp.Photo;
                nameLbl.Text = _emp.Name;
                birthdateLbl.Text = $"Дата рождения: {_emp.Birthdate.ToString(dateFormat)}";
                expLbl.Text = $"Опыт (в годах): {_emp.Experience}";
                mainLanguageLbl.Text = $"Основной язык: {_emp.MainLanguage}";
                salaryLbl.Text = $"Зарплата: {_emp.Salary} руб.";
                IdLbl.Text = $"ID: {_emp.Id}";
            }
        }

        // Перегружаем метод чтобы цвет не менялся при переходе на дочерние элементы
        protected override void OnMouseLeave(EventArgs e)
        {
            if (this.ClientRectangle.Contains(this.PointToClient(Control.MousePosition))) return;
            else base.OnMouseLeave(e);
        }
        private void EmployeeListItem_MouseEnter(object sender, EventArgs e) => this.BackColor = Color.Silver;
        private void EmployeeListItem_MouseLeave(object sender, EventArgs e) => this.BackColor = Color.FromKnownColor(KnownColor.Control);
        private void editLbl_MouseEnter(object sender, EventArgs e) => editLbl.ForeColor = Color.FromKnownColor(KnownColor.MenuHighlight);
        private void editLbl_MouseLeave(object sender, EventArgs e) => editLbl.ForeColor = Color.FromKnownColor(KnownColor.HotTrack);
        private void analysisLbl_MouseEnter(object sender, EventArgs e) => analysisLbl.ForeColor = Color.FromKnownColor(KnownColor.MenuHighlight);
        private void analysisLbl_MouseLeave(object sender, EventArgs e) => analysisLbl.ForeColor = Color.FromKnownColor(KnownColor.HotTrack);

        private void editLbl_Click(object sender, EventArgs e)
        {
            EditEmployeeForm editForm = new EditEmployeeForm();

            editForm.Emp = _emp;
            editForm.ShowDialog();
            RefreshData();
        }
        public void RefreshData()
        {
            try
            {
                this.Emp = Aggregator.GetEmployeeById(_emp.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private void analysisLbl_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeAnalysisForm analysisForm = new EmployeeAnalysisForm();

                analysisForm.Emp = _emp;
                analysisForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
