using System ;

public class Program {
    static void Main (String[] args) {
        
        //Reading a integer value
        
        short s = 10;
        int i = 20 ;
        i = Convert.ToInt32(Console.ReadLine());
        double d = s + i ;
        Console.WriteLine("s: {0}, i: {1}, d: {2}", s, i, d);
        
    }
}