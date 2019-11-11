using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    
        class Date
        {
            public int Day;
            public int Month;
            public int Year;
            public readonly int[] MonthDays = {31,28,31,30,31,30,31,31,30,31,30,31};


            public Date(int Day, int Month, int Year)
            {

                //Mesic shora a zespoda
                //Rok shora a zespoda
                if (Year < 2000)
                {
                    throw new Exception("Nejnizsi datum je 1.1.2000, napis prosim vyssi rok");
                }
                if (Year > 2100)
                {
                    throw new Exception("Nejvyssi datum je 1.1.2100, napis prosim nizsi rok");
                }
                if (Month < 1 || Month > 12 || Day < 1 || Day > 31)
                {
                    throw new Exception("Jsi idiot");
                }
                //Day zespoda shora (vzhledem k mesici)
                if (Month == 4 || Month == 6 || Month == 9 || Month == 11)
                {
                    //Day muze byt max 30
                    if (Day > 30)
                    {
                        throw new Exception("Tento mesic nema 31 dni");
                    }
                }
                if (Month == 2)
                {
                    if (Day > 28)
                    {
                        throw new Exception("Unor nema vic nez 28 dni, kaslat na prestupny rok");
                    }
                }
                this.Day = Day;
                this.Month = Month;
                this.Year = Year;
                Console.WriteLine("Dekuji, ze nejsi idiot a pises normalni datumy, tvuj datum narozeni je " + Day + "." + Month + "." + Year);
            }
            public int Numberofdays()
            {
                int result = 0;
                result += Day;
                result += (Year - 2000) * 365;

            //Add month
            for(int i=Month-1; i > 0; i--)
            {
                result += MonthDays[i - 1];
            }
            
                //Console.WriteLine("Od 1.1.2000 je to " + Day + " dnu" + Month + " mesicu" + Year + " let");

                return result;

            }
        }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("napis svuj den narozeni");
            int myday = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("napis svuj mesic narozeni");
            int mymonth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("napis svuj rok narozeni");
            int myyear = Convert.ToInt32(Console.ReadLine());

            Date myDate = new Date(myday, mymonth, myyear);
            int prepis = myDate.Numberofdays();
            Console.WriteLine(prepis.ToString());
            Console.ReadKey();
        }        
    }
}
