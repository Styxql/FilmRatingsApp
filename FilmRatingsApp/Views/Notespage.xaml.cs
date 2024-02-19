using FilmRatingsApp.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace FilmRatingsApp.Views;

public sealed partial class ViergePage : Page
{
    public UtilisateurViewModel ViewModel
    {
        get;
    }

    public ViergePage()
    {
        ViewModel = App.GetService<UtilisateurViewModel>();
        InitializeComponent();
    }
}
