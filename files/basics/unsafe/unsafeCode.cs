using System;

namespace UnsafeCodeApplication {
   class Program {
      static unsafe void Main(string[] args) {
        int var = 20;
        int* p = &var;

        Console.WriteLine("Integer variable data is: {0} ",  var);
        Console.WriteLine("Integer variable Address is: {0}",  (int)p);

         Console.ReadKey();
      }
   }
}