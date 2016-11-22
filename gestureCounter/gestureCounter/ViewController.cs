using System;

using UIKit;

namespace gestureCounter
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

		partial void ResetButton(UIButton sender)
		{
			SetCounterValue(0);
		}

		private void SetCounterValue(int counter)
		{
			this._counter = counter;
			counterLabel.Text = _counter.ToString();
		}

		#region SwipeGestures

		partial void LongPressGestureRecognizer(UILongPressGestureRecognizer sender)
		{
			return;
		}

		partial void RightSwipeGestureRecognizer(UISwipeGestureRecognizer sender)
		{
			SetCounterValue(--_counter);
		}

		partial void LeftSwipeGestureRecognizer(UISwipeGestureRecognizer sender)
		{
			SetCounterValue(++_counter);
		}

		partial void UpSwipeGestureRecognizer(UISwipeGestureRecognizer sender)
		{
			SetCounterValue(_counter - 10);
		}

		partial void DownSwipeGestureRecognizer(UISwipeGestureRecognizer sender)
		{
			SetCounterValue(_counter + 10);
		}

		#endregion

		partial void TouchDownTapOrHoldButton(UIButton sender)
		{
			SetCounterValue(++_counter);
		}
	}
}