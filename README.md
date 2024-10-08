

https://github.com/user-attachments/assets/15c09317-1ce9-4f94-a704-14bcd31e7e51

```csharp
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
```
