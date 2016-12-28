using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using Gtk;

namespace GTKValveViewer
{
	public static class HelperUtils
	{

		public static List<Type> GetSubclassesOf(this Type type, bool excludeSystemTypes)
		{
			List<Type> list = new List<Type>();
			IEnumerator enumerator = Thread.GetDomain().GetAssemblies().GetEnumerator();
			while (enumerator.MoveNext())
			{
				try
				{
					Type[] types = ((Assembly)enumerator.Current).GetTypes();
					if (!excludeSystemTypes || (excludeSystemTypes
												&& !((Assembly)enumerator.Current).FullName.StartsWith("System.", StringComparison.OrdinalIgnoreCase)))
					{
						IEnumerator enumerator2 = types.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							Type current = (Type)enumerator2.Current;
							if (type.IsInterface)
							{
								if (current.GetInterface(type.FullName) != null)
								{
									list.Add(current);
								}
							}
							else if (current.IsSubclassOf(type))
							{
								list.Add(current);
							}
						}
					}
				}
				catch
				{
				}
			}
			return list;
		}

		public static IEnumerable<FileFilter> gatherFileFilters()
		{
			// use reflection to get all classes that 
			foreach (var ltype in HelperUtils.GetSubclassesOf(typeof(GTKValveViewer.AbstractValveLoaderClass), true))
			{
				var f1 = (AbstractValveLoaderClass)Activator.CreateInstance(ltype);
				yield return f1.getFileFilter();
			}
			var filterAll = new FileFilter();
			filterAll.AddPattern("*.*");
			filterAll.Name = "All files (*.*)";
			yield return filterAll;
		}

		public static AbstractValveLoaderClass GetFileLoaderClass(String fileName, FileFilter filter)
		{
			foreach (var ltype in HelperUtils.GetSubclassesOf(typeof(GTKValveViewer.AbstractValveLoaderClass), true))
			{
				var f1 = (AbstractValveLoaderClass)Activator.CreateInstance(ltype);
				if (filter.Name == f1.getFileFilter().Name)
				{
					return f1;
				}
			}
			return null;
		}
	}
}
