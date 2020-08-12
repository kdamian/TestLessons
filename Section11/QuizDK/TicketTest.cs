using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QuizDK
{
    [TestClass]
    public class TicketTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DateTime date = new DateTime(2020, 04, 14);
            Play play = new Play("Star Wars", "Donkey Kong", 21, 123123, date, true);
            Console.WriteLine(play);
        }
    }
}
