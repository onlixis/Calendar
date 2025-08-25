namespace Calendar

{
    internal class Program
    {

       
        static void Main(string[] args)
        {
            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine()); //your year
            

            for (int month = 1; month <= 12; month++) // go through whole year
            {
                DateTime currentDate = new DateTime(year, month, 1);
                Console.WriteLine("\n" + currentDate.ToString("y"));
                Console.WriteLine("Su Mo Tu We Th Fr Sa");

                DateTime firstDay = new DateTime(year, month, 1);
                int daysInMonth = DateTime.DaysInMonth(year, month);
                int startPos = (int)firstDay.DayOfWeek; 

               
                for (int i = 0; i < startPos; i++) // allign days to week
                {
                    Console.Write("   ");
                }

                for (int day = 1; day <= daysInMonth; day++)  // fill up month with days
                {
                    Console.Write($"{day,2} ");
                    if ((startPos + day) % 7 == 0)
                    {
                        Console.WriteLine();
                    }
                }

                Console.WriteLine();
            }

        }
    }
}
