using System;

namespace TypeConversionApplication {
   class StringConversion {
      static void Main(string[] args) {
         int i = 75;
         float f = 53.005f;
         double d = 2345.7652;
         bool b = true;

         Console.WriteLine("i to string {0}",i.ToString());
         Console.WriteLine("f to string {0}",f.ToString());
         Console.WriteLine("d to string {0}",d.ToString());
         Console.WriteLine("b to string {0}",b.ToString());
         Console.ReadKey();
            
      }
   }
}