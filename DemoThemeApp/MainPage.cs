﻿using System.Reflection;

namespace DemoThemeApp;

public partial class MainPage : ContentPage, IFmgLibHotReload
{
    public MainPage()
    {
        this.InitializeHotReload();
    }

    public void Build()
    {
        var version = typeof(MauiApp).Assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;
        
        this
        .BackgroundColor(e => e.DynamicResource("myColor"))
        .Content(
            new ScrollView()
            .Content(
                new Grid()
                .RowDefinitions(e => e.Star(90).Star(10))
                .Children(
                    new StackLayout()
                    .Spacing(25)
                    .Children(
                        new Label()
                        .Text("Hello, World!")
                        .FontSize(32)
                        .CenterHorizontal()
                        .SemanticHeadingLevel(SemanticHeadingLevel.Level1),

                        new Label()
                        .Text("Welcome to FmgLib .NET MAUI Markup App")
                        .FontSize(18)
                        .CenterHorizontal()
                        .SemanticDescription("Welcome to dot net Multi platform App U I")
                        .SemanticHeadingLevel(SemanticHeadingLevel.Level1),

                        
                        new Button()
                        .Text("Click me")
                        .CenterHorizontal()
                        .OnClicked((s,e)=>{
                            App.ChangeTheme();
                        })
                        .SemanticHint("Counts the number of times you click")
                    ),

                    new Grid()
                    .BackgroundColor(AppColors.Primary)
                    .Row(1)
                    .Children(
                        new Label()
                        .Text($"dotNet version: {version}")
                        .TextColor(White)
                        .Center()
                    )
                )
            )
        );
    }
}
