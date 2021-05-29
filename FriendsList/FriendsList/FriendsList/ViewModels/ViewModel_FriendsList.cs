using FriendsList.Enums;
using FriendsList.Models;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace FriendsList.ViewModels
{
    public class ViewModel_FriendsList : ViewModelBase
    {
        #region events

        #endregion

        #region vars
        Random r = new Random(DateTime.Now.Second);
        #endregion

        #region properties
        public ObservableCollection<Model_UserDetails> Friends { get; set; } = new ObservableCollection<Model_UserDetails>();
        #endregion

        #region commands

        #endregion

        #region ctors
        public ViewModel_FriendsList()
        {
            InitCommands();
        }
        #endregion

        #region command methods

        #endregion

        #region methods
        void InitCommands()
        {

        }

        public void RefreshData()
        {
            string names = "Michaele Zale|Cecila Tigner|Lisette Prahl|Rebeca No|Wynell Tosh|Reena Dejesus|Keesha Abreu|Cory Maestas|Destiny Schoening|Christin Gamblin|Candie Fredericksen|Bret Peavy|Ai Quill|Nora Atkinson|Evan Burden|Preston Salazar|Eliza Parent|Kristeen Arant|Shela Lokey|Arleen Sobel|Dalia Speck|Janell Lafever|Remedios Rodger|Carlos Duenes|Tona Morell|Ona Blazier|Reuben Hartnett|Dino Negley|Hailey Verde|Merideth Okelley|Krysten Palmatier|Leigha Spagnoli|Dee Grief|Porsha Spears|Tiesha Weatherspoon|Archie Rodd|Esperanza Schlanger|Dora Edgar|Ruthie Krantz|Tynisha Filippini|Lino Priestley|Ramonita Dicicco|Paulette Perreault|Bok Texada|Caitlyn Calender|Dustin Hinkson|Linn Tobey|Long Redfield|Eddie Bernardino|Weldon Darrigo";
            string lorem = "Nullam lobortis nec nisi non auctor|Donec porta metus id ex egestas, nec dignissim elit porta|Aliquam pulvinar rhoncus purus, a ultricies arcu rhoncus non|Nunc porttitor dui ac blandit sodales|Quisque at gravida erat|Donec et malesuada massa|Curabitur semper rutrum enim, vel mollis mauris ultrices accumsan|Quisque nisi turpis, auctor sed felis sit amet, gravida semper nisl|Vivamus blandit, enim ut condimentum lobortis, nibh ipsum fringilla tellus, vitae dignissim dolor ipsum non lectus|Suspendisse accumsan ut velit a ultrices|Mauris cursus posuere elit sed tempor|Nulla sit amet vehicula purus|Fusce laoreet enim nunc, ut imperdiet leo gravida ac|Curabitur nec libero cursus, pulvinar felis efficitur, tincidunt nulla|Ut tincidunt leo eget porttitor suscipit|Fusce laoreet pulvinar pulvinar.";

            string[] nameArray = names.Split('|');
            string[] loremArray = lorem.Split('|');

            for(int i = 0; i < 30; i++)
            {
                this.Friends.Add(new Model_UserDetails()
                {
                    Name = nameArray[r.Next(0, nameArray.Length - 1)],
                    Status = (Enum_FriendStatus)r.Next(0, 3), // 3?
                    //DisplayPictureURL = "https://randomuser.me/api/portraits/lego/" + r.Next(1, 9) + ".jpg",
                    DisplayPictureURL = new Uri("https://randomuser.me/api/portraits/lego/8.jpg"),
                    LastMessage = loremArray[r.Next(0, loremArray.Length - 1)]
                });
            }
        }
        #endregion
    }
}
