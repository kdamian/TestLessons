using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Section14.DKHousingExam
{
	[TestClass]
	public class Tests
	{
		[TestMethod]
		public void SingleFamilyTest()
		{
			List<SingleFamily> homeList = new List<SingleFamily>();

			homeList.Add(new SingleFamily("LA", "Flat", 2002, 1500, 45, 2, 1, false, true));
			homeList.Add(new SingleFamily("SF", "Flat", 2015, 1700, 52, 2, 1, false, false));
			homeList.Add(new SingleFamily("MS", "Home", 1993, 1000, 102, 2, 2, true, true));

			foreach (SingleFamily home in homeList)
			{
				Console.WriteLine(home);
			}
		}

		[TestMethod]
		public void MultiUnitsTest()
		{
			List<MultiUnit> homeList = new List<MultiUnit>();

			homeList.Add(new MultiUnit("Spain", "HOME", 2010, "somethin", 4, 1000));

			foreach (var home in homeList)
			{
				Console.WriteLine(home);
			}
		}

		[TestMethod]
		public void CombinedTests()
		{
			List<Housing> homeList = new List<Housing>();

			homeList.Add(new SingleFamily("LA", "Flat", 2002, 1500, 45, 2, 1, false, true));
			homeList.Add(new MultiUnit("PL", "Home", 1989, "Oasia", 4, 9000));

			foreach (Housing home in homeList)
			{
				Console.WriteLine(home.Address);
			}

		}
	}
}
