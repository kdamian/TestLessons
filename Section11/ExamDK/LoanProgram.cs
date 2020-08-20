using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDK
{
    abstract class LoanProgram
    {
        private int loanNumber;
        private string customerFirstName;
        private string customerLastName;
        private double interestRate;
        private int loanAmount;
        private int termOfLoan;

        public LoanProgram(int number, string firstName, string lastName, double rate, int loanAmount, int term)
        {
            LoanNumber = number;
            CustomerFirstName = firstName;
            CustomerLastName = lastName;
            InterestRate = rate;
            LoanAmount = loanAmount;
            TermOfLoan = term;
        }

        #region Properties

        public int LoanNumber
        {
            get { return loanNumber; }
            set { loanNumber = value; }
        }

        public string CustomerFirstName
        {
            get { return customerFirstName; }
            set { customerFirstName = value; }
        }

        public string CustomerLastName
        {
            get { return customerLastName; }
            set { customerLastName = value; }
        }

        public double InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }

        public int LoanAmount
        {
            get { return loanAmount; }
            set { loanAmount = value; }
        }

        public int TermOfLoan
        {
            get { return termOfLoan; }
            set { termOfLoan = value; }
        }

        #endregion

        public abstract void CalculateInterest();
    }
}
