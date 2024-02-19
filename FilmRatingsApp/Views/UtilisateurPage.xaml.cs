using FilmRatingsApp.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace FilmRatingsApp.Views;

public sealed partial class Vierge2Page : Page
{
    public NotesViewModel ViewModel
    {
        get;
    }

    public Vierge2Page()
    {
        ViewModel = App.GetService<NotesViewModel>();
        InitializeComponent();
    }
}
