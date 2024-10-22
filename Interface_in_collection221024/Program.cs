using System.Collections;

namespace Interface_in_collection221024
{
    class SortEmpByName:IComparer
    {
        public int Compare(object x, object y)
        {
            emp t1= (emp)x;
            emp t2= (emp)y;
            //return t1.name.CompareTo(t2.name);
            return string.Compare(t1.name,t2.name);

        }
    }
    class SortEmpById:IComparer
    {
        public int Compare(object? x, object? y)
        {
            emp t1 = (emp)x;
            emp t2 = (emp)y;
            if (t1.id > t2.id)
            {
                return 1;
            }
            else if (t1.id < t2.id)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        }
    class SortEmpBySalary : IComparer
    {
        public int Compare(object? x, object? y)
        {
            emp t1=(emp)x;
            emp t2=(emp)y;
            if (t1.salary>t2.salary)
            {
                return 1;
            }
            else if(t1.salary<t2.salary)
            {
                return -1;
            }
            else
            {
                return 0;
            }
            
        }
    }
    class emp:IComparable
    {
        public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }

        

        public int CompareTo(Object ob)
        {
            /*
            emp t1 = (emp)this;
            emp t2 = (emp)ob;
            return t1.name.CompareTo(t2.name);
            //if (t1.id > t2.id)
            //{
            //    return 1;
            //}
            //else if (t1.id < t2.id)
            //{
            //    return -1;
            //}
            //else {
            //    return 0;
            //}

            */
            //return this.name.CompareTo(((emp)ob).name);
            
            emp t2 = (emp)ob;
           
            if (this.id > t2.id)
            {
                return 1;
            }
            else if (this.id < t2.id)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList intArrayList = new ArrayList();
            intArrayList.Add("11.2");
            intArrayList.Add("3.5");
            intArrayList.Add("11.1");
            intArrayList.Add("2.22");
            Console.WriteLine("before sort");
            foreach (var i in intArrayList)
            {
                Console.Write(" "+i);
            }
            intArrayList.Sort();
            Console.WriteLine("\nAfter sort");
            foreach (var i in intArrayList)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine("---------------------------");
            emp e1=new emp() { id = 1,name="x",salary=456 };
            emp e2 = new emp() { id = 4, name = "a", salary = 888 };
            emp e3 = new emp() { id = 2, name = "q", salary = 333 };
            emp e4 = new emp() { id = 3, name = "p", salary = 111 };
               ArrayList empArList = new ArrayList();
            empArList.Add(e1);
            empArList.Add(e2);
            empArList.Add(e3);
            empArList.Add(e4);
            Console.WriteLine("before sort emp data");
            foreach (var i in empArList)
            {
                emp temp = (emp)i;
                Console.WriteLine(" " + temp.id+ " "+temp.name+" "+temp.salary);
            }
            SortEmpBySalary sebs = new SortEmpBySalary();
            empArList.Sort(sebs);
            Console.WriteLine("\nAfter sort By Salary emp data");
            foreach (var i in empArList)
            {
                emp temp = (emp)i;
                Console.WriteLine(" " + temp.id + " " + temp.name + " " + temp.salary);
            }


            Console.WriteLine("Array list sort by ID");

            SortEmpById obj1 = new SortEmpById();
            empArList.Sort(obj1);
            Console.WriteLine("\nAfter sort By ID emp data");
            foreach (var i in empArList)
            {
                emp temp = (emp)i;
                Console.WriteLine(" " + temp.id + " " + temp.name + " " + temp.salary);
            }
            //--------------------------------

            SortEmpByName sebn = new SortEmpByName();
            empArList.Sort(sebn);
            Console.WriteLine("\nAfter sort By Name emp data");
            foreach (var i in empArList)
            {
                emp temp = (emp)i;
                Console.WriteLine(" " + temp.id + " " + temp.name + " " + temp.salary);
            }
        }
    }
}
