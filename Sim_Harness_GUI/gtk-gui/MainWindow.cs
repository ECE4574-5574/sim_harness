
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox mainLayoutBox;
	
	private global::Gtk.Label mainWindowTitleLabel;
	
	private global::Gtk.HBox topLayoutBox;
	
	private global::Gtk.VBox paramsBox;
	
	private global::Gtk.Label serverURLLable;
	
	private global::Gtk.Entry serverURLEntry;
	
	private global::Gtk.Label scenarioLabel;
	
	private global::Gtk.HBox hbox3;
	
	private global::Gtk.Button scenarioDirButton;
	
	private global::Gtk.Entry scenarioDirectoryText;
	
	private global::Gtk.Label appSimLocationLabel;
	
	private global::Gtk.HBox appLocationHBox;
	
	private global::Gtk.Button appSimulatorChooseFileButton;
	
	private global::Gtk.Entry appSimLocationEntry;
	
	private global::Gtk.Label houseSimLocationLabel;
	
	private global::Gtk.HBox houseLocationHBox;
	
	private global::Gtk.Button houseSimLocationButton;
	
	private global::Gtk.Entry houseSimLocationEntry;
	
	private global::Gtk.Label timeFrameLabel;
	
	private global::Gtk.HBox hbox10;
	
	private global::Gtk.Label realSecondLabel;
	
	private global::Gtk.SpinButton timeFrameSpeedSpinbutton;
	
	private global::Gtk.Label simSecondLabel;
	
	private global::Gtk.VSeparator vseparator1;
	
	private global::Gtk.VBox vbox3;
	
	private global::Gtk.Label Test_Scenario_Lable;
	
	private global::Gtk.ComboBox testScenarioComboBox;
	
	private global::Gtk.Label simDetailsLabel;
	
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	
	private global::Gtk.TextView testSenarioTextview;
	
	private global::Gtk.VBox vbox5;
	
	private global::Gtk.Label label3;
	
	private global::Gtk.Entry userURLentry;
	
	private global::Gtk.Label label4;
	
	private global::Gtk.Entry HouseURLentry;
	
	private global::Gtk.VBox vbox4;
	
	private global::Gtk.HBox hbox11;
	
	private global::Gtk.Label label8;
	
	private global::Gtk.HBox hbox14;
	
	private global::Gtk.SpinButton hourSpinBox;
	
	private global::Gtk.Label label10;
	
	private global::Gtk.HBox hbox16;
	
	private global::Gtk.SpinButton minSpinBox;
	
	private global::Gtk.Label label13;
	
	private global::Gtk.HSeparator hseparator3;
	
	private global::Gtk.HBox hbox4;
	
	private global::Gtk.VBox vbox14;
	
	private global::Gtk.HBox hbox12;
	
	private global::Gtk.Button loadScenarioButton;
	
	private global::Gtk.Button startTestButton;
	
	private global::Gtk.HSeparator hseparator2;
	
	private global::Gtk.Label currTestRunLabel;
	
	private global::Gtk.VBox vbox15;
	
	private global::Gtk.ScrolledWindow GtkScrolledWindow1;
	
	private global::Gtk.TextView currentTestTextview;
	
	private global::Gtk.Button endTestButton;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Sim Harness");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.BorderWidth = ((uint)(27));
		this.Gravity = ((global::Gdk.Gravity)(5));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.mainLayoutBox = new global::Gtk.VBox ();
		this.mainLayoutBox.Name = "mainLayoutBox";
		this.mainLayoutBox.Spacing = 6;
		// Container child mainLayoutBox.Gtk.Box+BoxChild
