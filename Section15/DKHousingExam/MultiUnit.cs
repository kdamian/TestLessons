using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section14.DKHousingExam
{
	public class MultiUnit : Housing, IUnits
	{
		private string _complexName;
		private int _numberOfUnits;
		private int _rentAmountPerUnit;


		public MultiUnit(string address, string typeOfConstruction, int yearBuilt,
			string complexName, int numberOfUnits, int rentAmountPerUnit)
			: base(address, typeOfConstruction, yearBuilt)
		{
			ComplexName = complexName;
			NumberOfUnits = numberOfUnits;
			RentAmountPerUnit = rentAmountPerUnit;
		}

		public string ComplexName { get { return _complexName; } set { _complexName = value; } }
		public int NumberOfUnits { get { return _numberOfUnits; } set { _numberOfUnits = value; } }
		public int RentAmountPerUnit { get { return _rentAmountPerUnit; } set { _rentAmountPerUnit = value; } }

		public int GetNumUnits()
		{
			throw new NotImplementedException();
		}

		public override decimal ProjectedRentalAmt()
		{
			return RentAmountPerUnit * NumberOfUnits * 12M;
		}



		public override string ToString()
		{

			return base.ToString() +
				"\nAddress:" + Address +
				"\nTypeOfConstruction:" + TypeOfConstruction +
				"\nYearBuilt:" + YearBuilt.ToString() +
				"\nComplexName:" + ComplexName +
				"\nNumberOfUnits:" + NumberOfUnits.ToString() +
				"\nRentAmountPerUnit:" + RentAmountPerUnit.ToString();


		}
	}
}
