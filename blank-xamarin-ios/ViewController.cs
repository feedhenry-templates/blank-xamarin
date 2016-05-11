using System;

using UIKit;
using FHSDK;

namespace blank_xamarin_ios
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var initTask = FHClient.Init();
			initTask.ContinueWith(task => 
			{
				if (!task.IsFaulted)
				{
					StatusLabel.Text = "FH init successful";
				}
				else 
				{
					StatusLabel.Text = "FH init in error";
					Console.WriteLine("Error {0}", task.Exception);
				}
			});
		}
	}
}


