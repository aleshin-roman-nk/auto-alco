using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArduinoCOM.BL.Db
{
	public class ContextFactory : IContextFactory
	{
		public AppDbContext Create(string cn)
		{
			return new AppDbContext(cn);
		}
	}
}
