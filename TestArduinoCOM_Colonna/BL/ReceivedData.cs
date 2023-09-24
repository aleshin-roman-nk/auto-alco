using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArduinoCOM.BL
{
	public class ReceivedData
	{
		public decimal T_uo { get; set; }
		public decimal T_cub { get; set; }
		public decimal T_mid { get; set; }
		public klapan_state kl { get; set; }
		//public decimal mta { get; set; }
		public decimal maximum_temperature_acually { get; set; }
		public decimal min_temperature_acually { get; set; }
		public bool auto { get; set; }
		public int error_code { get; set; }
		public int open_duration { get; set; }

		public static ReceivedData Deserialize(string str)
		{
			try
			{
				return Newtonsoft.Json.JsonConvert.DeserializeObject<ReceivedData>(str);

			}
			catch (Exception)
			{
				return null;
			}
		}
	}
}
