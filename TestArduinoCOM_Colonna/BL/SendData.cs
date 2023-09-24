using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArduinoCOM.BL
{
	public class SendData
	{
		public CmdCode cmd { get; set; }

		//public klapan_state klapan { get; set; }
		//public decimal max_temp { get; set; }

		public object val { get; set; }

		public string SerializeData()
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(this);
		}
	}
}
