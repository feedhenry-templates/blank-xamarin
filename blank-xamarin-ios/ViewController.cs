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

		public async override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			try {
				await FHClient.Init();
				StatusLabel.Text = "FH init succeed";
			} catch(Exception) {
				StatusLabel.Text = "FH init failed";
			}
		}
	}
}


