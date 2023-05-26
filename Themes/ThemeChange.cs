using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Themes
{
    public class ThemeChange
    {
        public static string themeValue;
        public static string ThemeValue 
        {
            get
            {
                return themeValue;
            }
            set
            {
                themeValue = value;
                var dictionary = new ResourceDictionary
                {
                    Source = new Uri($"pack://application:,,,/Themes;component/Themes/{value}Theme.xaml", UriKind.RelativeOrAbsolute)
                };
                Application.Current.Resources.MergedDictionaries.RemoveAt(0);
                Application.Current.Resources.MergedDictionaries.Insert(0, dictionary);
            }
        }
    }
}
