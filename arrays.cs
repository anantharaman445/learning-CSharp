using System;

public class Programs {
    static void Main ( String[] args ) {
        /* Using Arrays */
                int[] list ;                    // declaration doesn't initialize array in memory
                list = new int[10];             // using new keyword to initialize array
                Console.WriteLine("Default value of int arrays : {0}\n", list[9]); // Default value of int type is 0
                           
                Console.WriteLine("Default value of int arrays : {0}\n", list); // This line produces the output, "Default value of int arrays : System.Int32[]"
                
                    //Accessing list[10] causes the runtime error,
                    //Unhandled Exception: System.IndexOutOfRangeException: Index was outside the bounds of the array.
                    //    at Program.Main(String[] args)
                    
                // Assigning values to arrays.
                list[0] = 10 ;
                
                // assigning large set of value
                int[] list1 = {20,21,22,23,24,25,26,27,28,29}; //doesn't use new operator. Works fine.
                foreach (int element in list1)
                {
                    Console.Write(element + ", ") ;
                }
                
                Console.WriteLine("\n");
                
                // assigning large set of value - alternative method
                int[] list2 = new int[] {20,21,22,23,24,25,26,27,28,29}; //uses new operator. Works fine. Array size is optional here.
                foreach (int element in list2)
                {
                    Console.Write(element + ", " ) ;
                }
                
                Console.WriteLine("\n");
                
                // Copying arrays == creating references to same memory space
                
                int[] list3 = list2 ;               // creates reference to list2.
                foreach (int element in list3)
                {
                    Console.Write(element + ", ") ;
                }
                
                Console.WriteLine("\n");
                
                // Copied arrays are of reference type.
                Console.WriteLine ("\nList2[0]: {0}, List3[0]: {1}", list2[0], list3[0]);
                list2[0] = 100 ;
                Console.WriteLine ("List2[0]: {0}, List3[0]: {1}", list2[0], list3[0]);
    }
}        