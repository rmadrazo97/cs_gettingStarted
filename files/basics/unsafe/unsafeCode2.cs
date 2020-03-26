using System;

namespace UnsafeCodeApplication {
   class Program {
      public static void Main() {
        // just declaring a portion of the code as unsafe.
         unsafe {
            int var = 20;
            int* p = &var;
            
            Console.WriteLine("Data is: {0} " , var);
            // here we access the data from the pointer using ToString() method.
            Console.WriteLine("Data is: {0} " , p->ToString());
            Console.WriteLine("Address is: {0} " , (int)p);
         }
         Console.ReadKey();
      }
   }
}