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
    /// unit 8
    /// </summary>
    public partial class MainWindow : Window
    {
        private const String pathRoot = "./Answers";
        private const String fileNameUnitEight = "Answers_to_unit_8.txt";
        private const String fileNameUnitNine = "Answers_to_unit_9.txt";

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

        public static string FileNameUnitNine
        {
            get
            {
                return fileNameUnitNine;
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
                    StringBuilder answersUnit9 = new StringBuilder();
                    answersUnit9.Append($"Name: {InputUserName.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"Surname: {InputUserSurname.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"Group: {InputUserGroup.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"1.1. {Unit8_ComboBox_task_1_1.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"1.2. {Unit8_ComboBox_task_1_2.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"1.3. {Unit8_ComboBox_task_1_3.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"1.4. {Unit8_ComboBox_task_1_4.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"1.5. {Unit8_ComboBox_task_1_5.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"1.6. {Unit8_ComboBox_task_1_6.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"1.7. {Unit8_ComboBox_task_1_7.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"2.1. {Unit8_TextBox_2_1.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"2.2. {Unit8_TextBox_2_2.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"2.3. {Unit8_TextBox_2_3.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"2.4. {Unit8_TextBox_2_4.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"2.5. {Unit8_TextBox_2_5.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"3.1. {Unit8_TextBox_3_1.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"3.2. {Unit8_TextBox_3_2.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"3.3. {Unit8_TextBox_3_3.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"4.1. {Unit8_TextBox_4_1.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"4.2. {Unit8_TextBox_4_2.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"4.3. {Unit8_TextBox_4_3.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"4.4. {Unit8_TextBox_4_4.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"4.5. {Unit8_TextBox_4_5.Text.Trim()}{Environment.NewLine}");

                    byte[] stringToBytesUTF8 = Encoding.UTF8.GetBytes(answersUnit9.ToString());
                    StringBuilder encodingText = new StringBuilder();
                    foreach (byte element in stringToBytesUTF8)
                    {
                        encodingText.Append(element);
                    }

                    WriteLine(fstream, encodingText.ToString());

                    ///Декодирование

                    string bytesToString = Encoding.UTF8.GetString(stringToBytesUTF8);
                    MessageBox.Show(bytesToString);


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


        /// <summary>
        /// Unit 9
        /// </summary>

        private void Unit9_CreateFileWithAnswers_Click(object sender, RoutedEventArgs e)
        {
            var Unit9_isAllFieldsFilled = Unit9_IsAllFieldsFilled();
            if (Unit9_isAllFieldsFilled == "0")
            {
                if (!IsOk())
                {
                    return;
                }

                CreateDirectory();

                var result = Unit9_WriteInFile(FileNameUnitNine);
                if (result == "Успех!")
                {
                    MessageBox.Show($"Ответы записаны в файл {FileNameUnitNine}");
                }
                else
                {
                    MessageBox.Show(result);
                }
            }
            else
            {
                MessageBox.Show($"Не заполнено поле {Unit9_isAllFieldsFilled}");
            }
        }

        private String Unit9_IsAllFieldsFilled()
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

            if (Unit9_TextBox_1_1_1.Text.Length == 0)
            {
                return "1.1.1.";
            }
            if (Unit9_TextBox_1_1_2.Text.Length == 0)
            {
                return "1.1.2.";
            }
            if (Unit9_TextBox_1_1_3.Text.Length == 0)
            {
                return "1.1.3.";
            }
            if (Unit9_TextBox_1_2_1.Text.Length == 0)
            {
                return "1.2.1.";
            }
            if (Unit9_TextBox_1_2_2.Text.Length == 0)
            {
                return "1.2.2.";
            }
            if (Unit9_TextBox_1_3_1.Text.Length == 0)
            {
                return "1.3.1.";
            }
            if (Unit9_TextBox_1_3_2.Text.Length == 0)
            {
                return "1.3.2.";
            }
            if (Unit9_TextBox_1_3_3.Text.Length == 0)
            {
                return "1.3.3.";
            }
            if (Unit9_TextBox_1_4_1.Text.Length == 0)
            {
                return "1.4.1.";
            }
            if (Unit9_TextBox_1_4_2.Text.Length == 0)
            {
                return "1.4.2.";
            }
            if (Unit9_TextBox_1_5_1.Text.Length == 0)
            {
                return "1.5.1.";
            }
            if (Unit9_TextBox_1_5_2.Text.Length == 0)
            {
                return "1.5.2.";
            }
            if (Unit9_TextBox_2_1.Text.Length == 0)
            {
                return "2.1.";
            }
            if (Unit9_TextBox_2_2.Text.Length == 0)
            {
                return "2.2.";
            }
            if (Unit9_ComboBox_task_3_1.SelectedValue == null)
            {
                return "3.1.";
            }
            if (Unit9_ComboBox_task_3_2.SelectedValue == null)
            {
                return "3.2.";
            }
            if (Unit9_ComboBox_task_3_3.SelectedValue == null)
            {
                return "3.3.";
            }

            return "0";
        }

        private String Unit9_WriteInFile(String nameFile)
        {
            try
            {
                using (FileStream fstream = new FileStream($@"{PathRoot}/{nameFile}", FileMode.Create))
                {
                    StringBuilder answersUnit9 = new StringBuilder();
                    answersUnit9.Append($"Name: {InputUserName.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"Surname: {InputUserSurname.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"Group: {InputUserGroup.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"1.1.1. {Unit9_TextBox_1_1_1.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"1.1.2. {Unit9_TextBox_1_1_2.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"1.1.3. {Unit9_TextBox_1_1_3.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"1.2.1. {Unit9_TextBox_1_2_1.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"1.2.2. {Unit9_TextBox_1_2_2.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"1.3.1. {Unit9_TextBox_1_3_1.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"1.3.2. {Unit9_TextBox_1_3_2.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"1.3.3. {Unit9_TextBox_1_3_3.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"1.4.1. {Unit9_TextBox_1_4_1.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"1.4.2. {Unit9_TextBox_1_4_2.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"1.5.1. {Unit9_TextBox_1_5_1.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"1.5.2. {Unit9_TextBox_1_5_2.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"2.1. {Unit9_TextBox_2_1.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"2.2. {Unit9_TextBox_2_2.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"3.1. {Unit9_ComboBox_task_3_1.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"3.2. {Unit9_ComboBox_task_3_2.Text.Trim()}{Environment.NewLine}");
                    answersUnit9.Append($"3.3. {Unit9_ComboBox_task_3_3.Text.Trim()}{Environment.NewLine}");

                    byte[] stringToBytesUTF8 = Encoding.UTF8.GetBytes(answersUnit9.ToString());
                    StringBuilder encodingText = new StringBuilder();
                    foreach (byte element in stringToBytesUTF8)
                    {
                        encodingText.Append(element);
                    }

                    WriteLine(fstream, encodingText.ToString());

                    ///Декодирование

                    //string bytesToString = Encoding.UTF8.GetString(stringToBytesUTF8);
                    //MessageBox.Show(bytesToString);
                }

                return "Успех!";
            }
            catch (Exception ex)
            {
                return $"Error: {Environment.NewLine}{ex}";
            }
        }
    }
}