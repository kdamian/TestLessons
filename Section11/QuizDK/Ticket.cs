using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizDK
{
    abstract class Ticket
    {
        private string eventName;
        private string personName;
        private int seatNumber;
        private int ticketCode;
        private DateTime eventDate;

        public Ticket(string name, string person, int seat, int code, DateTime date)
        {
            name = eventName;
            person = personName;
            seat = seatNumber;
            code = ticketCode;
            date = eventDate;
        }

        public abstract void Reservation();
    }
}
