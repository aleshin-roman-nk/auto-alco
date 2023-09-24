using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArduinoCOM.BL
{
	public class Session
	{
		public Session()
		{
			GPoints = new List<GPoint>();
		}

		public int Id { get; set; }
		public string Name { get; set; }
		//public virtual ICollection<GPoint> GPoints { get; set; }
		public ICollection<GPoint> GPoints { get; set; }

		public IEnumerable<GPoint> Points
		{
			get
			{
				//return GPoints.OrderByDescending(x => x.Id).ToList();
				return GPoints.OrderByDescending(x => x.TimePoint).ToList();
			}
		}

		//public IEnumerable<GPoint> LastPoints(int n)
		//{
		//	//return GPoints.Skip(Math.Max(0, Points.Count() - n)).Where(x=>x.TempUO >= 0 && x.TempUO < 110).ToList();
		//	return GPoints.Skip(Math.Max(0, Points.Count() - n)).ToList();
		//}

		public IEnumerable<GPoint> LastPoints(int mins, DateTime thisTime)
		{
			DateTime lastTime = thisTime.Add(new TimeSpan(0, -1 * mins, 0));

			return GPoints.Where(x => x.TimePoint >= lastTime && x.TimePoint <= thisTime).ToList();
		}
	}
}
