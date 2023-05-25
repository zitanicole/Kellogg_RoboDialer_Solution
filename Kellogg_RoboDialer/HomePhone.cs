using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kellogg_RoboDialer
{
	internal class HomePhone : Phone
	{
		public HomePhone(string phoneNum, string company, string phoneType) : base(phoneNum, company, phoneType)	   
		{

		}

		public override string Dial()
		{
			return company + " is being dialed using " + phoneNum + "...";
		}
	}
}
