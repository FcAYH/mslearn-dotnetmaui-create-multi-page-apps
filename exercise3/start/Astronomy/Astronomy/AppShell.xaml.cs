using Astronomy.Pages;

namespace Astronomy;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute("astronomicalBodyPage", typeof(AstronomicalBodyPage));
    }
}
