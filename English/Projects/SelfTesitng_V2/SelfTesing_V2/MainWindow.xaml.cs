using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SelfTesing_V2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateFileWithAnswers_Click(object sender, RoutedEventArgs e)
        {
            if (IsAllFieldsFilled())
            {
                MessageBoxButton buttonMessageBox = MessageBoxButton.YesNo;
                MessageBoxImage iconMessageBox = MessageBoxImage.Question;
                MessageBoxResult resultMessageBox = MessageBox.Show("Уверены в своих результатах?", "Кря-кря", buttonMessageBox, iconMessageBox);

                if (resultMessageBox == MessageBoxResult.Yes)
                {
                    MessageBox.Show("" + (ComboBox_task_1_1.SelectedValue == null));
                }
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!");
            }
        }

        private bool IsAllFieldsFilled()
        {
            if (ComboBox_task_1_1.SelectedValue == null)
            {
                return false;
            }
            else if (ComboBox_task_1_2.SelectedValue == null)
            {
                return false;
            }
            else if (ComboBox_task_1_2.SelectedValue == null)
            {
                return false;
            }
            else if (ComboBox_task_1_3.SelectedValue == null)
            {
                return false;
            }
            else if (ComboBox_task_1_4.SelectedValue == null)
            {
                return false;
            }
            else if (ComboBox_task_1_5.SelectedValue == null)
            {
                return false;
            }
            else if (ComboBox_task_1_6.SelectedValue == null)
            {
                return false;
            }
            else if (ComboBox_task_1_7.SelectedValue == null)
            {
                return false;
            }
            else if (textBox_2_1.Text.Length == 0)
            {
                return false;
            }
            else if (textBox_2_2.Text.Length == 0)
            {
                return false;
            }
            else if (textBox_2_3.Text.Length == 0)
            {
                return false;
            }
            else if (textBox_2_4.Text.Length == 0)
            {
                return false;
            }
            else if (textBox_2_5.Text.Length == 0)
            {
                return false;
            }
            else if (textBox_3_1.Text.Length == 0)
            {
                return false;
            }
            else if (textBox_3_2.Text.Length == 0)
            {
                return false;
            }
            else if (textBox_3_3.Text.Length == 0)
            {
                return false;
            }
            else if (textBox_4_1.Text.Length == 0)
            {
                return false;
            }
            else if (textBox_4_2.Text.Length == 0)
            {
                return false;
            }
            else if (textBox_4_3.Text.Length == 0)
            {
                return false;
            }
            else if (textBox_4_4.Text.Length == 0)
            {
                return false;
            }
            else if (textBox_4_5.Text.Length == 0)
            {
                return false;
            }

            return false;
        }
    }
}
