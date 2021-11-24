using BindingElementExample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindingElementExample.Commands
{
    class CalculateCommand : CommandBase
    {
        private static SliderBindingViewModel _sliderBindingViewModel;

        private int _sliderOneNumber;
        private int _sliderTwoNumber;

        public CalculateCommand(SliderBindingViewModel sliderBindingViewModel)
        {
            _sliderBindingViewModel = sliderBindingViewModel;
        }

        public override bool CanExecute(object parameter)
        {
            if (_sliderBindingViewModel != null)
                return true;
            return false;
        }

        public override void Execute(object parameter)
        {
            _sliderOneNumber = _sliderBindingViewModel._number_SliderOne;
            _sliderTwoNumber = _sliderBindingViewModel._number_SliderTwo;
            _sliderBindingViewModel.Sum_SliderNumbers = (int)_sliderOneNumber + (int)_sliderTwoNumber;
        }
    }
}
