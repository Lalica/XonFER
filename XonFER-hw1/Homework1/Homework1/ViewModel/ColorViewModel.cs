using System.ComponentModel;
using System.Runtime.CompilerServices;
using Android.Locations;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace Homework1.ViewModel
{
    class ColorViewModel : INotifyPropertyChanged
    {
        public ColorViewModel()
        {
            ChangeColorCommand = new Command(ChangeColor);
        }
        private int _index;
        private string[] _colorArray = { "#4dffb8", "#00331a", "#004d4d", "#b30047", "#660000", "#cc9900" };
        private string _currentColor = "#4dffb8";

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public string CurrentColor
        {
            get => _currentColor;
            set
            {
                _currentColor = value;
                OnPropertyChanged();
            }
        }

        public Command ChangeColorCommand { get; }

        public void ChangeColor()
        {
            _index = (_index + 1) % _colorArray.Length;
            CurrentColor = _colorArray[_index];
        }
    }
}