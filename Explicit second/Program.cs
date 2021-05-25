using System;
struct Digit
{
    byte value;
    public Digit(byte value)
    {
        if (value >9)
        {
            throw new ArgumentException();
        }
        this.value = value;

    }
    // Define explicit byte-to-Digit conversion operator;
    public static explicit operator Digit(byte b)
    {
        Digit d = new Digit(b);
        Console.WriteLine("conversion occured");
        return d;
    }
        
}

namespace Explicit_second
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                byte b=3;
                Digit d = (Digit)b; //explicit conversion

            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
        }
    }
}
