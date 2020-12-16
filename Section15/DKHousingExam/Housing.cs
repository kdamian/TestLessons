using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section14.DKHousingExam
{
	public class Housing
	{
		public Housing(string address, string typeOfConstruction, int yearBuilt)
		{
			Address = address;
			TypeOfConstruction = typeOfConstruction;
			YearBuilt = yearBuilt;
		}

		public string Address { get; set; }
		public string TypeOfConstruction { get; set; }
		public int YearBuilt { get; set; }

		public virtual decimal ProjectedRentalAmt()
		{
			return 0;
		}

		public override string ToString()
		{
			return string.Format(
				"Address: {0}\n" +
				"TypeOfConstruction: {1}\n" +
				"YearBuilt: {2}\n",
				Address, TypeOfConstruction, YearBuilt
				);
		}
	}
}
