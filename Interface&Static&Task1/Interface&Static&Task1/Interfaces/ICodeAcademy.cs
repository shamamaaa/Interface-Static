using System;
using System.Xml.Linq;

namespace Interface_Static_Task1.Interfaces
{
	public interface ICodeAcademy
	{
		public string CodeEmail { get; set; }

		void GenerateEmail();

    }
}

