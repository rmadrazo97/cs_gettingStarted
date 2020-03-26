using System;
using System.Threading;

namespace MultithreadingApplication {
   class ThreadCreationProgram {
      public static void CallToChildThread() {
         Console.WriteLine("Child thread starts\n");
      }
      public static void AnotherPossibleThread(){
        int r,e;
        e = 1290;
        r = e*12 + 120;
        Console.WriteLine("r: {0} \n e:{1} \n",r,e);
      }
      static void Main(string[] args) {
         ThreadStart childref = new ThreadStart(CallToChildThread);

         ThreadStart chidlth = new ThreadStart(AnotherPossibleThread);

         Console.WriteLine("In Main: Creating the Child thread");
         
         Thread childThread = new Thread(childref);
         childThread.Start();

        Thread childThread2 = new Thread(childref);
        childThread2.Start();

        Thread childThread3 = new Thread(chidlth);
        childThread3.Start();

         Console.ReadKey();
      }
   }
}