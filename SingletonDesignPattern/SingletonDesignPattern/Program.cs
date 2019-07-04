using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton.Instance.Print();
        }
    }

    public sealed class Singleton
    {
        private static Singleton instance = null;

        private Singleton()
        {
        }

        public static Singleton Instance {
            get {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        public void Print()
        {
            Console.WriteLine("Singleton instance called");
        }
    }
}

