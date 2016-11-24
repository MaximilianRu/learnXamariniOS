using System;

using UIKit;

namespace gestureCounter
{
	public partial class ViewController : UIViewController
	{
		private int _counter = 0;

		private System.Timers.Timer _timer = new System.Timers.Timer(300.0);

		private int Counter {
			get { return _counter; }
			set {
					_counter = value;
					InvokeOnMainThread(() => {
							counterLabel.Text = _counter.ToString();
						}
					);
                }
		}

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
			Counter = 0;
		}

		#region SwipeGestures

		partial void RightSwipeGestureRecognizer(UISwipeGestureRecognizer sender)
		{
			--Counter;
		}

		partial void LeftSwipeGestureRecognizer(UISwipeGestureRecognizer sender)
		{
			++Counter;
		}

		partial void UpSwipeGestureRecognizer(UISwipeGestureRecognizer sender)
		{
			Counter -= 10;
		}

		partial void DownSwipeGestureRecognizer(UISwipeGestureRecognizer sender)
		{
			Counter += 10;
		}

		#endregion

		#region TouchEvents

		partial void TouchDownTapButton(UIButton sender)
		{
			++Counter;

			_timer.Start();
			_timer.Elapsed += delegate
			{
				_timer.Interval = 120.0;
				Counter++;
				Console.Write(_timer.Interval);
			};
		}

		partial void TouchUpInsideTapButton(UIButton sender)
		{
			_timer.Stop();
			_timer.Interval = 300.0;
			Console.Write(_timer.Interval);
		}

		#endregion
	}
}