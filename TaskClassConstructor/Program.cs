using System;
using TaskClassConstructor.Models;

namespace TaskClassConstructor
{
    class Program
    {
        static void Main(string[] args)
        {    
            Car mercedes = new Car(1999,"blue","mercedes","mercedes38PS",80,2,36 );
            Console.WriteLine("Information About Car");
            mercedes.ShowInfo();
            mercedes.Drive(10);
           
            

            

        }
    }
}
