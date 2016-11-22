// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace gestureCounter
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UILabel counterLabel { get; set; }

		[Outlet]
		UIKit.UIButton TapOrHoldButton { get; set; }

		[Action ("DownSwipeGestureRecognizer:")]
		partial void DownSwipeGestureRecognizer (UIKit.UISwipeGestureRecognizer sender);

		[Action ("LeftSwipeGestureRecognizer:")]
		partial void LeftSwipeGestureRecognizer (UIKit.UISwipeGestureRecognizer sender);

		[Action ("LongPressGestureRecognizer:")]
		partial void LongPressGestureRecognizer (UIKit.UILongPressGestureRecognizer sender);

		[Action ("ResetButton:")]
		partial void ResetButton (UIKit.UIButton sender);

		[Action ("RightSwipeGestureRecognizer:")]
		partial void RightSwipeGestureRecognizer (UIKit.UISwipeGestureRecognizer sender);

		[Action ("TouchDownTapOrHoldButton:")]
		partial void TouchDownTapOrHoldButton (UIKit.UIButton sender);

		[Action ("UpSwipeGestureRecognizer:")]
		partial void UpSwipeGestureRecognizer (UIKit.UISwipeGestureRecognizer sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (counterLabel != null) {
				counterLabel.Dispose ();
				counterLabel = null;
			}

			if (TapOrHoldButton != null) {
				TapOrHoldButton.Dispose ();
				TapOrHoldButton = null;
			}
		}
	}
}
