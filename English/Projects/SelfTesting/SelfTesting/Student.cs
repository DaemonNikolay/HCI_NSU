using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfTesting
{
    class Student
    {
        private String name;
        private String surname;
        private String groupNumber;
        private Task[] tasks;

        public Student(String name, String surname, String groupNumber, Task[] tasks)
        {
            Name = name;
            Surname = surname;
            GroupNumber = groupNumber;
            Tasks = tasks;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                surname = value;
            }
        }

        public string GroupNumber
        {
            get
            {
                return groupNumber;
            }

            set
            {
                groupNumber = value;
            }
        }

        public Task[] Tasks
        {
            get
            {
                return tasks;
            }

            set
            {
                tasks = value;
            }
        }


        public String Print()
        {
            String result = $"Name : {Name}\nSurname : {Surname}\nGroup number : {GroupNumber}\n";

            String temp = "";
            foreach (var element in tasks)
            {
                temp += $"Number task : {element.TaskNumber}\n";
                var i = 0;
                foreach (var instance in element.ItemAnswer)
                {
                    i++;
                    temp += $"\t{i} : {instance}\n";
                }
            }

            return result + temp;
        }
    }
}