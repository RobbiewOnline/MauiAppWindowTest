namespace MauiAppWindowTest;

public partial class App : Application
{
	public App()
	{
		Logger.Log("App - constructor");
		InitializeComponent();
		Logger.Log("App - constructor - done");
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		// Originally was new Window(new ShellPage()); - but I don't use Shell
		Logger.Log("App - CreateWindow");

		var targetPage = new NavigationPage(new MainPage());
		Logger.Log("App - CreateWindow - target page prepped");

		var window = new Window(targetPage);
		Logger.Log("App - CreateWindow - window prepped, returning window");

		return window;
	}
}
