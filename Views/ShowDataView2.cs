namespace CallaciProjektMaui.Views;

public class ShowDataView2 : ContentPage
{
	public ShowDataView2()
	{
		Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
				}
			}
		};
	}
}