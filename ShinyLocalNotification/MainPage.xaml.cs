using Shiny.Notifications;

namespace ShinyLocalNotification;

public partial class MainPage : ContentPage
{   
    public MainPage()
	{
		InitializeComponent();
    }

	private async void OnCounterClicked(object sender, EventArgs e)
	{
        INotificationManager notificationManager = Handler.MauiContext.Services.GetService<INotificationManager>();

        await notificationManager.RequestAccess(AccessRequestFlags.All);
         
        notificationManager?.Send("Hello", "World");
    }
}


