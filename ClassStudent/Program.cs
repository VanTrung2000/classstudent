using System;

namespace ClassStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Studen student1 = new Studen(1, "Ho Van Trung", "Hue", 20);

            Studen student2 = new Studen();
            student2.SetId(2);
            student2.SetName("Ho Van Trung1");
            student2.SetAddress("Hue1");
            student2.SetAge(21);

            Console.WriteLine(student1.ToString());
            Console.WriteLine(student2.ToString());
            Console.Read();
        }
    }
}
