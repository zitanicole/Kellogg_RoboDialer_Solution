using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kellogg_RoboDialer
{
	internal class Phone
	{
		private string _phoneNum;
		private string _company;
		private string _phoneType;
		public Phone(string phoneNum, string company, string phoneType) 
		{ 
			_phoneNum = phoneNum;
			_company = company;
			_phoneType = phoneType;
		}
		 public string phoneNum
		{ get { return _phoneNum; } }
		public string company
		{ get { return _company; } }
		public string phoneType
		{ get { return _phoneType; } }
		

		public virtual string Dial()
		{
			return "Dialing Phone Number (XXX) XXX-XXXX";
		}
	}
}
