using Microsoft.Extensions.Logging;

namespace MauiAppWindowTest;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{

		Logger.Log("MauiProgram - CreateMauiApp creating builder..");
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		Logger.Log("MauiProgram - CreateMauiApp creating builder - adding debug");
		builder.Logging.AddDebug();
#endif

		Logger.Log("MauiProgram - CreateMauiApp creating builder - returning build");
		return builder.Build();
	}
}
