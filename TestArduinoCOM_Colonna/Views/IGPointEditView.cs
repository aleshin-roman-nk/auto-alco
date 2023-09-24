using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArduinoCOM
{
	public interface IGPointEditView
	{
		bool Dispaly(decimal alco, string comm);
		decimal res_alco { get; }
		string res_comment { get; }
	}
}
