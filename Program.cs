using System;

/*This namespace represents the file folder that
the class is in. */
namespace homework3
{
    // Class is a blueprint of an object.
    class Program
    {
       /*static is only one, void is a return type
        Main is the method name, string[] is an array and a parameter */ 
        static void Main(string[] args)
        {
            // Console is a class, WriteLine is a method with a parameter 
            Console.WriteLine("Hello World!");

            House myHouse = new House();
            myHouse.PaintDoor = "Red";
            myHouse.CloseDoor();

            Console.WriteLine(myHouse.PaintDoor);

            House mySecondHouse = new House();
            mySecondHouse.PaintDoor = "Purple";

            Console.WriteLine(myHouse.PaintDoor);
            Console.WriteLine(mySecondHouse.PaintDoor);

            }

        }
    }

