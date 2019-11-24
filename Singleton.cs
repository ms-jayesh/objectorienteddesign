using System;

namespace OOD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    //implementation1
    public class singletonclass
    {
        public static singletonclass objsingleton;
        private singletonclass()
        {
           
        }

        public static singletonclass getObject()
        {
            if (objsingleton == null)
                objsingleton = new singletonclass();
            return objsingleton;
        }
    }

    //implementation2
    public  class singletonclass2
    {
        public static singletonclass2 objsingleton;
        static singletonclass2()
        {
            objsingleton = new singletonclass2();
        }

        public static singletonclass2 GetSingletonclass2()
        {
            return objsingleton;
        }
    }

    // implementation3
    public class singletonclass3
    {
        public static singletonclass3 objsingleton = new singletonclass3();
        private singletonclass3()
        {
           
        }
        public static singletonclass3 GetSingletonclass3()
        {
            return objsingleton;
        }
    }

    // thread safe implementation
    public class singletonclass4
    {
        public static singletonclass4 objsingleton;
        public static readonly object threadsync;
        private singletonclass4()
        {

        }
        public static singletonclass4 GetSingletonclass3()
        {
            if(objsingleton==null)
            {
                lock (threadsync)
                {
                    if(objsingleton == null)
                    {
                        objsingleton = new singletonclass4()
                    }
                }
            }
            return objsingleton;
        }
    }

    public class client
    {
        public void caller()
        {
            singletonclass oneObject = singletonclass.getObject();
            singletonclass2 oneObject2 = new singletonclass2();


        }
    }
}
