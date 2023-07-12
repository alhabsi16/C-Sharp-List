namespace C_Sharp_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>();
            //list.Add(1);
            //Console.WriteLine($"Size of the list is {list.Count}");
            //list.Add(2);
            //Console.WriteLine($"Size of the list is {list.Count}");
            //list.Remove(1);
            //Console.WriteLine($"Size of the list is {list.Count}");
            //list.Insert(0,5);
            //Console.WriteLine($"Size of the list is {list.Count}");
            //Console.WriteLine(list[0]);
            //foreach(int  i in list) 
            //Console.WriteLine(i);


            //List<Person> personList = new List<Person>();
            //personList.Add(new Person(1122,"Mohammed","Male"));
            //personList.Add(new Person(1133, "Ahmed", "Male"));
            //personList.Add(new Person(1144, "Anood", "Female"));
            //foreach (Person person in personList)
            //{
            //    Console.WriteLine(person.Id +" " + person.Name + " " + person.Gander);
            //}

            List<int> numberList = new List<int>();
            numberList.Add(4);
            numberList.Add(2);
            numberList.Add(10);
            numberList.Add(8);
            numberList.Add(12);
            numberList.Add(6);

            numberList.Sort();
            foreach (int i in numberList)
            {
                Console.WriteLine(i);
            }
        }
    }
}