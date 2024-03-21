# MauiApp1

## About
(Example).NET MAUI  for Beginners

[.NET MAUI Data Binding with MVVM & XAML [5 of 8] | .NET MAUI for Beginners](https://youtu.be/5Qga2pniN78?si=PAhENHsYOcuLo-EoY)
[Navigating Between Pages in .NET MAUI [6 of 8] | .NET MAUI for Beginners](https://youtu.be/ddmZ6k1GIkM?si=k044iqszyKdoxz2X)

## Environment
* IDE: Visual Studio 2022
* Language: C#
* Applied Project Template: .MAUI APP
* NuGet
  * CommunityToolkit.Mvvm
* Third Party Libraries: x
* DataBase: x

## Reference
* [Grid](https://learn.microsoft.com/ko-kr/dotnet/maui/user-interface/layouts/grid?view=net-maui-8.0)
* [Control](https://learn.microsoft.com/ko-kr/dotnet/maui/user-interface/controls/?view=net-maui-8.0)
* [x:Array: XAML 태그 확장 사용](https://learn.microsoft.com/en-us/dotnet/maui/xaml/markup-extensions/consume?view=net-maui-8.0)
* [XAML markup extensions](https://learn.microsoft.com/ko-kr/dotnet/desktop/xaml-services/xarray-markup-extension)
* [8 Very Useful Markup Extensions in .NET MAUI](https://www.telerik.com/blogs/8-very-useful-markup-extensions-dotnet-maui)
* [Binding](https://learn.microsoft.com/ko-kr/dotnet/maui/fundamentals/data-binding/?view=net-maui-8.0)
* [MVVM](https://learn.microsoft.com/ko-kr/dotnet/architecture/maui/mvvm)
* [MVVM Toolkit](https://learn.microsoft.com/ko-kr/dotnet/architecture/maui/mvvm-community-toolkit-features)
* [data binding](https://learn.microsoft.com/ko-kr/dotnet/maui/fundamentals/data-binding/?view=net-maui-8.0)
* [training dotnet maui](https://learn.microsoft.com/ko-kr/training/browse/?expanded=dotnet&products=dotnet-maui)

## Process
* install Nuget CommunityToolkit.Mvvm
* create ViewModel Folder and MainViewModel.cs class
* MainViewModel.cs: 
	* public partial class MainViewModel : ObservableObject 
	* add ObservableProperty, RelayCommand
* MainPage.xaml: add ContentPage and Add Data Binding
  	* xmlns:viewmodel="clr-namespace:MauiApp2.ViewModel"
	* x:DataType="viewmodel:MainViewModel"
	* use Data Binding and x:DataType
* MainPage.xaml.cs: add BindingContext = vm;
* MauiProgram.cs: Add AddSingleton
	* builder.Services.AddSingleton<MainPage>(); 
	* builder.Services.AddSingleton<MainViewModel>();