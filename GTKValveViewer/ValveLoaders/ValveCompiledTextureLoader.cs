using System;
using Gtk;
using Gdk;
using ValveResourceFormat;
using Texture = ValveResourceFormat.ResourceTypes.Texture;

namespace GTKValveViewer
{
	public class ValveCompiledTextureLoader : AbstractValveLoaderClass
	{
		public override FileFilter getFileFilter()
		{
			var f = new FileFilter();
			f.Name = "Valve Compiled Textures (*.vtex_c)";
			f.AddPattern("*.vtex_c");
			return f;							 
		}

		public override bool HandlesValveResource(ResourceType rtype)
		{
			return rtype == ResourceType.Texture;
		}



		public override Widget ProcessFile(Resource resource) {
					
			var tdw = new TextureDisplayWidget();
			var tex = (Texture)resource.Blocks[BlockType.DATA];
			tdw.SetImageTexture(tex.GenerateBitmap());

			foreach (var block in resource.Blocks)
			{
				switch (block.Key) {
					case BlockType.REDI:
						tdw.SetRediData(block.Value.ToString());
						break;
					case BlockType.DATA:
						tdw.SetData(block.Value.ToString());
						break;
				}
			}		
			return tdw;
		}
	}
}
