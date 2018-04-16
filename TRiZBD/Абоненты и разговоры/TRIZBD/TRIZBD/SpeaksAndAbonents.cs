using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRIZBD
{
    class SpeaksAndAbonents
    {
        private string numberPhone;
        private DateTime date;
        private int valueTime;
        private string FIO;
        private string nameCity;

        public string NumberPhone
        {
            get
            {
                return numberPhone;
            }

            set
            {
                numberPhone = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public int ValueTime
        {
            get
            {
                return valueTime;
            }

            set
            {
                valueTime = value;
            }
        }

        public string FIO1
        {
            get
            {
                return FIO;
            }

            set
            {
                FIO = value;
            }
        }

        public string NameCity
        {
            get
            {
                return nameCity;
            }

            set
            {
                nameCity = value;
            }
        }
    }
}
