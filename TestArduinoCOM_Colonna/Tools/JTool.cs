using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArduinoCOM.BL
{
	public static class JTool
	{
		public static object Deser(string j)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<object>(j);
		}

		public static string Ser(object r)
		{
			//return Newtonsoft.Json.JsonConvert.SerializeObject(r, Newtonsoft.Json.Formatting.Indented);
			return Newtonsoft.Json.JsonConvert.SerializeObject(r, Newtonsoft.Json.Formatting.Indented);
		}
	}
}
