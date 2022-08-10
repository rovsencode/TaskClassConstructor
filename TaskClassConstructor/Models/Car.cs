using System;
using System.Collections.Generic;
using System.Text;

namespace TaskClassConstructor.Models
{
    class Car:Vehicle
    {
        public string brand;
        public string model;
        public int fuelCapacity;
       public  int fuelFor1Km;
       public  int currentFuel; //Modeli, brandi,FuelFor1km, FuelCapacity
        public Car(int year,string color,string brand,string model,int fuelCapacity,int fuelFor1km,int currentFuel):base(year,color)
        {
            
            this.brand = brand;
            this.model = model;
            this.fuelCapacity = fuelCapacity;
            this.fuelFor1Km = fuelFor1km;
            this.currentFuel = currentFuel;

        }
        public void ShowInfo()
        {
            Console.WriteLine($"{year} {color} {brand} {model} {fuelCapacity} {fuelFor1Km} {currentFuel}");
        }
        public void Drive(int way)
        {
            int restOfFuel, wayFuel;
            
            wayFuel = way * fuelFor1Km;
            if (currentFuel > wayFuel)
            {      
                restOfFuel = currentFuel - wayFuel;
                Console.WriteLine("Yolu getdikden sonra qalan benzin: "+ restOfFuel);
            }
            else
            {
                Console.WriteLine("Masin o yolu gede bilmir");
            }
        }
        
    }
}
