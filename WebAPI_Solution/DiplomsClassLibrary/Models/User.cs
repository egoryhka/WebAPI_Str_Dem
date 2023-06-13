using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomsClassLibrary.Models
{
	public class User : IItem
	{
		public int Id { get; set; }

		public string Login { get; set; }
		public string EncryptedPass { get; set; }
	}
}
