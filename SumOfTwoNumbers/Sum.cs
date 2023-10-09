using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoNumbers
{
    public class Sum : INotifyPropertyChanged
    {

        private string number1;
        private string number2;
        private string result;

        public string Number1
        {
            get { return number1; }
            set
            {
                int number;
                bool res = int.TryParse(value, out number);
                if(res)
                {
                    number1 = value;
                }
                OnPropertyChanged("Number1");
                OnPropertyChanged("Result");
            }
        }

        public string Number2
        {
            get { return number2; }
            set
            {
                int number;
                bool res = int.TryParse(value, out number);
                if(res)
                {
                    number2 = value;
                }
                OnPropertyChanged("Number2");
                OnPropertyChanged("Result");
            }
        }

        public string Result
        {
            get
            {
                int res = int.Parse(Number1) + int.Parse(Number2);
                return res.ToString();    
            }
            set
            {
                int res = int.Parse(Number1) + int.Parse(Number2);
                result = res.ToString();
                OnPropertyChanged("Result");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
