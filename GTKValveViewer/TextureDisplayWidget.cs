using System;
using System.IO;
using System.Drawing;
using Gtk;

namespace GTKValveViewer
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class TextureDisplayWidget : Gtk.Bin
	{
		public TextureDisplayWidget()
		{
			this.Build();
		}

		public void SetRediData(String data)
		{

			this.textview_redi.Buffer.Text = data;
		}
		public void SetData(String data)
		{
			this.textview_data.Buffer.Text = data;
		}
		public void SetImageTexture(Bitmap image)
		{
			using (var ms = new MemoryStream())
			{
				image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
				ms.Seek(0, SeekOrigin.Begin);
				this.image1.Pixbuf = new Gdk.Pixbuf(ms);
			}
		}

		protected void OnSavePNG(object sender, EventArgs e)
		{
			using (var chooser = new FileChooserDialog("Export file as PNG",
			                                           (Window)this.Toplevel, FileChooserAction.Save,
			                                           "Cancel", ResponseType.Cancel,
			                                           "Save", ResponseType.Accept))
			{
				var response = chooser.Run();
				if (response == (int)ResponseType.Accept)
				{
					this.image1.Pixbuf.Save(chooser.Filename, "png");
				}

				chooser.Destroy();
			}

		}


		protected void OnSaveTGA(object sender, EventArgs e)
		{
			using (var chooser = new FileChooserDialog("Export file as TGA",
			                                           (Window)this.Toplevel, FileChooserAction.Save,
													   "Cancel", ResponseType.Cancel,
													   "Save", ResponseType.Accept))
			{
				var response = chooser.Run();
				if (response == (int)ResponseType.Accept)
				{
					this.image1.Pixbuf.Save(chooser.Filename, "tga");
				}
				chooser.Destroy();
			}
		}
	}
}
