namespace MauiAppWindowTest;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		// Originally was new Window(new ShellPage());

		// This will not let me switch out the 'main page' later
		return new Window(new MainPage());

		// Whereas this does!
		//return new Window(new NavigationPage(new MainPage()));
	}
}