//		this.mainWindowTitleLabel = new global::Gtk.Label ();
//		this.mainWindowTitleLabel.Name = "mainWindowTitleLabel";
//		this.mainWindowTitleLabel.Ypad = 7;
//		this.mainWindowTitleLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Sim Harness");
//		this.mainWindowTitleLabel.Justify = ((global::Gtk.Justification)(2));
//		this.mainLayoutBox.Add (this.mainWindowTitleLabel);
//		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.mainLayoutBox [this.mainWindowTitleLabel]));
//		w1.Position = 0;
//		w1.Expand = false;
//		w1.Fill = false;
		// Container child mainLayoutBox.Gtk.Box+BoxChild
		this.topLayoutBox = new global::Gtk.HBox ();
		this.topLayoutBox.Name = "topLayoutBox";
		this.topLayoutBox.Spacing = 10;
		// Container child topLayoutBox.Gtk.Box+BoxChild
		this.paramsBox = new global::Gtk.VBox ();
		this.paramsBox.Name = "paramsBox";
		this.paramsBox.Spacing = 6;
		// Container child paramsBox.Gtk.Box+BoxChild
		this.serverURLLable = new global::Gtk.Label ();
		this.serverURLLable.Name = "serverURLLable";
		this.serverURLLable.LabelProp = global::Mono.Unix.Catalog.GetString ("Server URL");
		this.serverURLLable.Justify = ((global::Gtk.Justification)(2));
		this.paramsBox.Add (this.serverURLLable);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.paramsBox [this.serverURLLable]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child paramsBox.Gtk.Box+BoxChild
		this.serverURLEntry = new global::Gtk.Entry ();
		this.serverURLEntry.CanFocus = true;
		this.serverURLEntry.Name = "serverURLEntry";
		this.serverURLEntry.IsEditable = true;
		this.serverURLEntry.InvisibleChar = '●';
		this.serverURLEntry.Text = "http://serverapi1.azurewebsites.net";
		this.paramsBox.Add (this.serverURLEntry);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.paramsBox [this.serverURLEntry]));
		w3.Position = 1;
		w3.Expand = false;
		w3.Fill = false;
		// Container child paramsBox.Gtk.Box+BoxChild
		this.scenarioLabel = new global::Gtk.Label ();
		this.scenarioLabel.Name = "scenarioLabel";
		this.scenarioLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Scenarios Directory");
		this.paramsBox.Add (this.scenarioLabel);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.paramsBox [this.scenarioLabel]));
		w4.Position = 2;
		w4.Expand = false;
		w4.Fill = false;
		// Container child paramsBox.Gtk.Box+BoxChild
		this.hbox3 = new global::Gtk.HBox ();
		this.hbox3.Name = "hbox3";
		this.hbox3.Spacing = 6;
		// Container child hbox3.Gtk.Box+BoxChild
		this.scenarioDirButton = new global::Gtk.Button ();
		this.scenarioDirButton.CanFocus = true;
		this.scenarioDirButton.Name = "scenarioDirButton";
		this.scenarioDirButton.UseUnderline = true;
		this.scenarioDirButton.Label = global::Mono.Unix.Catalog.GetString ("Choose...");
		this.hbox3.Add (this.scenarioDirButton);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.scenarioDirButton]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		// Container child hbox3.Gtk.Box+BoxChild
		this.scenarioDirectoryText = new global::Gtk.Entry ();
		this.scenarioDirectoryText.CanFocus = true;
		this.scenarioDirectoryText.Name = "scenarioDirectoryText";
		this.scenarioDirectoryText.IsEditable = false;
		this.scenarioDirectoryText.InvisibleChar = '●';
		this.hbox3.Add (this.scenarioDirectoryText);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.scenarioDirectoryText]));
		w6.Position = 1;
		this.paramsBox.Add (this.hbox3);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.paramsBox [this.hbox3]));
		w7.Position = 3;
		w7.Expand = false;
		w7.Fill = false;
		// Container child paramsBox.Gtk.Box+BoxChild
		this.appSimLocationLabel = new global::Gtk.Label ();
		this.appSimLocationLabel.Name = "appSimLocationLabel";
		this.appSimLocationLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("App Simulator Location");
		this.appSimLocationLabel.Justify = ((global::Gtk.Justification)(2));
		this.paramsBox.Add (this.appSimLocationLabel);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.paramsBox [this.appSimLocationLabel]));
		w8.Position = 4;
		w8.Expand = false;
		w8.Fill = false;
		// Container child paramsBox.Gtk.Box+BoxChild
		this.appLocationHBox = new global::Gtk.HBox ();
		this.appLocationHBox.Name = "appLocationHBox";
		this.appLocationHBox.Spacing = 6;
		// Container child appLocationHBox.Gtk.Box+BoxChild
		this.appSimulatorChooseFileButton = new global::Gtk.Button ();
		this.appSimulatorChooseFileButton.CanFocus = true;
		this.appSimulatorChooseFileButton.Name = "appSimulatorChooseFileButton";
		this.appSimulatorChooseFileButton.UseUnderline = true;
		this.appSimulatorChooseFileButton.Label = global::Mono.Unix.Catalog.GetString ("Choose...");
		this.appLocationHBox.Add (this.appSimulatorChooseFileButton);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.appLocationHBox [this.appSimulatorChooseFileButton]));
		w9.Position = 0;
		w9.Expand = false;
		w9.Fill = false;
		// Container child appLocationHBox.Gtk.Box+BoxChild
		this.appSimLocationEntry = new global::Gtk.Entry ();
		this.appSimLocationEntry.CanFocus = true;
		this.appSimLocationEntry.Name = "appSimLocationEntry";
		this.appSimLocationEntry.IsEditable = false;
		this.appSimLocationEntry.InvisibleChar = '●';
		this.appLocationHBox.Add (this.appSimLocationEntry);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.appLocationHBox [this.appSimLocationEntry]));
		w10.Position = 1;
		this.paramsBox.Add (this.appLocationHBox);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.paramsBox [this.appLocationHBox]));
		w11.Position = 5;
		w11.Expand = false;
		w11.Fill = false;
		// Container child paramsBox.Gtk.Box+BoxChild
		this.houseSimLocationLabel = new global::Gtk.Label ();
		this.houseSimLocationLabel.Name = "houseSimLocationLabel";
		this.houseSimLocationLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("House Simulator Location");
		this.paramsBox.Add (this.houseSimLocationLabel);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.paramsBox [this.houseSimLocationLabel]));
		w12.Position = 6;
		w12.Expand = false;
		w12.Fill = false;
		// Container child paramsBox.Gtk.Box+BoxChild
		this.houseLocationHBox = new global::Gtk.HBox ();
		this.houseLocationHBox.Name = "houseLocationHBox";
		this.houseLocationHBox.Spacing = 6;
		// Container child houseLocationHBox.Gtk.Box+BoxChild
		this.houseSimLocationButton = new global::Gtk.Button ();
		this.houseSimLocationButton.CanFocus = true;
		this.houseSimLocationButton.Name = "houseSimLocationButton";
		this.houseSimLocationButton.UseUnderline = true;
		this.houseSimLocationButton.Label = global::Mono.Unix.Catalog.GetString ("Choose...");
		this.houseLocationHBox.Add (this.houseSimLocationButton);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.houseLocationHBox [this.houseSimLocationButton]));
		w13.Position = 0;
		w13.Expand = false;
		w13.Fill = false;
		// Container child houseLocationHBox.Gtk.Box+BoxChild
		this.houseSimLocationEntry = new global::Gtk.Entry ();
		this.houseSimLocationEntry.CanFocus = true;
		this.houseSimLocationEntry.Name = "houseSimLocationEntry";
		this.houseSimLocationEntry.IsEditable = false;
		this.houseSimLocationEntry.InvisibleChar = '●';
		this.houseLocationHBox.Add (this.houseSimLocationEntry);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.houseLocationHBox [this.houseSimLocationEntry]));
		w14.Position = 1;
		this.paramsBox.Add (this.houseLocationHBox);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.paramsBox [this.houseLocationHBox]));
		w15.Position = 7;
		w15.Expand = false;
		w15.Fill = false;
		// Container child paramsBox.Gtk.Box+BoxChild
		this.timeFrameLabel = new global::Gtk.Label ();
		this.timeFrameLabel.Name = "timeFrameLabel";
		this.timeFrameLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Select Time Frame Speed");
		this.paramsBox.Add (this.timeFrameLabel);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.paramsBox [this.timeFrameLabel]));
		w16.Position = 8;
		w16.Expand = false;
		w16.Fill = false;
		// Container child paramsBox.Gtk.Box+BoxChild
		this.hbox10 = new global::Gtk.HBox ();
		this.hbox10.Name = "hbox10";
		this.hbox10.Spacing = 6;
		// Container child hbox10.Gtk.Box+BoxChild
		this.realSecondLabel = new global::Gtk.Label ();
		this.realSecondLabel.Name = "realSecondLabel";
		this.realSecondLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("1 Real Second = ");
		this.hbox10.Add (this.realSecondLabel);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.realSecondLabel]));
		w17.Position = 0;
		w17.Expand = false;
		w17.Fill = false;
		// Container child hbox10.Gtk.Box+BoxChild
		this.timeFrameSpeedSpinbutton = new global::Gtk.SpinButton (1, 10000, 1);
		this.timeFrameSpeedSpinbutton.CanFocus = true;
		this.timeFrameSpeedSpinbutton.Name = "timeFrameSpeedSpinbutton";
		this.timeFrameSpeedSpinbutton.Adjustment.PageIncrement = 10;
		this.timeFrameSpeedSpinbutton.ClimbRate = 1;
		this.timeFrameSpeedSpinbutton.Numeric = true;
		this.timeFrameSpeedSpinbutton.Value = 4;
		this.hbox10.Add (this.timeFrameSpeedSpinbutton);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.timeFrameSpeedSpinbutton]));
		w18.Position = 1;
		w18.Fill = false;
		// Container child hbox10.Gtk.Box+BoxChild
		this.simSecondLabel = new global::Gtk.Label ();
		this.simSecondLabel.Name = "simSecondLabel";
		this.simSecondLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Simulated Seconds");
		this.hbox10.Add (this.simSecondLabel);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.simSecondLabel]));
		w19.Position = 2;
		w19.Expand = false;
		w19.Fill = false;
		this.paramsBox.Add (this.hbox10);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.paramsBox [this.hbox10]));
		w20.Position = 9;
		w20.Expand = false;
		w20.Fill = false;
		this.topLayoutBox.Add (this.paramsBox);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.topLayoutBox [this.paramsBox]));
		w21.Position = 0;
		w21.Expand = false;
		w21.Fill = false;
		// Container child topLayoutBox.Gtk.Box+BoxChild
		this.vseparator1 = new global::Gtk.VSeparator ();
		this.vseparator1.Name = "vseparator1";
		this.topLayoutBox.Add (this.vseparator1);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.topLayoutBox [this.vseparator1]));
		w22.Position = 1;
		w22.Expand = false;
		w22.Fill = false;
		// Container child topLayoutBox.Gtk.Box+BoxChild
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.Test_Scenario_Lable = new global::Gtk.Label ();
		this.Test_Scenario_Lable.Name = "Test_Scenario_Lable";
		this.Test_Scenario_Lable.LabelProp = global::Mono.Unix.Catalog.GetString ("Test Scenarios");
		this.vbox3.Add (this.Test_Scenario_Lable);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.Test_Scenario_Lable]));
		w23.Position = 0;
		w23.Expand = false;
		w23.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.testScenarioComboBox = global::Gtk.ComboBox.NewText ();
		this.testScenarioComboBox.Name = "testScenarioComboBox";
		this.vbox3.Add (this.testScenarioComboBox);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.testScenarioComboBox]));
		w24.Position = 1;
		w24.Expand = false;
		w24.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.simDetailsLabel = new global::Gtk.Label ();
		this.simDetailsLabel.Name = "simDetailsLabel";
		this.simDetailsLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Test Details");
		this.vbox3.Add (this.simDetailsLabel);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.simDetailsLabel]));
		w25.Position = 2;
		w25.Expand = false;
		w25.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.testSenarioTextview = new global::Gtk.TextView ();
		this.testSenarioTextview.Buffer.Text = "None Selected \n(This will show what is contained in the selected Senario)";
		this.testSenarioTextview.WidthRequest = 200;
		this.testSenarioTextview.CanFocus = true;
		this.testSenarioTextview.Name = "testSenarioTextview";
		this.testSenarioTextview.Editable = false;
		this.GtkScrolledWindow.Add (this.testSenarioTextview);
		this.vbox3.Add (this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.GtkScrolledWindow]));
		w27.Position = 3;
		this.topLayoutBox.Add (this.vbox3);
		global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.topLayoutBox [this.vbox3]));
		w28.Position = 2;
		w28.Expand = false;
		w28.Fill = false;
		// Container child topLayoutBox.Gtk.Box+BoxChild
		this.vbox5 = new global::Gtk.VBox ();
		this.vbox5.Name = "vbox5";
		this.vbox5.Spacing = 6;
		// Container child vbox5.Gtk.Box+BoxChild
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("User URL ");
		this.label3.Justify = ((global::Gtk.Justification)(2));
		this.vbox5.Add (this.label3);
		global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.label3]));
		w29.Position = 0;
		w29.Expand = false;
		w29.Fill = false;
		// Container child vbox5.Gtk.Box+BoxChild
		this.userURLentry = new global::Gtk.Entry ();
		this.userURLentry.CanFocus = true;
		this.userURLentry.Name = "userURLentry";
		this.userURLentry.IsEditable = true;
		this.userURLentry.InvisibleChar = '●';
		this.vbox5.Add (this.userURLentry);
		global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.userURLentry]));
		w30.Position = 1;
		w30.Expand = false;
		w30.Fill = false;
		// Container child vbox5.Gtk.Box+BoxChild
		this.label4 = new global::Gtk.Label ();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("House URL");
		this.vbox5.Add (this.label4);
		global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.label4]));
		w31.Position = 2;
		w31.Expand = false;
		w31.Fill = false;
		// Container child vbox5.Gtk.Box+BoxChild
		this.HouseURLentry = new global::Gtk.Entry ();
		this.HouseURLentry.CanFocus = true;
		this.HouseURLentry.Name = "HouseURLentry";
		this.HouseURLentry.IsEditable = true;
		this.HouseURLentry.InvisibleChar = '●';
		this.vbox5.Add (this.HouseURLentry);
		global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.HouseURLentry]));
		w32.Position = 3;
		w32.Expand = false;
		w32.Fill = false;
		this.topLayoutBox.Add (this.vbox5);
		global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.topLayoutBox [this.vbox5]));
		w33.Position = 3;
		w33.Expand = false;
		w33.Fill = false;
		this.mainLayoutBox.Add (this.topLayoutBox);
		global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.mainLayoutBox [this.topLayoutBox]));
		w34.Position = 1;
		w34.Expand = false;
		w34.Fill = false;
		// Container child mainLayoutBox.Gtk.Box+BoxChild
		this.vbox4 = new global::Gtk.VBox ();
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 6;
		// Container child vbox4.Gtk.Box+BoxChild
		this.hbox11 = new global::Gtk.HBox ();
		this.hbox11.Name = "hbox11";
		this.hbox11.Spacing = 6;
		// Container child hbox11.Gtk.Box+BoxChild
		this.label8 = new global::Gtk.Label ();
		this.label8.Name = "label8";
		this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Simulation Time:");
		this.hbox11.Add (this.label8);
		global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.hbox11 [this.label8]));
		w35.Position = 0;
		w35.Expand = false;
		w35.Fill = false;
		// Container child hbox11.Gtk.Box+BoxChild
		this.hbox14 = new global::Gtk.HBox ();
		this.hbox14.Name = "hbox14";
		this.hbox14.Spacing = 6;
		// Container child hbox14.Gtk.Box+BoxChild
		this.hourSpinBox = new global::Gtk.SpinButton (0, 23, 1);
		this.hourSpinBox.CanFocus = true;
		this.hourSpinBox.Name = "hourSpinBox";
		this.hourSpinBox.Adjustment.PageIncrement = 1;
		this.hourSpinBox.ClimbRate = 1;
		this.hourSpinBox.Numeric = true;
		this.hourSpinBox.Value = 1;
		this.hbox14.Add (this.hourSpinBox);
		global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.hbox14 [this.hourSpinBox]));
		w36.Position = 0;
		w36.Expand = false;
		w36.Fill = false;
		// Container child hbox14.Gtk.Box+BoxChild
		this.label10 = new global::Gtk.Label ();
		this.label10.Name = "label10";
		this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("Hour");
		this.hbox14.Add (this.label10);
		global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.hbox14 [this.label10]));
		w37.Position = 1;
		w37.Expand = false;
		w37.Fill = false;
		// Container child hbox14.Gtk.Box+BoxChild
		this.hbox16 = new global::Gtk.HBox ();
		this.hbox16.Name = "hbox16";
		this.hbox16.Spacing = 6;
		// Container child hbox16.Gtk.Box+BoxChild
		this.minSpinBox = new global::Gtk.SpinButton (0, 59, 1);
		this.minSpinBox.CanFocus = true;
		this.minSpinBox.Name = "minSpinBox";
		this.minSpinBox.Adjustment.PageIncrement = 1;
		this.minSpinBox.ClimbRate = 1;
		this.minSpinBox.Numeric = true;
		this.minSpinBox.Value = 59;
		this.hbox16.Add (this.minSpinBox);
		global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.hbox16 [this.minSpinBox]));
		w38.Position = 0;
		w38.Expand = false;
		w38.Fill = false;
		// Container child hbox16.Gtk.Box+BoxChild
		this.label13 = new global::Gtk.Label ();
		this.label13.Name = "label13";
		this.label13.LabelProp = global::Mono.Unix.Catalog.GetString ("Minute");
		this.hbox16.Add (this.label13);
		global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.hbox16 [this.label13]));
		w39.Position = 1;
		w39.Expand = false;
		w39.Fill = false;
		this.hbox14.Add (this.hbox16);
		global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.hbox14 [this.hbox16]));
		w40.Position = 2;
		w40.Expand = false;
		w40.Fill = false;
		this.hbox11.Add (this.hbox14);
		global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.hbox11 [this.hbox14]));
		w41.Position = 1;
		w41.Expand = false;
		w41.Fill = false;
		this.vbox4.Add (this.hbox11);
		global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox11]));
		w42.Position = 0;
		w42.Expand = false;
		w42.Fill = false;
		this.mainLayoutBox.Add (this.vbox4);
		global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.mainLayoutBox [this.vbox4]));
		w43.Position = 2;
		w43.Expand = false;
		w43.Fill = false;
		// Container child mainLayoutBox.Gtk.Box+BoxChild
		this.hseparator3 = new global::Gtk.HSeparator ();
		this.hseparator3.Name = "hseparator3";
		this.mainLayoutBox.Add (this.hseparator3);
		global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.mainLayoutBox [this.hseparator3]));
		w44.Position = 3;
		w44.Expand = false;
		w44.Fill = false;
		// Container child mainLayoutBox.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox ();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.vbox14 = new global::Gtk.VBox ();
		this.vbox14.Name = "vbox14";
		this.vbox14.Spacing = 6;
		// Container child vbox14.Gtk.Box+BoxChild
		this.hbox12 = new global::Gtk.HBox ();
		this.hbox12.Name = "hbox12";
		this.hbox12.Spacing = 6;
		// Container child hbox12.Gtk.Box+BoxChild
		this.loadScenarioButton = new global::Gtk.Button ();
		this.loadScenarioButton.CanFocus = true;
		this.loadScenarioButton.Name = "loadScenarioButton";
		this.loadScenarioButton.UseUnderline = true;
		this.loadScenarioButton.Label = global::Mono.Unix.Catalog.GetString ("Load Scenario");
		this.hbox12.Add (this.loadScenarioButton);
		global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(this.hbox12 [this.loadScenarioButton]));
		w45.Position = 0;
		w45.Expand = false;
		w45.Fill = false;
		// Container child hbox12.Gtk.Box+BoxChild
		this.startTestButton = new global::Gtk.Button ();
		this.startTestButton.Sensitive = false;
		this.startTestButton.CanFocus = true;
		this.startTestButton.Name = "startTestButton";
		this.startTestButton.UseUnderline = true;
		this.startTestButton.Label = global::Mono.Unix.Catalog.GetString ("Start Test");
		this.hbox12.Add (this.startTestButton);
		global::Gtk.Box.BoxChild w46 = ((global::Gtk.Box.BoxChild)(this.hbox12 [this.startTestButton]));
		w46.Position = 1;
		w46.Expand = false;
		w46.Fill = false;
		this.vbox14.Add (this.hbox12);
		global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.vbox14 [this.hbox12]));
		w47.Position = 0;
		w47.Expand = false;
		w47.Fill = false;
		// Container child vbox14.Gtk.Box+BoxChild
		this.hseparator2 = new global::Gtk.HSeparator ();
		this.hseparator2.Name = "hseparator2";
		this.vbox14.Add (this.hseparator2);
		global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.vbox14 [this.hseparator2]));
		w48.Position = 1;
		w48.Expand = false;
		w48.Fill = false;
		// Container child vbox14.Gtk.Box+BoxChild
		this.currTestRunLabel = new global::Gtk.Label ();
		this.currTestRunLabel.Name = "currTestRunLabel";
		this.currTestRunLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("Current Test Running");
		this.vbox14.Add (this.currTestRunLabel);
		global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.vbox14 [this.currTestRunLabel]));
		w49.Position = 2;
		w49.Expand = false;
		w49.Fill = false;
		// Container child vbox14.Gtk.Box+BoxChild
		this.vbox15 = new global::Gtk.VBox ();
		this.vbox15.Name = "vbox15";
		this.vbox15.Spacing = 6;
		// Container child vbox15.Gtk.Box+BoxChild
		this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
		this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
		this.currentTestTextview = new global::Gtk.TextView ();
		this.currentTestTextview.WidthRequest = 500;
		this.currentTestTextview.HeightRequest = 200;
		this.currentTestTextview.Editable = false;
		this.currentTestTextview.CanFocus = true;
		this.currentTestTextview.Name = "currentTestTextview";
		this.GtkScrolledWindow1.Add (this.currentTestTextview);
		this.vbox15.Add (this.GtkScrolledWindow1);
		global::Gtk.Box.BoxChild w51 = ((global::Gtk.Box.BoxChild)(this.vbox15 [this.GtkScrolledWindow1]));
		w51.Position = 0;
		// Container child vbox15.Gtk.Box+BoxChild
		this.endTestButton = new global::Gtk.Button ();
		this.endTestButton.Sensitive = false;
		this.endTestButton.CanFocus = true;
		this.endTestButton.Name = "endTestButton";
		this.endTestButton.UseUnderline = true;
		this.endTestButton.Label = global::Mono.Unix.Catalog.GetString ("End Test");
		this.vbox15.Add (this.endTestButton);
		global::Gtk.Box.BoxChild w52 = ((global::Gtk.Box.BoxChild)(this.vbox15 [this.endTestButton]));
		w52.Position = 1;
		w52.Expand = false;
		w52.Fill = false;
		this.vbox14.Add (this.vbox15);
		global::Gtk.Box.BoxChild w53 = ((global::Gtk.Box.BoxChild)(this.vbox14 [this.vbox15]));
		w53.Position = 3;
		this.hbox4.Add (this.vbox14);
		global::Gtk.Box.BoxChild w54 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.vbox14]));
		w54.Position = 0;
		w54.Expand = false;
		w54.Fill = false;
		this.mainLayoutBox.Add (this.hbox4);
		global::Gtk.Box.BoxChild w55 = ((global::Gtk.Box.BoxChild)(this.mainLayoutBox [this.hbox4]));
		w55.Position = 4;
		this.Add (this.mainLayoutBox);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = DefaultWidth;
		this.DefaultHeight = DefaultHeight;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.serverURLEntry.Changed += new global::System.EventHandler (this.OnServerURLEntryChanged);
		this.scenarioDirButton.Clicked += new global::System.EventHandler (this.OnScenarioDirectoryLoad);
		this.scenarioDirectoryText.Changed += new global::System.EventHandler (this.OnScenarioDirectoryTextChanged);
		this.appSimulatorChooseFileButton.Clicked += new global::System.EventHandler (this.OnAppSimulatorChooseFileButtonClicked);
		this.appSimLocationEntry.Changed += new global::System.EventHandler (this.OnAppSimLocationEntryChanged);
		this.houseSimLocationButton.Clicked += new global::System.EventHandler (this.OnHouseSimLocationButtonClicked);
		this.houseSimLocationEntry.Changed += new global::System.EventHandler (this.OnHouseSimLocationEntryChanged);
		this.userURLentry.Changed += new global::System.EventHandler (this.OnUserURLentryChanged);
		this.HouseURLentry.Changed += new global::System.EventHandler (this.OnHouseURLentryChanged);
		this.loadScenarioButton.Clicked += new global::System.EventHandler (this.OnLoadScenarioButton);
		this.startTestButton.Clicked += new global::System.EventHandler (this.OnStartTestButtonClicked);
	}
}
