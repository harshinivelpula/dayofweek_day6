

namespace dayofweek
{
    class program
    {
        
        static void Main(string[] args)
        {
            int weekday;

         
            Console.WriteLine("enter weekday number(0-6)");
            weekday = Convert.ToInt32(Console.ReadLine());

        
            switch (weekday)
            {
                case 0:
                    Console.WriteLine("it is sunday");
                    break;
                case 1:
                    Console.WriteLine("it is monday");
                    break;
                case 2:
                    Console.WriteLine("it is tuesday");
                    break;
                case 3:
                    Console.WriteLine("it is wednesday");
                    break;
                case 4:
                    Console.WriteLine("it is thursday");
                    break;
                case 5:
                    Console.WriteLine("it is friday");
                    break;
                case 6:
                    Console.WriteLine("it is saturday");
                    break;

            }


        }
    }
}
