using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDK
{
    class HomeLoan : LoanProgram
    {
        private string address;
        private int yearBuilt;
        private int squareFootage;

        public HomeLoan(int number, string firstName, string lastName, double rate, int loanAmount, int term, string address, int yearBuilt, int SquareFootage) 
            :base(number, firstName, lastName, rate, loanAmount, term)
        {
            Address = address;
            YearBuilt = yearBuilt;
            SquareFootage = squareFootage;
        }

        #region Properties

        public string Address 
        {
            get { return address; }
            set { address = value; }
        }

        public int YearBuilt
        {
            get { return yearBuilt; }
            set { yearBuilt = value; }
        }

        public int SquareFootage
        {
            get { return squareFootage; }
            set { squareFootage = value; }
        }

        #endregion

        public override decimal CalculateInterest()
        {
            decimal result = (decimal)(InterestRate / (TermOfLoan * 12) * (LoanAmount + 5000));
            return result;
        }

        public override string ToString()
        {
            return "Number of your loan: " + LoanNumber
                + "\nCalculates for your HomeLoan: " + CalculateInterest();
        }
    }
}
