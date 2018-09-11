using System;

namespace RectangleApplication {
  class Rectangle {
    string lengthInput;
    string widthInput;
    double length;
    double width;

    public void Acceptdetails() {
      Console.WriteLine("Enter the length of your rectangle");
      lengthInput = Console.ReadLine();
      length = Convert.ToInt32(lengthInput);

      Console.WriteLine("Enter the width of your rectangle");
      widthInput = Console.ReadLine();
      width = Convert.ToInt32(widthInput);
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
  class ExecuteRectangle {
    static void Main(string[] args) {
      Rectangle r = new Rectangle();
      r.Acceptdetails();
      r.Display();
      Console.ReadLine();
    }
  }
}
