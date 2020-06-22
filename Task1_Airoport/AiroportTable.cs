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

        public static void testInfo()
        {
            object[] vs1 = { 690, "qqq", "www", 20, "B", "1F", new DateTime(2020, 9, 20, 22, 22, 00), "unknown" };
            object[] vs2 = { 305, "eee;", "rrr", 7, "P", "5F", new DateTime(2020, 10, 21, 22, 12, 00), "unknown" };
            object[] vs3 = { 33, "ttt", "yyy", 55, "E", "2F", new DateTime(2020, 6, 5, 22, 5, 00), "unknown" };
            object[] vs4 = { 404, "uuu", "iii", 6, "G", "11C", new DateTime(2020, 9, 20, 22, 22, 00), "unknown" };
            object[] vs5 = { 506, "ooo", "ppp", 8, "L", "4D", new DateTime(2020, 9, 20, 22, 22, 00), "unknown" };
            table.Add(vs1);
            table.Add(vs2);
            table.Add(vs3);
            table.Add(vs4);
            table.Add(vs5);
        }

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
            ShowTableInfo();

        }
        public static void DeleteFly()
        {
            Console.WriteLine("Enter the fly number that you wont delete");
            int flyNumDel = int.Parse(Console.ReadLine());
            for(int i=0;i<table.Count();i++)
            {
                if ((int)table[i][0] == flyNumDel)
                    table.RemoveAt(i);
            }
            ShowTableInfo();
        }
        public static void EditFly()
        {
            Console.WriteLine("Enter the fly number that you wont Edit");
            int flyNumEdit = int.Parse(Console.ReadLine());
            Console.WriteLine("What info you wont change? If you wont change cityDeparture--press 1,\n" +
                "cityArrival--press 2,airlineNumber--press 3,terminal--press 4,gate--press 5,\n" +
                "dateTime--press 6,flightStatus--press 7, end press 'ENTER' ");
            int choise = int.Parse(Console.ReadLine());
            Console.WriteLine("Write new info ");
            string newInfo = Console.ReadLine();
            int index = 0;
            for (int i = 0; i < table.Count(); i++)
            {
                if ((int)table[i][0] == flyNumEdit)
                    break;
                index++;
            }
            switch (choise)
            {
                case 1:
                    table[index][1] = newInfo;
                    Console.WriteLine(index);
                    break;
                case 2:
                    table[index][2] = newInfo;
                    Console.WriteLine(index);
                    break;
            }
            ShowTableInfo();

        }
        public static void ShowTableInfo()
        {
            foreach(var i in table)
                Console.WriteLine($"{i[0]} {i[1]} {i[2]} {i[3]} {i[4]} {i[5]} {i[6]} {i[7]}");
        }
    }
}
