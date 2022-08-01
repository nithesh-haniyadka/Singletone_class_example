namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton obj = Singleton.GetInstance;
           
            Console.WriteLine("Enter the input");

            while (true)
            {

                var input = Console.ReadLine();
                if(input == "x") {
                    break;
                }
                obj.PrintDetails(input.ToString());
            }
            
        }
    }
}