// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;

namespace TableViewController
{
	public partial class TableViewController : UITableViewController
	{
		public TableViewController (IntPtr handle) : base (handle)
		{
		}

		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
			tableView.DeselectRow(indexPath, true);
		}
	}
}
