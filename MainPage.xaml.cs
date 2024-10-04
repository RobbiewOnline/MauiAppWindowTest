namespace MauiAppWindowTest;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		Logger.Log("MainPage - constructor");
		InitializeComponent();
		Logger.Log("MainPage - constructor - starting background task");

		Task.Run(() => {
			// An exeriment by taking off the EDT, wait 5s, then hop back on the EDT
			// to transition the page.
			Logger.Log("MainPage - constructor - starting background task - waiting 5s");
			_ = Task.Delay(5000).ContinueWith((t) => {
					Logger.Log("MainPage - constructor - on background task - creating new page");
					NextPage nextPage = new NextPage();
					nextPage.BackgroundColor = Colors.Blue;
					Logger.Log("MainPage - constructor - on background task - requesting transition on EDT");
					ChangeRootPageOnEDT(nextPage);
					Logger.Log("MainPage - constructor - on background task - requesting transition on EDT - done");
			});
		});

		Logger.Log("MainPage - constructor - starting background task - done");
	}

	private void FuchsiaPushOntoNavClicked(object sender, EventArgs e)
	{
		Logger.Log("MainPage - FuchsiaPushOntoNavClicked, pushing onto nav stack");
		NextPage nextPage = new NextPage();
		nextPage.BackgroundColor = Colors.Fuchsia;
		Application.Current.MainPage.Navigation.PushAsync(nextPage);
		Logger.Log("MainPage - FuchsiaPushOntoNavClicked - done");
	}

	private void RedPageViaWindowClicked(object sender, EventArgs e)
	{
		Logger.Log("MainPage - RedPageViaWindowClicked, requesting transition on EDT");
		NextPage nextPage = new NextPage();
		nextPage.BackgroundColor = Colors.Red;
		ChangeRootPageOnEDT(nextPage);
		Logger.Log("MainPage - RedPageViaWindowClicked, requesting transition on EDT - done");
	}

	private void GreenPageViaWindowClicked(object sender, EventArgs e)
	{
		Logger.Log("MainPage - GreenPageViaWindowClicked, requesting transition on EDT");
		NextPage nextPage = new NextPage();
		nextPage.BackgroundColor = Colors.Green;
		ChangeRootPageOnEDT(nextPage);
		Logger.Log("MainPage - GreenPageViaWindowClicked, requesting transition on EDT - done");
	}

	private void ChangeRootPageOnEDT(Page page) {
		Logger.Log("MainPage - ChangeRootPageOnEDT, requesting transition, ensuring on EDT");
		
		MainThread.BeginInvokeOnMainThread(() => {
			Logger.Log("MainPage - ChangeRootPageOnEDT, now on EDT");
			if (Application.Current == null) {
				Logger.Log("MainPage - ChangeRootPageOnEDT, OOPS - no Application.Current - can't do it");
				return; // Can't do it
			}

			Logger.Log("MainPage - ChangeRootPageOnEDT, replacing window with page:"+page+" (colour:"+page.BackgroundColor+")");
			Application.Current.Windows.First().Page = page;
			Logger.Log("MainPage - ChangeRootPageOnEDT, transition done");
		});

		Logger.Log("MainPage - ChangeRootPageOnEDT - done");
	}

}

