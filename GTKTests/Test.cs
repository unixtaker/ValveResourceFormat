using NUnit.Framework;
using System;
using GTKValveViewer;

namespace GTKTests
{
	[TestFixture()]
	public class Test
	{
		[Test()]
		public void TestCase()
		{
			var results = GTKValveViewer.HelperUtils.GetSubclassesOf(typeof(GTKValveViewer.AbstractValveLoaderClass), true);
			AbstractValveLoaderClass f1 = (AbstractValveLoaderClass)Activator.CreateInstance(results[0]);
			var filter = f1.getFileFilter();

			Assert.IsNotNull(filter);
		}
	}
}
