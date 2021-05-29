using FriendsList.Enums;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FriendsList.Models
{
    public class Model_UserDetails : INotifyPropertyChanged
    {
        string _name = null;
        public string Name
        {
            get => this._name;
            set
            {
                if(this._name != value)
                {
                    this._name = value;
                    NotifyUI();
                }
            }
        }

        Enum_FriendStatus _status = Enum_FriendStatus.OFFLINE;
        public Enum_FriendStatus Status
        {
            get => _status;
            set
            {
                if(_status != value)
                {
                    _status = value;
                    this.NotifyUI();
                }
            }
        }

        Uri _displayPictureURL = null;
        public Uri DisplayPictureURL
        {
            get => _displayPictureURL;
            set
            {
                if(_displayPictureURL != value)
                {
                    this._displayPictureURL = value;
                    NotifyUI();
                }
            }
        }

        string _lastMessage = null;
        public string LastMessage
        {
            get => this._lastMessage;
            set
            {
                if(this._lastMessage != value)
                {
                    this._lastMessage = value;
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
