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
    public partial class EmployeePaymentListItem : UserControl
    {
        private EmployeePayment _payment;
        public EmployeePaymentListItem()
        {
            InitializeComponent();
        }

        [Category("Custom Props")]
        public EmployeePayment Payment
        {
            get { return _payment; }
            set
            {
                _payment = value;

                employeeLbl.Text = $"Получатель: {_payment.EmployeeName}";
                amountLbl.Text = $"Размер: {_payment.Amount} руб.";
                dateLbl.Text = $"Дата: {_payment.Date.ToString("dd/MM/yyyy")}";
                idLbl.Text = $"ID: {_payment.Id}";
                typeLbl.Text = _payment.PaymentType;
            }
        }

        // Перегружаем метод чтобы цвет не менялся при переходе на дочерние элементы
        protected override void OnMouseLeave(EventArgs e)
        {
            if (this.ClientRectangle.Contains(this.PointToClient(Control.MousePosition))) return;
            else base.OnMouseLeave(e);
        }
        private void EmployeePaymentListItem_MouseEnter(object sender, EventArgs e) => this.BackColor = Color.Silver;
        private void EmployeePaymentListItem_MouseLeave(object sender, EventArgs e) => this.BackColor = Color.FromKnownColor(KnownColor.Control);
        private void editLbl_MouseEnter(object sender, EventArgs e) => editLbl.ForeColor = Color.FromKnownColor(KnownColor.MenuHighlight);
        private void editLbl_MouseLeave(object sender, EventArgs e) => editLbl.ForeColor = Color.FromKnownColor(KnownColor.HotTrack);

        private void editLbl_Click(object sender, EventArgs e)
        {
            try
            {
                EditPaymentForm editForm = new EditPaymentForm();
                editForm.Payment = _payment;
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
                this.Payment = Aggregator.GetPaymentById(_payment.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
