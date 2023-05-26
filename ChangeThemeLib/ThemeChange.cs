using static System.Net.Mime.MediaTypeNames;
using System.Windows;
using Xamarin.Forms;

namespace ChangeThemeLib
{
    public class ThemeChange
    {
        public static void ChangeTheme(ResourceDictionary newTheme)
        {
            // Очистить текущие словари ресурсов
            Xamarin.Forms.Application.Current.Resources.Clear();

            // Установить новый словарь ресурсов
            Xamarin.Forms.Application.Current.Resources.MergedDictionaries.Add(newTheme);
        }
    }
}