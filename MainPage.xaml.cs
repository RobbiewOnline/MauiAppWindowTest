namespace MauiAppWindowTest;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		Task.Run(() => {
			// An exeriment by taking off the EDT, wait 5s, then hop back on the EDT
			// to transition the page.
			_ = Task.Delay(5000).ContinueWith((t) => {
					NextPage nextPage = new NextPage();
					nextPage.BackgroundColor = Colors.Blue;
					ChangeRootPage(nextPage);
			});
		});
		
	}

	private void PushOntoNavClicked(object sender, EventArgs e)
	{
		NextPage nextPage = new NextPage();
		Application.Current.MainPage.Navigation.PushAsync(nextPage);
	}

	private void ReplaceMainPageClicked(object sender, EventArgs e)
	{
		NextPage nextPage = new NextPage();
		nextPage.BackgroundColor = Colors.Red;
		ChangeRootPage(nextPage);
	}

	private void ReplacePageViaWindowClicked(object sender, EventArgs e)
	{
		NextPage nextPage = new NextPage();
		nextPage.BackgroundColor = Colors.Green;
		ChangeRootPage(nextPage);
	}

	private void ChangeRootPage(Page page) {
		MainThread.BeginInvokeOnMainThread(() => {
			if (Application.Current == null) {
				return; // Can't do it
			}
			Application.Current.Windows.First().Page = page;
		});
	}

}

