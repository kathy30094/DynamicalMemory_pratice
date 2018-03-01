using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Function
{
    public struct Employee
    {
        public string Name;
        public string Sex;
    }
    public static void QueueTest()
    {
        Console.WriteLine();
        Console.WriteLine("Queue");
        Queue<string> queue1 = new Queue<string>();

        int i = 1;
        while (i <= 9)
        {
            queue1.Enqueue("第" + i++ + "個進入的項目");
        } // end while

        int n = 1;
        while (queue1.Count > 0)
        {
            Console.WriteLine(queue1.Dequeue() + "，第" + n++ + "個被Dequeue出來");
        } // end while
    } // end QueueTest
    public static void StackTest()
    {
        Console.WriteLine();
        Console.WriteLine("Stack");
        Stack<string> stack1 = new Stack<string>();
        int i = 1;
        while (i <= 9)
        {
            stack1.Push("第" + i++ + "個進入的項目");
        } // end while

        int n = 1;
        while (stack1.Count > 0)
        {
            Console.WriteLine(stack1.Pop()+ "，第" + n++ + "個被Pop出來" );
        } // end while
    } // end StackTest

    public static class Dictionary
    {
        public static void Dictionary1()
        {
            Console.WriteLine();
            Console.WriteLine("Dictionary");
            
            Dictionary<int, Employee> dictionary = new Dictionary<int, Employee>();
            dictionary.Add(1, new Employee() { Name = "Oli", Sex = "F"});
            dictionary.Add(2, new Employee() { Name = "John", Sex = "F" });
            dictionary.Add(3, new Employee() { Name = "Key", Sex = "F" });
            dictionary.Add(4, new Employee() { Name = "Sunny", Sex = "F" });
            dictionary.Add(5, new Employee() { Name = "Sony", Sex = "F" });

            // foreach 取值
            foreach (var dictionaryItem in dictionary)
            {
                Console.WriteLine(dictionaryItem.Key.ToString() + "  " + dictionaryItem.Value.Name + "   " + dictionaryItem.Value.Sex);
            }

            FindInDictionary(dictionary, 4);
            FindInDictionary(dictionary, 6);
        } // end Dictionary1  

        public static void FindInDictionary(Dictionary<int, Employee> dictionary, int ToFind)
        {
            if (dictionary.ContainsKey(ToFind))
            {
                Console.WriteLine("由Key " + ToFind + " 所找到的值為 " + dictionary[ToFind].Name + " " + dictionary[ToFind].Sex);
            }
            else
            {
                Console.WriteLine("dictionary 中 key " + ToFind + " 不存在 " );
            } // end if             
        } // end FindInDictionary
    }
    public static class HashTable
    {
        public static void HashTable1()
        {
            Console.WriteLine();
            Console.WriteLine("HashTable");
            Hashtable hashT = new Hashtable();
            hashT.Add(1, new Employee() { Name = "Oli", Sex = "F" });
            hashT.Add(2, new Employee() { Name = "John", Sex = "F" });
            hashT.Add(3, new Employee() { Name = "Key", Sex = "F" });
            hashT.Add(4, new Employee() { Name = "Sunny", Sex = "F" });
            hashT.Add(5, new Employee() { Name = "Sony", Sex = "F" });
            hashT.Add(106, "Six");
            hashT.Add(107, "Seven");
            hashT.Add(201, 3000);
            hashT.Add(202, -900);
            hashT.Add("A", "Apple");

            //需使用 ICollection 獲取hashT的Key的集合
            ICollection keys = hashT.Keys;
            foreach (var key in keys)
            {
                Console.WriteLine(key + " : " +hashT[key]);
            }

            FindInHashTable(hashT, 4);
            FindInHashTable(hashT, 107);
            FindInHashTable(hashT, 9);
            FindInHashTable(hashT, 201);
            FindInHashTable(hashT, 202);
            FindInHashTable(hashT, "A");
        } // end HashTable1

        public static void FindInHashTable(Hashtable hashT, object ToFind)
        {
            if (hashT.ContainsKey(ToFind))
            {
                Console.WriteLine("由Key " + ToFind + " 所找到的值為 " + hashT[ToFind].ToString());
            }
            else
            {
                Console.WriteLine("HashT 中 key " + ToFind + " 不存在 " );
            } // end if
        } // end FindInHashTable
    } // end HashTable
   
}



