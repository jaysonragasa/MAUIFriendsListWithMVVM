using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using FriendsList.ViewModels;

namespace FriendsList
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FriendsListPage : ContentPage
    {
        public FriendsListPage()
        {
            InitializeComponent();

            var vm = (ViewModel_FriendsList)this.BindingContext;
            vm.RefreshData();
        }
    }
}