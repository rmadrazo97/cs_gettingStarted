using System;

namespace DataTypesApps{
  class RunMeBaby{
    static void Main(string[] args){
      Console.WriteLine("A continuación se muestran los dataTypes de C# \n");
      object obj;
      obj = 100; // this is boxing
      Console.WriteLine("object: {0} \n",obj);
      dynamic dyn = 123;

      Console.WriteLine("Dynamic variable 1: {0} \n", dyn);
      dyn = true;
      Console.WriteLine("Dynamic variable 2: {0}\n", dyn);
      Console.WriteLine("String: {0}\n",@"Tutorials Point");
           
      Console.ReadLine();
    }
  }
}