using Android.App;
using Android.Widget;
using Android.OS;
using FHSDK.Droid;

namespace fhxamarinandroidblank
{
	[Activity (Label = "fh-xamarin-android-blank", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected async override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			SetContentView (Resource.Layout.Main);

			await FHClient.Init();

		}
	}
}


