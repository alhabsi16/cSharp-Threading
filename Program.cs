namespace cSharp_Threading
{
    internal class Program
    {
        static int someValue = 10;
        static bool isLocked = false;
        static async Task Main(string[] args)
        {

            //Thread thread = new Thread(new ThreadStart(doSomeWork));
            //thread.IsBackground = true; //To use Background thread
            //thread.Start();

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Main Thread: {0}", i);
            //    Thread.Sleep(10);
            //}
            //thread.Join(); // Join use here to not stop the doSomeWork thread from debugging.
            //Console.WriteLine("Main black");

            //Thread thread1 = new Thread(increamentVariable);
            //Thread thread2 = new Thread(increamentVariable);

            //thread1.Start();
            //thread2.Start();

            //thread1.Join();
            //thread2.Join();
            //Console.WriteLine(someValue);

            int result = await add(2, 3);
            Console.WriteLine(result);
            Console.WriteLine("Hello");


        }


        public static void doSomeWork()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Worker Thread: {0}", i);
                Thread.Sleep(100);
            }
        }

        static void increamentVariable()
        {
            if (!isLocked)
            {
                isLocked = true;
                for( int i = 0;i < 1000 ; i++)
                {
                    someValue++;
                }
                isLocked = false;
            }
        }

        public static async Task<int> add(int a, int b)
        {
            //await Task.Delay(5000);
            return a + b;
        }
    }
}
