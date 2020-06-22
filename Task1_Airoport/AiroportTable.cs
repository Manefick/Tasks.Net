using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Airoport
{
    class AiroportTable
    {
        private static List<object[]> table = new List<object[]>();

        public static void AddFly()
        {
            Console.WriteLine("Print the fly number, and press 'ENTER' ");
            int flyNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Print the city ​​of departure, and press 'ENTER' ");
            string cityDeparture = Console.ReadLine();
            Console.WriteLine("Print the city ​​of arrival, and press 'ENTER' ");
            string cityArrival = Console.ReadLine();
            Console.WriteLine("Print the number ​​of airline, and press 'ENTER' ");
            int airlineNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Print the terminal name, and press 'ENTER' ");
            string terminal = Console.ReadLine();
            Console.WriteLine("Print the gate, and press 'ENTER' ");
            string gate = Console.ReadLine();
            Console.WriteLine("Print the time like this format:'year/month/day/hour/minute/sec', and press 'ENTER' ");
            string[] data = Console.ReadLine().Split('/');//нужно сделать проверку на попадание в интервал часа, минуты, секунды, месяца и тд
            DateTime dateTime = new DateTime(int.Parse(data[0]), int.Parse(data[1]), int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4]), int.Parse(data[5]));
            Console.WriteLine("Enter the flight status, and press 'ENTER' ");
            Console.WriteLine("Possible fligth status: check-in/gate closed/arrived/departed at/unknown/canceled/expected at/delayed/in flight");
            string flightStatus = Console.ReadLine();

            object[] flyInfo = {flyNumber,cityDeparture,cityArrival,airlineNumber,terminal,gate,dateTime,flightStatus};
            table.Add(flyInfo);
        }
    }
}
