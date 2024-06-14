using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfBook.libs
{
    // Implement this class in any other class to have NotifyPropertyChanged features
    public class NotifyPropertyChangeImp : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
