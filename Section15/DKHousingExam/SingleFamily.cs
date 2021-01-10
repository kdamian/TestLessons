using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section14.DKHousingExam
{
	public class SingleFamily : Housing
	{

		private int _rentAmount;
		private int _size;
		private int _noOfBedrooms;
		private int _noOfBathrooms;
		private bool _idPorch;
		private bool _isGarage;

		public SingleFamily(string address, string typeOfConstruction, int yearBuilt,
			int rentAmount, int size, int noOfBedrooms, int noOfBathrooms, bool isPorch, bool isGarage) 
			: base(address, typeOfConstruction, yearBuilt)
		{
			RentAmount = rentAmount;
			Size = size;
			NoOfBedrooms = noOfBedrooms;
			NoOfBathrooms = noOfBathrooms;
			IsPorch = isPorch;
			IsGarage = isGarage;
		}

		public int RentAmount { get { return _rentAmount; } set { _rentAmount = value; } }
		public int Size { get { return _size; } set { _size = value; } }
		public int NoOfBedrooms { get { return _noOfBedrooms; } set { _noOfBedrooms = value; } }
		public int NoOfBathrooms { get { return _noOfBathrooms; } set { _noOfBathrooms = value; } }
		public bool IsPorch { get { return _idPorch; } set { _idPorch = value; } }
		public bool IsGarage { get { return _isGarage; } set { _isGarage = value; } }

		public override decimal ProjectedRentalAmt()
		{
			return RentAmount * 12M;
		}

		public override string ToString()
		{
			return base.ToString() +
				"\n\n\nAddress:" + Address +
				"\nTypeOfConstruction:" + TypeOfConstruction +
				"\nYearBuilt:" + YearBuilt.ToString() +
				"\nRentAmount:" + RentAmount.ToString() +
				"\nSize:" + Size.ToString() +
				"\nNoOfBedrooms:" + NoOfBedrooms.ToString() +
				"\nNoOfBathrooms:" + NoOfBathrooms.ToString() +
				"\nIsPorch:" + IsPorch.ToString() +
				"\nIsGarage:" + IsGarage.ToString() +
				"\nExpected Annual Rents: " + ProjectedRentalAmt().ToString("C");


		}

	}
}
