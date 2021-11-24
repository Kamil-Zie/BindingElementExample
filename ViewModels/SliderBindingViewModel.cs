using BindingElementExample.Commands;
using BindingElementExample.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace BindingElementExample.ViewModels
{
    public class SliderBindingViewModel : ViewModelBase
    {
        public ICommand Calc { get; }

        public int _number_SliderOne;
        public int Number_SliderOne
        {
            get { return _number_SliderOne; }
            set 
            {
                _number_SliderOne = value;
                OnPropertyChanged(nameof(Number_SliderOne));
            }
        }

        public int _number_SliderTwo;
        public int Number_SliderTwo
        {
            get { return _number_SliderTwo; }
            set
            {
                _number_SliderTwo = value;
                OnPropertyChanged(nameof(Number_SliderTwo));
            }
        }

        public int _sum_SliderNumbers;
        public int Sum_SliderNumbers
        {
            get { return _sum_SliderNumbers; }
            set
            {
                _sum_SliderNumbers = value;
                OnPropertyChanged(nameof(Sum_SliderNumbers));
            }
        }

        public SliderBindingViewModel()
        {
            Calc = new CalculateCommand(this);
        }
    }
}
