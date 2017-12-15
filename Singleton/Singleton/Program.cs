using System;

namespace Singleton
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Singleton s = Singleton.getInstance();
            Console.Write(s.getNum);
        }
    }

    class Singleton
    {
        //private static Singleton inst;
        private static Singleton obj;
        public int getNum{
            get{
                return 1;
            }
        }

        private Singleton(){ }

        /* not thread safe */
        public static Singleton getInstance(){
            if (obj == null){ // two threads may enter here at the same time and
                              // and return different objects
                obj = new Singleton(); 
            }
            return obj; 
        }

    }
}
