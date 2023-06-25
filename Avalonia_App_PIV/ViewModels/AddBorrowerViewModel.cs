using System;
using System.ComponentModel;

namespace Avalonia_App_PIV.ViewModels
{
    public class AddBorrowerViewModel : INotifyPropertyChanged
    {
        private decimal _money;
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }
        public decimal Money
        {
            get { return _money; }
            set
            {
                if (_money != value)
                {
                    _money = value;
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}