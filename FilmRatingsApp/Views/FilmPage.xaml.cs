using FilmRatingsApp.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace FilmRatingsApp.Views;

public sealed partial class Vierge1Page : Page
{
    public HomeViewModel ViewModel
    {
        get;
    }

    public Vierge1Page()
    {
        ViewModel = App.GetService<HomeViewModel>();
        InitializeComponent();
    }
}
