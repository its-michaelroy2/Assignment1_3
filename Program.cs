namespace Assignment1_3
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    //Assignment 1.3.1
        //    Console.WriteLine("##################\n Assignment 1.3.1\n##################\n");
        //    Console.WriteLine("This program calculates the area of a triangle, square and rectangle with 3 different functions for each shape to take dimensions of figure and display the area. ");

        //    while(true)
        //    {
        //        Console.WriteLine();
        //        Console.WriteLine("Enter 1 to calculate the area of a triangle");
        //        Console.WriteLine("Enter 2 to calculate the area of a square");
        //        Console.WriteLine("Enter 3 to calculate the area of a rectangle");
        //        Console.WriteLine("Enter 4 to exit");

        //        Console.WriteLine();

        //        Console.WriteLine("Please select a numeric option above & press ENTER :)");

        //        int choice = Convert.ToInt32(Console.ReadLine());

        //        switch(choice)
        //        {
        //            //Triangle Area
        //            case 1:
        //                CalculateTriangleArea();
        //                break;
        //            //Square Area
        //            case 2:
        //                CalculateSquareArea();
        //                break;
        //            //Rectangle Area
        //            case 3:
        //                CalculateRectangleArea();
        //                break;
        //            case 4:
        //                Console.WriteLine("\nDo you want to continue to the next Assignment (Y/N)");
        //                string continueChoice = Console.ReadLine().ToUpper()!;
        //                if (continueChoice == "Y")
        //                {
        //                    // Call Assignment 1.3.2 method
        //                    Assignment1_3_2();
        //                    break;
        //                }
        //                else
        //                {
        //                    return;
        //                }
        //        }
        //    }
        //}

        //static void CalculateTriangleArea()
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("Enter the base of the triangle & press ENTER");
        //    double baseOfTriangle = Convert.ToDouble(Console.ReadLine());

        //    Console.WriteLine();
        //    Console.WriteLine("Enter the height of the triangle & press ENTER");
        //    double heightOfTriangle = Convert.ToDouble(Console.ReadLine());

        //    double area = 0.5 * baseOfTriangle * heightOfTriangle;

        //    Console.WriteLine();
        //    Console.WriteLine($"The area of the triangle is: {area}");
        //}

        //static void CalculateSquareArea()
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("Enter the side of the square & press ENTER");
        //    double sideOfSquare = Convert.ToDouble(Console.ReadLine());

        //    double area = sideOfSquare * sideOfSquare;

        //    Console.WriteLine();
        //    Console.WriteLine($"The area of the square is: {area}");
        //}

        //static void CalculateRectangleArea()
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("Enter the length of the rectangle & press ENTER");
        //    double lengthOfRectangle = Convert.ToDouble(Console.ReadLine());

        //    Console.WriteLine();
        //    Console.WriteLine("Enter the width of the rectangle & press ENTER");
        //    double widthOfRectangle = Convert.ToDouble(Console.ReadLine());

        //    double area = lengthOfRectangle * widthOfRectangle;

        //    Console.WriteLine();
        //    Console.WriteLine($"The area of the rectangle is: {area}");
        //}

        //static void Assignment1_3_2()
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("##################\n Assignment 1.3.2\n##################\n");
        //    Console.WriteLine("This program ...");

        //    //Declare and init an array using array initializer
        //    int[] numbers = { 1, 2, 3, 4, 5 };

        //    bool continueProgram = true;

        //    do
        //    {
        //        Console.WriteLine();
        //        Console.WriteLine("Enter 1 to continue with this assignment");
        //        Console.WriteLine("Enter 2 to exit the program");

        //        int choice = Convert.ToInt32(Console.ReadLine());

        //        switch (choice)
        //        {
        //            case 1:
        //                // Continue with the next assignment
        //                Console.WriteLine("Thanks! Continuing with the assignment...");
        //                break;
        //            case 2:
        //                // Exit the program
        //                Console.WriteLine("Exiting the program...");
        //                continueProgram = false;
        //                Environment.Exit(0);
        //                break;
        //                break;
        //        }
        //    } while (continueProgram);
        //}

        static void Main(string[] args)
        {
            //Assignment 1.3.2
            Console.WriteLine("##################\n Assignment 1.3.2\n##################\n");
            Console.WriteLine("This program calculates the area of a triangle, square and rectangle with 3 different functions for each shape to take dimensions of figure and display the area.");

            Console.WriteLine();
            double squareLength = 5.5;
            double result = SquareArea(squareLength);
            Console.WriteLine("Square is: " + result);
            Console.WriteLine();

            double rectangleHeight = 5.5;
            double rectangleWidth = 15.5;
            double rectangleResult = RectangleArea(rectangleHeight, rectangleWidth);
            Console.WriteLine("Rectangle is: " + rectangleResult);
            Console.WriteLine();

            double triangleBase = 5.5;
            double triangleHeight = 15.5;
            double triangleResult = TriangleArea(triangleBase, triangleHeight);
            Console.WriteLine("Triangle is : " + triangleResult);
            Console.WriteLine();

            Assignment1_3_2();
        }

        static double SquareArea(double length)
        {
            return length * length;
        }

        static double RectangleArea(double height, double width)
        {
            return height * width;
        }

        static double TriangleArea(double baseOfTriangle, double heightOfTriangle)
        {
            double area = 0.5 * baseOfTriangle * heightOfTriangle;
            return area;
        }

        static void Assignment1_3_2()
        {
            Console.WriteLine();
            Console.WriteLine("##################\n Assignment 1.3.2\n##################\n");
            Console.WriteLine("This program deomnstrates an exploration of various declarations and initialization of arrays.");
            Console.WriteLine();

            // Declare and initialize a string array
            string[] cars = { "Ford", "BMW", "Fiat", "Volvo" };
            Console.WriteLine("Cars: " + string.Join(", ", cars));
            Console.WriteLine();

            // Additional arrays
            int[] numbers = { 1, 2, 3, 4, 5 };
            double[] decimalNumbers = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            string[] fruits = { "apple", "banana", "orange", "grape" };

            Console.WriteLine("Numbers: " + string.Join(", ", numbers));
            Console.WriteLine();
            Console.WriteLine("Decimal Numbers: " + string.Join(", ", decimalNumbers));
            Console.WriteLine();
            Console.WriteLine("Fruits: " + string.Join(", ", fruits));

            Console.WriteLine();
            Console.WriteLine();

            Assignment1_3_3();

        }

        static void Assignment1_3_3()
        {
            //Assignment 1.3.3
            Console.WriteLine("##################\n Assignment 1.3.3\n##################\n");
            Console.WriteLine("This program reads n number of values in an array and display it in reverse order");
            Console.WriteLine();

            Console.Write("Input the number of elements to store in the array: ");
            int numOfElements = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int[] arr = new int[numOfElements];

            Console.WriteLine("You will have " + numOfElements + " separate prompts asking for a number for each index in the array. Please read carefully and enter the values below: (IE: element - 0 : (your single number here)");

            Console.WriteLine();
            for (int i = 0; i < numOfElements; i++)
            {
                Console.Write("element - " + i + " : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("The values stored into the array are: ");
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("The values stored into the array in reverse are: ");
            for (int i = numOfElements - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
