using System;

namespace ShippingCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display required welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            
            // Student identification header
            Console.WriteLine("\n=== Student Information ===");
            Console.WriteLine("Name: abdul nasser");
            Console.WriteLine("College: AOLCC");
            Console.WriteLine("Contact: +1 (226) 211-980\n");

            // Get package weight from user
            Console.WriteLine("Please enter the package weight (kg):");
            double weight = Convert.ToDouble(Console.ReadLine());

            // Check weight limit (50kg maximum)
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Terminate program immediately
            }

            // Get package dimensions from user
            Console.WriteLine("Please enter the package width (cm):");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the package height (cm):");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the package length (cm):");
            double length = Convert.ToDouble(Console.ReadLine());

            // Calculate total dimensions
            double dimensionTotal = width + height + length;

            // Check dimension limit (50cm maximum total)
            if (dimensionTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Terminate program immediately
            }

            // Calculate shipping cost using formula: (w*h*l*weight)/100
            double quote = (width * height * length * weight) / 100;

            // Display formatted quote with currency formatting
            Console.WriteLine($"\nYour estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");
        }
    }
}