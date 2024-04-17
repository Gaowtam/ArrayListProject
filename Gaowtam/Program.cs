

using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gaowtam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ArrayList arraylist = new ArrayList();
             arraylist.Add(1);
             arraylist.Add("FG");
             arraylist.Add(true);
            *//* for(int i=0;i<arraylist.Count;i++)
             {
                 Console.WriteLine(arraylist[i]);
             }*//*
            foreach(var a in arraylist)
             {
                 Console.WriteLine(a);
             }*/



            /*  List<int> list = new List<int>();
              list.Add(1);
              list.Add(1);
              list.Add(1);
              list.Add(1);
              for (int i=0;i<list.Count();i++)
              {
                  Console.WriteLine(list[i]);
              }*/



            /*  Stack<int> stack = new Stack<int>();
              stack.Push(1);
              stack.Push(2);
              stack.Push(3);

              Console.WriteLine(stack.Count);

              Console.WriteLine(stack.Pop());

              Console.WriteLine(stack.Count);

              Console.WriteLine(stack.Peek());

              Console.WriteLine(stack.Count);

              foreach(int a in stack)
              {
                  Console.WriteLine(a);
              }*/



            /*Queue<int> quewue = new Queue<int>();
            quewue.Enqueue(1);
            quewue.Enqueue(2);
            quewue.Enqueue(3);
            Console.WriteLine(quewue.Peek());

            foreach (int a in quewue)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("First : "+quewue.Count);
            Console.WriteLine(quewue.Dequeue());
            Console.WriteLine("Last :"+quewue.Count);


            foreach (int a in quewue)
            {
                Console.WriteLine(a);
            }*/












            /*  Hashtable hastable = new Hashtable();
              hastable.Add("1", 311);
              hastable.Add(2,false);
              hastable.Add(true,"Gaowtam");

              Console.WriteLine(hastable["1"]);

              *//*foreach(var key in hastable.Keys)
              {
                  Console.WriteLine("Reuslt : "+key);
              }*/

            /*foreach (var key in hastable.Values)
            {
                Console.WriteLine("Reuslt : " + key);
            }*/

            /*foreach (var key in hastable.Keys)
            {
                Console.WriteLine("Reuslt : " + hastable[key]);
            }*/

            /*foreach (var key in hastable)
            {
                Console.WriteLine("Reuslt : " + key);
            }*/



            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1,"gawotam");
            dic.Add(2, "Nirob");
            /*foreach(var k in dic.Keys)
            {
                Console.WriteLine(dic[k]);
            }*/

            foreach (var k in dic)
            {
                Console.WriteLine(k.Key +" "+k.Value);
            }
        }
    }
}
