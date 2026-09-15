// Writing a fuction to calculate the area of a rectangle given its length and width.


// Function to calculate the area of a rectangle
double CalculateRectangleArea(double length, double width)
{ return length * width; }

// prompt the user to enter the length and convert from string to double.
Console.WriteLine("Enter the length of rectangle: "); double length = Convert.ToDouble(Console.ReadLine());
// prompt the user to enter the width and convert from string to double.
Console.WriteLine("Enter the width of rectangle: "); double width = Convert.ToDouble(Console.ReadLine());

// Call the function to calculate the area of the rectangle and stored to variable area.
double area = CalculateRectangleArea(length, width);
// Display the area of the rectangle to the user.
Console.WriteLine("this is the area of the rectangle: " + area);



// ______________________________________________________________________________________

// This is a function to calculate the area of a triabgle.
Double CalculateTriangleArea(double baseLength, double height)
{
    return 0.5 * baseLength * height;
}

Console.WriteLine("Enter the base length of traingle:"); double baseLenght = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the height of triangle:"); double height = Convert.ToDouble(Console.ReadLine());


double areaTraingle = CalculateTriangleArea(baseLenght, height);
Console.WriteLine("this is the area of Triangle" + areaTraingle);

// ______________________________________________________________________________________



// Caculate the area of trapezoid area = 0.5 * (base1(a) + base2(b)) * height

double CalculateTrapezoidArea(double a, double b, double height)
{
    return 0.5 * (a + b) * height;
}

Console.WriteLine("Enter the first base length of trapezoid:"); double base1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the second base length of trapezoid:"); double base2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the height of trapezoid:"); double height_ = Convert.ToDouble(Console.ReadLine());

double areaTrapezoid = CalculateTrapezoidArea(base1, base2, height_);
Console.WriteLine("this is the area of Trapezoid: " + areaTrapezoid);

//----------------------------------------------------------------


// Method Practice: define a method to add two numbers and return the result.
class program
{
    static int AddNumbers(int a, int b)
    {
        return a + b;
    }

    static void Main()
    {
        Console.WriteLine("Enter the first number: "); int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number: "); int num2 = Convert.ToInt32(Console.ReadLine());
        int sum = AddNumbers(num1, num2);
        Console.WriteLine("The sum is: " + sum);
    }
}