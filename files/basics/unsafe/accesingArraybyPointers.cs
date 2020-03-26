using System;

namespace UnsafeCodeApplication {
   class TestPointer {
      public unsafe static void Main() {
         int[]  list = {1001, 90, 20, 33, 4, 7};
         // we must fix de pointer, since arrays have fixed memory addreses.
         fixed(int *ptr = list)
         
         /* let us have array address in pointer */
         for ( int i = 0; i < 6; i++) {
            Console.WriteLine("Address of list[{0}]={1}",i,(int)(ptr + i));
            Console.WriteLine("Value of list[{0}]={1} \n", i, *(ptr + i));
         }
         
         Console.ReadKey();
      }
   }
}