using System;

namespace UnsafeCodeApplication {
   class TestPointer {
      public unsafe void swap(int* p, int *q) {
         int temp = *p;
         *p = *q;
         *q = temp;
      }
      public unsafe static void Main() {
         TestPointer p = new TestPointer();
         int var1 = 10;
         int var2 = 20;
         int* x = &var1;
         int* y = &var2;
         
         Console.WriteLine("Before Swap: \n var1:{0}, Address of var1:{1}  \n var2: {2} Addressof var2: {3}", var1, (int)x, var2, (int)y);

         p.swap(x, y);

         Console.WriteLine("\n After Swap: \n var1:{0}, Address of var1:{1}  \n var2: {2} Addressof var2: {3}", var1, (int)x, var2, (int)y);
         Console.ReadKey();
      }
   }
}