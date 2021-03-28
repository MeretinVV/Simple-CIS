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

namespace CISDocumentProcessing.Controls
{
    public partial class ProjectListItem : UserControl
    {
        private Project _project;
        private string dateFormat = "dd/MM/yyyy";
        public ProjectListItem()
        {
            InitializeComponent();
        }

        [Category("Custom Props")]
        public Project Project
        {
            get { return _project; }
            set
            {
                _project = value;

                nameLbl.Text = _project.Name;
                startDateLbl.Text = $"Дата начала: {_project.StartDate.ToString(dateFormat)}";
                endDateLbl.Text = $"Дата начала: {_project.EndDate.ToString(dateFormat)}";
                costLbl.Text = $"Стоимость: {_project.Cost} руб.";
                leaderNameLbl.Text = $"Руководитель: {_project.LeaderName}";
                customerNameLbl.Text = $"Заказчик: {_project.CustomerName}";
                idLbl.Text = $"ID: {_project.Id}";
            }
        }

        // Перегружаем метод чтобы цвет не менялся при переходе на дочерние элементы
        protected override void OnMouseLeave(EventArgs e)
        {
            if (this.ClientRectangle.Contains(this.PointToClient(Control.MousePosition))) return;
            else base.OnMouseLeave(e);
        }
        private void ProjectListItem_MouseEnter(object sender, EventArgs e) => this.BackColor = Color.Silver;
        private void ProjectListItem_MouseLeave(object sender, EventArgs e) => this.BackColor = Color.FromKnownColor(KnownColor.Control);
        private void editLbl_MouseEnter(object sender, EventArgs e) => editLbl.ForeColor = Color.FromKnownColor(KnownColor.MenuHighlight);
        private void editLbl_MouseLeave(object sender, EventArgs e) => editLbl.ForeColor = Color.FromKnownColor(KnownColor.HotTrack);
        private void analysisLbl_MouseEnter(object sender, EventArgs e) => analysisLbl.ForeColor = Color.FromKnownColor(KnownColor.MenuHighlight);
        private void analysisLbl_MouseLeave(object sender, EventArgs e) => analysisLbl.ForeColor = Color.FromKnownColor(KnownColor.HotTrack);

        private void editLbl_Click(object sender, EventArgs e)
        {
            try
            {
                EditProjectForm editForm = new EditProjectForm();
                editForm.Project = _project;
                editForm.ShowDialog();
                RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }
        public void RefreshData()
        {
            try
            {
                this.Project = Aggregator.GetProjectById(_project.Id);
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
                ProjectAnalysisForm analysisForm = new ProjectAnalysisForm();

                analysisForm.Project = _project;
                analysisForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
