namespace OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part2 Q01
            Circle circle = new Circle();
            IShape circleShape = circle;
            circle.Radius = 5;
            circle.CalculateCircumference();
            circle.DisplayCircleInfo();
            circleShape.Area = 78; // Example area value
            Console.WriteLine($"Circle Area: {circleShape.Area}");

            Rectangle rectangle = new Rectangle();
            IShape rectangleShape = rectangle;
            rectangle.Length = 10;
            rectangle.Width = 5;
            rectangle.CalculatePerimeter();
            rectangle.DisplayRectangleInfo();
            rectangle.Area =50; // Example area value

            Console.WriteLine(  $"Rectangle Area:  {rectangle.Area}");

           #endregion
        }
    }
}
