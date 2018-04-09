using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfTesting
{
    class Task
    {
        private int taskNumber;
        private String[] itemAnswer;

        public Task(int taskNumber, String[] itemAnswer)
        {
            TaskNumber = taskNumber;
            ItemAnswer = itemAnswer;
        }

        public string[] ItemAnswer
        {
            get
            {
                return itemAnswer;
            }

            set
            {
                itemAnswer = value;
            }
        }

        public int TaskNumber
        {
            get
            {
                return taskNumber;
            }

            set
            {
                taskNumber = value;
            }
        }
    }
}
