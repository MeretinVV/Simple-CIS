using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CISDocumentProcessing.Controls
{
    public partial class EmployeePaymentFilter : UserControl
    {
        private string _dateFormat = "yyyy-MM-dd";
        public EmployeePaymentFilter()
        {
            InitializeComponent();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            idCheckBox.Checked = false;
            idNum.Value = 0;

            nameCheckBox.Checked = false;
            nameTxt.Text = string.Empty;

            amounCheckBox.Checked = false;
            amountMinNum.Value = 0;
            amountMaxNum.Value = 40000;

            typeCheckBox.Checked = false;
            typeBox.SelectedIndex = -1;

            dateCheckBox.Checked = false;
            minDate.Value = DateTime.Now;
            maxDate.Value = DateTime.Now;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string filter = string.Empty;

            // Получаем WHERE выражение фильтра
            List<string> filterList = new List<string>();

            if (idCheckBox.Checked) filterList.Add($"(EPId = {idNum.Value})");
            if (nameCheckBox.Checked) filterList.Add($"(LOWER(EName) LIKE '%{nameTxt.Text.ToLower()}%')");
            if (amounCheckBox.Checked) filterList.Add($"(EPAmount BETWEEN {amountMinNum.Value} AND {amountMaxNum.Value})");
            if (typeCheckBox.Checked) filterList.Add($"(EPType LIKE'{typeBox.SelectedItem}')");
            if (dateCheckBox.Checked) filterList.Add($"(EPDate BETWEEN '{minDate.Value.ToString(_dateFormat)}' AND " +
                                                     $"'{maxDate.Value.ToString(_dateFormat)}')");

            if (filterList.Count > 0) filter = "WHERE " + string.Join(" AND ", filterList);
            ((MainForm)this.Parent.Parent).ShowPayments(filter);
        }
    }
}
