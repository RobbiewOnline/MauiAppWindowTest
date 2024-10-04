using Android.App;
using Android.Runtime;

namespace MauiAppWindowTest;

[Application]
public class MainApplication : MauiApplication
{
	public MainApplication(IntPtr handle, JniHandleOwnership ownership)
		: base(handle, ownership)
	{
		Logger.Log("MainApplication - constructor hit");
	}

	// protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

	protected override MauiApp CreateMauiApp() { 
		Logger.Log("MainApplication - CreateMauiApp invoked");
		var app = MauiProgram.CreateMauiApp();
		Logger.Log("MainApplication - CreateMauiApp invoked - done");
		return app;
	}	
}
