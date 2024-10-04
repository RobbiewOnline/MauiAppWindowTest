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

		return new Window(new NavigationPage(new MainPage()));
	}
}
