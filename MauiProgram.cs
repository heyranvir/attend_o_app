using LoginFlowMAUI.Pages;
using LoginFlowMAUI.Services;
using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;

namespace LoginFlowMAUI;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder.ConfigureSyncfusionCore();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		builder.Services.AddTransient<AuthService>();
		builder.Services.AddTransient<LoadingPage>();
		builder.Services.AddTransient<LoginPage>();
		builder.Services.AddTransient<ProfilePage>();

		return builder.Build();
	}
}
