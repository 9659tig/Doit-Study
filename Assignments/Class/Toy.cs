using System;
namespace Assignment01Class
{
    public class Toy
    {
        public string name {get; private set;}
        public int year {get; private set;}
        public int price {get; private set;}

        public int point {get; private set;}

        //Constructor
         public Toy(string Name, int Year, int Price){
            name = Name;
            year = Year;
            price = Price;
            point = CalculatePoint();
        }

        //Method
        public int CalculatePoint(){
            return (year % 100)*(price/1000);
        }
        
    }
}