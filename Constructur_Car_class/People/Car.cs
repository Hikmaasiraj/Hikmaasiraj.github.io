using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructur_Car_class.people
{
    public class Car
    {

        private string _make;
        private string _model;
        private int _year;
        private double _mileage;
        private decimal _price;

        // define a constructors. it's specail method with a single purpose
        // allows you to initaize a private field
        //special syntax
        // 1. Must have the same name as the class
        //2.Cannot have a return type
        // 3.In general should be public
        // 4. should have as many parameters as there are private fields

        //The goal of a constructors os to initialize the private field

        public Car(string make, string model, int year, double mileage, decimal price)
        {
            _make = make;
            _model = model;
            _year = year;
            _mileage = mileage;
            _price = price;

        }
         
        public string Make
        {
            get
            {
                return _make;
            }
            //set
            //{

            //}
        }
        public string Model
        {
            get
            {
                return _model;
            }
        }
        public int Year
        {
            get
            {
                return _year;
            }

        }
        public double Mileage
        {
            get
            {
                return _mileage;
            }
        }
        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        //public methods
        public void ReduceBy(decimal amount)
        {
            //reduce by the given amount
            //_price = _price - amount;
            _price -= amount;
        }
        // provide a methods that returns a formatted string contain all the information of this car 
        public string GetCarInfo()
        {
            // string carinfo = ($" {c.Make} {c.Model} {c.Year}  {c.Mileage} {c.Price}");
            return GetCarInfo;
        }

    }
        
    
}
//Excercise 
// Add construtor and properties to both classes. All fields should be private
// for Car class only the Price should have a set asccessor.
// for Account class only the BankName should have a set accessor.
// Redo the car class
// Add a class Account:_ownerName,bankName, balance(decimal),_accountNumbe(int),