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
            // Fibonacci_Iterative(50);


            // Duplicate();
            //CopyArray();
            //MaxMinArray();
            //AddElement();
            //RemoveElementArray();
            // IndexOfArray();
            //AvarangeArray();
            //SumOf2Arrays();
            // Numbers();
            // Palindrom();
        }

        private static void Palindrom()
        {
            bool valoare;

            Console.Write(" Introdu un sir : ");
            string sir1 = Console.ReadLine();
            valoare = IsPalindrome(sir1);
            if (valoare == true)
            {
                Console.WriteLine(" Sirul este Palindrom.\n");
            }
            else
            {
                Console.WriteLine(" Sirul nu este  Palindrom.\n");
            }
            Console.ReadLine();
        }

        public static bool IsPalindrome(string text)
            {
                if (text.Length <= 1)
                    return true;
                else
                {
                    if (text[0] != text[text.Length - 1])
                        return false;
                    else
                        return IsPalindrome(text.Substring(1, text.Length - 2));
                }

            
            }

        private static void Duplicate()
        {
            string sir = "word";

            if (uniqueCharacters(sir) == true)
            {
                Console.WriteLine("The String " + sir + " has all unique characters");
            }
            else
            {
                Console.WriteLine("The String " + sir + " has duplicate characters");
            }

            Console.ReadLine();
        }

        static bool uniqueCharacters(string sir)
        {

            for (int i = 0; i < sir.Length - 1; i++)
            {
                for (int j = i + 1; j < sir.Length; j++)
                {
                    if (sir[i] == sir[j])
                    {
                        return false;
                    }
                }
            } 
            return true;
        }
        




        private static void CopyArray()
        {
            int[] sir1 = new int[5] { 1, 2, 3, 4, 5 };
            int[] sir2 = new int[sir1.Length];
            for (int i = 0; i < sir1.Length; i++)
            {
                sir2[i] = sir1[i];
                Console.WriteLine(sir2[i]);
            }
        }

        private static void MaxMinArray()
        {
            int maxim, minim;
            int nrElem;
            Console.WriteLine("introduceti numarul de elemente ale sirului:");
            nrElem = int.Parse(Console.ReadLine());
            int[] sir = new int[nrElem];
            Console.WriteLine("introduceti elementele sirului");
            for (int i = 0; i < nrElem; i++)
            {
                sir[i] = int.Parse(Console.ReadLine());
            }
            maxim = sir[0];
            minim = sir[1];
            for (int i = 0; i < nrElem; i++)
            {
                if (sir[i] > maxim)
                {
                    maxim = sir[i];
                }
            }
            for (int i = 0; i < nrElem; i++)
            {
                if (sir[i] < minim)
                {
                    minim = sir[i];
                }
            }
            Console.WriteLine(maxim + "  maximul sirului");
            Console.WriteLine(minim + "  minimul sirului");
        }

        private static void AddElement()
        {
            int pozitie, element;
            int[] sir = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Elementele sirului inainte:");
            for (int i = 0; i < sir.Length; i++)
            {
                Console.WriteLine("Element[" + (i) + "]= " + sir[i]);
            }
            pozitie = 3;
            element = 23;
            for (int i = pozitie - 1; i < sir.Length - 1; i++)
            {
                sir[i] = sir[i - 1];
            }
            sir[pozitie - 1] = element;
            Console.WriteLine("Elementele sirului dupa:");
            for (int i = 0; i < sir.Length; i++)
            {
                Console.WriteLine("Element[" + (i + 1) + "]= " + sir[i]);
            }
            Console.WriteLine();
        }

        



        private static void RemoveElementArray()
        {
            int pozitie;
            int[] sir = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Elementele sirului inainte:");
            for (int i = 0; i < sir.Length; i++)
            {
                Console.WriteLine("Element[" + (i) + "]= " + sir[i]);
            }
            pozitie = 3;
            for (int i = pozitie - 1; i < sir.Length - 1; i++)
            {
                sir[i] = sir[i + 1];
            }
            Console.WriteLine("Elementele sirului dupa:");
            for (int i = 0; i < sir.Length; i++)
            {
                Console.WriteLine("Element[" + (i + 1) + "]= " + sir[i]);
            }
            Console.WriteLine();
        }

        private static void IndexOfArray()
        {
            int[] sir = new int[] { 3, 4, 5, 6, 7, 8 };
            int element;
            int index;
            Console.WriteLine("Introduceti elementul din sir:");
            element = int.Parse(Console.ReadLine());
            for (int i = 0; i < sir.Length; i++)
            {

                if (element == sir[i])
                {
                    index = i;
                    Console.WriteLine("Indexul elementului este:");
                    Console.WriteLine( index );
                }

            }
        }

        private static void AvarangeArray()
        {
            int nrElem;
            Console.WriteLine("Introduceti nr de elemente:");
            nrElem = int.Parse(Console.ReadLine());
            int[] sir = new int[nrElem];
            Console.WriteLine("Introduceti elementele sirului:");
            for (int i = 0; i < nrElem; i++)
            {
                sir[i] = int.Parse(Console.ReadLine());
            }
            int suma = 0;
            int media = 0;
            for (int i = 0; i < nrElem; i++)
            {
                suma += sir[i];
            }
            media = suma / nrElem;
            Console.WriteLine("suma si media sunt:");
            Console.WriteLine(suma);
            Console.Write(media);
        }

        private static void SumOf2Arrays()
        {
            int[] sir1 = new int[5] { 1, 2, 3, 4, 5 };
            int[] sir2 = new int[5] { 6, 7, 8, 9, 10 };
            int[] sir3 = new int[sir1.Length];
            for (int i = 0; i < sir1.Length; i++)
            {

                sir3[i] = sir1[i] + sir2[i];
                Console.WriteLine(sir3[i]);
            }
        }

        private static void Numbers()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 4 || i == 7)
                {
                    continue;
                }
                Console.Write(i);
            }
        }

        public static void Fibonacci_Iterative(int len)
        {
            System.Int64 a = 0, b = 1, suma = 0;
            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < len; i++)
            {
                suma = a + b;
                Console.Write(" {0}", suma);
                a = b;
                b = suma;
            }
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
