namespace integer_tutorial;

internal class Program {                                            

    static void Main(string[] args) {

        int[] scores = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int sum = 0;

        sum = sum + scores[0]; // sum is 1
        sum = sum + scores[1]; // sum is 3
        sum = sum + scores[2]; // sum is 6
        sum = sum + scores[3]; 
        sum = sum + scores[4]; 
        sum = sum + scores[5]; 
        sum = sum + scores[6]; 
        sum = sum + scores[7]; 
        sum = sum + scores[8]; 

        sum = sum + scores[9];

        Console.WriteLine($"Sum is {sum}");

        double count = scores.Length;

        var average = sum / count;

        Console.WriteLine($"Sum is {sum}, count is {count}, average is {average}");

/*
        var a = 125;
        int b = 2023;
        int c = 23;
        var d = 3;

        var z = (a + (b * c)) / d;

        bool isEven = z % 2 == 0;

        string message = $"({a} + ({b} * {c})) / {d} equals {z}";

        Console.WriteLine(message);

        if(z < 100000) 
        {
            Console.WriteLine("That z is even");
        } 
        else 
        {
            Console.WriteLine("That z is odd");
        }
*/
    }
}
