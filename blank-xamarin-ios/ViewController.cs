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

			try 
			{
				var initTask = await FHClient.Init();
				if (initTask)
				{
					StatusLabel.Text = "FH init successful";
				}
			}
			catch(Exception e)
			{
				StatusLabel.Text = "FH init in error";
				Console.WriteLine("Error {0}", e);
			}
		}
	}
}