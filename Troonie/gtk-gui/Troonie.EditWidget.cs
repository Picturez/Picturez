
// This file has been generated by the GUI designer. Do not modify.
namespace Troonie
{
	public partial class EditWidget
	{
		private global::Gtk.VBox vboxA;
		
		private global::Gtk.EventBox eventboxToolbar;
		
		private global::Gtk.HBox hboxToolbarButtons;
		
		private global::Gtk.HBox hbox1;
		
		private global::Troonie.ImagePanel imagepanel1;
		
		private global::Gtk.VBox vbox1;
		
		private global::Gtk.Frame frameShortcuts;
		
		private global::Gtk.Alignment GtkAlignmentShortcuts;
		
		private global::Gtk.Table table3;
		
		private global::Gtk.ComboBox comboboxShortcuts;
		
		private global::Gtk.Label lbShortcutsText;
		
		private global::Gtk.Label lbFrameShortcuts;
		
		private global::Gtk.Frame frameCutPoints;
		
		private global::Gtk.Alignment GtkAlignment2;
		
		private global::Gtk.Table table1;
		
		private global::Troonie.TroonieButton btnBottomMinus;
		
		private global::Troonie.TroonieButton btnBottomPlus;
		
		private global::Troonie.TroonieButton btnLeftMinus;
		
		private global::Troonie.TroonieButton btnLeftPlus;
		
		private global::Troonie.TroonieButton btnRightMinus;
		
		private global::Troonie.TroonieButton btnTopMinus;
		
		private global::Troonie.TroonieButton btnTopPlus;
		
		private global::Gtk.EventBox ebBtnRightPlus;
		
		private global::Troonie.TroonieButton btnRightPlus;
		
		private global::Gtk.Entry entryBottom;
		
		private global::Gtk.Entry entryLeft;
		
		private global::Gtk.Entry entryRight;
		
		private global::Gtk.Entry entryTop;
		
		private global::Gtk.Label lbBottomText;
		
		private global::Gtk.Label lbLeftText;
		
		private global::Gtk.Label lbRightText;
		
		private global::Gtk.Label lbTopText;
		
		private global::Gtk.Label lbFrameCutDimensions;
		
		private global::Gtk.Frame frameRotation;
		
		private global::Gtk.Alignment GtkAlignment3;
		
		private global::Gtk.Table table2;
		
		private global::Troonie.TroonieButton btnRotateMinus;
		
		private global::Troonie.TroonieButton btnRotatePlus;
		
		private global::Gtk.Entry entryRotate;
		
		private global::Gtk.Label lbRotateText;
		
		private global::Gtk.Label lbFrameRotation;
		
		private global::Gtk.Frame frameImageDimensions;
		
		private global::Gtk.Alignment GtkAlignment;
		
		private global::Gtk.Table tableImageDimensions;
		
		private global::Gtk.Label lbFormat;
		
		private global::Gtk.Label lbFormatText;
		
		private global::Gtk.Label lbNew;
		
		private global::Gtk.Label lbNewText;
		
		private global::Gtk.Label lbOriginal;
		
		private global::Gtk.Label lbOriginalText;
		
		private global::Gtk.Label lbFrameImageDimensions;
		
		private global::Gtk.Frame frameCursorPos;
		
		private global::Gtk.Alignment GtkAlignment1;
		
		private global::Gtk.Label lbCursorPos;
		
		private global::Gtk.Label lbFrameCursorPos;
		
