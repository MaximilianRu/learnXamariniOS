// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace ClickCounter
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UILabel ClickCounter { get; set; }

		[Action ("ResetButton:")]
		partial void ResetButton (UIKit.UIButton sender);

		[Action ("TapButton:")]
		partial void TapButton (UIKit.UIButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (ClickCounter != null) {
				ClickCounter.Dispose ();
				ClickCounter = null;
			}
		}
	}
}
