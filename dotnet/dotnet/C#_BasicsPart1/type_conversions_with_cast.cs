using System;
class CastDemo
{
    //type conversions with casts
    static void Main()
    {
        double x, y;
        byte b;
        int i;
        char ch;
        uint u;
        short s;
        long l;
        x = 10.0;
        y = 3.0;
        // Cast double to int, fractional component lost.
        i = (int)(x / y);
        Console.WriteLine("Integer outcome of x / y: " + i);
        Console.WriteLine();
        // Cast an int into a byte, no data lost.
        i = 255;
        b = (byte)i;
        Console.WriteLine("b after assigning 255: " + b +" -- no data lost.");
        // Cast an int into a byte, data lost.
        i = 257;
        b = (byte)i;
        Console.WriteLine("b after assigning 257: " + b +" -- data lost.");
        Console.WriteLine();
        // Cast a uint into a short, no data lost.
        u = 32000;
        s = (short)u;
        Console.WriteLine("s after assigning 32000: " + s +" -- no data lost.");
        
        // Cast an int into a char.
        b = 88; // ASCII code for X
        ch = (char)b;
        Console.WriteLine("ch after assigning 88: " + ch);
    }
}