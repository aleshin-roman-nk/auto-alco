using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArduinoCOM.BL
{
	public class GPoint
	{
		public int Id { get; set; }
		public DateTime TimePoint { get; set; }
		public decimal TempUO { get; set; }
		public decimal TempCUB { get; set; }
		public decimal Alco { get; set; }
		public string Comment { get; set; }
		public int SessionId { get; set; }
	}
}
