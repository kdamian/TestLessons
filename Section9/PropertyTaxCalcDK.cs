using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section9
{
    class PropertyTaxCalcDK
    {
        private decimal millageRate = 10.03M;
        private decimal assesmentIncrease = 0.027M;
        private decimal exemption = 25000M;

        public PropertyTaxCalcDK(string address, decimal lastYearValue, decimal thisYearValue)
        {
            PropertyAddress = address;
            PropertyLastYearValue = lastYearValue;
            PropertyThisYearValue = thisYearValue;            
        }

        public string PropertyAddress { get; set; }
        public decimal PropertyLastYearValue { get; set; }
        public decimal PropertyThisYearValue { get; set; }

        public decimal CalculateNewAssessedValue()
        {
            return PropertyLastYearValue * (1 + assesmentIncrease);
        }

        public decimal CalculateTaxesDue()
        {
            return (PropertyThisYearValue - exemption) / 1000 * millageRate;
        }

        public decimal CalculateTaxableValue()
        {
            return PropertyThisYearValue - exemption;
        }

        public override string ToString()
        {
            return string.Format(
                "Property Address: {0}\n" +
                "Last Year Assessed Value: {1:C}\n" +
                "Current Assessed Value: {2:C}\n" +
                "Exemption: {3:C}\n" +
                "Taxable Value: {4:C}\n" +
                "Millage Rate: {5:C}\n" +
                "Taxes Due: {6:C}\n",
                PropertyAddress, PropertyLastYearValue, PropertyThisYearValue, exemption,
                CalculateTaxableValue(), millageRate, CalculateTaxesDue()
                );
        }
    }


}
