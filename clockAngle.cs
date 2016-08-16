using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clockAngle
{
    class Program
    {
        static void Main(string[] args)
        {
            double hour = 12;
            double minutes = 00;

            double angleHour = hour * 30 + .5 * minutes;
            double angleMinutes = (minutes / 5) * 30;

            double angle1 = Math.Abs(angleHour - angleMinutes);
            double angle2 = Math.Abs(angleMinutes - angleHour);
            if(angle1 < angle2)
            {
                Console.WriteLine(angle1);
            }
            else
            {
                Console.WriteLine(angle1);
            }

            Console.ReadLine();
        }
    }
}
