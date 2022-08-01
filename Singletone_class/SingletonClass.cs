﻿namespace SingletonDemo
{
    public sealed class Singleton
    {
        private static int counter = 0;
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
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        private void decrement()
        {
            counter--;
            Console.WriteLine("Counter Value " + counter.ToString());

        }

        private void increment()
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