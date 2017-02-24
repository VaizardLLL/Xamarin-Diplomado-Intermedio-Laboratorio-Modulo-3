using Xamarin.Forms;

namespace Contacts
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
			var startup = new XamarinDiplomado.Participants.Startup.Startup("UserName", "EMail", 1, 3);
			startup.Init();
			MainPage = new NavigationPage(new LoginPage());
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
