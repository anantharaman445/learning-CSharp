using System ;

namespace conditionalOperations {
    public class Program {
        static void Main (String[] args) {
            // Conditional logic operations.
            
            // 01. if .. then
            if ( 10 < 20 ) {
                Console.WriteLine ("Ten is lesser than 20.");
            }
            
            // 02. if .. then .. else
            if ( 20 < 10 ){
                Console.WriteLine ("20 is lesser than 10.");
            }
            else {
                Console.WriteLine ("20 is not lesser than 10.");
            }
            
            // 03. switch case
            
            int a = Convert.ToInt32(Console.ReadLine());
            
            switch (a)                  // argument must be of a simple datatype
            {
                case 0:                 // must of the same type of the argument
                    Console.WriteLine (" a equals 0.");
                    break;              // break statement is compulsory.
                    
                    // neglecting break throws this error, "conditionalOperations.cs(30,17): error CS0163: Control cannot fall through from one case label ('case 1:') to another"
                    
                case 1:
                    Console.WriteLine (" a equals 1.");
                    break;
                case 2:
                    Console.WriteLine (" a equals 2.");
                    break;
                default:                // executed when no match was found
                    Console.WriteLine ("The argument didn't match any of the cases.");
                    break;              // break statement compulsory even in the last case.
            }
            
            // 04. Ternary Operators -- shorthand of if .. then .. else statement
            
            int b ;
            Console.WriteLine ("Enter two numbers for comparison: " ) ;
            a= Convert.ToInt16(Console.ReadLine());
            b= Convert.ToInt32(Console.ReadLine());
            
            int greaterNumber = (a>b) ? a : b ;     // based on the condition, the true value or the false value is assigned to the result variable.
            Console.WriteLine("The greater amount among the two variables is : {0}", greaterNumber);
            
        }        
    }
}