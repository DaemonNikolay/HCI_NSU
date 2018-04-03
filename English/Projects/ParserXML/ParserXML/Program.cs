using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ParserXML
{
    class Program
    {
        private static String name, surname, groupNumber;
        private static List<String> answers = new List<string>();

        public static string GroupNumber
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

        public static string Name
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

        public static string Surname
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

        public static List<string> Answers
        {
            get
            {
                return answers;
            }

            set
            {
                answers = value;
            }
        }

        static void Main(string[] args)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(@"c:\users\user\documents\visual studio 2015\Projects\ParserXML\ParserXML\Test6.xml");
            // получим корневой элемент
            XmlElement xRoot = xDoc.DocumentElement;
            // обход всех узлов в корневом элементе

            int i = 0;
            foreach (XmlNode xnode in xRoot)
            {
                if (xnode.Name == "student")
                {
                    foreach (XmlNode childStudent in xnode)
                    {
                        if (childStudent.Name == "name")
                        {
                            Name = childStudent.InnerText;
                        }
                        else if (childStudent.Name == "surname")
                        {
                            Surname = childStudent.InnerText;
                        }
                        else if (childStudent.Name == "group-number")
                        {
                            GroupNumber = childStudent.InnerText; 
                        }
                    }
                }
                else if (xnode.Name == "tasks")
                {
                    foreach (XmlNode child in xnode.ChildNodes)
                    {
                        Console.WriteLine(child.Name + " №" + child.Attributes.GetNamedItem("number").InnerText);
                    }
                }
            }
            //Console.WriteLine("THE END");


            Console.WriteLine(Name);
            Console.WriteLine(Surname);
            Console.WriteLine(GroupNumber);

            Console.ReadKey();
        }
    }
}
