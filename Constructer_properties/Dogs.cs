using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructer_properties
{
    //First pronciple of object orienrd programming 
    // 1. Encapsulation and data hiding 
    public class Dog
    {
        private string _name;
        private string _breed;
        private string _color;
        private int _age;
        private double _weight;

        //define a constructor. it's specail method with a single purpese
        // allow you to initiakize private fields.
        // specail syntax
        // 1.Must have same name as the as the class
        //2. Cannot have a returen type 
        //3. in general should be public
        //4. should have as many parameters as there are private fields

        // The goal of a constructor is to initialize the fields.

        // we cannot directly call a constructor. the compiler does that 
        // The constructor is called only when a new obhect is created.
        // when we go to form1 and create an object.
        public Dog(string name, string breed, string color, int age, double weight)
        {
            _name = name;
            _breed = breed;
            _color = color;
            _age = age;
            _weight = weight;
        }
        //Add accessors: get accessors(reading),det accessors(for writing / updating ) (geteers/setters)
        // in .Net  they are called properties
        //each property is defined with a get  and / or set
        // a propery role is to provide access to a provides access to a private field

        // Good practices 
        // 1.property name schould start with a capital/uppercase  letter 
        // 2.it should sound the same as the field it is accessing 
        // example for field _name the property should be Name
        //3. should always be declared public
        public string Name
        {
            get
            {
                return _name;
            }
            //set
            //{

            //}
        }
       
        public string Breed
        {
            get
            {
                return _breed;
            }
        }
        public string Color
        {
            get
            {
                return _color;
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >0 && value <=20)
                // assihn a value to _age
                _age = value;  // value is a keyword and placeholder for a real value that will assign out side of this class
            }
        }
        public double Weight
        {
            get
            {
                return _weight;
            }
        }

    }
}











