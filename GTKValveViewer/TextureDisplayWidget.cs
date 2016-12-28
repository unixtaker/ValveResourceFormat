using System;
using System.IO;
using System.Drawing;

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
	}
}
