using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArduinoCOM
{
	public static class LogGer
	{
		public static void Clear()
		{
			File.Delete("log.txt");
		}
		public static void WriteLine(string msg)
		{
			File.AppendAllText("log.txt", $"{DateTime.Now} :{msg}{Environment.NewLine}", Encoding.UTF8);
		}
	}
}
