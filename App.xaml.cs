namespace LoginFlowMAUI;

public partial class App : Application
{
	public App()
	{

		Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NBaF5cXmZCe0xyWmFZfVpgc19GYFZQRGY/P1ZhSXxXdkFjXX5XcHRURGBZUEw=");

		InitializeComponent();

		MainPage = new AppShell();
	}
}
