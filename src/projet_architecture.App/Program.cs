using System;
using projet_architecture.Core;

namespace projet_architecture.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Post_It task1 = new Post_It("Do this", new Clock(), new Status());
            Console.WriteLine(task1.getPost_It());
        }
    }
}
