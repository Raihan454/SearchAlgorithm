using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithm
{
    internal class Program
    {   //array to be reached
        int[] arr = new int[20];
        //number of elements in the array
        int n;
        //get the number of elements to store in the array
        int i;

        public void input()
        {
            while (true)
            {
                Console.Write("Enter the number of elements i the array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("\narray should have minimum 1 and maximum 20 elements.\n");
            }
            //accept array elements
            Console.WriteLine("");
            Console.WriteLine("----------------------");
            Console.WriteLine("enter array elements");
            Console.WriteLine("----------------------");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }

        }
        public void BinarySearch()
        {
            char ch;
            do
            {
                //acc the number to be searched
                Console.Write("\nenter element want you to search ; ");
                int item = Convert.ToInt32(Console.ReadLine());

                //apply binary search
                int lowerbound = 0;
                int upperbound = 0;

                //obtain the index of the middle element
                int mid = (lowerbound + upperbound) / 2;
                int ctr = 1;

                //loop to search for the elements in the array
                while ((item != arr[mid]) && (lowerbound <= upperbound))
                {
                    if (item > arr[mid])
                        lowerbound = mid + 1;
                    else upperbound = mid - 1;

                    mid = (lowerbound + upperbound) / 2;
                    ctr++;
                }
                if (item == arr[mid])
                    Console.WriteLine("\n" + item.ToString() + "found at position" + (mid + 1).ToString());
                else
                    Console.WriteLine("\n" + item.ToString() + "not found in the array\n");
                Console.WriteLine("\nNumber of comparasion : " + ctr);

                Console.Write("\ncontinue search (y/n):");
                ch = char.Parse(Console.ReadLine());
            } while ((ch == 'y') || (ch == 'Y'));
        }
        public void LinearSearch()
        {
            char ch;
            //search for number of comparison
            int ctr;
            do
            {
                //acc the number to be reached
                Console.Write("\nenter the element ypu want to search: ");
                int item = Convert.ToInt32(Console.ReadLine());

                ctr = 0;
                for (i = 0; i < n; i++)
                {
                    ctr++;
                    if (arr[i] == item)
                    {
                        Console.WriteLine("\n" + item.ToString() + "found st position" + (i + 1).ToString());
                        break;
                    }
                }
                if (i == n)
                    Console.WriteLine("\n" + item.ToString() + "not found in the array");
                Console.WriteLine("\nNumber of comparison: " + ctr);
                Console.Write("\ncontinous search (y/n):");
                ch = char.Parse(Console.ReadLine());
            } while ((ch == 'y') || (ch == 'Y'));
        }
        static void Main(string[] args)
        {
            Program mylist = new Program();
            int pilihanmenu;
            do
            {
                Console.WriteLine("menu option");
                Console.WriteLine("================");
                Console.WriteLine("1.Linear Search");
                Console.WriteLine("2.Binary Search");
                Console.WriteLine("Exit");
                Console.Write("Enter your choice(1,2,3) : ");
                pilihanmenu = Convert.ToInt32(Console.ReadLine());

                switch (pilihanmenu)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("*****");
                        Console.WriteLine("Linear Search");
                        Console.WriteLine("*****");
                        mylist.input();
                        mylist.LinearSearch();
                        break;
                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("*****");
                        Console.WriteLine("Binary Search");
                        Console.WriteLine("*****");
                        mylist.input();
                        mylist.BinarySearch();
                        break;
                    case 3:

                        Console.WriteLine("Exit.");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
                //to exit from the console
                Console.WriteLine("\n\npress Return to exit.");
                Console.ReadLine();
            } while (pilihanmenu != 3);
        }
    }
}