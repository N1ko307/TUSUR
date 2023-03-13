using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class ReportCredit : Form
    {
        public ReportCredit()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "BankDBDataSet.Активные_кредиты". При необходимости она может быть перемещена или удалена.
            this.Активные_кредитыTableAdapter.Fill(this.BankDBDataSet.Активные_кредиты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "BankDBDataSet.Активные_кредиты". При необходимости она может быть перемещена или удалена.
            this.Активные_кредитыTableAdapter.Fill(this.BankDBDataSet.Активные_кредиты);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
