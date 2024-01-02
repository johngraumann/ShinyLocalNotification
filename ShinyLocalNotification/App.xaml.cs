namespace ShinyLocalNotification;

public partial class App : Application
{
    public App(IServiceProvider services)
	{
        InitializeComponent();

		MainPage = new AppShell();
	}
}

