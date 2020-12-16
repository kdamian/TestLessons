using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section14.DKHousingExam
{
	public class MultiUnit : Housing, IUnits
	{

		public MultiUnit(string address, string typeOfConstruction, int yearBuilt,
			string complexName, int numberOfUnits, int rentAmountPerUnit)
			: base(address, typeOfConstruction, yearBuilt)
		{
			ComplexName = complexName;
			NumberOfUnits = numberOfUnits;
			RentAmountPerUnit = rentAmountPerUnit;
		}

		public string ComplexName { get; set; }
		public int NumberOfUnits { get; set; }
		public int RentAmountPerUnit { get; set; }

		public int GetNumUnits()
		{
			throw new NotImplementedException();
		}

		public override decimal ProjectedRentalAmt()
		{
			return RentAmountPerUnit * NumberOfUnits * 12;
		}



		public override string ToString()
		{
			return string.Format(
				"Address: {0}\n" +
				"TypeOfConstruction: {1}\n" +
				"YearBuilt: {2}\n",
				"ComplexName: {3}\n",
				"NumberOfUnits: {4}\n",
				"RentAmount: {5}\n",
				Address, TypeOfConstruction, YearBuilt, ComplexName, NumberOfUnits, RentAmountPerUnit
				);
		}
	}
}
