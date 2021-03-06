
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;

	private global::Gtk.Action FileAction;

	private global::Gtk.Action HelpAction;

	private global::Gtk.Action OpenAction;

	private global::Gtk.Action ExitAction;

	private global::Gtk.Action SettingsAction;

	private global::Gtk.Action AboutAction;

	private global::Gtk.VBox vbox1;

	private global::Gtk.MenuBar menubar2;

	private global::Gtk.Notebook notebook;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup("Default");
		this.FileAction = new global::Gtk.Action("FileAction", global::Mono.Unix.Catalog.GetString("_File"), null, null);
		this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString("File");
		w1.Add(this.FileAction, null);
		this.HelpAction = new global::Gtk.Action("HelpAction", global::Mono.Unix.Catalog.GetString("Help"), null, null);
		this.HelpAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Help");
		w1.Add(this.HelpAction, null);
		this.OpenAction = new global::Gtk.Action("OpenAction", global::Mono.Unix.Catalog.GetString("_Open"), null, null);
		this.OpenAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Open");
		w1.Add(this.OpenAction, null);
		this.ExitAction = new global::Gtk.Action("ExitAction", global::Mono.Unix.Catalog.GetString("E_xit"), null, null);
		this.ExitAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Exit");
		w1.Add(this.ExitAction, null);
		this.SettingsAction = new global::Gtk.Action("SettingsAction", global::Mono.Unix.Catalog.GetString("Settings"), null, null);
		this.SettingsAction.ShortLabel = global::Mono.Unix.Catalog.GetString("Settings");
		w1.Add(this.SettingsAction, null);
		this.AboutAction = new global::Gtk.Action("AboutAction", global::Mono.Unix.Catalog.GetString("About"), null, null);
		this.AboutAction.ShortLabel = global::Mono.Unix.Catalog.GetString("About");
		w1.Add(this.AboutAction, null);
		this.UIManager.InsertActionGroup(w1, 0);
		this.AddAccelGroup(this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("GTK Valve Resource Viewer");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString("<ui><menubar name='menubar2'><menu name='FileAction' action='FileAction'><menuitem name='OpenAction' action='OpenAction'/><menuitem name='ExitAction' action='ExitAction'/></menu><menu name='HelpAction' action='HelpAction'><menuitem name='SettingsAction' action='SettingsAction'/><menuitem name='AboutAction' action='AboutAction'/></menu></menubar></ui>");
		this.menubar2 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget("/menubar2")));
		this.menubar2.Name = "menubar2";
		this.vbox1.Add(this.menubar2);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.menubar2]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.notebook = new global::Gtk.Notebook();
		this.notebook.CanFocus = true;
		this.notebook.Name = "notebook";
		this.notebook.CurrentPage = -1;
		this.notebook.TabPos = ((global::Gtk.PositionType)(0));
		this.vbox1.Add(this.notebook);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.notebook]));
		w3.Position = 1;
		this.Add(this.vbox1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 438;
		this.DefaultHeight = 300;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.OpenAction.Activated += new global::System.EventHandler(this.OnOpen);
		this.ExitAction.Activated += new global::System.EventHandler(this.OnExit);
		this.SettingsAction.Activated += new global::System.EventHandler(this.OnSettings);
		this.AboutAction.Activated += new global::System.EventHandler(this.OnAbout);
	}
}
