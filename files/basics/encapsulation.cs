using System;

namespace RectangleApplication {
   class Rectangle {
      //member variables
      public double length;
      public double width;
      
      public double GetArea() {
         return length * width;
      }
      public void Display() {
         Console.WriteLine("Length: {0}", length);
         Console.WriteLine("Width: {0}", width);
         Console.WriteLine("Area: {0}", GetArea());
      }
   }//end class Rectangle
   class Triangle {
    private double base_l;
    private double height;

    public void GetData(){
      Console.WriteLine("Enter Base: ");
      base_l = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Enter Height: ");
      height = Convert.ToDouble(Console.ReadLine());
    }

    public double GetArea(){
      return 0.5*(base_l*height);
    }
    public void Display(){
      Console.WriteLine("Base: {0}",base_l);
      Console.WriteLine("Height: {0}",height);
      Console.WriteLine("Area: {0}",GetArea());
    }
   }//end class Triangle

   class Square{
     internal double base_l;
     internal double height;

     public double GetArea(){
       return base_l * height;
     }
     public void Display(){
       Console.WriteLine("Base: {0}", base_l);
       Console.WriteLine("Height: {0},",height);
       Console.WriteLine("Square Area: {0}",GetArea());
     }
   }
   
   class ExecuteShapes {
      static void Main(string[] args) {
          Console.WriteLine("\n ----Rectangle---- \n");
         Rectangle r = new Rectangle();
         r.length = 4.5;
         r.width = 3.5;
         r.Display();
         Console.WriteLine("\n ----Triangle---- \n");
         Triangle t = new Triangle();
         t.GetData();
         t.Display();
          Console.WriteLine("\n ----Square---- \n");
        Square s = new Square();
        s.base_l = 10;
        s.height = s.base_l;
        s.Display();
         Console.ReadLine();
      }
   }
}