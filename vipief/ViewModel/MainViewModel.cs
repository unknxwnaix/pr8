using System.Collections.ObjectModel;
using vipief.Model;
using vipief.ViewModel.Helpers;
using SerealizationAndDeserealizationLib1;
using Themes;
using Languages;
using System.Windows;
using System;

namespace vipief.ViewModel
{
    internal class MainViewModel : BindingHelper
    {
        #region Команды
        public BindableCommand AddCommand { get; set; }
        public BindableCommand Upload { get; set; }
        public BindableCommand Save { get; set; }
        public BindableCommand Theme { get; set; }
        public BindableCommand Language { get; set; }
        #endregion

        #region Свойства
        public string themeName;
        public string ThemeName
        {
            get
            {
                return themeName;
            }
            set
            {
                themeName = value;
                OnPropertyChanged();
            }
        }

        public string languageName;
        public string LanguageName
        {
            get
            {
                return languageName;
            }
            set
            {
                languageName = value;
                OnPropertyChanged();
            }
        }

        private Colour selected = new Colour();
        public Colour Selected
        {
            get { return selected; }
            set
            {
                selected = value;
                OnPropertyChanged();
            }   
        }

        private ObservableCollection<Colour> colours;
        public ObservableCollection<Colour> Colours
        {
            get { return colours; }
            set
            {
                colours = value;
                OnPropertyChanged();
            }
        }

        #endregion

        public MainViewModel()
        {
            #region Команды кнопок
            AddCommand = new BindableCommand(_ => AddItems());
            Upload = new BindableCommand(_ => UploadItems());
            Save = new BindableCommand(_ => SaveItems());
            Theme = new BindableCommand(_ => ChangeTheme());
            Language = new BindableCommand(_ => ChangeLanguage());
            #endregion

            ThemeName = "Orange";
            LanguageName = "Ru";
            Colours = new ObservableCollection<Colour>()
            {
                new Colour("Насыщенный фиолетовый", "#53377A"),
                new Colour("Сине-зеленый", "#008080")
            };
        }

        public void AddItems()
        {
            Colours.Add(Selected);
        }

        public void UploadItems()
        {
            Colours = SerealizationAndDeserealizationLib.Deserialize<ObservableCollection<Colour>>();
        }

        public void SaveItems()
        {
            SerealizationAndDeserealizationLib.Serialize(Colours);
        }

        public void ChangeTheme()
        {
            ThemeName = (themeName == "Orange") ? "Purple" : "Orange";
            ThemeChange.ThemeValue = themeName;
        }

        public void ChangeLanguage()
        {
            LanguageName = (languageName == "Ru") ? "Eng" : "Ru";
            LanguageChange.LanguageChangeConstructor = languageName;
        }
    }
}
