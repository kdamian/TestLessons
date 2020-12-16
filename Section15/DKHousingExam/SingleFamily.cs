using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section14.DKHousingExam
{
	public class SingleFamily : Housing
	{
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

		public int RentAmount { get; set; }
		public int Size { get; set; }
		public int NoOfBedrooms { get; set; }
		public int NoOfBathrooms { get; set; }
		public bool IsPorch { get; set; }
		public bool IsGarage { get; set; }

		public override decimal ProjectedRentalAmt()
		{
			return RentAmount * 12;
		}

		public override string ToString()
		{
			return string.Format(
				"Address: {0}\n" +
				"TypeOfConstruction: {1}\n" +
				"YearBuilt: {2}\n",
				"RentAmount: {3}\n",
				"Size: {4}\n",
				"NoOfBedrooms: {5}\n",
				"NoOfBathrooms: {6}\n",
				"IsPorch: {7}\n",
				"IsGarage: {8}\n",
				Address, TypeOfConstruction, YearBuilt, RentAmount, Size, NoOfBedrooms, NoOfBathrooms, IsPorch, IsGarage
				);
		}

	}
}
