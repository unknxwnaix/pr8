using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Languages
{
    public class LanguageChange
    {
        public static string languageChange;
        public static string LanguageChangeConstructor
        {
            get
            {
                return languageChange;
            }
            set
            {
                languageChange = value;
                var dictionary = new ResourceDictionary
                {
                    Source = new Uri($"pack://application:,,,/Languages;component/Themes/Language{value}.xaml", UriKind.RelativeOrAbsolute)
                };
                Application.Current.Resources.MergedDictionaries.RemoveAt(1);
                Application.Current.Resources.MergedDictionaries.Insert(1, dictionary);
            }
        }
    }
}
