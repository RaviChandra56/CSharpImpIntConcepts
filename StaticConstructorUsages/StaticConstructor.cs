using System;

namespace StaticConstructorUsages
{
    /// <summary>
    /// Only 1 instance is created and serves all the clients
    /// </summary>
    public static class StaticConstructor
    {
        /// <summary>
        /// Constants = You can assign a variable only when you declare a variable.
        /// Readonly = You can assign a variable only when you declare a variable or and in the constructor of the same class
        ///            in which it is declared
        /// </summary>
        public static int empId;
        /// <summary>
        /// No - Access Modifier
        ///    - Return Type
        ///    - Input Parameter
        /// Automatically called when class is instantiated
        /// Static constructor is called only one time in whole life time
        /// Static Constructors con not be inherited or overloaded.
        /// </summary>
        /// 
        static StaticConstructor()
        {
            //empId = 102;
        }

        public static void SomeMethod()
        {
            Console.WriteLine("");
        }
    }
}
