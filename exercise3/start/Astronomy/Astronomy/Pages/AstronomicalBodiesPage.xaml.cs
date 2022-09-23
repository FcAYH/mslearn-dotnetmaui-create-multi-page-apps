namespace Astronomy.Pages;

public partial class AstronomicalBodiesPage : ContentPage
{
	public AstronomicalBodiesPage()
	{
		InitializeComponent();

        btnEarth.Clicked += async (s, e) => { await Shell.Current.GoToAsync("astronomicalBodyPage?astroName=earth"); };
        btnMoon.Clicked += async (s, e) => { await Shell.Current.GoToAsync("astronomicalBodyPage?astroName=moon"); };
        btnSun.Clicked += async (s, e) => { await Shell.Current.GoToAsync("astronomicalBodyPage?astroName=sun"); };
        btnComet.Clicked += async (s, e) => { await Shell.Current.GoToAsync("astronomicalBodyPage?astroName=comet"); };
    }
}