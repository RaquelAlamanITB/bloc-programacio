using System;
using System.Collections;

namespace generics
{
    public class Program 
    {
        public static void Main() 
        {
            Console.WriteLine("************** Enum ************************");
            Gender gender = Gender.NotSpecified;
            Person person = new Person("Maria", "Gonzalez", gender);
            Console.WriteLine(person.Gender);
            // Invoke the generic method
            Console.WriteLine("************** Generic Method ************************");
            Classe.Display<int>("Integer: ", 122);
            Classe.Display<char>("Character: ", 'H');
            Classe.Display<double>("Decimal: ", 255.67);
            Classe.Display<string>("String: ", "Hello World");
 
            Console.WriteLine("************* Generic Method in a Generic Class *************************");
            // Invoke the generic method from the generic class
            Console.WriteLine(Calculator<int>.AreEqual(10, 10));
            Console.WriteLine(Calculator<string>.AreEqual("Hello", "Bye"));

            // Create a new instance of the generic class
            Console.WriteLine("************** Generic Class ************************");
            Space<int> spaceInt = new Space<int>(0, 0, 1920, 1280);
            Space<double> spaceDoub = new Space<double>(0.0, 0.0, 50.0, 75.5);
            Console.WriteLine(spaceInt.ToString());
            Console.WriteLine(spaceDoub.ToString());

            Console.WriteLine("************** ArrayList ************************");
            ArrayList arrList = new ArrayList();
            arrList.Add(1);
            arrList.Add(3.5);
            arrList.Add("Hello");
            foreach (var item in arrList)
            {
                Console.WriteLine(item);
            }
            //arrList.Sort();
            
            foreach (var item in arrList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("************** Hashtable ************************");
            Hashtable hashTable = new Hashtable();
            hashTable.Add(1, "One");
            hashTable.Add(2, "Two");
            hashTable.Add(3, "Three");
            foreach (DictionaryEntry item in hashTable)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            Console.WriteLine("************** SortedList ************************");
            SortedList sortedList = new SortedList();
            sortedList.Add(1, "One");
            sortedList.Add(3, "Three");
            sortedList.Add(2, "Two");
            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            Console.WriteLine("************* Queue *************************");
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(3);
            queue.Enqueue(3);
            queue.Enqueue(4);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("***************** Stack *********************");
            Stack stack = new Stack();  
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("************** Generic List ************************");
            List<string> employee = new List<string>();
            employee.Add("Maria");
            employee.Add("Joan");
            employee.Add("Carme");
            foreach (var item in employee)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("*************** Generic Dictionary ***********************");
            Dictionary<int, string> employeeDic = new Dictionary<int, string>();
            employeeDic.Add(1, "Maria");
            employeeDic.Add(2, "Joan");
            employeeDic.Add(3, "Carme");
            foreach (var item in employeeDic)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }

            Console.WriteLine("************** Generic SortedList ************************");
            SortedList<int, string> employeeSort = new SortedList<int, string>();
            employeeSort.Add(1, "Maria");
            employeeSort.Add(3, "Joan");
            employeeSort.Add(2, "Carme");
            foreach (var item in employeeSort)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }

            Console.WriteLine("************** Generic Queue ************************");
            Queue<int> employeeQueue = new Queue<int>();
            employeeQueue.Enqueue(1);
            employeeQueue.Enqueue(3);
            employeeQueue.Enqueue(2);
            foreach (var item in employeeQueue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("************** Generic Stack ************************");
            Stack<int> employeeStack = new Stack<int>();
            employeeStack.Push(1);
            employeeStack.Push(3);              
            employeeStack.Push(2);
            foreach (var item in employeeStack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("************** Comparable ************************");
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("2", "Maria", "Sanz"));
            employees.Add(new Employee("1", "Joan", "Azcona"));
            employees.Add(new Employee("3", "Carme", "García"));
            foreach (var item in employees)
            {
                Console.WriteLine(item.Id + " " + item.FirstName + " " + item.LastName);
            }
            employees.Sort();
            Console.WriteLine();
            foreach (var item in employees)
            {
                Console.WriteLine(item.Id + " " + item.FirstName + " " + item.LastName);
            }

            Console.WriteLine("************** Comparer ************************");
            List<Employee> employeeList = new List<Employee>() {
                new Employee("2", "Maria", "Sanz"),
                new Employee("1", "Joan", "Azcona"),
                new Employee("3", "Carme", "García")
            };
            employeeList.Sort(new EmployeeComparer());
            foreach (var item in employees)
            {
                Console.WriteLine(item.Id + " " + item.FirstName + " " + item.LastName);
            }
        }
    }
}
