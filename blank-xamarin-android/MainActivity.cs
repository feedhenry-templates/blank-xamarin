using Android.App;
using Android.Widget;
using Android.OS;
using FHSDK;

namespace fhxamarinandroidblank
{
	[Activity (Label = "fh-xamarin-android-blank", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		

		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			// Set our view from the "main" layout resource
			//SetContentView (Resource.Layout.Main);

			var initTask = FHClient.Init();
			initTask.ContinueWith(task =>
				{RunOnUiThread(()=>{
					if (!task.IsFaulted)
					{
						Toast.MakeText(this, "Init complete", ToastLength.Long).Show();
					}
					else 
					{
						Toast.MakeText(this, "Init failed " + task.Exception, ToastLength.Long).Show();
					}
				});

			});
		}
	}
}


