using System;

using UIKit;

namespace NavigationBar
{
	public partial class ViewController : UIViewController
	{
		private int _counter;

		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		private void ResetLabel(int counter)
		{
			counterLabel.Text = counter.ToString();
		}

		partial void addOneButton(UIButton sender)
		{
			ResetLabel(++_counter);
		}

		partial void navReset(UIBarButtonItem sender)
		{
			ResetLabel(0);
		}
	}
}
