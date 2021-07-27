using System;

namespace Clockangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Second challenge to write a program that uses time on a 24 hour clock to determine angle between the hands

            double hour;
            int minute;
            //Firstly the current time is input by the user
            Console.WriteLine("Please enter the current hour on a 24 hour clock");
            hour = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the current minute within the hour");
            minute = int.Parse(Console.ReadLine());
            //Correction is made for 24 hour digital clock to 12 hour analog clock
            if(hour >= 12)
            hour = hour-12;
            Console.WriteLine("{0}:{1}", hour, minute);

            //Next step is conversion from hours and minutes to degrees on a clock face
            double bighandangle;
            double littlehandangle;
            double adjust;
            bighandangle = minute*6;
            littlehandangle = hour*30;
            Console.WriteLine("{0},{1}", bighandangle, littlehandangle);
            //The hour hand has an additional complication that its precise position is dependant on the minute hand
            //Important to know there are 30 degrees in 1 hour on a clock
            adjust = minute*0.5;
            littlehandangle = littlehandangle + adjust;

            //Finally, calculate the two angles between the clock hands and write the smallest angle to the console
            double angle1;
            double angle2;
            angle1 = bighandangle-littlehandangle;
            if(angle1 < 0){
                angle1 = angle1*(-1);
            }
            angle2 = 360-angle1;
            if(angle1 >= angle2)
                Console.WriteLine(angle2);
            else
            Console.WriteLine(angle1);
            //Factor of negative 1 included so angle is positive

        }
    }
}