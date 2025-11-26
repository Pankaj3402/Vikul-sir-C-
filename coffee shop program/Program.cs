

//Program using conditional & looping statements

// Coffee shop program

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("welcome to coffee shop!!!");
        int smallquantity = 0;
        int mediumquantity = 0;
        int largequantity = 0;

        string choice = string.Empty;
        do
        {
            Console.WriteLine("what would you like to have?");
            Console.WriteLine($"1-small 10rs 2-medium 20rs 3-large 30rs");
            int size = int.Parse(Console.ReadLine());

            switch (size)
            {


                case 1:
                    Console.WriteLine($"how much small coffee?");
                    smallquantity += int.Parse(Console.ReadLine());
                    Console.WriteLine($"you have ordered{smallquantity}small coffee");
                    break;

                case 2:
                    Console.WriteLine($"how much medium coffee?");
                    mediumquantity += int.Parse(Console.ReadLine());
                    Console.WriteLine($"you have ordered {mediumquantity}medium coffee");
                    break;

                case 3:
                    Console.WriteLine($"how much large coffee?");
                    largequantity += int.Parse(Console.ReadLine());
                    Console.WriteLine($"you have ordered {largequantity}large coffee");
                    break;

                default:
                    Console.WriteLine($"invalid order");
                    break;

            }
            Console.WriteLine($"do you want to continue?");
            choice = Console.ReadLine().ToUpper();

        }
        while (choice == "Y" || choice == "YES");
        int totalbill = 0;

        if (smallquantity > 0 || mediumquantity > 0 || largequantity > 0)
        {
            Console.WriteLine("**** bill receipt ****");

            if (smallquantity > 0)
            {
                Console.WriteLine($"small coffee{smallquantity}*10={smallquantity * 10}rs");
            }
            if (mediumquantity > 0)
            {
                Console.WriteLine($"medium coffee{mediumquantity}*20={mediumquantity * 20}rs");
            }
            if (largequantity > 0)
            {
                Console.WriteLine($"large coffee{largequantity}*30={largequantity * 30}rs");
            }
            totalbill = smallquantity * 10 + mediumquantity * 20 + largequantity * 30;
            Console.WriteLine($"****total bill = {totalbill}rs****");
            Console.WriteLine("******thank you visit again !!!");
        }
        else
        {
            Console.WriteLine($"bhag yahan se");
        }
        Console.Read();
    }
}