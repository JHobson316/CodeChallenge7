using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace CodeChallenge7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting");
            // Populating linked list
            OurNode A = new OurNode("A");
            OurNode B = new OurNode("B");
            OurNode C = new OurNode("C");
            OurNode D = new OurNode("D");
            OurNode E = new OurNode("E");

            OurLinkedList letters = new OurLinkedList(new List<OurNode> {A, B, C, D, E});

            OurNode c = letters.Head;
            OurNode d = letters.Tail;

            Console.WriteLine("List Values in Order:");
            while (c != null)
            {
                Console.WriteLine(c.Info);
                c = c.Next;
            }
            Console.Write("------------\n");

            string search = "B";
            int found = 0;
            int i = 0;

            c = letters.Head;

            if (c != null)
            {
                while (c != null)
                {
                    i++;
                    if (c.Info == search)
                    {
                        // found is increased to 1
                        // and loop is broken out of
                        found++;
                        break;
                    }
                    c = c.Next;
                }
                if (found == 1)
                {
                    //Message to the user of their found result 
                    Console.WriteLine($"{search} is found at index {i}.");
                }
                else
                {
                    // Result of no 
                    Console.WriteLine($"{search} is not found in this list.");
                }
            }
            else
            {

                //4. If the temp node is null at the start, 
                //   the list is empty
                Console.WriteLine("The list is empty.");
            }

            c = letters.Head;

            // requested index
            int search2 = 4;
            // node info at requested index
            string nodeInfo = "Placeholder";
            //index storage
            int index = 0;
            // find check
            int found2 = 0;

            while (c != null)
            {
                while (c!= null)
                {
                    index++;
                    if (search2 == index)
                    {
                        nodeInfo = c.Info;
                        found2++;
                        break;
                    }
                    c = c.Next;
                }
                if (found2 == 1)
                {
                    Console.WriteLine($"Index {search2} contains [{nodeInfo}].");
                }
                else
                {
                    Console.WriteLine($"Nothing found at index {search2}.");
                }
                
            }

        }

    }
    
}