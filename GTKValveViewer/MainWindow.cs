using System;
using System.Linq;
using Gtk;
using GTKValveViewer;

public partial class MainWindow : Gtk.Window
{
	public MainWindow() : base(Gtk.WindowType.Toplevel)
	{
		Build();
	}

	protected void OnDeleteEvent(object sender, DeleteEventArgs a)
	{
		Application.Quit();
		a.RetVal = true;
	}

	protected void OnExit(object sender, EventArgs e)
	{
		Application.Quit();
	}

	protected void OnOpen(object sender, EventArgs e)
	{

		using (var chooser = new FileChooserDialog("Please select a valve resource file ...",
											this, FileChooserAction.Open,
											"Cancel", ResponseType.Cancel,
												   "Open", ResponseType.Accept))
		{
			foreach (var filter in HelperUtils.gatherFileFilters())
			{
				chooser.AddFilter(filter);
			}

			var response = chooser.Run();
			if (response == (int)ResponseType.Accept)
			{
				Console.WriteLine("{0}: picked", chooser.Filename);
				AddFile(chooser.Filename, chooser.Filter);
			}
			else if (response == (int)ResponseType.Cancel)
			{
				Console.WriteLine("File Open / Cancelled");
			}
			chooser.Destroy();
		}
	}





	protected void OnSettings(object sender, EventArgs e)
	{
	}

	protected void OnAbout(object sender, EventArgs e)
	{
	}

	protected void AddFile(String fileName, FileFilter filter)
	{		
		string[] filePath = fileName.Split('/');

		var l = new NotebookTabLabel(filePath.Last());

		var loader = HelperUtils.GetFileLoaderClass(fileName, filter);
		if ( loader == null ) {

			return;
		}

		var widget = loader.ProcessFile(fileName);
		widget.Show();
		l.Show();
		notebook.AppendPage(widget, l);
		l.CloseClicked += delegate (object obj, EventArgs eventArgs)
		{
			notebook.RemovePage(notebook.PageNum(widget));
		};
	}

}
