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
    public partial class AllClients : Form
    {
        public AllClients()
        {
            InitializeComponent();
        }

        private void AllClients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "BankDBDataSet.Все_клиенты". При необходимости она может быть перемещена или удалена.
            this.Все_клиентыTableAdapter.Fill(this.BankDBDataSet.Все_клиенты);

            this.reportViewer1.RefreshReport();
        }
    }
}
