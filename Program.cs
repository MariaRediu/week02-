using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Ora2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ListExemple();
            //LinkedExemple();
            // GuessRandomNumber();
            //SirInversat();
            int  a = 0;
            int b = 1;
            int urmNr=0;

            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < 50; i++)
            {
                urmNr = a + b;
                Console.Write("Codul este:", urmNr);

                a =b;
                b = urmNr;
            }
            Console.ReadLine();
        }

        private static void SirInversat()
        {
            Console.WriteLine("introduceti text:");
            string text = Console.ReadLine();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.Write(text[i]);
            }
            Console.ReadLine();
        }

        private static void GuessRandomNumber()
        {
            Random rand = new Random();
            int numarRandom = rand.Next(1, 10);
            bool numarcorect = false;
            Console.WriteLine("Introduceti numarul:");
            int nr = int.Parse(Console.ReadLine());
            while (!numarcorect)
            {
                if (nr == numarRandom)
                {
                    Console.WriteLine("Ai ghicit!");
                    numarcorect = true;
                    break;
                }
                if (nr > numarRandom)
                {
                    Console.WriteLine("Numar prea mare");
                    break;
                }
                if (nr < numarRandom)
                {
                    Console.WriteLine("Numar prea mic");
                    break;
                }
                else
                {
                    Console.WriteLine("Mai incearca!");
                    break;

                }
            }
        }

        private static void ListExemple()
        {
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);

            int[] arr = new int[] { 30, 40, 50 };
            list.AddRange(arr);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        private static void LinkedExemple()
        {
            LinkedList<int> list = new LinkedList<int>();
            var node1 = list.AddFirst(10);
            LinkedListNode<int> node2 = new LinkedListNode<int>(20);
            list.AddAfter(node1, node2);
            var node3 = list.AddLast(30);

            foreach (int node in list)
            {
                Console.WriteLine(node);
            }
        }
    }
}
