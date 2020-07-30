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
            EventName = name;
            PersonName = person;
            SeatNumber = seat;
            TicketCode = code;
            EventDate = date;
        }

        public string EventName 
        { 
            get {  return eventName; }
            set { eventName = value; } 
        }

        public string PersonName 
        {
            get { return personName; }
            set { personName = value; } 
        }

        public int SeatNumber 
        { 
            get { return seatNumber; }
            set { seatNumber = value; } 
        }

        public int TicketCode 
        { 
            get { return ticketCode; }
            set { ticketCode = value; }
        }

        public DateTime EventDate 
        {
            get { return eventDate; }
            set { eventDate = value; }
        }

        public override string ToString()
        {
            return eventName.ToUpper() +
                "\n\tWho:\t" + PersonName +
                "\n\tWhere:\t" + SeatNumber +
                "\n\tCODE:\t" + TicketCode +
                "\n\tWhen:\t" + EventDate;
        }
    }
}
