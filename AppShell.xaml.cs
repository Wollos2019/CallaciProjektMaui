using CallaciProjektMaui.Views;

namespace CallaciProjektMaui;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute("QuizView", typeof(QuizView));
    }
}
