using System;
using Gtk;
using ValveResourceFormat;

namespace GTKValveViewer
{

	public class ValveCompiledXmlLoader : AbstractValveLoaderClass { 
		public override FileFilter getFileFilter()
		{
			var f = new FileFilter();
			f.Name = "Valve Compiled XML (*.vxml_c)";
			f.AddPattern("*.vxml_c");
			return f;
		}

		public override bool HandlesValveResource(ResourceType rtype)
		{
			return false;
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
