namespace DemoThemeApp
{
    public partial class App : Application
    {
        public App()
        {
            this
            .Resources(AppStyles.Default)
            .MainPage(new AppShell());
        }


        public static void ChangeTheme(){
            App.Current.UserAppTheme = App.Current.UserAppTheme switch
            {
                AppTheme.Dark => AppTheme.Light,
                AppTheme.Light => AppTheme.Dark,
                _ => AppTheme.Light
            };

            App.Current.Resources.MergedDictionaries.Clear();
            App.Current.Resources.MergedDictionaries.Add(AppStyles.Default);
        }
    }
}
