using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbonentsAndSpeaks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void abonentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.abonentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.abonentsAndSpeaksDataSet);

        }

        private void abonentBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.abonentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.abonentsAndSpeaksDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "abonentsAndSpeaksDataSet.Abonent". При необходимости она может быть перемещена или удалена.
            this.abonentTableAdapter.Fill(this.abonentsAndSpeaksDataSet.Abonent);

        }
    }
}
