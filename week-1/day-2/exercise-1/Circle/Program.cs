namespace Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Circle object and display its area and circumference
          
            double radius = 5.0; // Replace with the desired radius

            Circle circle = new Circle(radius);

            double area = circle.GetArea();
            double circumference = circle.GetCircumference();

            Console.WriteLine("Area: " + area);
            Console.WriteLine("Circumference: " + circumference);
            
        }
    }
}