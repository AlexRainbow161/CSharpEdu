using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] arr = new string[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = "Привет " + i;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            string[] arr2 = new string[20];
            Array.Copy(arr, arr2, arr.Length);

            List<string> list = new List<string>();

            list.Add("Привет");
            list.AddRange(arr);

            list.Remove(list[0]);

            List<MyClass> list2 = new List<MyClass>();

            // list2.Add(new MyClass() { Id = 3 });
            // list2.Add(new MyClass() { Id = 2 });
            // list2.Add(new MyClass() { Id = 4 });
            // list2.Add(new MyClass() { Id = 1 });

            // var item2 = list2.Find(x => x.Id == 2);

            list2.Sort(new MyClassComparer());

            Dictionary<string, string[]> dict = new Dictionary<string, string[]>();

            dict.Add("Виталик", new string[] { "Директор", "Отец", "Столп общества" });
            var human = dict["Виталик"];

            foreach (var i in Enumerable.Range(0, 9))
            {
                list2.Add(new MyClass(Guid.NewGuid(), "Human " + i));
            }

            Dictionary<Guid, string> myClassesDict = new Dictionary<Guid, string>();

            foreach (var i in list2)
            {
                myClassesDict.Add(i.Id, i.Name);
            }

            var json = System.Text.Json.JsonSerializer.Serialize(list2);
        }
    }

    public class MyClass
    {
        public MyClass(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class MyClassComparer : IComparer<MyClass>
    {
        public int Compare(MyClass? x, MyClass? y)
        {
            if (x != null && y != null)
            {
                if (x.Id < y.Id) return -1;
                else if (x.Id > y.Id) return 1;
                else return 0;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }
    }
}