		private global::Troonie.TroonieButton btnOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Troonie.EditWidget
			this.Name = "Troonie.EditWidget";
			this.Title = global::Mono.Unix.Catalog.GetString ("EditWidget");
			// Container child Troonie.EditWidget.Gtk.Container+ContainerChild
			this.vboxA = new global::Gtk.VBox ();
			this.vboxA.Name = "vboxA";
			this.vboxA.Spacing = 6;
			// Container child vboxA.Gtk.Box+BoxChild
			this.eventboxToolbar = new global::Gtk.EventBox ();
			this.eventboxToolbar.Name = "eventboxToolbar";
			// Container child eventboxToolbar.Gtk.Container+ContainerChild
			this.hboxToolbarButtons = new global::Gtk.HBox ();
			this.hboxToolbarButtons.Name = "hboxToolbarButtons";
			this.hboxToolbarButtons.Spacing = 6;
			this.eventboxToolbar.Add (this.hboxToolbarButtons);
			this.vboxA.Add (this.eventboxToolbar);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vboxA [this.eventboxToolbar]));
			w2.Position = 0;
			w2.Expand = false;
			// Container child vboxA.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.imagepanel1 = new global::Troonie.ImagePanel ();
			this.imagepanel1.Events = ((global::Gdk.EventMask)(260));
			this.imagepanel1.Name = "imagepanel1";
			this.imagepanel1.Angle = 0;
			this.imagepanel1.ScaleCursorX = 0F;
			this.imagepanel1.ScaleCursorY = 0F;
			this.hbox1.Add (this.imagepanel1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.imagepanel1]));
			w3.Position = 0;
			w3.Expand = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.frameShortcuts = new global::Gtk.Frame ();
			this.frameShortcuts.Name = "frameShortcuts";
			// Container child frameShortcuts.Gtk.Container+ContainerChild
			this.GtkAlignmentShortcuts = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignmentShortcuts.Name = "GtkAlignmentShortcuts";
			this.GtkAlignmentShortcuts.LeftPadding = ((uint)(12));
			// Container child GtkAlignmentShortcuts.Gtk.Container+ContainerChild
			this.table3 = new global::Gtk.Table (((uint)(1)), ((uint)(4)), false);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(6));
			this.table3.ColumnSpacing = ((uint)(6));
			// Container child table3.Gtk.Table+TableChild
			this.comboboxShortcuts = global::Gtk.ComboBox.NewText ();
			this.comboboxShortcuts.AppendText (global::Mono.Unix.Catalog.GetString (" - "));
			this.comboboxShortcuts.Name = "comboboxShortcuts";
			this.comboboxShortcuts.Active = 0;
			this.table3.Add (this.comboboxShortcuts);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table3 [this.comboboxShortcuts]));
			w4.LeftAttach = ((uint)(2));
			w4.RightAttach = ((uint)(3));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.lbShortcutsText = new global::Gtk.Label ();
			this.lbShortcutsText.Name = "lbShortcutsText";
			this.lbShortcutsText.LabelProp = global::Mono.Unix.Catalog.GetString ("Angle  ");
			this.table3.Add (this.lbShortcutsText);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table3 [this.lbShortcutsText]));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			this.GtkAlignmentShortcuts.Add (this.table3);
			this.frameShortcuts.Add (this.GtkAlignmentShortcuts);
			this.lbFrameShortcuts = new global::Gtk.Label ();
			this.lbFrameShortcuts.Name = "lbFrameShortcuts";
			this.lbFrameShortcuts.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Cutting by common picture formats</b>");
			this.lbFrameShortcuts.UseMarkup = true;
			this.frameShortcuts.LabelWidget = this.lbFrameShortcuts;
			this.vbox1.Add (this.frameShortcuts);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.frameShortcuts]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.frameCutPoints = new global::Gtk.Frame ();
			this.frameCutPoints.Name = "frameCutPoints";
			// Container child frameCutPoints.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(12));
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table (((uint)(4)), ((uint)(4)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.btnBottomMinus = new global::Troonie.TroonieButton ();
			this.btnBottomMinus.Name = "btnBottomMinus";
			this.btnBottomMinus.CheckReleaseState = true;
			this.btnBottomMinus.BorderlineWidth = 2;
			this.btnBottomMinus.ButtonHeight = 35;
			this.btnBottomMinus.ButtonWidth = 0;
			this.btnBottomMinus.Font = "Arial";
			this.btnBottomMinus.Text = "-";
			this.btnBottomMinus.TextSize = 12;
			this.table1.Add (this.btnBottomMinus);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnBottomMinus]));
			w9.TopAttach = ((uint)(3));
			w9.BottomAttach = ((uint)(4));
			w9.LeftAttach = ((uint)(3));
			w9.RightAttach = ((uint)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.btnBottomPlus = new global::Troonie.TroonieButton ();
			this.btnBottomPlus.Name = "btnBottomPlus";
			this.btnBottomPlus.CheckReleaseState = true;
			this.btnBottomPlus.BorderlineWidth = 2;
			this.btnBottomPlus.ButtonHeight = 35;
			this.btnBottomPlus.ButtonWidth = 0;
			this.btnBottomPlus.Font = "Arial";
			this.btnBottomPlus.Text = "+";
			this.btnBottomPlus.TextSize = 12;
			this.table1.Add (this.btnBottomPlus);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnBottomPlus]));
			w10.TopAttach = ((uint)(3));
			w10.BottomAttach = ((uint)(4));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.btnLeftMinus = new global::Troonie.TroonieButton ();
			this.btnLeftMinus.Name = "btnLeftMinus";
			this.btnLeftMinus.CheckReleaseState = true;
			this.btnLeftMinus.BorderlineWidth = 2;
			this.btnLeftMinus.ButtonHeight = 35;
			this.btnLeftMinus.ButtonWidth = 0;
			this.btnLeftMinus.Font = "Arial";
			this.btnLeftMinus.Text = "-";
			this.btnLeftMinus.TextSize = 12;
			this.table1.Add (this.btnLeftMinus);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnLeftMinus]));
			w11.LeftAttach = ((uint)(3));
			w11.RightAttach = ((uint)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.btnLeftPlus = new global::Troonie.TroonieButton ();
			this.btnLeftPlus.Name = "btnLeftPlus";
			this.btnLeftPlus.CheckReleaseState = true;
			this.btnLeftPlus.BorderlineWidth = 2;
			this.btnLeftPlus.ButtonHeight = 35;
			this.btnLeftPlus.ButtonWidth = 0;
			this.btnLeftPlus.Font = "Arial";
			this.btnLeftPlus.Text = "+";
			this.btnLeftPlus.TextSize = 12;
			this.table1.Add (this.btnLeftPlus);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnLeftPlus]));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.XPadding = ((uint)(1));
			w12.YPadding = ((uint)(1));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.btnRightMinus = new global::Troonie.TroonieButton ();
			this.btnRightMinus.Name = "btnRightMinus";
			this.btnRightMinus.CheckReleaseState = true;
			this.btnRightMinus.BorderlineWidth = 2;
			this.btnRightMinus.ButtonHeight = 35;
			this.btnRightMinus.ButtonWidth = 0;
			this.btnRightMinus.Font = "Arial";
			this.btnRightMinus.Text = "-";
			this.btnRightMinus.TextSize = 12;
			this.table1.Add (this.btnRightMinus);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnRightMinus]));
			w13.TopAttach = ((uint)(1));
			w13.BottomAttach = ((uint)(2));
			w13.LeftAttach = ((uint)(3));
			w13.RightAttach = ((uint)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.btnTopMinus = new global::Troonie.TroonieButton ();
			this.btnTopMinus.Name = "btnTopMinus";
			this.btnTopMinus.CheckReleaseState = true;
			this.btnTopMinus.BorderlineWidth = 2;
			this.btnTopMinus.ButtonHeight = 35;
			this.btnTopMinus.ButtonWidth = 0;
			this.btnTopMinus.Font = "Arial";
			this.btnTopMinus.Text = "-";
			this.btnTopMinus.TextSize = 12;
			this.table1.Add (this.btnTopMinus);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnTopMinus]));
			w14.TopAttach = ((uint)(2));
			w14.BottomAttach = ((uint)(3));
			w14.LeftAttach = ((uint)(3));
			w14.RightAttach = ((uint)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.btnTopPlus = new global::Troonie.TroonieButton ();
			this.btnTopPlus.Name = "btnTopPlus";
			this.btnTopPlus.CheckReleaseState = true;
			this.btnTopPlus.BorderlineWidth = 2;
			this.btnTopPlus.ButtonHeight = 35;
			this.btnTopPlus.ButtonWidth = 0;
			this.btnTopPlus.Font = "Arial";
			this.btnTopPlus.Text = "+";
			this.btnTopPlus.TextSize = 12;
			this.table1.Add (this.btnTopPlus);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1 [this.btnTopPlus]));
			w15.TopAttach = ((uint)(2));
			w15.BottomAttach = ((uint)(3));
			w15.LeftAttach = ((uint)(1));
			w15.RightAttach = ((uint)(2));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.ebBtnRightPlus = new global::Gtk.EventBox ();
			this.ebBtnRightPlus.Events = ((global::Gdk.EventMask)(2));
			this.ebBtnRightPlus.Name = "ebBtnRightPlus";
			// Container child ebBtnRightPlus.Gtk.Container+ContainerChild
			this.btnRightPlus = new global::Troonie.TroonieButton ();
			this.btnRightPlus.Name = "btnRightPlus";
			this.btnRightPlus.CheckReleaseState = true;
			this.btnRightPlus.BorderlineWidth = 2;
			this.btnRightPlus.ButtonHeight = 35;
			this.btnRightPlus.ButtonWidth = 0;
			this.btnRightPlus.Font = "Arial";
			this.btnRightPlus.Text = "+";
			this.btnRightPlus.TextSize = 12;
			this.ebBtnRightPlus.Add (this.btnRightPlus);
			this.table1.Add (this.ebBtnRightPlus);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table1 [this.ebBtnRightPlus]));
			w17.TopAttach = ((uint)(1));
			w17.BottomAttach = ((uint)(2));
			w17.LeftAttach = ((uint)(1));
			w17.RightAttach = ((uint)(2));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryBottom = new global::Gtk.Entry ();
			this.entryBottom.CanFocus = true;
			this.entryBottom.Name = "entryBottom";
			this.entryBottom.IsEditable = true;
			this.entryBottom.MaxLength = 9;
			this.entryBottom.InvisibleChar = '●';
			this.table1.Add (this.entryBottom);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryBottom]));
			w18.TopAttach = ((uint)(3));
			w18.BottomAttach = ((uint)(4));
			w18.LeftAttach = ((uint)(2));
			w18.RightAttach = ((uint)(3));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryLeft = new global::Gtk.Entry ();
			this.entryLeft.CanFocus = true;
			this.entryLeft.Name = "entryLeft";
			this.entryLeft.IsEditable = true;
			this.entryLeft.MaxLength = 9;
			this.entryLeft.InvisibleChar = '●';
			this.table1.Add (this.entryLeft);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryLeft]));
			w19.LeftAttach = ((uint)(2));
			w19.RightAttach = ((uint)(3));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryRight = new global::Gtk.Entry ();
			this.entryRight.CanFocus = true;
			this.entryRight.Name = "entryRight";
			this.entryRight.IsEditable = true;
			this.entryRight.MaxLength = 9;
			this.entryRight.InvisibleChar = '●';
			this.table1.Add (this.entryRight);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryRight]));
			w20.TopAttach = ((uint)(1));
			w20.BottomAttach = ((uint)(2));
			w20.LeftAttach = ((uint)(2));
			w20.RightAttach = ((uint)(3));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryTop = new global::Gtk.Entry ();
			this.entryTop.CanFocus = true;
			this.entryTop.Name = "entryTop";
			this.entryTop.IsEditable = true;
			this.entryTop.MaxLength = 9;
			this.entryTop.InvisibleChar = '●';
			this.table1.Add (this.entryTop);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryTop]));
			w21.TopAttach = ((uint)(2));
			w21.BottomAttach = ((uint)(3));
			w21.LeftAttach = ((uint)(2));
			w21.RightAttach = ((uint)(3));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbBottomText = new global::Gtk.Label ();
			this.lbBottomText.Name = "lbBottomText";
			this.lbBottomText.LabelProp = global::Mono.Unix.Catalog.GetString ("Bottom");
			this.table1.Add (this.lbBottomText);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table1 [this.lbBottomText]));
			w22.TopAttach = ((uint)(3));
			w22.BottomAttach = ((uint)(4));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbLeftText = new global::Gtk.Label ();
			this.lbLeftText.Name = "lbLeftText";
			this.lbLeftText.LabelProp = global::Mono.Unix.Catalog.GetString ("Left");
			this.table1.Add (this.lbLeftText);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table1 [this.lbLeftText]));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbRightText = new global::Gtk.Label ();
			this.lbRightText.Name = "lbRightText";
			this.lbRightText.LabelProp = global::Mono.Unix.Catalog.GetString ("Right");
			this.table1.Add (this.lbRightText);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table1 [this.lbRightText]));
			w24.TopAttach = ((uint)(1));
			w24.BottomAttach = ((uint)(2));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbTopText = new global::Gtk.Label ();
			this.lbTopText.Name = "lbTopText";
			this.lbTopText.LabelProp = global::Mono.Unix.Catalog.GetString ("Top");
			this.table1.Add (this.lbTopText);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table1 [this.lbTopText]));
			w25.TopAttach = ((uint)(2));
			w25.BottomAttach = ((uint)(3));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			this.GtkAlignment2.Add (this.table1);
			this.frameCutPoints.Add (this.GtkAlignment2);
			this.lbFrameCutDimensions = new global::Gtk.Label ();
			this.lbFrameCutDimensions.Name = "lbFrameCutDimensions";
			this.lbFrameCutDimensions.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Cut points (in pixel)</b>");
			this.lbFrameCutDimensions.UseMarkup = true;
			this.frameCutPoints.LabelWidget = this.lbFrameCutDimensions;
			this.vbox1.Add (this.frameCutPoints);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.frameCutPoints]));
			w28.Position = 1;
			w28.Expand = false;
			w28.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.frameRotation = new global::Gtk.Frame ();
			this.frameRotation.Name = "frameRotation";
			// Container child frameRotation.Gtk.Container+ContainerChild
			this.GtkAlignment3 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment3.Name = "GtkAlignment3";
			this.GtkAlignment3.LeftPadding = ((uint)(12));
			// Container child GtkAlignment3.Gtk.Container+ContainerChild
			this.table2 = new global::Gtk.Table (((uint)(1)), ((uint)(4)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.btnRotateMinus = new global::Troonie.TroonieButton ();
			this.btnRotateMinus.Name = "btnRotateMinus";
			this.btnRotateMinus.CheckReleaseState = true;
			this.btnRotateMinus.BorderlineWidth = 2;
			this.btnRotateMinus.ButtonHeight = 35;
			this.btnRotateMinus.ButtonWidth = 0;
			this.btnRotateMinus.Font = "Arial";
			this.btnRotateMinus.Text = "-";
			this.btnRotateMinus.TextSize = 12;
			this.table2.Add (this.btnRotateMinus);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table2 [this.btnRotateMinus]));
			w29.LeftAttach = ((uint)(3));
			w29.RightAttach = ((uint)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.btnRotatePlus = new global::Troonie.TroonieButton ();
			this.btnRotatePlus.Name = "btnRotatePlus";
			this.btnRotatePlus.CheckReleaseState = true;
			this.btnRotatePlus.BorderlineWidth = 2;
			this.btnRotatePlus.ButtonHeight = 35;
			this.btnRotatePlus.ButtonWidth = 0;
			this.btnRotatePlus.Font = "Arial";
			this.btnRotatePlus.Text = "+";
			this.btnRotatePlus.TextSize = 12;
			this.table2.Add (this.btnRotatePlus);
			global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.table2 [this.btnRotatePlus]));
			w30.LeftAttach = ((uint)(1));
			w30.RightAttach = ((uint)(2));
			w30.XPadding = ((uint)(1));
			w30.YPadding = ((uint)(1));
			w30.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.entryRotate = new global::Gtk.Entry ();
			this.entryRotate.CanFocus = true;
			this.entryRotate.Name = "entryRotate";
			this.entryRotate.IsEditable = true;
			this.entryRotate.MaxLength = 4;
			this.entryRotate.InvisibleChar = '●';
			this.table2.Add (this.entryRotate);
			global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table2 [this.entryRotate]));
			w31.LeftAttach = ((uint)(2));
			w31.RightAttach = ((uint)(3));
			w31.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.lbRotateText = new global::Gtk.Label ();
			this.lbRotateText.Name = "lbRotateText";
			this.lbRotateText.LabelProp = global::Mono.Unix.Catalog.GetString ("Angle  ");
			this.table2.Add (this.lbRotateText);
			global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.table2 [this.lbRotateText]));
			w32.XOptions = ((global::Gtk.AttachOptions)(4));
			w32.YOptions = ((global::Gtk.AttachOptions)(4));
			this.GtkAlignment3.Add (this.table2);
			this.frameRotation.Add (this.GtkAlignment3);
			this.lbFrameRotation = new global::Gtk.Label ();
			this.lbFrameRotation.Name = "lbFrameRotation";
			this.lbFrameRotation.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Rotatation in 1/10 degrees (e.g. 900 = 90°)</b>");
			this.lbFrameRotation.UseMarkup = true;
			this.frameRotation.LabelWidget = this.lbFrameRotation;
			this.vbox1.Add (this.frameRotation);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.frameRotation]));
			w35.Position = 2;
			w35.Expand = false;
			w35.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.frameImageDimensions = new global::Gtk.Frame ();
			this.frameImageDimensions.Name = "frameImageDimensions";
			// Container child frameImageDimensions.Gtk.Container+ContainerChild
			this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment.Name = "GtkAlignment";
			this.GtkAlignment.LeftPadding = ((uint)(12));
			// Container child GtkAlignment.Gtk.Container+ContainerChild
			this.tableImageDimensions = new global::Gtk.Table (((uint)(2)), ((uint)(4)), true);
			this.tableImageDimensions.Name = "tableImageDimensions";
			this.tableImageDimensions.RowSpacing = ((uint)(6));
			this.tableImageDimensions.ColumnSpacing = ((uint)(6));
			// Container child tableImageDimensions.Gtk.Table+TableChild
			this.lbFormat = new global::Gtk.Label ();
			this.lbFormat.Name = "lbFormat";
			this.lbFormat.LabelProp = global::Mono.Unix.Catalog.GetString ("10000 x 10000");
			this.tableImageDimensions.Add (this.lbFormat);
			global::Gtk.Table.TableChild w36 = ((global::Gtk.Table.TableChild)(this.tableImageDimensions [this.lbFormat]));
			w36.LeftAttach = ((uint)(3));
			w36.RightAttach = ((uint)(4));
			w36.XOptions = ((global::Gtk.AttachOptions)(4));
			w36.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableImageDimensions.Gtk.Table+TableChild
			this.lbFormatText = new global::Gtk.Label ();
			this.lbFormatText.Name = "lbFormatText";
			this.lbFormatText.LabelProp = global::Mono.Unix.Catalog.GetString ("Format: ");
			this.tableImageDimensions.Add (this.lbFormatText);
			global::Gtk.Table.TableChild w37 = ((global::Gtk.Table.TableChild)(this.tableImageDimensions [this.lbFormatText]));
			w37.LeftAttach = ((uint)(2));
			w37.RightAttach = ((uint)(3));
			w37.XOptions = ((global::Gtk.AttachOptions)(4));
			w37.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableImageDimensions.Gtk.Table+TableChild
			this.lbNew = new global::Gtk.Label ();
			this.lbNew.Name = "lbNew";
			this.lbNew.LabelProp = global::Mono.Unix.Catalog.GetString ("10000 x 10000");
			this.tableImageDimensions.Add (this.lbNew);
			global::Gtk.Table.TableChild w38 = ((global::Gtk.Table.TableChild)(this.tableImageDimensions [this.lbNew]));
			w38.TopAttach = ((uint)(1));
			w38.BottomAttach = ((uint)(2));
			w38.LeftAttach = ((uint)(1));
			w38.RightAttach = ((uint)(2));
			w38.XOptions = ((global::Gtk.AttachOptions)(4));
			w38.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableImageDimensions.Gtk.Table+TableChild
			this.lbNewText = new global::Gtk.Label ();
			this.lbNewText.Name = "lbNewText";
			this.lbNewText.LabelProp = global::Mono.Unix.Catalog.GetString ("New:");
			this.tableImageDimensions.Add (this.lbNewText);
			global::Gtk.Table.TableChild w39 = ((global::Gtk.Table.TableChild)(this.tableImageDimensions [this.lbNewText]));
			w39.TopAttach = ((uint)(1));
			w39.BottomAttach = ((uint)(2));
			w39.XOptions = ((global::Gtk.AttachOptions)(4));
			w39.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableImageDimensions.Gtk.Table+TableChild
			this.lbOriginal = new global::Gtk.Label ();
			this.lbOriginal.Name = "lbOriginal";
			this.lbOriginal.LabelProp = global::Mono.Unix.Catalog.GetString ("10000 x 10000");
			this.tableImageDimensions.Add (this.lbOriginal);
			global::Gtk.Table.TableChild w40 = ((global::Gtk.Table.TableChild)(this.tableImageDimensions [this.lbOriginal]));
			w40.LeftAttach = ((uint)(1));
			w40.RightAttach = ((uint)(2));
			w40.XOptions = ((global::Gtk.AttachOptions)(4));
			w40.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child tableImageDimensions.Gtk.Table+TableChild
			this.lbOriginalText = new global::Gtk.Label ();
			this.lbOriginalText.Name = "lbOriginalText";
			this.lbOriginalText.LabelProp = global::Mono.Unix.Catalog.GetString ("Original: ");
			this.tableImageDimensions.Add (this.lbOriginalText);
			global::Gtk.Table.TableChild w41 = ((global::Gtk.Table.TableChild)(this.tableImageDimensions [this.lbOriginalText]));
			w41.XOptions = ((global::Gtk.AttachOptions)(4));
			w41.YOptions = ((global::Gtk.AttachOptions)(4));
			this.GtkAlignment.Add (this.tableImageDimensions);
			this.frameImageDimensions.Add (this.GtkAlignment);
			this.lbFrameImageDimensions = new global::Gtk.Label ();
			this.lbFrameImageDimensions.Name = "lbFrameImageDimensions";
			this.lbFrameImageDimensions.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Image Dimension</b>");
			this.lbFrameImageDimensions.UseMarkup = true;
			this.frameImageDimensions.LabelWidget = this.lbFrameImageDimensions;
			this.vbox1.Add (this.frameImageDimensions);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.frameImageDimensions]));
			w44.Position = 3;
			w44.Expand = false;
			w44.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.frameCursorPos = new global::Gtk.Frame ();
			this.frameCursorPos.Name = "frameCursorPos";
			// Container child frameCursorPos.Gtk.Container+ContainerChild
			this.GtkAlignment1 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment1.Name = "GtkAlignment1";
			this.GtkAlignment1.LeftPadding = ((uint)(12));
			// Container child GtkAlignment1.Gtk.Container+ContainerChild
			this.lbCursorPos = new global::Gtk.Label ();
			this.lbCursorPos.Name = "lbCursorPos";
			this.lbCursorPos.LabelProp = global::Mono.Unix.Catalog.GetString ("0 x 0");
			this.GtkAlignment1.Add (this.lbCursorPos);
			this.frameCursorPos.Add (this.GtkAlignment1);
			this.lbFrameCursorPos = new global::Gtk.Label ();
			this.lbFrameCursorPos.Name = "lbFrameCursorPos";
			this.lbFrameCursorPos.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Cursor position</b>");
			this.lbFrameCursorPos.UseMarkup = true;
			this.frameCursorPos.LabelWidget = this.lbFrameCursorPos;
			this.vbox1.Add (this.frameCursorPos);
			global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.frameCursorPos]));
			w47.Position = 4;
			w47.Expand = false;
			w47.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.btnOk = new global::Troonie.TroonieButton ();
			this.btnOk.Name = "btnOk";
			this.btnOk.CheckReleaseState = false;
			this.btnOk.BorderlineWidth = 3;
			this.btnOk.ButtonHeight = 35;
			this.btnOk.ButtonWidth = 0;
			this.btnOk.Font = "Arial";
			this.btnOk.Text = "OK";
			this.btnOk.TextSize = 14;
			this.vbox1.Add (this.btnOk);
			global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.btnOk]));
			w48.Position = 5;
			w48.Expand = false;
			w48.Fill = false;
			w48.Padding = ((uint)(3));
			this.hbox1.Add (this.vbox1);
			global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox1]));
			w49.Position = 1;
			w49.Padding = ((uint)(5));
			this.vboxA.Add (this.hbox1);
			global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.vboxA [this.hbox1]));
			w50.Position = 1;
			w50.Expand = false;
			w50.Fill = false;
			this.Add (this.vboxA);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 688;
			this.DefaultHeight = 1115;
			this.Show ();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
			this.DragDrop += new global::Gtk.DragDropHandler (this.OnDragDrop);
			this.DragDataReceived += new global::Gtk.DragDataReceivedHandler (this.OnDragDataReceived);
			this.KeyPressEvent += new global::Gtk.KeyPressEventHandler (this.OnKeyPressEvent);
			this.KeyReleaseEvent += new global::Gtk.KeyReleaseEventHandler (this.OnKeyReleaseEvent);
			this.comboboxShortcuts.Changed += new global::System.EventHandler (this.OnComboboxShortcutsChanged);
			this.entryTop.KeyReleaseEvent += new global::Gtk.KeyReleaseEventHandler (this.OnEntryTopKeyReleaseEvent);
			this.entryRight.KeyReleaseEvent += new global::Gtk.KeyReleaseEventHandler (this.OnEntryRightKeyReleaseEvent);
			this.entryLeft.KeyReleaseEvent += new global::Gtk.KeyReleaseEventHandler (this.OnEntryLeftKeyReleaseEvent);
			this.entryBottom.KeyReleaseEvent += new global::Gtk.KeyReleaseEventHandler (this.OnEntryBottomKeyReleaseEvent);
			this.btnRightPlus.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler (this.OnBtnRightPlusButtonPressEvent);
			this.btnRightPlus.ButtonReleaseEvent += new global::Gtk.ButtonReleaseEventHandler (this.OnButtonReleaseEvent);
			this.btnTopPlus.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler (this.OnBtnTopPlusButtonPressEvent);
			this.btnTopPlus.ButtonReleaseEvent += new global::Gtk.ButtonReleaseEventHandler (this.OnButtonReleaseEvent);
			this.btnTopMinus.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler (this.OnBtnTopMinusButtonPressEvent);
			this.btnTopMinus.ButtonReleaseEvent += new global::Gtk.ButtonReleaseEventHandler (this.OnButtonReleaseEvent);
			this.btnRightMinus.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler (this.OnBtnRightMinusButtonPressEvent);
			this.btnRightMinus.ButtonReleaseEvent += new global::Gtk.ButtonReleaseEventHandler (this.OnButtonReleaseEvent);
			this.btnLeftPlus.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler (this.OnBtnLeftPlusButtonPressEvent);
			this.btnLeftPlus.ButtonReleaseEvent += new global::Gtk.ButtonReleaseEventHandler (this.OnButtonReleaseEvent);
			this.btnLeftMinus.ButtonReleaseEvent += new global::Gtk.ButtonReleaseEventHandler (this.OnButtonReleaseEvent);
			this.btnLeftMinus.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler (this.OnBtnLeftMinusButtonPressEvent);
			this.btnBottomPlus.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler (this.OnBtnBottomPlusButtonPressEvent);
			this.btnBottomPlus.ButtonReleaseEvent += new global::Gtk.ButtonReleaseEventHandler (this.OnButtonReleaseEvent);
			this.btnBottomMinus.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler (this.OnBtnBottomMinusButtonPressEvent);
			this.btnBottomMinus.ButtonReleaseEvent += new global::Gtk.ButtonReleaseEventHandler (this.OnButtonReleaseEvent);
			this.entryRotate.KeyReleaseEvent += new global::Gtk.KeyReleaseEventHandler (this.OnEntryRotateKeyReleaseEvent);
			this.btnRotatePlus.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler (this.OnBtnRotatePlusButtonPressEvent);
			this.btnRotatePlus.ButtonReleaseEvent += new global::Gtk.ButtonReleaseEventHandler (this.OnButtonReleaseEvent);
			this.btnRotateMinus.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler (this.OnBtnRotateMinusButtonPressEvent);
			this.btnRotateMinus.ButtonReleaseEvent += new global::Gtk.ButtonReleaseEventHandler (this.OnButtonReleaseEvent);
			this.btnOk.ButtonReleaseEvent += new global::Gtk.ButtonReleaseEventHandler (this.OnBtnOkReleased);
		}
	}
}
