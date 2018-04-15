using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AAS0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "abonentsAndSpeaksDataSet.Тариф". При необходимости она может быть перемещена или удалена.
            this.тарифTableAdapter.Fill(this.abonentsAndSpeaksDataSet.Тариф);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "abonentsAndSpeaksDataSet.Разговор". При необходимости она может быть перемещена или удалена.
            this.разговорTableAdapter.Fill(this.abonentsAndSpeaksDataSet.Разговор);

        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.тарифBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.abonentsAndSpeaksDataSet);
        }

        private void сохранитьToolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.разговорBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.abonentsAndSpeaksDataSet);
        }
    }
}
