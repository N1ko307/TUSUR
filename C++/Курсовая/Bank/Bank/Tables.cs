using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Bank
{
    public partial class TableForm : Form
    {
        public static string connectString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\BankDB.mdb";
        private OleDbConnection myConnect;
        public TableForm()
        {
            InitializeComponent();
            myConnect = new OleDbConnection(connectString);
            myConnect.Open();
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Client_table_Enter(object sender, EventArgs e)
        {
            
            TypeOper_box.Text = "";
            TypeCreditBox_text.Text = "";
            TermCreditBox_text.Text = "";
            TypePayCreditBox_text.Text = "";           
           
           

            string query = "SELECT * FROM Клиент";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            dataGridView1.DataSource = db.Tables[0];

           
        }

        private void BankClient_table_Enter(object sender, EventArgs e)
        {
            TypeOper_box.Text = "";
            TypeCreditBox_text.Text = "";
            TermCreditBox_text.Text = "";
            TypePayCreditBox_text.Text = "";           
           
           
            string query = "SELECT * FROM [Банки клиента]";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            dataGridView2.DataSource = db.Tables[0];
           
        }

        private void TableForm_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            myConnect.Close();
          
            TypeOper_box.Text = "";
            TypeCreditBox_text.Text = "";
            TermCreditBox_text.Text = "";
            TypePayCreditBox_text.Text = "";           
           
           
        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void BankAccount_table_Enter(object sender, EventArgs e)
        {
            
            TypeOper_box.Text = "";
            TypeCreditBox_text.Text = "";
            TermCreditBox_text.Text = "";
            TypePayCreditBox_text.Text = "";            
           
           

            string query = "SELECT * FROM [Счета в банках]";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            dataGridView3.DataSource = db.Tables[0];
           
        }

        private void BankInfo_table_Enter(object sender, EventArgs e)
        {
           
            TypeOper_box.Text = "";
            TypeCreditBox_text.Text = "";
            TermCreditBox_text.Text = "";
            TypePayCreditBox_text.Text = "";          
           
           

            string query = "SELECT * FROM [Банк]";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            dataGridView4.DataSource = db.Tables[0];
           
        }

        private void Operation_table_Enter(object sender, EventArgs e)
        {
            
            TypeOper_box.Text = "";
            TypeCreditBox_text.Text = "";
            TermCreditBox_text.Text = "";
            TypePayCreditBox_text.Text = "";           
            
           

            string query = "SELECT * FROM [Операции]";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            dataGridView5.DataSource = db.Tables[0];
           
          


        }

        private void TypeOperation_table_Enter(object sender, EventArgs e)
        {
            
            TypeOper_box.Text = "";
            TypeCreditBox_text.Text = "";
            TermCreditBox_text.Text = "";
            TypePayCreditBox_text.Text = "";            
          
            

            string query = "SELECT * FROM [Тип операции]";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            dataGridView6.DataSource = db.Tables[0];

        }

        private void CreditReg_tabl_Enter(object sender, EventArgs e)
        {
           
            TypeOper_box.Text = "";
            TypeCreditBox_text.Text = "";
            TermCreditBox_text.Text = "";
            TypePayCreditBox_text.Text = "";           
           
            

            NumCredit_text.Text = "";
            NumAccC_text.Text = "";
            TypeCreditBox_text.Text = "";
            TermCreditBox_text.Text = "";
            TypePayCreditBox_text.Text = "";
            MoneyTake_text.Text = "";
            BackCredit_editCheck.Checked = false;

            string query = "SELECT * FROM [Предоставление кредита]";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            dataGridView7.DataSource = db.Tables[0];
        }

        private void TypeCredit_table_Enter(object sender, EventArgs e)
        {
          
            TypeOper_box.Text = "";
            TypeCreditBox_text.Text = "";
            TermCreditBox_text.Text = "";
            TypePayCreditBox_text.Text = "";            
            
            

            string query = "SELECT * FROM [Тип кредита]";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            dataGridView8.DataSource = db.Tables[0];
        }

        private void TypeCreditTerm_table_Enter(object sender, EventArgs e)
        {
            
            TypeOper_box.Text = "";
            TypeCreditBox_text.Text = "";
            TermCreditBox_text.Text = "";
            TypePayCreditBox_text.Text = "";            
           
           

            string query = "SELECT * FROM [Вид кредитного срока]";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            dataGridView9.DataSource = db.Tables[0];
        }

        private void TypePayCredit_table_Enter(object sender, EventArgs e)
        {

            
            TypeOper_box.Text = "";
            TypeCreditBox_text.Text = "";
            TermCreditBox_text.Text = "";
            TypePayCreditBox_text.Text = "";           
            
           

            string query = "SELECT * FROM [Способ погашения]";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            dataGridView10.DataSource = db.Tables[0];
        }

        private void Staff_table_Enter(object sender, EventArgs e)
        {
            
            TypeOper_box.Text = "";
            TypeCreditBox_text.Text = "";
            TermCreditBox_text.Text = "";
            TypePayCreditBox_text.Text = "";          
                       

            string query = "SELECT * FROM [Сотрудники]";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            dataGridView11.DataSource = db.Tables[0];
        }

        private void Post_table_Enter(object sender, EventArgs e)
        {
          
            TypeOper_box.Text = "";
            TypeCreditBox_text.Text = "";
            TermCreditBox_text.Text = "";
            TypePayCreditBox_text.Text = "";           
            
            
            string query = "SELECT * FROM [Должность]";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            dataGridView12.DataSource = db.Tables[0];
        }

        private void TypePayCredit_table_Leave(object sender, EventArgs e)
        {
            TypePayCredit_text.Text = "";
        }

        private void TypeCreditTerm_table_Leave(object sender, EventArgs e)
        {
            NameTypeCreditTerm_text.Text = "";
            CreditTermT_text.Text = "";

        }

        private void TypeCredit_table_Leave(object sender, EventArgs e)
        {
            NameTypeCredit_text.Text = "";
            InterRate_text.Text = "";
        }

        private void TypeOperation_table_Leave(object sender, EventArgs e)
        {
            NameOper_text.Text = "";
        }

        private void Operation_table_Leave(object sender, EventArgs e)
        {
            CodeOper_text.Text = "";
            NumAcc_text.Text = "";
            TypeOper_box.Text = "";
            DateOper_text.Value = DateTime.Now;
            MoneyOper_text.Text = "";
            Manager_box.Text = "";
           
        }

        private void BankInfo_table_Leave(object sender, EventArgs e)
        {
            CodeBankB_text.Text = "";
            BankName_text.Text = "";
            BankAdds_text.Text = "";
        }

        private void BankAccount_table_Leave(object sender, EventArgs e)
        {
            NumCount_text.Text = "";
            CodeBankC_text.Text = "";
            Money_text.Text = "";
        }

        private void BankClient_table_Leave(object sender, EventArgs e)
        {
            idbank_text.Text = "";
            codebank_text.Text = "";
            codeclient_text.Text = "";
        }

        private void Client_table_Leave(object sender, EventArgs e)
        {
            id_text.Text = "";
            surname_text.Text = "";
            name_text.Text = "";
            patr_text.Text = "";
            adds_text.Text = "";
            phone_text.Text = "";
            passport_text.Text = "";
            date_text.Value = DateTime.Now;
            check_text.Checked = false;
         
        }
        private void Staff_table_Leave(object sender, EventArgs e)
        {
            CodeStaff_text.Text = "";
            SurnameStaff_text.Text = "";
            NameStaff_text.Text = "";
            PatrStaff_text.Text = "";
            AddsStaff_text.Text = "";
            PhoneStaff_text.Text = "";
            DateStaff_text.Value = DateTime.Now;
            PostStaffBox_text.Text = "";
          
        }

        private void Post_table_Leave(object sender, EventArgs e)
        {
            PostStaff_text.Text = "";
        }

        private void TableForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDBDataSet11.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.bankDBDataSet11.Клиент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDBDataSet11.Счета_в_банках". При необходимости она может быть перемещена или удалена.
            this.счета_в_банкахTableAdapter.Fill(this.bankDBDataSet11.Счета_в_банках);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDBDataSet11.Банк". При необходимости она может быть перемещена или удалена.
            this.банкTableAdapter.Fill(this.bankDBDataSet11.Банк);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDBDataSet11.Операции". При необходимости она может быть перемещена или удалена.
            this.операцииTableAdapter1.Fill(this.bankDBDataSet11.Операции);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDBDataSet11.Тип_операции". При необходимости она может быть перемещена или удалена.
            this.тип_операцииTableAdapter1.Fill(this.bankDBDataSet11.Тип_операции);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDBDataSet11.Предоставление_кредита". При необходимости она может быть перемещена или удалена.
            this.предоставление_кредитаTableAdapter.Fill(this.bankDBDataSet11.Предоставление_кредита);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDBDataSet11.Тип_кредита". При необходимости она может быть перемещена или удалена.
            this.тип_кредитаTableAdapter1.Fill(this.bankDBDataSet11.Тип_кредита);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDBDataSet11.Вид_кредитного_срока". При необходимости она может быть перемещена или удалена.
            this.вид_кредитного_срокаTableAdapter1.Fill(this.bankDBDataSet11.Вид_кредитного_срока);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDBDataSet11.Банки_клиента". При необходимости она может быть перемещена или удалена.
            this.банки_клиентаTableAdapter.Fill(this.bankDBDataSet11.Банки_клиента);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDBDataSet11.Способ_погашения". При необходимости она может быть перемещена или удалена.
            this.способ_погашенияTableAdapter1.Fill(this.bankDBDataSet11.Способ_погашения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDBDataSet11.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter1.Fill(this.bankDBDataSet11.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDBDataSet11.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter1.Fill(this.bankDBDataSet11.Должность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDBDataSet11.Персональный_менеджр". При необходимости она может быть перемещена или удалена.
            this.персональный_менеджрTableAdapter.Fill(this.bankDBDataSet11.Персональный_менеджр);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDBDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.bankDBDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDBDataSet.Должность". При необходимости она может быть перемещена или удалена.
            this.должностьTableAdapter.Fill(this.bankDBDataSet.Должность);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDBDataSet1.Способ_погашения". При необходимости она может быть перемещена или удалена.
            this.способ_погашенияTableAdapter.Fill(this.bankDBDataSet1.Способ_погашения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDBDataSet1.Вид_кредитного_срока". При необходимости она может быть перемещена или удалена.
            this.вид_кредитного_срокаTableAdapter.Fill(this.bankDBDataSet1.Вид_кредитного_срока);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDBDataSet1.Тип_кредита". При необходимости она может быть перемещена или удалена.
            this.тип_кредитаTableAdapter.Fill(this.bankDBDataSet1.Тип_кредита);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDBDataSet.Способ_погашения". При необходимости она может быть перемещена или удалена.
            this.способ_погашенияTableAdapter.Fill(this.bankDBDataSet.Способ_погашения);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDBDataSet.Вид_кредитного_срока". При необходимости она может быть перемещена или удалена.
            this.вид_кредитного_срокаTableAdapter.Fill(this.bankDBDataSet.Вид_кредитного_срока);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDBDataSet.Тип_кредита". При необходимости она может быть перемещена или удалена.
            this.тип_кредитаTableAdapter.Fill(this.bankDBDataSet.Тип_кредита);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDBDataSet.Операции". При необходимости она может быть перемещена или удалена.
            this.операцииTableAdapter.Fill(this.bankDBDataSet.Операции);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bankDBDataSet.Тип_операции". При необходимости она может быть перемещена или удалена.
            this.тип_операцииTableAdapter.Fill(this.bankDBDataSet.Тип_операции);

           
            TypeOper_box.Text = "";
            TypeCreditBox_text.Text = "";
            TermCreditBox_text.Text = "";
            TypePayCreditBox_text.Text = "";          
           
           


        }
        private void AllTable_Enter(object sender, EventArgs e)
        {
            
            TypeOper_box.Text = "";
            TypeCreditBox_text.Text = "";
            TermCreditBox_text.Text = "";
            TypePayCreditBox_text.Text = "";            
           
           
        }

        private void Execute_bt_Click(object sender, EventArgs e)
        {
            if(Edit_rb.Checked)
            {
                int id = Convert.ToInt32(id_text.Text);
                int phone = Convert.ToInt32(phone_text.Text);
                int passport = Convert.ToInt32(passport_text.Text);
                DateTime dt = date_text.Value;
                string query = "UPDATE Клиент SET Фамилия = '" + surname_text.Text + "', Имя = '" + name_text.Text + "', Отчество = '" + patr_text.Text + "', Адрес = '" + adds_text.Text + "', [Номер телефона] = " + phone + ", Паспорт = " + passport + ", [Дата рождения] ='" + dt.ToShortDateString() + "', Задолженность = " + check_text.Checked + " WHERE Код = " + id;
                OleDbCommand command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();
                MessageBox.Show("Data update");
                query = "SELECT * FROM Клиент";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
                DataSet db = new DataSet();
                dataAdapter.Fill(db);
                dataGridView1.DataSource = db.Tables[0];
                id_text.Text = "";
                surname_text.Text = "";
                name_text.Text = "";
                patr_text.Text = "";
                adds_text.Text = "";
                phone_text.Text = "";
                passport_text.Text = "";
                date_text.Value = DateTime.Now;
                check_text.Checked = false;

            }
            if(Add_rb.Checked)
            {
                int phone = Convert.ToInt32(phone_text.Text);
                int passport = Convert.ToInt32(passport_text.Text);
                DateTime dt = date_text.Value;
                string query = "INSERT INTO Клиент (Фамилия, Имя, Отчество, Адрес, [Номер телефона], Паспорт, [Дата рождения], Задолженность) VALUES ('" + surname_text.Text + "', '" + name_text.Text + "', '" + patr_text.Text + "', '" + adds_text.Text + "', " + phone + ", " + passport + ", '" + dt.ToShortDateString() + "', " + check_text.Checked + ")";
                OleDbCommand command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Add");
                query = "SELECT * FROM Клиент";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
                DataSet db = new DataSet();
                dataAdapter.Fill(db);
                dataGridView1.DataSource = db.Tables[0];
                id_text.Text = "";
                surname_text.Text = "";
                name_text.Text = "";
                patr_text.Text = "";
                adds_text.Text = "";
                phone_text.Text = "";
                passport_text.Text = "";
                date_text.Value = DateTime.Now;
                check_text.Checked = false;

            }
            if(Delet_rb.Checked)
            {
                int id = Convert.ToInt32(id_text.Text);
                string query = "DELETE FROM Клиент WHERE Код = " + id;
                OleDbCommand command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Delete");
                query = "SELECT * FROM Клиент";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
                DataSet db = new DataSet();
                dataAdapter.Fill(db);
                dataGridView1.DataSource = db.Tables[0];
                id_text.Text = "";
                surname_text.Text = "";
                name_text.Text = "";
                patr_text.Text = "";
                adds_text.Text = "";
                phone_text.Text = "";
                passport_text.Text = "";
                date_text.Value = DateTime.Now;
                check_text.Checked = false;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_text.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            surname_text.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            name_text.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            patr_text.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            adds_text.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            phone_text.Text = dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
            passport_text.Text = dataGridView1.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
            date_text.Value = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString());
            if (dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString() == "True")
            {

                check_text.Checked = true;
            }
            else { check_text.Checked = false; }
            
       
        }

        private void id_search_TextChanged(object sender, EventArgs e)
        {
            if (id_search.Text == "")
            { (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = ""; }
            else
            {
                int id = Convert.ToInt32(id_search.Text);
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Код = " + id;
            }
        }

        private void surname_search_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Фамилия LIKE '%" + surname_search.Text + "%'";
        }

        private void name_search_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Имя LIKE '%" + name_search.Text + "%'";
        }

        private void patr_search_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Отчество LIKE '%" + patr_search.Text + "%'";
        }

        private void adds_search_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Адрес LIKE '%" + adds_search.Text + "%'";
        }

        private void phone_search_TextChanged(object sender, EventArgs e)
        {
            if (phone_search.Text == "")
            { (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = ""; }
            else
            {
                int phone = Convert.ToInt32(phone_search.Text);
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"[Номер телефона] = " + phone;
            }
        }

        private void passport_search_TextChanged(object sender, EventArgs e)
        {
            if (passport_search.Text == "")
            { (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = ""; }
            else
            {
                int passport = Convert.ToInt32(passport_search.Text);
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"[Паспорт] = " + passport;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                setting_date.Visible = true;
                
            }
            if (checkBox1.Checked == false)
            {
                setting_date.Visible = false;
                exact_r.Checked = false;
                before_r.Checked = false;
                between_r.Checked = false;
                date_enter_panel.Visible = false;
                date_search1.Value = DateTime.Now;
                date_search2.Value = DateTime.Now;
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "";

            }
        }

        private void exact_r_CheckedChanged(object sender, EventArgs e)
        {
            if (exact_r.Checked == true)
            {
                date_enter_panel.Visible = true;
                date_search1.Location = new Point(4, 30);
                date_search2.Visible = false;
            }
        }

        private void before_r_CheckedChanged(object sender, EventArgs e)
        {
            if (before_r.Checked == true)
            {
                
                date_enter_panel.Visible = true;
                date_search1.Location = new Point(4,30);
                date_search2.Visible = false;

            }
        }

        private void between_r_CheckedChanged(object sender, EventArgs e)
        {
           
            date_enter_panel.Visible = true;
            date_search1.Location = new Point(4, 13);
            date_search2.Visible = true;
        }

        private void date_search1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = date_search1.Value;

            DateTime dt1 = date_search2.Value;

            if (exact_r.Checked == true)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Дата рождения] = '{0}'", dt.ToShortDateString());
            }
            if (between_r.Checked == true)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("([Дата рождения] >= '{0}') AND ([Дата рождения] <= '{1}')", dt.ToShortDateString(), dt1.ToShortDateString());
            }

            if (before_r.Checked == true)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Дата рождения] <= '{0}'", dt.ToShortDateString());
            }
        }

        private void date_search2_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = date_search1.Value;

            DateTime dt1 = date_search2.Value;

            if (between_r.Checked == true)
            {
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("([Дата рождения] >= '{0}') AND ([Дата рождения] <= '{1}')", dt.ToShortDateString(), dt1.ToShortDateString());
            }
        }

        private void check_search_CheckedChanged(object sender, EventArgs e)
        {
            if (check_search.Checked == false)
            {
                cheked_panel.Visible = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "";
            }
            else
            {
                cheked_panel.Visible = true;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"[Задолженность] = " + true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"[Задолженность] = " + false;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idbank_text.Text = dataGridView2.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            codebank_text.Text = dataGridView2.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            codeclient_text.Text = dataGridView2.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Edit2_rb.Checked)
            {
                int id = Convert.ToInt32(idbank_text.Text);
                int bank = Convert.ToInt32(codebank_text.Text);
                int client = Convert.ToInt32(codeclient_text.Text);
                string query = "UPDATE [Банки клиента] SET [Код банка] = " + bank + ", [Код клиента] = " + client + " WHERE Код = " + id;
                OleDbCommand command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();
                MessageBox.Show("Data update");
                query = "SELECT * FROM [Банки клиента]";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
                DataSet db = new DataSet();
                dataAdapter.Fill(db);
                dataGridView2.DataSource = db.Tables[0];
                idbank_text.Text = "";
                codebank_text.Text = "";
                codeclient_text.Text = "";
                
            }
            if (Add2_rb.Checked)
            {
                int bank = Convert.ToInt32(codebank_text.Text);
                int client = Convert.ToInt32(codeclient_text.Text);
                string query = "INSERT INTO [Банки клиента] ([Код банка], [Код клиента]) VALUES (" + bank + ", " + client + ")";
                OleDbCommand command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Add");
                query = "SELECT * FROM [Банки клиента]";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
                DataSet db = new DataSet();
                dataAdapter.Fill(db);
                dataGridView2.DataSource = db.Tables[0];
                idbank_text.Text = "";
                codebank_text.Text = "";
                codeclient_text.Text = "";

            }
            if (Delet2_rb.Checked)
            {
                int id = Convert.ToInt32(idbank_text.Text);
                string query = "DELETE FROM [Банки клиента] WHERE Код = " + id;
                OleDbCommand command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Delete");
                query = "SELECT * FROM [Банки клиента]";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
                DataSet db = new DataSet();
                dataAdapter.Fill(db);
                dataGridView2.DataSource = db.Tables[0];
                idbank_text.Text = "";
                codebank_text.Text = "";
                codeclient_text.Text = "";
            }
        }

        private void Reset_bt_Click(object sender, EventArgs e)
        {
            id_search.Text = "";
            surname_search.Text = "";
            name_search.Text = "";
            patr_search.Text = "";
            adds_search.Text = "";
            phone_search.Text = "";
            passport_search.Text = "";
            checkBox1.Checked = false;
            check_search.Checked = false;
        }

        private void idbank_search_TextChanged(object sender, EventArgs e)
        {
            if (idbank_search.Text == "")
            { (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = ""; }
            else
            {
                int id = Convert.ToInt32(idbank_search.Text);
                (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = $"Код = " + id;
            }
        }

        private void CodeBank_search_TextChanged(object sender, EventArgs e)
        {
            if (CodeBank_search.Text == "")
            { (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = ""; }
            else
            {
                int id = Convert.ToInt32(idbank_search.Text);
                (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = $"[Код банка] = " + id;
            }
        }

        private void CodeClient_search_TextChanged(object sender, EventArgs e)
        {
            if (CodeClient_search.Text == "")
            { (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = ""; }
            else
            {
                int id = Convert.ToInt32(idbank_search.Text);
                (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = $"[Код клиента] = " + id;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            idbank_search.Text = "";
            CodeBank_search.Text = "";
            CodeClient_search.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Edit3_rb.Checked)
            {
                int id = Convert.ToInt32(NumCount_text.Text);
                int bank = Convert.ToInt32(CodeBankC_text.Text);
                int money = Convert.ToInt32(Money_text.Text);
                string query = "UPDATE [Счета в банках] SET [Код банка] = " + bank + ", [Сумма] = " + money + " WHERE [Номер счета] = " + id;
                OleDbCommand command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();
                MessageBox.Show("Data update");
                query = "SELECT * FROM [Счета в банках]";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
                DataSet db = new DataSet();
                dataAdapter.Fill(db);
                dataGridView3.DataSource = db.Tables[0];
                NumCount_text.Text = "";
                CodeBankC_text.Text = "";
                Money_text.Text = "";

            }
            if (Add3_rb.Checked)
            {
                int bank = Convert.ToInt32(CodeBankC_text.Text);
                int money = Convert.ToInt32(Money_text.Text);
                string query = "INSERT INTO [Счета в банках] ([Код банка], [Сумма]) VALUES (" + bank + ", " + money + ")";
                OleDbCommand command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Add");
                query = "SELECT * FROM [Счета в банках]";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
                DataSet db = new DataSet();
                dataAdapter.Fill(db);
                dataGridView3.DataSource = db.Tables[0];
                NumCount_text.Text = "";
                CodeBankC_text.Text = "";
                Money_text.Text = "";

            }
            if (Delet3_rb.Checked)
            {
                int id = Convert.ToInt32(NumCount_text.Text);
                string query = "DELETE FROM [Счета в банках] WHERE [Номер счета] = " + id;
                OleDbCommand command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Delete");
                query = "SELECT * FROM [Счета в банках]";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
                DataSet db = new DataSet();
                dataAdapter.Fill(db);
                dataGridView3.DataSource = db.Tables[0];
                NumCount_text.Text = "";
                CodeBankC_text.Text = "";
                Money_text.Text = "";
            }
        }

        private void NumCount_search_TextChanged(object sender, EventArgs e)
        {
            if (NumCount_search.Text == "")
            { (dataGridView3.DataSource as DataTable).DefaultView.RowFilter = ""; }
            else
            {
                int id = Convert.ToInt32(NumCount_search.Text);
                (dataGridView3.DataSource as DataTable).DefaultView.RowFilter = $"[Номер счета] = " + id;
            }
        }

        private void CodeBankC_search_TextChanged(object sender, EventArgs e)
        {
            if (CodeBankC_search.Text == "")
            { (dataGridView3.DataSource as DataTable).DefaultView.RowFilter = ""; }
            else
            {
                int codeBank = Convert.ToInt32(CodeBankC_search.Text);
                (dataGridView3.DataSource as DataTable).DefaultView.RowFilter = $"[Код банка] = " + codeBank;
            }
        }

        private void Money_search_TextChanged(object sender, EventArgs e)
        {
            if (Money_search.Text == "")
            { (dataGridView3.DataSource as DataTable).DefaultView.RowFilter = ""; }
            else
            {
                int money = Convert.ToInt32(Money_search.Text);
                (dataGridView3.DataSource as DataTable).DefaultView.RowFilter = $"[Сумма] = " + money;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NumCount_search.Text = "";
            CodeBankC_search.Text = "";
            Money_search.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Edit4_rb.Checked)
            {
                int id = Convert.ToInt32(CodeBankB_text.Text);
                string query = "UPDATE [Банк] SET [Наименование] = '" + BankName_text.Text + "', [Юридический адрес] = '" + BankAdds_text.Text + "' WHERE [Код банка] = " + id;
                OleDbCommand command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();
                MessageBox.Show("Data update");
                query = "SELECT * FROM [Банк]";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
                DataSet db = new DataSet();
                dataAdapter.Fill(db);
                dataGridView4.DataSource = db.Tables[0];
                CodeBankB_text.Text = "";
                BankName_text.Text = "";
                BankAdds_text.Text = "";

            }
            if (Add4_rb.Checked)
            {
               
                string query = "INSERT INTO [Банк] ([Наименование], [Юридический адрес]) VALUES ('" + BankName_text.Text + "', '" + BankAdds_text.Text + "')";
                OleDbCommand command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Add");
                query = "SELECT * FROM [Банк]";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
                DataSet db = new DataSet();
                dataAdapter.Fill(db);
                dataGridView4.DataSource = db.Tables[0];
                CodeBankB_text.Text = "";
                BankName_text.Text = "";
                BankAdds_text.Text = "";

            }
            if (Delet4_rb.Checked)
            {
                int id = Convert.ToInt32(CodeBankB_text.Text);
                string query = "DELETE FROM [Банк] WHERE [Код банка] = " + id;
                OleDbCommand command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Delete");
                query = "SELECT * FROM [Банк]";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
                DataSet db = new DataSet();
                dataAdapter.Fill(db);
                dataGridView4.DataSource = db.Tables[0];
                CodeBankB_text.Text = "";
                BankName_text.Text = "";
                BankAdds_text.Text = "";
            }
        }

        private void CodeBankB_search_TextChanged(object sender, EventArgs e)
        {
            if (CodeBankB_search.Text == "")
            { (dataGridView4.DataSource as DataTable).DefaultView.RowFilter = ""; }
            else
            {
                int id = Convert.ToInt32(CodeBankB_search.Text);
                (dataGridView4.DataSource as DataTable).DefaultView.RowFilter = $"[Код банка] = " + id;
            }
        }

        private void BankName_search_TextChanged(object sender, EventArgs e)
        {
            (dataGridView4.DataSource as DataTable).DefaultView.RowFilter = $"[Наименование] LIKE '%" + BankName_search.Text + "%'";
        }

        private void BankAdds_search_TextChanged(object sender, EventArgs e)
        {
            (dataGridView4.DataSource as DataTable).DefaultView.RowFilter = $"[Юридический адрес] LIKE '%" + BankAdds_search.Text + "%'";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CodeBankB_search.Text = "";
            BankName_search.Text = "";
            BankAdds_search.Text = "";
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NumCount_text.Text = dataGridView3.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            CodeBankC_text.Text = dataGridView3.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            Money_text.Text = dataGridView3.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CodeBankB_text.Text = dataGridView4.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            BankName_text.Text = dataGridView4.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            BankAdds_text.Text = dataGridView4.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Edit5_rb.Checked)
            {
                int id = Convert.ToInt32(CodeOper_text.Text);
                int money = Convert.ToInt32(MoneyOper_text.Text);
                int num = Convert.ToInt32(NumAcc_text.Text);
                int manager = Convert.ToInt32(Manager_box.Text);
                DateTime dt = DateOper_text.Value;
                string query = "UPDATE [Операции] SET [Номер счета] = " + num + ", [Тип операции] = '" + TypeOper_box.Text + "', [Дата] = '" + dt.ToShortDateString() + "', [Сумма] = " + money + ", [Менеджер] = " + manager + " WHERE [Код операции] = " + id;
                OleDbCommand command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();
                MessageBox.Show("Data update");
                query = "SELECT * FROM [Операции]";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
                DataSet db = new DataSet();
                dataAdapter.Fill(db);
                dataGridView5.DataSource = db.Tables[0];
                CodeOper_text.Text = "";
                NumAcc_text.Text = "";
                TypeOper_box.Text = "";
                DateOper_text.Value = DateTime.Now;
                MoneyOper_text.Text = "";
                Manager_box.Text = "";

            }
            if (Add5_rb.Checked)
            {
                int money = Convert.ToInt32(MoneyOper_text.Text);
                int num = Convert.ToInt32(NumAcc_text.Text);
                int manager = Convert.ToInt32(Manager_box.Text);
                DateTime dt = DateOper_text.Value;
                string query = "INSERT INTO [Операции] ([Номер счета], [Тип операции], Дата, Сумма, Менеджер) VALUES (" + num + ", '" + TypeOper_box.Text + "', '" + dt.ToShortDateString() + "', " + money + "," + manager + ")";
                OleDbCommand command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Add");
                query = "SELECT * FROM [Операции]";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
                DataSet db = new DataSet();
                dataAdapter.Fill(db);
                dataGridView5.DataSource = db.Tables[0];
                CodeOper_text.Text = "";
                NumAcc_text.Text = "";
                TypeOper_box.Text = "";
                DateOper_text.Value = DateTime.Now;
                MoneyOper_text.Text = "";
                Manager_box.Text = "";
            }
            if (Delet5_rb.Checked)
            {
                int id = Convert.ToInt32(CodeOper_text.Text);
                string query = "DELETE FROM [Операции] WHERE [Код операции] = " + id;
                OleDbCommand command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Delete");
                query = "SELECT * FROM [Операции]";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
                DataSet db = new DataSet();
                dataAdapter.Fill(db);
                dataGridView5.DataSource = db.Tables[0];
                CodeOper_text.Text = "";
                NumAcc_text.Text = "";
                TypeOper_box.Text = "";
                DateOper_text.Value = DateTime.Now;
                MoneyOper_text.Text = "";
                Manager_box.Text = "";
            }
        }
        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CodeOper_text.Text = dataGridView5.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            NumAcc_text.Text = dataGridView5.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            TypeOper_box.Text = dataGridView5.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            DateOper_text.Value = DateTime.Parse(dataGridView5.Rows[e.RowIndex].Cells[3].Value.ToString());
            MoneyOper_text.Text = dataGridView5.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            Manager_box.Text = dataGridView5.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();

        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                setting_date1.Visible = true;

            }
            if (checkBox2.Checked == false)
            {
                setting_date1.Visible = false;
                exact_r1.Checked = false;
                before_r1.Checked = false;
                between_r1.Checked = false;
                date_enter_panel1.Visible = false;
                date_search3.Value = DateTime.Now;
                date_search4.Value = DateTime.Now;
                (dataGridView5.DataSource as DataTable).DefaultView.RowFilter = "";

            }
        }

        private void exact_r1_CheckedChanged(object sender, EventArgs e)
        {
            if (exact_r1.Checked == true)
            {
                date_enter_panel1.Visible = true;
                date_search3.Location = new Point(4, 30);
                date_search4.Visible = false;
            }
        }

        private void before_r1_CheckedChanged(object sender, EventArgs e)
        {
            if (before_r1.Checked == true)
            {

                date_enter_panel1.Visible = true;
                date_search3.Location = new Point(4, 30);
                date_search4.Visible = false;

            }
        }

        private void between_r1_CheckedChanged(object sender, EventArgs e)
        {
            date_enter_panel1.Visible = true;
            date_search3.Location = new Point(4, 13);
            date_search4.Visible = true;
        }

        private void date_search3_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = date_search3.Value;

            DateTime dt1 = date_search4.Value;

            if (exact_r1.Checked == true)
            {
                (dataGridView5.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Дата] = '{0}'", dt.ToShortDateString());
            }
            if (between_r1.Checked == true)
            {
                (dataGridView5.DataSource as DataTable).DefaultView.RowFilter = string.Format("([Дата] >= '{0}') AND ([Дата] <= '{1}')", dt.ToShortDateString(), dt1.ToShortDateString());
            }

            if (before_r1.Checked == true)
            {
                (dataGridView5.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Дата] <= '{0}'", dt.ToShortDateString());
            }
        }

        private void date_search4_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = date_search3.Value;

            DateTime dt1 = date_search4.Value;

            if (between_r1.Checked == true)
            {
                (dataGridView5.DataSource as DataTable).DefaultView.RowFilter = string.Format("([Дата] >= '{0}') AND ([Дата] <= '{1}')", dt.ToShortDateString(), dt1.ToShortDateString());
            }
        }

        private void CodeOper_search_TextChanged(object sender, EventArgs e)
        {
            if (CodeOper_search.Text == "")
            { (dataGridView5.DataSource as DataTable).DefaultView.RowFilter = ""; }
            else
            {
                int id = Convert.ToInt32(CodeOper_search.Text);
                (dataGridView5.DataSource as DataTable).DefaultView.RowFilter = $"[Код операции] = " + id;
            }
        }

        private void NumAcc_search_TextChanged(object sender, EventArgs e)
        {
            if (NumAcc_search.Text == "")
            { (dataGridView5.DataSource as DataTable).DefaultView.RowFilter = ""; }
            else
            {
                int id = Convert.ToInt32(NumAcc_search.Text);
                (dataGridView5.DataSource as DataTable).DefaultView.RowFilter = $"[Номер счета] = " + id;
            }
        }
        private void TypeOper_search_TextChanged(object sender, EventArgs e)
        {
            (dataGridView5.DataSource as DataTable).DefaultView.RowFilter = $"[Тип операции] LIKE  '%" + TypeOper_search.Text + "%'";
        }

      
        private void MoneyOper_search_TextChanged(object sender, EventArgs e)
        {
            if (MoneyOper_search.Text == "")
            { (dataGridView5.DataSource as DataTable).DefaultView.RowFilter = ""; }
            else
            {
                int money = Convert.ToInt32(MoneyOper_search.Text);
                (dataGridView5.DataSource as DataTable).DefaultView.RowFilter = $"[Сумма] = " + money;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CodeOper_search.Text = "";
            NumAcc_search.Text = "";
            TypeOper_search.Text = "";
            checkBox2.Checked = false;
            MoneyOper_search.Text = "";
            NumbManager_search.Text = "";
        }
       

        private void dataGridView6_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NameOper_text.Text = dataGridView6.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
            if (Add6_rb.Checked)
            {               
                string query = "INSERT INTO [Тип операции] ([Наименование]) VALUES ('" + NameOper_text.Text + "')";
                OleDbCommand command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Add");
                query = "SELECT * FROM [Тип операции]";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
                DataSet db = new DataSet();
                dataAdapter.Fill(db);
                dataGridView6.DataSource = db.Tables[0];
                NameOper_text.Text = "";
               

            }
            if (Delet6_rb.Checked)
            {
                int id = Convert.ToInt32(CodeOper_text.Text);
                string query = "DELETE FROM [Тип операции] WHERE [Наименование] = '" + NameOper_text.Text + "'";
                OleDbCommand command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Delete");
                query = "SELECT * FROM [Тип операции]";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
                DataSet db = new DataSet();
                dataAdapter.Fill(db);
                dataGridView6.DataSource = db.Tables[0];
                NameOper_text.Text = "";
            }
        }

        private void NameOper_search_TextChanged(object sender, EventArgs e)
        {
            (dataGridView6.DataSource as DataTable).DefaultView.RowFilter = $"[Наименование] LIKE  '%" + NameOper_search.Text + "%'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IdOper_search.Text = "";
            NameOper_search.Text = "";
        }
        private void CreditReg_tabl_Leave(object sender, EventArgs e)
        {                      
            
            NumCredit_text.Text = "";
            NumAccC_text.Text = "";
            TypeCreditBox_text.Text = "";
            TermCreditBox_text.Text = "";
            TypePayCreditBox_text.Text = "";
            MoneyTake_text.Text = "";
            BackCredit_editCheck.Checked = false;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            if (Edit7_rb.Checked)
            {
                int id = Convert.ToInt32(NumCredit_text.Text);
                int money = Convert.ToInt32(MoneyTake_text.Text);
                int num = Convert.ToInt32(NumAccC_text.Text);                
                string query = "UPDATE [Предоставление кредита] SET [Номер счет] = " + num + ", [Тип кредита] = '" + TypeCreditBox_text.Text + "', [Срок кредита] = '" + TermCreditBox_text.Text + "', [Способ погашения] = '" + TypePayCreditBox_text.Text + "', [Сумма получения] = " + money + ", [Отметка о возврате] = " + BackCredit_editCheck.Checked + " WHERE [Номер кредита] = " + id;
                OleDbCommand command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();
                MessageBox.Show("Data update");
                query = "SELECT * FROM [Предоставление кредита]";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
                DataSet db = new DataSet();
                dataAdapter.Fill(db);
                dataGridView7.DataSource = db.Tables[0];
                NumCredit_text.Text = "";
                NumAccC_text.Text = "";
                TypeCreditBox_text.Text = "";
                TermCreditBox_text.Text = "";
                TypePayCreditBox_text.Text = "";
                MoneyTake_text.Text = "";
                BackCredit_editCheck.Checked = false;

            }
            if (Add7_rb.Checked)
            {
                int money = Convert.ToInt32(MoneyTake_text.Text);
                int num = Convert.ToInt32(NumAccC_text.Text);
                
                string query = "INSERT INTO [Предоставление кредита] ([Номер счет], [Тип кредита], [Срок кредита], [Способ погашения], [Сумма получения], [Отметка о возврате]) VALUES (" + num + ", '" + TypeCreditBox_text.Text + "', '" + TermCreditBox_text.Text + "', '" + TypePayCreditBox_text.Text + "', " + money + ", " + BackCredit_editCheck.Checked + ")";
                OleDbCommand command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Add");
                query = "SELECT * FROM [Предоставление кредита]";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
                DataSet db = new DataSet();
                dataAdapter.Fill(db);
                dataGridView7.DataSource = db.Tables[0];
                NumCredit_text.Text = "";
                NumAccC_text.Text = "";
                TypeCreditBox_text.Text = "";
                TermCreditBox_text.Text = "";
                TypePayCreditBox_text.Text = "";
                MoneyTake_text.Text = "";
                BackCredit_editCheck.Checked = false;
            }
            if (Delet7_rb.Checked)
            {
                int id = Convert.ToInt32(NumCredit_text.Text);
                string query = "DELETE FROM [Предоставление кредита] WHERE [Номер кредита] = " + id;
                OleDbCommand command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Delete");
                query = "SELECT * FROM [Предоставление кредита]";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
                DataSet db = new DataSet();
                dataAdapter.Fill(db);
                dataGridView7.DataSource = db.Tables[0];
                NumCredit_text.Text = "";
                NumAccC_text.Text = "";
                TypeCreditBox_text.Text = "";
                TermCreditBox_text.Text = "";
                TypePayCreditBox_text.Text = "";
                MoneyTake_text.Text = "";
                BackCredit_editCheck.Checked = false;
            }
        }

        private void dataGridView7_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NumCredit_text.Text = dataGridView7.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            NumAccC_text.Text = dataGridView7.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            TypeCreditBox_text.Text = dataGridView7.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            TermCreditBox_text.Text = dataGridView7.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            TypePayCreditBox_text.Text = dataGridView7.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            MoneyTake_text.Text = dataGridView7.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
            if (dataGridView7.Rows[e.RowIndex].Cells[6].Value.ToString() == "True")
            {

                BackCredit_editCheck.Checked = true;
            }
            else { BackCredit_editCheck.Checked = false; }
        }

        private void NumCredit_search_TextChanged(object sender, EventArgs e)
        {
            if (NumCredit_search.Text == "")
            { (dataGridView7.DataSource as DataTable).DefaultView.RowFilter = ""; }
            else
            {
                int id = Convert.ToInt32(NumCredit_search.Text);
                (dataGridView7.DataSource as DataTable).DefaultView.RowFilter = $"[Номер кредита] = " + id;
            }
        }

        private void NumAccC_search_TextChanged(object sender, EventArgs e)
        {
            if (NumAccC_search.Text == "")
            { (dataGridView7.DataSource as DataTable).DefaultView.RowFilter = ""; }
            else
            {
                int numacc = Convert.ToInt32(NumAccC_search.Text);
                (dataGridView7.DataSource as DataTable).DefaultView.RowFilter = $"[Номер счет] = " + numacc;
            }
        }

        private void TypeCredit_search_TextChanged(object sender, EventArgs e)
        {
            (dataGridView7.DataSource as DataTable).DefaultView.RowFilter = $"[Тип кредита] LIKE '%" + TypeCredit_search.Text + "%'";
        }
        private void TermCredit_search_TextChanged(object sender, EventArgs e)
        {
            (dataGridView7.DataSource as DataTable).DefaultView.RowFilter = $"[Срок кредита] LIKE '%" + TermCredit_search.Text + "%'";
        }
        private void TyperPayCredit_serach_TextChanged(object sender, EventArgs e)
        {
            (dataGridView7.DataSource as DataTable).DefaultView.RowFilter = $"[Способ погашения] LIKE '%" + TyperPayCredit_serach.Text + "%'";
        }

      

        private void MoneyTake_search_TextChanged(object sender, EventArgs e)
        {
            if (MoneyTake_search.Text == "")
            { (dataGridView7.DataSource as DataTable).DefaultView.RowFilter = ""; }
            else
            {
                int money = Convert.ToInt32(MoneyTake_search.Text);
                (dataGridView7.DataSource as DataTable).DefaultView.RowFilter = $"[Сумма получения] = " + money;
            }
        }

        private void BackCredit_check_CheckedChanged(object sender, EventArgs e)
        {
            if (BackCredit_check.Checked == false)
            {
                chek_panel1.Visible = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;
                (dataGridView7.DataSource as DataTable).DefaultView.RowFilter = "";
            }
            else
            {
                chek_panel1.Visible = true;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            (dataGridView7.DataSource as DataTable).DefaultView.RowFilter = $"[Отметка о возврате] = " + true;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            (dataGridView7.DataSource as DataTable).DefaultView.RowFilter = $"[Отметка о возврате] = " + false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            NumCredit_search.Text = "";
            NumAccC_search.Text = "";
            TermCredit_search.Text = "";
            TyperPayCredit_serach.Text = "";
            MoneyTake_search.Text = "";
            TypeCredit_search.Text = "";
            BackCredit_check.Checked = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (Edit8_rb.Checked)
            {
                int prec = Convert.ToInt32(InterRate_text.Text);                   
                string query = "UPDATE [Тип кредита] SET [Процентная ставка] = " + prec + " WHERE [Наименование] = '" + NameTypeCredit_text.Text + "'";
                OleDbCommand command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();
                MessageBox.Show("Data update");
                query = "SELECT * FROM [Тип кредита]";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
                DataSet db = new DataSet();
                dataAdapter.Fill(db);
                dataGridView8.DataSource = db.Tables[0];
                NameTypeCredit_text.Text = "";
                InterRate_text.Text = "";
                

            }
            if (Add8_rb.Checked)
            {
                int prec = Convert.ToInt32(InterRate_text.Text);
                string query = "INSERT INTO [Тип кредит] ([Процентная ставка]) VALUES (" + prec;
                OleDbCommand command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Add");
                query = "SELECT * FROM [Тип кредита]";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
                DataSet db = new DataSet();
                dataAdapter.Fill(db);
                dataGridView8.DataSource = db.Tables[0];
                NameTypeCredit_text.Text = "";
                InterRate_text.Text = "";
            }
            if (Delet8_rb.Checked)
            {
                string query = "DELETE FROM [Тип кредит] WHERE [Наименование] = '" + NameTypeCredit_text.Text + "'";
                OleDbCommand command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Delete");
                query = "SELECT * FROM [Тип кредита]";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
                DataSet db = new DataSet();
                dataAdapter.Fill(db);
                dataGridView8.DataSource = db.Tables[0];
                NameTypeCredit_text.Text = "";
                InterRate_text.Text = "";
            }
        }

        private void dataGridView8_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NameTypeCredit_text.Text = dataGridView8.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            InterRate_text.Text = dataGridView8.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
        }

        private void NameTypeCredit_search_TextChanged(object sender, EventArgs e)
        {
            (dataGridView8.DataSource as DataTable).DefaultView.RowFilter = $"[Наименование] LIKE '%" + NameTypeCredit_search.Text + "%'";
        }

        private void InterRate_search_TextChanged(object sender, EventArgs e)
        {
            if (InterRate_search.Text == "")
            { (dataGridView8.DataSource as DataTable).DefaultView.RowFilter = ""; }
            else
            {
                int prec = Convert.ToInt32(InterRate_search.Text);
                (dataGridView8.DataSource as DataTable).DefaultView.RowFilter = $"[Процентная ставка] = " + prec;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            IdTypeCredit_search.Text = "";
            NameTypeCredit_search.Text = "";
            InterRate_search.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (Edit9_rb.Checked)
            {
                
                string query = "UPDATE [Вид кредитного срока] SET [Срок] = '" + CreditTermT_text.Text + "' WHERE [Наименование] = '" + NameTypeCreditTerm_text.Text + "'";
                OleDbCommand command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();
                MessageBox.Show("Data update");
                query = "SELECT * FROM [Вид кредитного срока]";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
                DataSet db = new DataSet();
                dataAdapter.Fill(db);
                dataGridView9.DataSource = db.Tables[0];
                NameTypeCreditTerm_text.Text = "";
                CreditTermT_text.Text = "";


            }
            if (Add9_rb.Checked)
            {
                int prec = Convert.ToInt32(InterRate_text.Text);
                string query = "INSERT INTO [Вид кредитного срока] ([Срок]) VALUES ('" + CreditTermT_text + "')";
                OleDbCommand command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Add");
                query = "SELECT * FROM [Вид кредитного срока]";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
                DataSet db = new DataSet();
                dataAdapter.Fill(db);
                dataGridView9.DataSource = db.Tables[0];
                NameTypeCreditTerm_text.Text = "";
                CreditTermT_text.Text = "";
            }
            if (Delet9_rb.Checked)
            {
                string query = "DELETE FROM [Вид кредитного срокат] WHERE [Наименование] = '" + NameTypeCreditTerm_text.Text + "'";
                OleDbCommand command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Delete");
                query = "SELECT * FROM [Вид кредитного срока]";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
                DataSet db = new DataSet();
                dataAdapter.Fill(db);
                dataGridView9.DataSource = db.Tables[0];
                NameTypeCreditTerm_text.Text = "";
                CreditTermT_text.Text = "";
            }
        }

        private void dataGridView9_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NameTypeCreditTerm_text.Text = dataGridView9.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            CreditTermT_text.Text = dataGridView9.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
        }

        private void NameTypeCreditTerm_search_TextChanged(object sender, EventArgs e)
        {
            (dataGridView9.DataSource as DataTable).DefaultView.RowFilter = $"[Наименование] LIKE '%" + NameTypeCreditTerm_search.Text + "%'";
        }

        private void CreditTermT_search_TextChanged(object sender, EventArgs e)
        {
            (dataGridView9.DataSource as DataTable).DefaultView.RowFilter = $"[Срок] LIKE '%" + CreditTermT_search.Text + "%'";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Id_NameTypeCreditTerm_search.Text = "";
            NameTypeCreditTerm_search.Text = "";
            CreditTermT_search.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (Add10_rb.Checked)
            {
               
                string query = "INSERT INTO [Способ погашения] ([Наименование]) VALUES ('" + TypePayCredit_text.Text + "')";
                OleDbCommand command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Add");
                query = "SELECT * FROM [Способ погашения]";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
                DataSet db = new DataSet();
                dataAdapter.Fill(db);
                dataGridView10.DataSource = db.Tables[0];
                TypePayCredit_text.Text = "";
                
            }
            if (Delet10_rb.Checked)
            {
                string query = "DELETE FROM [Способ погашения] WHERE [Наименование] = '" + TypePayCredit_text.Text + "'";
                OleDbCommand command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Delete");
                query = "SELECT * FROM [Способ погашения]";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
                DataSet db = new DataSet();
                dataAdapter.Fill(db);
                dataGridView10.DataSource = db.Tables[0];
                TypePayCredit_text.Text = "";
            }
        }

        private void TypePayCredit_search_TextChanged(object sender, EventArgs e)
        {
            (dataGridView10.DataSource as DataTable).DefaultView.RowFilter = $"[Наименование] LIKE '%" + TypePayCredit_search.Text + "%'";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            TypePayCredit_search.Text = "";
            Id_TypePayCredit_search.Text = "";
        }

        private void dataGridView10_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TypePayCredit_text.Text = dataGridView10.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (Edit11_rb.Checked)
            {
                int id = Convert.ToInt32(CodeStaff_text.Text);
                int phone = Convert.ToInt32(PhoneStaff_text.Text);
                DateTime dt = DateStaff_text.Value;
                string query = "UPDATE Сотрудники SET Фамилия = '" + SurnameStaff_text.Text + "', Имя = '" + NameStaff_text.Text + "', Отчество = '" + PatrStaff_text.Text + "', Адрес = '" + AddsStaff_text.Text + "', [Дата рождения] ='" + dt.ToShortDateString() + "', [Номер телефона] = " + phone + ", Должность = '" + PostStaffBox_text.Text + "' WHERE Код = " + id;
                OleDbCommand command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();
                MessageBox.Show("Data update");
                query = "SELECT * FROM Сотрудники";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
                DataSet db = new DataSet();
                dataAdapter.Fill(db);
                dataGridView11.DataSource = db.Tables[0];
                CodeStaff_text.Text = "";
                SurnameStaff_text.Text = "";
                NameStaff_text.Text = "";
                PatrStaff_text.Text = "";
                AddsStaff_text.Text = "";
                PhoneStaff_text.Text = "";                
                DateStaff_text.Value = DateTime.Now;
                PostStaffBox_text.Text = "";

            }
            if (Add11_rb.Checked)
            {
                int phone = Convert.ToInt32(PhoneStaff_text.Text);
                DateTime dt = DateStaff_text.Value;
                string query = "INSERT INTO Сотрудники (Фамилия, Имя, Отчество, Адрес, [Дата рождения], [Номер телефона], Должность) VALUES ('" + SurnameStaff_text.Text + "', '" + NameStaff_text.Text + "', '" + PatrStaff_text.Text + "', '" + AddsStaff_text.Text + "', '" + dt.ToShortDateString() + "', " + phone + ",  '" + PostStaffBox_text.Text + "')";
                OleDbCommand command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Add");
                query = "SELECT * FROM Сотрудники";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
                DataSet db = new DataSet();
                dataAdapter.Fill(db);
                dataGridView11.DataSource = db.Tables[0];
                CodeStaff_text.Text = "";
                SurnameStaff_text.Text = "";
                NameStaff_text.Text = "";
                PatrStaff_text.Text = "";
                AddsStaff_text.Text = "";
                PhoneStaff_text.Text = "";
                DateStaff_text.Value = DateTime.Now;
                PostStaffBox_text.Text = "";

            }
            if (Delet11_rb.Checked)
            {
                int id = Convert.ToInt32(CodeStaff_text.Text);
                string query = "DELETE FROM Сотрудники WHERE Код = " + id;
                OleDbCommand command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Delete");
                query = "SELECT * FROM Сотрудники";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
                DataSet db = new DataSet();
                dataAdapter.Fill(db);
                dataGridView11.DataSource = db.Tables[0];
                CodeStaff_text.Text = "";
                SurnameStaff_text.Text = "";
                NameStaff_text.Text = "";
                PatrStaff_text.Text = "";
                AddsStaff_text.Text = "";
                PhoneStaff_text.Text = "";
                DateStaff_text.Value = DateTime.Now;
                PostStaffBox_text.Text = "";
            }
        }

        private void dataGridView11_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CodeStaff_text.Text = dataGridView11.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            SurnameStaff_text.Text = dataGridView11.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            NameStaff_text.Text = dataGridView11.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            PatrStaff_text.Text = dataGridView11.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            AddsStaff_text.Text = dataGridView11.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            DateStaff_text.Value = DateTime.Parse(dataGridView11.Rows[e.RowIndex].Cells[5].Value.ToString());
            PhoneStaff_text.Text = dataGridView11.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
            PostStaffBox_text.Text = dataGridView11.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                setting_date2.Visible = true;

            }
            if (checkBox3.Checked == false)
            {
                setting_date2.Visible = false;
                exact_r2.Checked = false;
                before_r2.Checked = false;
                between_r2.Checked = false;
                date_enter_panel2.Visible = false;
                date_search5.Value = DateTime.Now;
                date_search6.Value = DateTime.Now;
                (dataGridView11.DataSource as DataTable).DefaultView.RowFilter = "";

            }
        }

        private void exact_r2_CheckedChanged(object sender, EventArgs e)
        {
            if (exact_r2.Checked == true)
            {
                date_enter_panel2.Visible = true;
                date_search5.Location = new Point(4, 30);
                date_search6.Visible = false;
            }
        }

        private void before_r2_CheckedChanged(object sender, EventArgs e)
        {
            if (before_r2.Checked == true)
            {

                date_enter_panel2.Visible = true;
                date_search5.Location = new Point(4, 30);
                date_search6.Visible = false;

            }
        }

        private void between_r2_CheckedChanged(object sender, EventArgs e)
        {

            date_enter_panel2.Visible = true;
            date_search5.Location = new Point(4, 13);
            date_search6.Visible = true;
        }

        private void date_search5_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = date_search5.Value;

            DateTime dt1 = date_search6.Value;

            if (exact_r2.Checked == true)
            {
                (dataGridView11.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Дата рождения] = '{0}'", dt.ToShortDateString());
            }
            if (between_r2.Checked == true)
            {
                (dataGridView11.DataSource as DataTable).DefaultView.RowFilter = string.Format("([Дата рождения] >= '{0}') AND ([Дата рождения] <= '{1}')", dt.ToShortDateString(), dt1.ToShortDateString());
            }

            if (before_r2.Checked == true)
            {
                (dataGridView11.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Дата рождения] <= '{0}'", dt.ToShortDateString());
            }
        }

        private void date_search6_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = date_search5.Value;

            DateTime dt1 = date_search6.Value;

            if (between_r2.Checked == true)
            {
                (dataGridView11.DataSource as DataTable).DefaultView.RowFilter = string.Format("([Дата рождения] >= '{0}') AND ([Дата рождения] <= '{1}')", dt.ToShortDateString(), dt1.ToShortDateString());
            }
        }

        private void CodeStaff_search_TextChanged(object sender, EventArgs e)
        {
            if (CodeStaff_search.Text == "")
            { (dataGridView11.DataSource as DataTable).DefaultView.RowFilter = ""; }
            else
            {
                int id = Convert.ToInt32(CodeStaff_search.Text);
                (dataGridView11.DataSource as DataTable).DefaultView.RowFilter = $"[Код] = " + id;
            }
        }

        private void SurnameStaff_seatch_TextChanged(object sender, EventArgs e)
        {
            (dataGridView11.DataSource as DataTable).DefaultView.RowFilter = $"[Фамилия] LIKE '%" + SurnameStaff_seatch.Text + "%'";
        }

        private void NameStaff_search_TextChanged(object sender, EventArgs e)
        {
            (dataGridView11.DataSource as DataTable).DefaultView.RowFilter = $"[Имя] LIKE '%" + NameStaff_search.Text + "%'";
        }

        private void PatrStaff_search_TextChanged(object sender, EventArgs e)
        {
            (dataGridView11.DataSource as DataTable).DefaultView.RowFilter = $"[Отчество] LIKE '%" + PatrStaff_search.Text + "%'";
        }

        private void AddsStaff_search_TextChanged(object sender, EventArgs e)
        {
            (dataGridView11.DataSource as DataTable).DefaultView.RowFilter = $"[Адрес] LIKE '%" + AddsStaff_search.Text + "%'";
        }

        private void PhoneStaff_search_TextChanged(object sender, EventArgs e)
        {
            if (PhoneStaff_search.Text == "")
            { (dataGridView11.DataSource as DataTable).DefaultView.RowFilter = ""; }
            else
            {
                int phone = Convert.ToInt32(PhoneStaff_search.Text);
                (dataGridView11.DataSource as DataTable).DefaultView.RowFilter = $"[Номер телефона] = " + phone;
            }
        }
        private void PostText_search_TextChanged(object sender, EventArgs e)
        {
            (dataGridView11.DataSource as DataTable).DefaultView.RowFilter = $"[Должность] LIKE '%" + PostText_search.Text + "%'";
        }
       

        private void button19_Click(object sender, EventArgs e)
        {
            CodeStaff_search.Text = "";
            SurnameStaff_seatch.Text = "";
            NameStaff_search.Text = "";
            PatrStaff_search.Text = "";
            AddsStaff_search.Text = "";
            PhoneStaff_search.Text = "";
            checkBox3.Checked = false;
            PostText_search.Text = "";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (Add12_rb.Checked)
            {

                string query = "INSERT INTO [Должность] ([Наименование]) VALUES ('" + PostStaff_text.Text + "')";
                OleDbCommand command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Add");
                query = "SELECT * FROM [Должность]";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
                DataSet db = new DataSet();
                dataAdapter.Fill(db);
                dataGridView12.DataSource = db.Tables[0];
                PostStaff_text.Text = "";

            }
            if (Delet12_rb.Checked)
            {
                string query = "DELETE FROM [Должность] WHERE [Наименование] = '" + PostStaff_text.Text + "'";
                OleDbCommand command = new OleDbCommand(query, myConnect);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Delete");
                query = "SELECT * FROM [Должность]";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, myConnect);
                DataSet db = new DataSet();
                dataAdapter.Fill(db);
                dataGridView12.DataSource = db.Tables[0];
                PostStaff_text.Text = "";
            }
        }

        private void dataGridView12_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PostStaff_text.Text = dataGridView12.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
        }

        private void PostStaff_search_TextChanged(object sender, EventArgs e)
        {
            (dataGridView12.DataSource as DataTable).DefaultView.RowFilter = $"[Наименование] LIKE '%" + PostStaff_search.Text + "%'";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            PostStaff_search.Text = "";
            Id_PostStaff_search.Text = "";
        }

        private void TableForm_Leave(object sender, EventArgs e)
        {
           
            TypeOper_box.Text = "";
            TypeCreditBox_text.Text = "";
            TermCreditBox_text.Text = "";
            TypePayCreditBox_text.Text = "";            
            
           
        }

        private void AllTable_Leave(object sender, EventArgs e)
        {
           
            TypeOper_box.Text = "";
            TypeCreditBox_text.Text = "";
            TermCreditBox_text.Text = "";
            TypePayCreditBox_text.Text = "";            
            
         }

        private void Id_PostStaff_search_TextChanged(object sender, EventArgs e)
        {
            if (Id_PostStaff_search.Text == "")
            { (dataGridView12.DataSource as DataTable).DefaultView.RowFilter = ""; }
            else
            {
                int Id_PostStaff = Convert.ToInt32(Id_PostStaff_search.Text);
                (dataGridView12.DataSource as DataTable).DefaultView.RowFilter = $"[Код] = " + Id_PostStaff;
            }
                              
        }

        private void Id_TypePayCredit_search_TextChanged(object sender, EventArgs e)
        {
            if (Id_TypePayCredit_search.Text == "")
            { (dataGridView10.DataSource as DataTable).DefaultView.RowFilter = ""; }
            else
            {
                int Id_PayCredit = Convert.ToInt32(Id_TypePayCredit_search.Text);
                (dataGridView10.DataSource as DataTable).DefaultView.RowFilter = $"[Код] = " + Id_PayCredit;
            }
        }

        private void Id_NameTypeCreditTerm_search_TextChanged(object sender, EventArgs e)
        {
            if (Id_NameTypeCreditTerm_search.Text == "")
            { (dataGridView9.DataSource as DataTable).DefaultView.RowFilter = ""; }
            else
            {
                int Id_NameCreditTerm = Convert.ToInt32(Id_NameTypeCreditTerm_search.Text);
                (dataGridView9.DataSource as DataTable).DefaultView.RowFilter = $"[Код] = " + Id_NameCreditTerm;
            }
        }

        private void IdTypeCredit_search_TextChanged(object sender, EventArgs e)
        {
            if (IdTypeCredit_search.Text == "")
            { (dataGridView8.DataSource as DataTable).DefaultView.RowFilter = ""; }
            else
            {
                int IdTypeCredit = Convert.ToInt32(IdTypeCredit_search.Text);
                (dataGridView8.DataSource as DataTable).DefaultView.RowFilter = $"[Код] = " + IdTypeCredit;
            }
        }

        private void IdOper_search_TextChanged(object sender, EventArgs e)
        {
            if (IdOper_search.Text == "")
            { (dataGridView6.DataSource as DataTable).DefaultView.RowFilter = ""; }
            else
            {
                int IdOper = Convert.ToInt32(IdOper_search.Text);
                (dataGridView6.DataSource as DataTable).DefaultView.RowFilter = $"[Код] = " + IdOper;
            }
        }

        private void NumbManager_search_TextChanged(object sender, EventArgs e)
        {
            if (NumbManager_search.Text == "")
            { (dataGridView5.DataSource as DataTable).DefaultView.RowFilter = ""; }
            else
            {
                int NumbManager = Convert.ToInt32(NumbManager_search.Text);
                (dataGridView5.DataSource as DataTable).DefaultView.RowFilter = $"[Менеджер] = " + NumbManager;
            }
            
        }
    }
}
