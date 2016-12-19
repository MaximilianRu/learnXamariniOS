// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace NavigationBar
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UILabel counterLabel { get; set; }

		[Action ("addOneButton:")]
		partial void addOneButton (UIKit.UIButton sender);

		[Action ("navReset:")]
		partial void navReset (UIKit.UIBarButtonItem sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (counterLabel != null) {
				counterLabel.Dispose ();
				counterLabel = null;
			}
		}
	}
}
