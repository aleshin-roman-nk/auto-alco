using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArduinoCOM.BL.Db
{
	public interface IContextFactory
	{
		AppDbContext Create(string cn);
	}
}
