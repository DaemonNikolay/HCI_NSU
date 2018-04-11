using System;
using System.Collections.Generic;
using System.IO;
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
        private const String pathRoot = "./Answers";
        private const String fileNameUnitEight = "Answers_to_unit_8.txt";

        public static string PathRoot
        {
            get
            {
                return pathRoot;
            }
        }

        public static string FileNameUnitEight
        {
            get
            {
                return fileNameUnitEight;
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Unit8_CreateFileWithAnswers_Click(object sender, RoutedEventArgs e)
        {
            var Unit8_isAllFieldsFilled = Unit8_IsAllFieldsFilled();
            if (Unit8_isAllFieldsFilled == "0")
            {
                if (!IsOk())
                {
                    return;
                }

                CreateDirectory();

                var result = Unit8_WriteInFile(FileNameUnitEight);
                if (result == "Успех!")
                {
                    MessageBox.Show($"Ответы записаны в файл {FileNameUnitEight}");
                }
                else
                {
                    MessageBox.Show(result);
                }
            }
            else
            {
                MessageBox.Show($"Не заполнено поле {Unit8_isAllFieldsFilled}");
            }
        }

        private void CreateDirectory()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(PathRoot);

            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
        }

        private bool IsOk()
        {
            MessageBoxButton buttonMessageBox = MessageBoxButton.YesNo;
            MessageBoxImage iconMessageBox = MessageBoxImage.Question;
            MessageBoxResult resultMessageBox = MessageBox.Show("Уверены в своих результатах?", "Кря-кря", buttonMessageBox, iconMessageBox);

            if (resultMessageBox == MessageBoxResult.Yes)
            {
                return true;
            }

            return false;
        }

        private String Unit8_IsAllFieldsFilled()
        {
            if (InputUserName.Text.Length == 0)
            {
                return "Name";
            }
            if (InputUserSurname.Text.Length == 0)
            {
                return "Surname";
            }
            if (InputUserGroup.Text.Length == 0)
            {
                return "Group";
            }

            if (Unit8_ComboBox_task_1_1.SelectedValue == null)
            {
                return "1.1.";
            }
            if (Unit8_ComboBox_task_1_2.SelectedValue == null)
            {
                return "1.2.";
            }
            if (Unit8_ComboBox_task_1_3.SelectedValue == null)
            {
                return "1.3.";
            }
            if (Unit8_ComboBox_task_1_4.SelectedValue == null)
            {
                return "1.4.";
            }
            if (Unit8_ComboBox_task_1_5.SelectedValue == null)
            {
                return "1.5.";
            }
            if (Unit8_ComboBox_task_1_6.SelectedValue == null)
            {
                return "1.6.";
            }
            if (Unit8_ComboBox_task_1_7.SelectedValue == null)
            {
                return "1.7.";
            }
            if (Unit8_TextBox_2_1.Text.Length == 0)
            {
                return "2.1.";
            }
            if (Unit8_TextBox_2_2.Text.Length == 0)
            {
                return "2.2.";
            }
            if (Unit8_TextBox_2_3.Text.Length == 0)
            {
                return "2.3.";
            }
            if (Unit8_TextBox_2_4.Text.Length == 0)
            {
                return "2.4.";
            }
            if (Unit8_TextBox_2_5.Text.Length == 0)
            {
                return "2.5.";
            }
            if (Unit8_TextBox_3_1.Text.Length == 0)
            {
                return "3.1.";
            }
            if (Unit8_TextBox_3_2.Text.Length == 0)
            {
                return "3.2.";
            }
            if (Unit8_TextBox_3_3.Text.Length == 0)
            {
                return "3.3.";
            }
            if (Unit8_TextBox_4_1.Text.Length == 0)
            {
                return "4.1.";
            }
            if (Unit8_TextBox_4_2.Text.Length == 0)
            {
                return "4.2.";
            }
            if (Unit8_TextBox_4_3.Text.Length == 0)
            {
                return "4.3.";
            }
            if (Unit8_TextBox_4_4.Text.Length == 0)
            {
                return "4.4.";
            }
            if (Unit8_TextBox_4_5.Text.Length == 0)
            {
                return "4.5.";
            }

            return "0";
        }

        private String Unit8_WriteInFile(String nameFile)
        {
            try
            {
                using (FileStream fstream = new FileStream($@"{PathRoot}/{nameFile}", FileMode.Create))
                {
                    WriteLine(fstream, ($"Name: {InputUserName.Text.Trim()}"));
                    WriteLine(fstream, ($"Surname: {InputUserSurname.Text.Trim()}"));
                    WriteLine(fstream, ($"Group: {InputUserGroup.Text.Trim()}"));
                    WriteLine(fstream, ($"1.1. {Unit8_ComboBox_task_1_1.Text.Trim()}"));
                    WriteLine(fstream, ($"1.2. {Unit8_ComboBox_task_1_2.Text.Trim()}"));
                    WriteLine(fstream, ($"1.3. {Unit8_ComboBox_task_1_3.Text.Trim()}"));
                    WriteLine(fstream, ($"1.4. {Unit8_ComboBox_task_1_4.Text.Trim()}"));
                    WriteLine(fstream, ($"1.5. {Unit8_ComboBox_task_1_5.Text.Trim()}"));
                    WriteLine(fstream, ($"1.6. {Unit8_ComboBox_task_1_6.Text.Trim()}"));
                    WriteLine(fstream, ($"1.7. {Unit8_ComboBox_task_1_7.Text.Trim()}"));
                    WriteLine(fstream, ($"2.1. {Unit8_TextBox_2_1.Text.Trim()}"));
                    WriteLine(fstream, ($"2.2. {Unit8_TextBox_2_2.Text.Trim()}"));
                    WriteLine(fstream, ($"2.3. {Unit8_TextBox_2_3.Text.Trim()}"));
                    WriteLine(fstream, ($"2.4. {Unit8_TextBox_2_4.Text.Trim()}"));
                    WriteLine(fstream, ($"2.5. {Unit8_TextBox_2_5.Text.Trim()}"));
                    WriteLine(fstream, ($"3.1. {Unit8_TextBox_3_1.Text.Trim()}"));
                    WriteLine(fstream, ($"3.1. {Unit8_TextBox_3_2.Text.Trim()}"));
                    WriteLine(fstream, ($"3.1. {Unit8_TextBox_3_3.Text.Trim()}"));
                    WriteLine(fstream, ($"4.1. {Unit8_TextBox_4_1.Text.Trim()}"));
                    WriteLine(fstream, ($"4.2. {Unit8_TextBox_4_2.Text.Trim()}"));
                    WriteLine(fstream, ($"4.3. {Unit8_TextBox_4_3.Text.Trim()}"));
                    WriteLine(fstream, ($"4.4. {Unit8_TextBox_4_4.Text.Trim()}"));
                    WriteLine(fstream, ($"4.5. {Unit8_TextBox_4_5.Text.Trim()}"));
                }

                return "Успех!";
            }
            catch (Exception ex)
            {
                return $"Error: {Environment.NewLine}{ex}";
            }
        }

        private void WriteLine(FileStream fstream, String text)
        {
            byte[] array = Encoding.Default.GetBytes(text + Environment.NewLine);
            fstream.Write(array, 0, array.Length);
        }
    }
}