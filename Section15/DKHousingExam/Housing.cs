using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section14.DKHousingExam
{
	public class Housing
	{
		private string _adddress;
		private string _typeOfConstruction;
		private int _yearBuilt;

		public Housing(string address, string typeOfConstruction, int yearBuilt)
		{
			Address = address;
			TypeOfConstruction = typeOfConstruction;
			YearBuilt = yearBuilt;
		}

		public string Address { get { return _adddress; } set { _adddress = value; } }
		public string TypeOfConstruction { get { return _typeOfConstruction; } set { _typeOfConstruction = value; } }
		public int YearBuilt { get { return _yearBuilt; } set { _yearBuilt = value; } }

		public virtual decimal ProjectedRentalAmt()
		{
			return 0;
		}

		public override string ToString()
		{
			return base.ToString() +
							"\nAddress:" + Address +
							"\nTypeOfConstruction:" + TypeOfConstruction +
							"\nYearBuilt:" + YearBuilt.ToString();

		}
	}
}
