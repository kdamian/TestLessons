using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDK
{
    class AutoLoan : LoanProgram
    {
        private int yearBuilt;
        private string model;
        private string make;
        private string color;

        public AutoLoan(int number, string firstName, string lastName, double rate, int loanAmount, int term, int yearBuilt, string model, string make, string color)
            :base(number, firstName, lastName, rate, loanAmount, term)
        {
            YearBuilt = yearBuilt;
            Model = model;
            Make = make;
            Color = color;
        }

        #region Properties

        public int YearBuilt 
        {
            get { return yearBuilt; }
            set { yearBuilt = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        #endregion

        public override decimal CalculateInterest()
        {
            decimal result = (decimal)(InterestRate / (TermOfLoan * 12) * (LoanAmount + 1000));
            return result;
        }

        public override string ToString()
        {
            return "Number of your loan: " + LoanNumber
                + "\nCalculates for your AutoLoan: " + CalculateInterest();
        }
    }
}
