using BindingLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp1.ViewModels
{
    public class MainViewModel : NotifyPropertyBase
    {
        public double _Weight;
        public double Weight
        {
            get { return _Weight; }
            set { SetProperty(ref _Weight, value); }
        }

        public double _High;
        public double High
        {
            get { return _High; }
            set { SetProperty(ref _High, value); }
        }

        public double _Bmi;
        public double Bmi
        {
            get { return _Bmi; }
            set { SetProperty(ref _Bmi, value); }
        }

        private ICommand _BmiCommand;

        public ICommand BmiCommand
        {
            get
            {
                if (_BmiCommand == null)
                {
                    _BmiCommand = new RelayCommand(x => { Bmi = Math.Round(Weight / Math.Pow(High,2), 2);});                  
                }
                return _BmiCommand;
            }
        }
    }
}
