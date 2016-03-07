using System;

class loop
{
    static void Main(String[] args)
    {
        int[] a = new int[] { 0, 1, 2, 3, 4 } ;
        foreach(string s in a)
        {
            Console.WriteLine(s);
        }
        Console.ReadLine();
    }
}
