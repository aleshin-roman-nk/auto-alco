using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArduinoCOM.BL
{
	public class AppDbContext: DbContext
	{
		public AppDbContext(string cn) : base(cn)
		{

		}

		public DbSet<Session> Sessions { get; set; }
		public DbSet<GPoint> GPoints { get; set; }
	}
}
