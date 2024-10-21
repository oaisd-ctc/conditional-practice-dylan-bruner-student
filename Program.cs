
public class Program {
    public static void Main(string[] args) {
        FahrenheitToCelsius(23); // Test FahrenheitToCelsius Function with a random value

        // Test your functions by calling them below:
        CheckForPositiveNegativeZero(-1); // This should output: "Your number is negative"
        CheckForPositiveNegativeZero(0); // This should output: "Your number is zero"
        CheckForPositiveNegativeZero(1); // This should output: "Your number is positive"
        // DisplayDayOfWeek(0); // This should output: "Thursday"

        FindMinimum(45,15,50);
        FindMaximum(45,15,50);
        IsDivisibleBy5(25);
        IsDivisibleBy5(26);
        CheckEvenOrOdd(10);
        CheckEvenOrOdd(7);
        CheckVowelOrConsonant('e');
        CheckVowelOrConsonant('t');
        DisplayDayOfWeek(4);
    }

    public static void CheckForPositiveNegativeZero(int number) {
        if (number > 0)
            Console.WriteLine("You number is positive");
        else if (number < 0)
            Console.WriteLine("Your number is negative");
        else
            Console.WriteLine("Your number is zero");
    }

    public static void FindMinimum(int n1, int n2, int n3) {
        int min = new int[]{n1, n2, n3}.Min();
        Console.WriteLine($"The minimum value is {min}.");
    }

    public static void FindMaximum(int n1, int n2, int n3) {
        int min = new int[]{n1, n2, n3}.Max();
        Console.WriteLine($"The maximum value is {min}.");
    }

    public static void IsDivisibleBy5(int num) {
        Console.WriteLine($"{num} is " + (num%5!=0 ? "not ":"") + "divisible by 5");
    }

    public static void FahrenheitToCelsius(double fahrenheit) {
        double celsiusDegree = (fahrenheit - 32) * 5/9; 
        Console.WriteLine($"{fahrenheit} degrees Fahrenheit is {celsiusDegree} degrees Celsius.");
    }

    public static void CheckEvenOrOdd(int num) {
        Console.WriteLine($"{num} is an " + (num%2==0?"Even":"Odd") + " number.");
    }

    public static void CheckVowelOrConsonant(char c) {
        Console.Write($"{c} is a ");
        if (new char[]{'a', 'e', 'i', 'o', 'u'}.Contains(c))
            Console.WriteLine("vowel");
        else
            Console.WriteLine("consonant");
    }

    public static void DisplayDayOfWeek(int day) {
        var days = new string[]{"Sunday","Monday","Tuesday","Wednesday","Thursday", "Friday", "Saturday"};
        Console.WriteLine(days[day]);
    }
}
