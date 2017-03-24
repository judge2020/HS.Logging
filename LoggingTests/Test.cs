using System;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HS.Logging; 

namespace LoggingTests
{
	[TestClass]
	public class LoggingTest
	{
		[TestMethod]
		public void CreateTxtLog()
		{
			var LogDir = Directory.GetCurrentDirectory();
			var LogName = "TestLog.txt";
			var FQLD = Path.Combine(LogDir, LogName);
			Log.Initialize(LogDir, LogName);
			Assert.IsTrue(File.Exists(FQLD));
		}
	}
}
