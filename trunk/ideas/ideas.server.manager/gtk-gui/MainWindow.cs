
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;

	private global::Gtk.Action FileAction;

	private global::Gtk.Action EditAction;

	private global::Gtk.Action HelpAction;

	private global::Gtk.Action aboutAction;

	private global::Gtk.Action quitAction;

	private global::Gtk.Action openAction;

	private global::Gtk.Action quitAction1;

	private global::Gtk.Action closeAction;

	private global::Gtk.VBox vbox1;

	private global::Gtk.MenuBar menubar3;

	private global::Gtk.HPaned hpaned1;

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

	private global::Gtk.TreeView applicationTreeView;

	private global::Gtk.Fixed fixed1;

	private global::Gtk.Button button17;

	private global::Gtk.Button button1;

	private global::Gtk.Statusbar statusbar1;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("File"), null, null);
		this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("File");
		w1.Add (this.FileAction, null);
		this.EditAction = new global::Gtk.Action ("EditAction", global::Mono.Unix.Catalog.GetString ("Edit"), null, null);
		this.EditAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Edit");
		w1.Add (this.EditAction, null);
		this.HelpAction = new global::Gtk.Action ("HelpAction", global::Mono.Unix.Catalog.GetString ("Help"), null, null);
		this.HelpAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Help");
		w1.Add (this.HelpAction, null);
		this.aboutAction = new global::Gtk.Action ("aboutAction", global::Mono.Unix.Catalog.GetString ("About"), null, "gtk-about");
		this.aboutAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("About");
		w1.Add (this.aboutAction, null);
		this.quitAction = new global::Gtk.Action ("quitAction", global::Mono.Unix.Catalog.GetString ("Exit"), null, "gtk-quit");
		this.quitAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Exit");
		w1.Add (this.quitAction, null);
		this.openAction = new global::Gtk.Action ("openAction", global::Mono.Unix.Catalog.GetString ("Open..."), null, "gtk-open");
		this.openAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Open Application");
		w1.Add (this.openAction, null);
		this.quitAction1 = new global::Gtk.Action ("quitAction1", global::Mono.Unix.Catalog.GetString ("Exit"), null, "gtk-quit");
		this.quitAction1.ShortLabel = global::Mono.Unix.Catalog.GetString ("Exit");
		w1.Add (this.quitAction1, null);
		this.closeAction = new global::Gtk.Action ("closeAction", global::Mono.Unix.Catalog.GetString ("Close Application"), null, "gtk-close");
		this.closeAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Close Application");
		w1.Add (this.closeAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("IDEAS Server Management");
		this.Icon = global::Gdk.Pixbuf.LoadFromResource ("ideas.server.manager.resources.icons.icon_128x128.png");
		this.WindowPosition = ((global::Gtk.WindowPosition)(1));
		this.DefaultWidth = 800;
		this.DefaultHeight = 600;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><menubar name='menubar3'><menu name='FileAction' action='FileAction'><menuitem name='openAction' action='openAction'/><menuitem name='closeAction' action='closeAction'/><separator/><menuitem name='quitAction1' action='quitAction1'/></menu><menu name='EditAction' action='EditAction'/><menu name='HelpAction' action='HelpAction'><menuitem name='aboutAction' action='aboutAction'/></menu></menubar></ui>");
		this.menubar3 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar3")));
		this.menubar3.Name = "menubar3";
		this.vbox1.Add (this.menubar3);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.menubar3]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hpaned1 = new global::Gtk.HPaned ();
		this.hpaned1.CanFocus = true;
		this.hpaned1.Name = "hpaned1";
		this.hpaned1.Position = 276;
		// Container child hpaned1.Gtk.Paned+PanedChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.applicationTreeView = new global::Gtk.TreeView ();
		this.applicationTreeView.CanFocus = true;
		this.applicationTreeView.Name = "applicationTreeView";
		this.GtkScrolledWindow.Add (this.applicationTreeView);
		this.hpaned1.Add (this.GtkScrolledWindow);
		global::Gtk.Paned.PanedChild w4 = ((global::Gtk.Paned.PanedChild)(this.hpaned1[this.GtkScrolledWindow]));
		w4.Resize = false;
		// Container child hpaned1.Gtk.Paned+PanedChild
		this.fixed1 = new global::Gtk.Fixed ();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button17 = new global::Gtk.Button ();
		this.button17.CanFocus = true;
		this.button17.Name = "button17";
		this.button17.UseUnderline = true;
		// Container child button17.Gtk.Container+ContainerChild
		global::Gtk.Alignment w5 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		global::Gtk.HBox w6 = new global::Gtk.HBox ();
		w6.Spacing = 2;
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Image w7 = new global::Gtk.Image ();
		w7.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-execute", global::Gtk.IconSize.Menu);
		w6.Add (w7);
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Label w9 = new global::Gtk.Label ();
		w9.LabelProp = global::Mono.Unix.Catalog.GetString ("Start");
		w9.UseUnderline = true;
		w6.Add (w9);
		w5.Add (w6);
		this.button17.Add (w5);
		this.fixed1.Add (this.button17);
		global::Gtk.Fixed.FixedChild w13 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button17]));
		w13.X = 9;
		w13.Y = 13;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button1 = new global::Gtk.Button ();
		this.button1.CanFocus = true;
		this.button1.Name = "button1";
		this.button1.UseUnderline = true;
		// Container child button1.Gtk.Container+ContainerChild
		global::Gtk.Alignment w14 = new global::Gtk.Alignment (0.5f, 0.5f, 0f, 0f);
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		global::Gtk.HBox w15 = new global::Gtk.HBox ();
		w15.Spacing = 2;
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Image w16 = new global::Gtk.Image ();
		w16.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-stop", global::Gtk.IconSize.Menu);
		w15.Add (w16);
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Label w18 = new global::Gtk.Label ();
		w18.LabelProp = global::Mono.Unix.Catalog.GetString ("Stop");
		w18.UseUnderline = true;
		w15.Add (w18);
		w14.Add (w15);
		this.button1.Add (w14);
		this.fixed1.Add (this.button1);
		global::Gtk.Fixed.FixedChild w22 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button1]));
		w22.X = 13;
		w22.Y = 52;
		this.hpaned1.Add (this.fixed1);
		this.vbox1.Add (this.hpaned1);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hpaned1]));
		w24.Position = 1;
		// Container child vbox1.Gtk.Box+BoxChild
		this.statusbar1 = new global::Gtk.Statusbar ();
		this.statusbar1.Name = "statusbar1";
		this.statusbar1.Spacing = 6;
		this.vbox1.Add (this.statusbar1);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.statusbar1]));
		w25.Position = 2;
		w25.Expand = false;
		w25.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.aboutAction.Activated += new global::System.EventHandler (this.aboutAction_Click);
		this.quitAction.Activated += new global::System.EventHandler (this.mnuFileExit_Click);
		this.openAction.Activated += new global::System.EventHandler (this.mnuOpenApplication_Click);
		this.quitAction1.Activated += new global::System.EventHandler (this.mnuFileExit_Click);
		this.button17.Clicked += new global::System.EventHandler (this.btnStart_Click);
		this.button1.Clicked += new global::System.EventHandler (this.btnStop_Click);
	}
}
