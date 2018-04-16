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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connect.DataSource = @"(LocalDB)\MSSQLLocalDB";
            connect.InitialCatalog = "AbonentsAndSpeaks";


            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = connect.ConnectionString;
                try
                {
                    //Открыть подключение
                    cn.Open();

                    //string strSQL = "SELECT * FROM Разговор";
                    string strSQL = "SELECT Разговор.[НомерТелефона], Разговор.Дата, Разговор.[КолВремени], Abonent.Адрес, Abonent.ФИО, Тариф.[НазваниеГорода] FROM Разговор INNER JOIN Abonent ON Разговор.[НомерТелефона] = Abonent.[Номер телефона] INNER JOIN Тариф ON Разговор.[КодГорода] = Тариф.[КодГорода]";

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strSQL, cn);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);

                    DataGridAbAndSp.DataSource = dataTable;
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
