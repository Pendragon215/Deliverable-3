using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please enter an integer value between 1 and 100");

        try
        {

            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("Specify a series of integer numbers");
            string input2 = Console.ReadLine();
         
            Console.WriteLine("INTEGER INPUT:" + input.ToString());
            Console.WriteLine("STRING INPUT:" + input2.ToString());
            Console.WriteLine("You have selected the " + input2.ToString()+" series. The numbers between 0 and "+ input.ToString()+ " are: ");
            if ((input >= 0) && (input <= 100))
            {
                Console.WriteLine("You have entered " + input.ToString());
                for (int i = 0; i <= input; i++)
                {
                    int odd = 2 * i +1;
                    int even = 2 * i;
                     if (odd > input)
                    {
                        break;
                    }
                    else if (even >input)
                    {
                        break;
                    }
                    else if ((input2 == "Odd")|| (input2 == "odd"))
                    {
                        Console.WriteLine(odd.ToString() + " is an odd number");

                    }
                 
                  
                    else if ((input2 == "Even") || (input2 == "even"))
                    {
                        Console.WriteLine(even.ToString() + " is an even number");
                    }




                }

            }
            }
        
        catch
        {
            Console.WriteLine("Please enter a integer value and try again");
            Console.WriteLine("Press any key to exit the program");
            Console.ReadKey(true);
        }
        
            {
            

        }

    }
}