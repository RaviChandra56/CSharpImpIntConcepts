using System;

namespace AbstractClassWithStaticMethod
{
    /// <summary>
    /// We can't create object of abstract class
    /// Abstract Class has a protected constructor by default allowing derived types to initialize it
    /// Eg : Shape object - Draw method is abstract --> what we can draw without the derived object.
    /// </summary>
    public abstract class AbstractClass
    {
        public static void StaticMethod()
        {
            Console.WriteLine("Abstract Class - Static Method");
        }
    }
}
