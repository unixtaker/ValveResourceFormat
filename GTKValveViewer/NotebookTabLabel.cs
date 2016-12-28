using System;
using Gtk;

namespace GTKValveViewer
{
	
	public partial class NotebookTabLabel : EventBox
	{
		public NotebookTabLabel(String title)
		{
			var button = new Button();
			button.Image = new Gtk.Image(Stock.Close, IconSize.Menu);
			button.TooltipText = "Close Tab";
			button.Relief = ReliefStyle.None;

			var rcstyle = new RcStyle();
			rcstyle.Xthickness = 0;
			rcstyle.Ythickness = 0;
			button.ModifyStyle(rcstyle);

			button.FocusOnClick = false;
			button.Clicked += OnCloseClicked;
			button.Show();

			var label = new Label(title);
			label.UseMarkup = false;
			label.UseUnderline = false;
			label.Show();

			var hbox = new HBox(false, 0);
			hbox.Spacing = 0;
			hbox.Add(label);
			hbox.Add(button);
			hbox.Show();
			this.Add(hbox);
		}

		public event EventHandler<EventArgs> CloseClicked;

		public void OnCloseClicked(object sender, EventArgs e)
		{
			if (CloseClicked != null)
			{
				CloseClicked(sender, e);
			}
		}

		public void OnCloseClicked()
		{
			OnCloseClicked(this, EventArgs.Empty);
		}
	}
}
