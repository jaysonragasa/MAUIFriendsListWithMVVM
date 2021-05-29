using FriendsList.Enums;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using System;
using System.Globalization;

namespace FriendsList.Converters
{
    public class Converter_StatusToColor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Color color = Color.FromArgb("#ff00ff00");

            if(value is Enum_FriendStatus)
            {
                var stat = (Enum_FriendStatus)value;

                color = stat switch
                {
                    Enum_FriendStatus.IDLE => Color.FromArgb("#FFFF9933"),
                    Enum_FriendStatus.OFFLINE => Color.FromArgb("#00000000"),
                    Enum_FriendStatus.ONLINE => Color.FromArgb("#ff00ff00"),
                    _ => Color.FromArgb("#ff00ff00")
                };
            }

            return color;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
