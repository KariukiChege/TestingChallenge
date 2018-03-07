using NUnit.Framework;
using System;
namespace DateAndTime
{
    [TestFixture()]
    public class TestDateTime
    {
        DateTime time = DateTime.Now;
        [Test()]
        [Category("DATE")]
        public void TestYear()
        {
            var year = time.Year;
            Assert.AreEqual(2018,year);
            Console.WriteLine($"The year is {year}");
        }

        [Test()]
        [Category("DATE")]
        public void TestMonth()
        {
            var month = time.Month;
            Assert.AreEqual(03,month);
            Console.WriteLine($"Current month is {month} (March)");
        }

        [Test()]
        [Category("DATE")]
        public void TestDay()
        {
            var day = time.Day;
            Assert.AreEqual(07, day);
            Console.WriteLine($"Current day is ({day})");
        }

        [Test()]
        [Category("TIME")]
        public void TestHours()
        {
            var hours = time.Hour;
            if(!(hours <= hours -1)){
                Console.WriteLine($"The hour is {hours}");
            }
        }

        [Test()]
        [Category("TIME")]
        public void TestMinutes()
        {
            var minutes = time.Minute;
            if(!(minutes <= minutes -1)){
                Console.WriteLine($"The minutes are {minutes}");
            }
        }

        [Test()]
        [Category("TIME")]
        public void TestSeconds()
        {
            var seconds = time.Second;
            if(!(seconds <= seconds -1)){
                Console.WriteLine($"The seconds are {seconds}");
            }
        }
    }
}
