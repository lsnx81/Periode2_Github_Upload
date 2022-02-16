using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DataGrid_FileExplorer.Model
{
    public abstract class ObervableClass : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string? propertyName = null)
        {
            if (!Equals(field, newValue))
            {
                field = newValue;
                NotifyPropertyChanged(propertyName!);
                return true;
            }

            return false;

        }
        protected void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
