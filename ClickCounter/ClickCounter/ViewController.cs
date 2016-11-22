using System;

using UIKit;

namespace ClickCounter
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
			ClickCounter.Text = "0";
		}

		partial void TapButton(UIButton sender)
		{
			RefreshCounter(++_counter);
		}

		partial void ResetButton(UIButton sender)
		{
			RefreshCounter(_counter = 0);
		}

		public void RefreshCounter(int counter)
		{
			ClickCounter.Text = counter.ToString();
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
