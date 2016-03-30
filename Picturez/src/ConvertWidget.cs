﻿using System;
using Picturez_Lib;
using Gtk;
using System.Collections.Generic;
using IOPath = System.IO.Path;

namespace Picturez
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class ConvertWidget : Gtk.Window
	{
		private bool isSettingGuiToCurrentConfiguration;
		private bool leftControlPressed;
		private Picturez.ColorConverter colorConverter;
		private string format;
		private float newVersion;
		private ConfigConvert config;

		public ConvertWidget (string[] pFilenames = null) : base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
			this.SetIconFromFile(Constants.I.EXEPATH + Constants.ICONNAME);

			GuiHelper.I.CreateToolbarIconButton (hboxToolbarButtons, 0, "folder-new-3.png", OnToolbarBtn_OpenPressed);
			GuiHelper.I.CreateToolbarIconButton (hboxToolbarButtons, 1, "edit-select-all.png", OnToolbarBtn_SelectAllPressed);
			GuiHelper.I.CreateToolbarIconButton (hboxToolbarButtons, 2, "edit-clear-3.png", OnToolbarBtn_ClearPressed);
			GuiHelper.I.CreateToolbarIconButton (hboxToolbarButtons, 3, "window-close-2.png", OnToolbarBtn_RemovePressed);
			GuiHelper.I.CreateToolbarIconButton (hboxToolbarButtons, 4, "help-about-3.png", OnToolbarBtn_InfoPressed);
			GuiHelper.I.CreateToolbarSeparator (hboxToolbarButtons, 5);
			GuiHelper.I.CreateToolbarIconButton (hboxToolbarButtons, 6, "tools-check-spelling-5.png", OnToolbarBtn_LanguagePressed);
			GuiHelper.I.CreateToolbarIconButton (hboxToolbarButtons, 7, "folder-new-4.png", OnToolbarBtn_PropertiesPressed);

			// CheckContextMenu ();

			format = ".jpg";
			colorConverter = Picturez.ColorConverter.Instance;
			SetGuiColors ();
			SetLanguageToGui();

			htlbOutputDirectory.InitDefaultValues ();
			config = ConfigConvert.Load ();
			if (config.StretchImage == ConvertMode.Editor)
				config.StretchImage = ConvertMode.StretchForge;

			SetGuiToCurrentConfiguration();
			htlbOutputDirectory.OnHyperTextLabelTextChanged += OnHyperTextLabelTextChanged;
			Constants.I.OnUpdateAvailable += OnUpdateAvailable;

			if (Constants.I.WINDOWS) {
				rdPng1bit.Sensitive = true;
				rdBmp1bit.Sensitive = true;
				Gtk.Drag.DestSet (this, 0, null, 0);
			} else {
				// Original is ShadowType.EtchedIn, but linux cannot draw it correctly.
				// Otherwise ShadowType.In looks terrible at Win10.
				frameImageFormat.ShadowType = ShadowType.In;
				frameImageResize.ShadowType = ShadowType.In;
				frameImageList.ShadowType = ShadowType.In;
				frameImageFormat.ShadowType = ShadowType.In;
				frameOutputDirectory.ShadowType = ShadowType.In;

				rdJpegGray.Sensitive = true;
				Gtk.Drag.DestSet (this, DestDefaults.All, MainClass.Target_table, Gdk.DragAction.Copy);
			}		
			// insertIter = textview1.Buffer.StartIter;

			if (pFilenames != null)
				FillImageList (new List<string>(pFilenames));

			SetCorrectWindowSize ();

			if (config.AskForDesktopContextMenu)
				new AskForDesktopContextMenuWindow (true, config).Show();
		}

		private void SetCorrectWindowSize()
		{
			// best linux mint 17.3 values
			const int originalWidth = 765;
			const int originalHeight = 833;
			const int taskbarHeight = 90;
			int maxW = Screen.Width;
			int maxH = Screen.Height - taskbarHeight;

			this.WidthRequest = Math.Min(originalWidth, maxW);
			this.HeightRequest = Math.Min(originalHeight, maxH);
		}

		private void SetGuiColors()
		{
			this.ModifyBg(StateType.Normal, colorConverter.GRID);
			eventboxRoot.ModifyBg(StateType.Normal, colorConverter.GRID);
			eventboxToolbar.ModifyBg(StateType.Normal, colorConverter.GRID);

			entryBiggerLength.ModifyBase(StateType.Normal, colorConverter.White);
			entryFixSizeWidth.ModifyBase(StateType.Normal, colorConverter.White);
			entryFixSizeHeight.ModifyBase(StateType.Normal, colorConverter.White);
			eventboxImageList.ModifyBg(StateType.Normal, colorConverter.White);

			lbFrameImageFormat.ModifyFg(StateType.Normal, colorConverter.FONT);
			lbFrameImageResize.ModifyFg(StateType.Normal, colorConverter.FONT);
			lbFrameOutputDirectory.ModifyFg(StateType.Normal, colorConverter.FONT);

			GtkLabel11.ModifyFg(StateType.Normal, colorConverter.FONT);
			GtkLabel15.ModifyFg(StateType.Normal, colorConverter.FONT);
			GtkLabel21.ModifyFg(StateType.Normal, colorConverter.FONT);
			GtkLabel29.ModifyFg(StateType.Normal, colorConverter.FONT);
			GtkLabel6.ModifyFg(StateType.Normal, colorConverter.FONT);
		}

		private void SetLanguageToGui()
		{			
			// hboxToolbarButtons.Children[0].TooltipText = Language.I.L[2];
			GtkLabel29.LabelProp = "<b>" + Language.I.L[19] + "</b>";
			lbFrameImageFormat.LabelProp = "<b>" + Language.I.L[20] + "</b>";
			rdJpeg.Label = "JPEG (24 Bit " + Language.I.L[22] + ")";
			rdJpegGray.Label = "JPEG (8 Bit " + Language.I.L[21] + ")";
			lbQuality.Text = Language.I.L[23];

			rdPng1bit.Label = "PNG (1 Bit " + Language.I.L[24] + ")";
			rdPng8Bit.Label = "PNG (8 Bit " + Language.I.L[21] + ")";
			rdPng24Bit.Label = "PNG (24 Bit " + Language.I.L[22] + ")";
			rdPNG32bit.Label = "PNG (32 Bit " + Language.I.L[25] + ")";
			rdPng32BitAlphaAsValue.Label = "PNG (32 Bit " + Language.I.L[79] + ")";
			lbTransparencyColor.Text = Language.I.L[26];

			rdBmp1bit.Label = "BMP (1 Bit " + Language.I.L[24] + ")";
			rdBmp8bit.Label = "BMP (8 Bit " + Language.I.L[21] + ")";
			rdBmp24bit.Label = "BMP (24 Bit " + Language.I.L[22] + ")";
			GtkLabel21.LabelProp = "<b>" + Language.I.L[27] + "</b>";

			lbFrameImageResize.LabelProp = "<b>" + Language.I.L[28] + "</b>";
//			GtkLabel24.LabelProp = "<b>" + Language.I.L[29] + "</b>";
			rdOriginalSize.Label = Language.I.L[30];
//			GtkLabel26.LabelProp = "<b>" + Language.I.L[31] + "</b>";
			rdBiggerLength.Label = Language.I.L[32];
//			GtkLabel30.LabelProp = "<b>" + Language.I.L[33] + "</b>";
			rdFixSize.Label = Language.I.L[34];
			checkBtnStretch.Label = Language.I.L[35];

			lbFrameOutputDirectory.LabelProp = "<b>" + Language.I.L[36] + "</b>";
			checkBtnUseOriginalDirectory.Label = Language.I.L[37];
			checkBtnOverwriteOriginalImage.Label = Language.I.L[38];

			hboxToolbarButtons.Children[0].TooltipText = Language.I.L[39];
			hboxToolbarButtons.Children[1].TooltipText = Language.I.L[40];
			hboxToolbarButtons.Children[2].TooltipText = Language.I.L[41];
			hboxToolbarButtons.Children[3].TooltipText = Language.I.L[42];
			hboxToolbarButtons.Children[4].TooltipText = Language.I.L[4];
			hboxToolbarButtons.Children[6].TooltipText = 
				Language.I.L[43] +	": " + 
				Language.I.L[0] + "\n\n" + 
				Language.I.L[44] +	": \n" +
				Language.AllLanguagesAsString;
			hboxToolbarButtons.Children[7].TooltipText = Language.I.L[59];

			btnConvert.Text = Language.I.L[45];
			btnConvert.Redraw ();
		}

		private void SetGuiToCurrentConfiguration()
		{
			isSettingGuiToCurrentConfiguration = true;

			// image format radio buttons
			switch (config.Format)
			{
			case PicturezImageFormat.BMP1:
				rdBmp1bit.Active = true;
				break;
			case PicturezImageFormat.BMP8:
				rdBmp8bit.Active = true;
				break;
			case PicturezImageFormat.BMP24:
				rdBmp24bit.Active = true;
				break;
			case PicturezImageFormat.EMF:
				rdEmf.Active = true;
				break;
			case PicturezImageFormat.GIF:
				rdGif.Active = true;
				break;
			case PicturezImageFormat.ICO:
				rdIcon.Active = true;
				break;
			case PicturezImageFormat.JPEG8:
				rdJpegGray.Active = true;
				break;
			case PicturezImageFormat.JPEG24:
				rdJpeg.Active = true;
				break;
			case PicturezImageFormat.PNG1:
				rdPng1bit.Active = true;
				break;
			case PicturezImageFormat.PNG8:
				rdPng8Bit.Active = true;
				break;
			case PicturezImageFormat.PNG24:
				rdPng24Bit.Active = true;
				break;
			case PicturezImageFormat.PNG32Transparency:
				rdPNG32bit.Active = true;
				break;
			case PicturezImageFormat.PNG32AlphaAsValue:
				rdPng32BitAlphaAsValue.Active = true;
				break;
			case PicturezImageFormat.TIFF:
				rdTiff.Active = true;
				break;
			case PicturezImageFormat.WMF:
				rdWmf.Active = true;
				break;
			}

			// jpg quality track bar
			hscaleQuality.Value = config.JpgQuality;

			// resize version radio button
			switch (config.ResizeVersion)
			{
			case ResizeVersion.No:
				rdOriginalSize.Active = true;
				break;
			case ResizeVersion.BiggestLength:
				rdBiggerLength.Active = true;
				break;
			case ResizeVersion.FixedSize:
				rdFixSize.Active = true;
				break;
			}

			// BiggestLength text box
			entryBiggerLength.Text = config.BiggestLength.ToString();

			// stretch image check box
			checkBtnStretch.Active = config.StretchImage == ConvertMode.StretchForge;

			// Fixed width and height text boxes
			entryFixSizeHeight.Text = config.Height.ToString();
			entryFixSizeWidth.Text = config.Width.ToString();

			// path
			htlbOutputDirectory.Text = config.Path;
			// htlbOutputDirectory.QueueDraw ();

			// using original path and overwrite image check boxes
			checkBtnUseOriginalDirectory.Active = config.UseOriginalPath;
			htlbOutputDirectory.Sensitive = !config.UseOriginalPath;
			checkBtnOverwriteOriginalImage.Active = config.FileOverwriting;

			// NEW: transparency color button
			btnColor.Color = new Gdk.Color(config.TransparencyColorRed,
				config.TransparencyColorGreen, config.TransparencyColorBlue);

			isSettingGuiToCurrentConfiguration = false;
		}

		private void OnHyperTextLabelTextChanged()
		{
			config.Path = htlbOutputDirectory.Text;
		}			

		protected void OnHscaleQualityValueChanged (object sender, EventArgs e)
		{
			config.JpgQuality = (byte)hscaleQuality.Value;
		}

		protected void OnBtnColorColorSet (object sender, EventArgs e)
		{			
			byte r, g, b;
			colorConverter.ToDotNetColor (btnColor.Color, out r, out g,out b);

			config.TransparencyColorRed = r;
			config.TransparencyColorGreen = g;
			config.TransparencyColorBlue = b;
		}

		private void OnUpdateAvailable(float newVersion)
		{
			this.newVersion = newVersion;
			GuiHelper.I.CreateToolbarIconButton (hboxToolbarButtons, 10, 
				"security-medium-2.png", OnToolbarBtn_UpdatePressed, Language.I.L[69]);
		}

		#region drag and drop

		private void FillImageList(List<string> newImages)
		{
			PressedInButton l_pressedInButton;

			for (int i=0; i<newImages.Count; ++i)
			{
				string waste = Constants.I.WINDOWS ? "file:///" : "file://";
				newImages [i] = newImages [i].Replace (@waste, "");
				// Also change possible wrong directory separator
				newImages [i] = newImages [i].Replace (IOPath.AltDirectorySeparatorChar, IOPath.DirectorySeparatorChar);

				l_pressedInButton = new PressedInButton ();
				l_pressedInButton.FullText = newImages [i];
				l_pressedInButton.Text = newImages [i].Substring(newImages[i].LastIndexOf(
					IOPath.DirectorySeparatorChar) + 1);	
				l_pressedInButton.CanFocus = true;
				l_pressedInButton.Sensitive = true;
				l_pressedInButton.TextSize = 10;
				l_pressedInButton.ShowAll ();

				vboxImageList.PackStart(l_pressedInButton, false, false, 0);
			}	
		}

		protected void OnDragDrop (object sender, Gtk.DragDropArgs args)
		{
			Gtk.Drag.GetData
			((Gtk.Widget)sender, args.Context,
				args.Context.Targets[0], args.Time);
		}

		protected void OnDragDataReceived (object sender, Gtk.DragDataReceivedArgs args)
		{
			if (args.SelectionData.Length > 0
				&& args.SelectionData.Format == 8) {

				byte[] data = args.SelectionData.Data;
				string encoded = System.Text.Encoding.UTF8.GetString (data);

				// drag n drop at linux wont accept spaces, so it has to be replaced
				encoded = encoded.Replace ("%20", " ");

				List<string> newImages = new List<string> (encoded.Split ('\r', '\n'));
				newImages.RemoveAll (string.IsNullOrEmpty);

				// I don't know what last object (when Windows) is,
				//  but I tested and noticed that it is not a path
				if (Constants.I.WINDOWS)
					newImages.RemoveAt (newImages.Count-1);

				FillImageList (newImages);
				newImages.Clear ();
			}
		}

		#endregion drag and drop

		protected void OnDeleteEvent (object sender, DeleteEventArgs a)
		{
			ConfigConvert.Save (config);
			this.DestroyAll ();

			Application.Quit ();
			a.RetVal = true;
		}

		[GLib.ConnectBefore ()] 
		protected void OnKeyPressEvent (object o, KeyPressEventArgs args)
		{
			// System.Console.WriteLine("Keypress: {0}", args.Event.Key);

			switch (args.Event.Key) {
			case Gdk.Key.Control_L:
				leftControlPressed = true;
				break;
			case Gdk.Key.a:
				if (leftControlPressed) {
					OnToolbarBtn_SelectAllPressed (null, null);
				}
				break;
			case Gdk.Key.Escape:
				OnToolbarBtn_ClearPressed (null, null);
				break;
			case Gdk.Key.Delete:
				OnToolbarBtn_RemovePressed (null, null);
				break;
			}
				
			// args.RetVal = true;
		}

		[GLib.ConnectBefore ()] 
		protected void OnKeyReleaseEvent (object o, KeyReleaseEventArgs args)
		{
			// System.Console.WriteLine("Keyrelease: {0}", args.Event.Key);
			if (args.Event.Key == Gdk.Key.Control_L) {
				leftControlPressed = false;
			}

			// args.RetVal = true;
		}
				
		protected void OnBtnConvertReleased (object sender, EventArgs e)
		{			
//			Console.WriteLine ("OnBtnConvertReleased ConvertWidget");

			BitmapWithTag bt;
			int nr = 1;
			int count = vboxImageList.Children.Length;
			progressbar1.Adjustment.Lower = nr;
			progressbar1.Adjustment.Upper = count;
			List<string> errors = new List<string> ();

			foreach (Widget pib in vboxImageList.Children) {
				string imageFile = (pib as PressedInButton).FullText;
				progressbar1.Adjustment.Value = nr;
				progressbar1.Text = (nr + "/" + count + "  ( " + 
									 nr * 100 / count +"% )");
				// Force redrawing progress bar
				Main.IterationDo (false);
				nr++;

				try {
				bt = new BitmapWithTag (imageFile, true);

				string relativeImageName = imageFile.Substring(
					imageFile.LastIndexOf(IOPath.DirectorySeparatorChar) + 1);
				relativeImageName = relativeImageName.Substring(0, relativeImageName.LastIndexOf('.'));
				relativeImageName = relativeImageName + format;
				bt.Save (config, relativeImageName);
				}
				catch(Exception){
					errors.Add (imageFile);			
				}
			}

			string mssg = "Finished. " + Environment.NewLine;
			if (errors.Count != 0) {
				mssg += "Some images could not be converted: " + Environment.NewLine;
				foreach (string errorimage in errors) {
					mssg += errorimage + Environment.NewLine;
				}
			} else {
				mssg += "All images are converted. :) " + Environment.NewLine;
			}

			MessageDialog md = new MessageDialog(this, 
				DialogFlags.DestroyWithParent, MessageType.Info, 
				ButtonsType.Close, mssg);
			md.Run();
			md.Destroy();
			
		}						
	}
}

