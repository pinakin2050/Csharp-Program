using System;

namespace EnumDemo
{
    public enum Day
    {
        Monday, Tuesday, Wednesday, Thursday, Friday
    }
    class EnumWithProperty
    {
        //Defining an auto property with default values Monday
        //Making it static to directly use it in Main() 
        public static Day MeetingDay { get; set; } = Day.Monday;

        static void Main()
        {
            Console.WriteLine("Default Meeting Day: " + MeetingDay);
            //Setting another meeting day
            MeetingDay = Day.Tuesday;
            Console.WriteLine("Updated Meeting Day: " + MeetingDay);
        }
    }
}
