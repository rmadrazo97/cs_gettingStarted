using System;

namespace RectangleApplication {
   class Rectangle {
      
      // member variables
      double length;
      double width;
      
      public void Acceptdetails() {
         length = 4.5;    
         width = 3.5;
      }
      public double GetArea() {
         return length * width; 
      }
      public void Display() {
         Console.WriteLine("Length: {0}", length);
         Console.WriteLine("Width: {0}", width);
         Console.WriteLine("Area: {0}", GetArea());
      }
   }
   class Triangle {
     double baseL;
     double height;

     public void GetDetails(double uno, double dos){
       baseL = uno;
      height = dos;
     }
     public double GetArea(){
       return (baseL * height) / 2;
     }
     public void Display(){
       Console.WriteLine("Base: {0}", baseL);
       Console.WriteLine("Height: {0}", height);
       Console.WriteLine("Area of Triangle: {0} cm^2",GetArea());
     }

   }
   class ExecuteRectangle {
      static void Main(string[] args) {
         Rectangle r = new Rectangle();
         r.Acceptdetails();
         r.Display();
         Console.WriteLine("Now comes the triangle. ");
         Triangle t = new Triangle();
         t.GetDetails(10,30);
         t.Display();
         Console.ReadLine(); 
      }
   }
}