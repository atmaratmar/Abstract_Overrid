using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrac_Overrid
{
    class Program
    {
        static void Main(string[] args)
        {
                                //_1  We call transformer and create an object for car
            Transformer trans = new Car();
            trans.Run();    // run which is in the transformer class will not run this 
                            // will overrid and run from car class.
                            //we create another class Boat
            trans = new Boat();
            trans.Run();
            trans = new Helicopter();
            trans.Run();

        }
    }
}
