using System;
using Gtk;
using ValveResourceFormat;

namespace GTKValveViewer
{
	public abstract class AbstractValveLoaderClass
	{
		public AbstractValveLoaderClass()
		{
		}

		public virtual Widget ProcessFile(Resource resource)
		{
			var l = new Label(resource.ResourceType.ToString());
			return l;
		}

		public abstract bool HandlesValveResource(ResourceType rtype);

		public abstract FileFilter getFileFilter();

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
