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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TableForm tableForm = new TableForm();
            tableForm.Owner = this;
            tableForm.ShowDialog();
        }

      
        private void button4_Click(object sender, EventArgs e)
        {
            ReportCredit reportCredit = new ReportCredit();
            reportCredit.Owner = this;
            reportCredit.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AllClients allClients = new AllClients();
            allClients.Owner = this;
            allClients.ShowDialog();
        }
    }
}
