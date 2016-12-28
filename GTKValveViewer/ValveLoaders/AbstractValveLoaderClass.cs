using System;
using Gtk;

namespace GTKValveViewer
{
	public abstract class AbstractValveLoaderClass
	{
		public AbstractValveLoaderClass()
		{
		}

		public virtual Widget ProcessFile(String fileName) {
			Label l = new Label(fileName);
			return l;
		}

		public abstract FileFilter getFileFilter();

	}


	
	public class ValvePackageFileLoader : AbstractValveLoaderClass
	{
		public override FileFilter getFileFilter()
		{
			var f = new FileFilter();
			f.Name = "Valve Package File (*.vpk)";
			f.AddPattern("*.vpk");
			return f;
		}
	}

	public class ValveCompiledXmlLoader : AbstractValveLoaderClass { 
		public override FileFilter getFileFilter()
		{
			var f = new FileFilter();
			f.Name = "Valve Compiled XML (*.vxml_c)";
			f.AddPattern("*.vxml_c");
			return f;
		}
	}

	public class ValveCompiledSoundLoader : AbstractValveLoaderClass
	{
		public override FileFilter getFileFilter()
		{
			var f = new FileFilter();
			f.Name = "Valve Compiled Sound (*.vsnd_c)";
			f.AddPattern("*.vsnd_c");
			return f;
		}
	}

	public class ValveCompiledMeshLoader : AbstractValveLoaderClass
	{
		public override FileFilter getFileFilter()
		{
			var f = new FileFilter();
			f.Name = "Valve Compiled Mesh (*.vmesh_c)";
			f.AddPattern("*.vmesh_c");
			return f;
		}
	}

	public class ValveCompiledMaterialLoader : AbstractValveLoaderClass
	{
		public override FileFilter getFileFilter()
		{
			var f = new FileFilter();
			f.Name = "Valve Compiled Material (*.vmat_c)";
			f.AddPattern("*.vmat_c");
			return f;
		}
	}

	//vsndstck_c
	//vsndevts_c
	//vmorf_c
//vpcf_c
//vpdi_c
//vphys_c
//vrman_c
//vseq_c
//vsnd_c
//	vmdl_c
//	vanim_c
//	vjs_c
//	vagrp_c


}
