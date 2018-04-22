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
            Load += SearchTwoDate;
        }

        private void SearchTwoDate(object sender, EventArgs e)
        {
            DateTimePickerTo.Value = DateTime.Today;
            DateTimePickerDo.Value = DateTime.Today.AddMilliseconds(1);
        }

        private void AddSpeak_Load(object sender, EventArgs e)
        {
            номерТелефонаComboBox.SelectedValue = "";
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

                    string strSQL = $"SELECT ФИО FROM Abonent WHERE [Номер телефона]='{номерТелефонаComboBox.SelectedValue}'";

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

        private void колВремениTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ввод в texBox только цифр и кнопки Backspace
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void AddNewSpeak_Click(object sender, EventArgs e)
        {
            connect.DataSource = @"(LocalDB)\MSSQLLocalDB";
            connect.InitialCatalog = "AbonentsAndSpeaks";

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = connect.ConnectionString;
                try
                {
                    cn.Open();

                    string strSQLBase = "INSERT INTO Разговор (НомерТелефона, КодГорода, КолВремени) " +
                                        $"VALUES('{номерТелефонаComboBox.SelectedValue}', {названиеГородаComboBox.SelectedValue}, {колВремениTextBox.Text})";

                    SqlDataAdapter sqlDataAdapterBase = new SqlDataAdapter(strSQLBase, cn);
                    SqlCommand myCommandBase = new SqlCommand(strSQLBase, cn);
                    myCommandBase.ExecuteNonQuery();

                    Form1_Load(sender, e);

                    номерТелефонаComboBox.SelectedValue = "";
                    названиеГородаComboBox.Text = "";
                    колВремениTextBox.Text = "";

                    MessageBox.Show("Данные успешно добавлены!");
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

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.тарифBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.abonentsAndSpeaksDataSet);
        }

        private void AddNewCity_Click(object sender, EventArgs e)
        {
            if (NewNameCity.Text == "")
            {
                MessageBox.Show("Имя нового города не может отсутствовать! \nЗаполните поле!");
                return;
            }
            if (CostInMinute.Text == "")
            {
                MessageBox.Show($"Укажите цену за минуту для города {NewNameCity.Text}!");
                return;
            }

            connect.DataSource = @"(LocalDB)\MSSQLLocalDB";
            connect.InitialCatalog = "AbonentsAndSpeaks";

            using (SqlConnection cn = new SqlConnection())
            {
                cn.ConnectionString = connect.ConnectionString;
                try
                {
                    cn.Open();

                    string strSQLBase = "INSERT INTO Тариф (НазваниеГорода, ЦенаЗаМин) " +
                                        $"VALUES('{NewNameCity.Text}', {CostInMinute.Text})";

                    SqlDataAdapter sqlDataAdapterBase = new SqlDataAdapter(strSQLBase, cn);
                    SqlCommand myCommandBase = new SqlCommand(strSQLBase, cn);
                    myCommandBase.ExecuteNonQuery();

                    Form1_Load(sender, e);

                    номерТелефонаComboBox.SelectedValue = "";
                    названиеГородаComboBox.Text = "";
                    колВремениTextBox.Text = "";

                    MessageBox.Show("Данные успешно добавлены!");
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

            сохранитьToolStripButton_Click(sender, e);

            NewNameCity.Text = "";
            CostInMinute.Text = "";
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableAdapterManager.UpdateAll(this.abonentsAndSpeaksDataSet);
            }
            catch (SqlException ex)
            {
                this.тарифTableAdapter.Fill(this.abonentsAndSpeaksDataSet.Тариф);
                MessageBox.Show("Ошибка SQL запроса\n\n" + ex.Message + "\n\nИзменения не применены!");

                return;
            }

            сохранитьToolStripButton_Click(sender, e);
        }

        private void сохранитьToolStripAddNewAbonent_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.abonentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.abonentsAndSpeaksDataSet);
        }

        private void номер_телефонаTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ввод в texBox только цифр, кнопки Backspace и знака тире('-')
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 45)
            {
                e.Handled = true;
            }
        }

        private void фИОTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ввод в texBox только букв, кнопки Backspace и знака пробела
            char ch = e.KeyChar;
            if (Char.IsDigit(ch) && ch != 8 && ch != 32)
            {
                e.Handled = true;
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (номерТелефонаSearch.Text == null)
            {
                MessageBox.Show("Требуется номер телефона!");
                return;
            }
            if (DateTimePickerTo.Value > DateTimePickerDo.Value)
            {
                MessageBox.Show("Дата начала не может быть больше даты конца!");
                return;
            }

            connect.DataSource = @"(LocalDB)\MSSQLLocalDB";
            connect.InitialCatalog = "AbonentsAndSpeaks";
            string sqlExpression = "AbonentTalk";

            using (SqlConnection cn = new SqlConnection())
            {
                try
                {
                    cn.ConnectionString = connect.ConnectionString;
                    cn.Open();

                    SqlCommand command = new SqlCommand(sqlExpression, cn);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlParameter data1 = new SqlParameter
                    {
                        ParameterName = "@data1",
                        Value = DateTimePickerTo.Value.Date,
                    };
                    command.Parameters.Add(data1);

                    SqlParameter data2 = new SqlParameter
                    {
                        ParameterName = "@data2",
                        Value = DateTimePickerDo.Value.Date,
                    };
                    command.Parameters.Add(data2);

                    SqlParameter namber = new SqlParameter
                    {
                        ParameterName = "@namber",
                        Value = номерТелефонаSearch.Text,
                    };
                    command.Parameters.Add(namber);

                    SqlDataAdapter ada = new SqlDataAdapter();
                    ada.SelectCommand = command;

                    DataSet ds = new DataSet();
                    ada.Fill(ds, "Разговор");

                    TablesForSearch.DataSource = ds.Tables[0].DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cn.Close();
                }
            }
        }
    }
}
