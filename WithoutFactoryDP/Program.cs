using System;

namespace WithoutFactoryDP
{
    /// <summary>
    ///  Default access modifiers 
    ///  Class / struct = Internal
    ///  Class Members(variables and methods) / Struct Members = Private  
    ///  Interface / Enum = Internal
    ///  Interface Members(variables and methods) / Enum Members = Public
    /// </summary>
    class Program
    {
        /// <summary>
        /// The Problem with this approach is, if in the future, a new Car [Nano] is introduced
        /// client has to create an instance of that class to access all the property and member function, 
        /// they need to modify the object creation logic and add the following code.
        /// Nano objNano = new Nano();  
        /// objNano.GetCarModel(); 
        /// and Nano class implemetation
        /// Solution = FACTORY DESIGN PATTRON
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Honda objHonda = new Honda();
            objHonda.GetCarModel();

            BMW objBMW = new BMW();
            objBMW.GetCarModel();

            Console.ReadLine();
        }
    }
}
