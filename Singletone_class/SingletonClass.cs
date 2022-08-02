namespace SingletonDemo
{
    public sealed class Singleton
    {
        private static int counter;
        private static Singleton instance = null;
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }

        private Singleton()
        {
            counter = 0;
            Console.WriteLine("Counter Value_check " + counter.ToString());
        }

        public void decrement()
        {
            counter--;

            if (counter < 0)
            {
                counter = 0;
            }


            Console.WriteLine("Counter Value " + counter.ToString());

        }

        public void increment()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());

        }

        public void PrintDetails(string message)
        {
            
            if(message == "d")

            {
                decrement();
            }
            else if(message == "i")
            {
                increment();
            }
        }
    }
}