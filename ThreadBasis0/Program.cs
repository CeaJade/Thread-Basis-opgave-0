using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadBasis0
{

    // Program which the threads has been assigned and will call methods from
    class program
    {
        // Threads calling this method will output their names 5 times
        public void WorkThreadFunction()
        {
            for (int i = 0; i< 5; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name);
            }
        }
    }
        
    class threprog
    {
        public static void Main()
        {
            // Creates a program and 2 threads
            program pg = new program();
            Thread thread1 = new Thread(new ThreadStart(pg.WorkThreadFunction));
            Thread thread2 = new Thread(new ThreadStart(pg.WorkThreadFunction));

            // Renaming the threads
            thread1.Name = "T1";
            thread2.Name = "T2";

            // Start threads
            thread1.Start();
            thread2.Start();
            Console.Read();
                
        }
    }
}
