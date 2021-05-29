using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FriendsList.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        bool _isBusy = false;
        public bool IsBusy
        {
            get => this._isBusy;
            set
            {
                if(this._isBusy != value)
                {
                    this._isBusy = value;
                    NotifyUI();
                }
            }
        }

        #region INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyUI([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
        #endregion

    }
}
