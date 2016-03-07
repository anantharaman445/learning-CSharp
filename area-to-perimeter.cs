using System;

public class Test
{
	public static void Main()
	{
		Console.WriteLine("Enter the area of square");
		int area=Convert.ToInt32(Console.ReadLine());
		double side=Math.Sqrt(area);
		Console.WriteLine("Perimeter of square is {0}", 4*side);
	}
}
