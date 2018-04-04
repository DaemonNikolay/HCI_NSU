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

namespace SelfTesting
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Code();
        }

        private void Code()
        {
            String name = "Nik";
            String surname = "Kin";
            String groupNumber = "603c";

            String[] answers = new String[3];
            answers[0] = "1";
            answers[1] = "2";
            answers[2] = "3";

            Task[] tasks = new Task[3];
            tasks[0] = new Task(1, answers);
            tasks[1] = new Task(2, answers);
            tasks[2] = new Task(3, answers);

            Student student = new Student(name, surname, groupNumber, tasks);

            textBlock.Text = student.Print();

            //MessageBox.Show(student.Print());   
        }
    }
}
