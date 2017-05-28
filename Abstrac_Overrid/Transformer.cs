using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrac_Overrid
{
    /*If you you want enable Polymorfism in you class you need abstarct class
     abstrac is a class with no implementation because polymorfism says that
     implemntation should be always in the child class lets see how to make 
     abtract class 
     first we define a class then we write abstract infront of the class to 
     make it abstract .
     in the abstract class you only say method signiture not implementation
     */
    abstract class Transformer//add abstract key word 
                              //you can not create object from abstract class
                              // why we add such a class losly cuple class flixable.
                              
    {
        public abstract void Run();
    }
    //now we create a car class and it must inharite from the transformer class
    class Car : Transformer // copiler force as to implement every method in side the transformer class
    {
        public override void Run()
        {
            //throw new NotImplementedException();insted we write "Run Car"
            Console.WriteLine("Run Car"); // we implemented goto program _1
        }
    }
    class Boat : Transformer
    {
        public override void Run()
        {
            Console.WriteLine("Run Boat");
        }
    }
    class Helicopter : Transformer
    {
        public override void Run()
        {
            Console.WriteLine("Run Helicopter");
        }
    }
}
