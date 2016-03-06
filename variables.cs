using System ;

public class Program {
    static void Main (String[] args) {
        int number = 20 ;
        byte bit ;
        do {
            -- number ;
            bit = Convert.ToByte(number) ;
            Console.WriteLine ("{0} == {1}", number, bit);
        }while ( number == bit );
        Console.WriteLine ("number {0} doesn't equals bit {1}",number , bit);
    }
}