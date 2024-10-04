namespace MauiAppWindowTest;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void PushOntoNavClicked(object sender, EventArgs e)
	{
		try {
		NextPage nextPage = new NextPage();
		Application.Current.MainPage.Navigation.PushAsync(nextPage);
		} catch (Exception ex) {
			DisplayAlert(
				"Whoops", 
				"You can't push onto a NavigationPage that isn't configured yet - change in app.xaml.cs before you can use this option", 
				"OK");
		}
	}

	private void ReplaceMainPageClicked(object sender, EventArgs e)
	{
		NextPage nextPage = new NextPage();
		nextPage.BackgroundColor = Colors.Red;
		Application.Current.MainPage = nextPage;
	}

	private void ReplacePageViaWindowClicked(object sender, EventArgs e)
	{
		NextPage nextPage = new NextPage();
		nextPage.BackgroundColor = Colors.Green;
		Application.Current.Windows.First().Page = nextPage;
	}

}

