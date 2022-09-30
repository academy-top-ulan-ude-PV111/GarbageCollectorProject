namespace GarbageCollectorProject
{
    class User : IDisposable
    {
        public string Name { set; get; }
        public int Age { set; get; }

        public User(string name, int age)
        {
            Console.WriteLine("User construct");
            Name = name;
            Age = age;
        }

        public void Dispose()
        {
            Console.WriteLine("User dispose");
        }

        //~User()
        //{
        //    Console.WriteLine("User destruct");
        //}
    }

    class Congress
    {
        public void UsersCreate(int count = 5000)
        {
            User user = new("Bob", 23);

            //for (int i = 0; i < count; i++)
            //{
            //    User u = new();
            //}

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // garabage collwector is work

            //Console.WriteLine($"Max generation: {GC.MaxGeneration}");
            //Console.WriteLine($"Memory busy: {GC.GetTotalMemory(false)}");

            //Congress congress = new();

            //Console.WriteLine($"Generaton object: {GC.GetGeneration(congress)}");
            //congress.UsersCreate();
            //Console.WriteLine($"Memory busy: {GC.GetTotalMemory(false)}");
            //GC.Collect(0);
            //Console.WriteLine("\n---------------\n");
            //Console.WriteLine($"Memory busy: {GC.GetTotalMemory(false)}");
            //Console.WriteLine($"Generaton object: {GC.GetGeneration(congress)}");
            //GC.Collect();
            //Console.WriteLine("\n---------------\n");
            //Console.WriteLine($"Memory busy: {GC.GetTotalMemory(false)}");
            //Console.WriteLine($"Generaton object: {GC.GetGeneration(congress)}");

            //new Congress().UsersCreate();

            //User user = new("Bob", 23);

            //user.Dispose();

            using(User user = new("Bob", 23))
            {
                Console.WriteLine($"User {user.Name} - {user.Age}");
            }


            Console.ReadKey();
        }
    }
}