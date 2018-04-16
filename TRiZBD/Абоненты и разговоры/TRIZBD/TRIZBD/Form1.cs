using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRIZBD
{
    public partial class Form1 : Form
    {
        private SqlConnectionStringBuilder connect = new SqlConnectionStringBuilder();

        public Form1()
        {
            InitializeComponent();

            Load += AddSpeak_Load;
        }

        private void AddSpeak_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "abonentsAndSpeaksDataSet.Разговор". При необходимости она может быть перемещена или удалена.
            this.разговорTableAdapter.Fill(this.abonentsAndSpeaksDataSet.Разговор);

            connect.DataSource = @"(LocalDB)\MSSQLLocalDB";
            connect.InitialCatalog = "AbonentsAndSpeaks";

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = connect.ConnectionString;
                try
                {
                    cn.Open();
                }
                catch (SqlException ex)
                {
                    // Протоколировать исключение
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    // Гарантировать освобождение подключения
                    cn.Close();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "abonentsAndSpeaksDataSet.Abonent". При необходимости она может быть перемещена или удалена.
            this.abonentTableAdapter.Fill(this.abonentsAndSpeaksDataSet.Abonent);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "abonentsAndSpeaksDataSet.Тариф". При необходимости она может быть перемещена или удалена.
            this.тарифTableAdapter.Fill(this.abonentsAndSpeaksDataSet.Тариф);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "abonentsAndSpeaksDataSet.Тариф". При необходимости она может быть перемещена или удалена.
            this.тарифTableAdapter.Fill(this.abonentsAndSpeaksDataSet.Тариф);

            connect.DataSource = @"(LocalDB)\MSSQLLocalDB";
            connect.InitialCatalog = "AbonentsAndSpeaks";


            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = connect.ConnectionString;
                try
                {
                    cn.Open();

                    string strSQL = "SELECT Разговор.[НомерТелефона], Разговор.Дата, Разговор.[КолВремени], Abonent.Адрес, Abonent.ФИО, Тариф.[НазваниеГорода] FROM Разговор INNER JOIN Abonent ON Разговор.[НомерТелефона] = Abonent.[Номер телефона] INNER JOIN Тариф ON Разговор.[КодГорода] = Тариф.[КодГорода]";

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strSQL, cn);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);

                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = dataTable;

                    DataGridAbAndSp.DataSource = bindingSource;
                    bindingNavigatorAbAndSp.BindingSource = bindingSource;
                }
                catch (SqlException ex)
                {
                    // Протоколировать исключение
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    // Гарантировать освобождение подключения
                    cn.Close();
                }
            }
        }

        private void номерТелефонаComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            connect.DataSource = @"(LocalDB)\MSSQLLocalDB";
            connect.InitialCatalog = "AbonentsAndSpeaks";

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = connect.ConnectionString;
                try
                {
                    cn.Open();

                    string strSQL = $"SELECT ФИО FROM Abonent WHERE [Номер телефона]='{номерТелефонаComboBox.Text}'";

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strSQL, cn);
                    SqlCommand myCommand = new SqlCommand(strSQL, cn);
                    SqlDataReader dr = myCommand.ExecuteReader();

                    while (dr.Read())
                    {
                        AdSpFIO.Text = dr[0].ToString();
                        break;       
                    }
                }
                catch (SqlException ex)
                {
                    // Протоколировать исключение
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    // Гарантировать освобождение подключения
                    cn.Close();
                }
            }
        }
    }
}
